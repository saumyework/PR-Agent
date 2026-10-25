<#
Token-lean PR review engine. A deterministic PowerShell driver does all the
plumbing (fetching, sharding, evidence checks, rendering). The model is only
called for the parts that need judgement, and each call is ONE request with
NO tools (--tools ""), so there are no agent turns re-sending growing context
and no ~15k-token tool/system overhead per turn.

  powershell -NoProfile -ExecutionPolicy Bypass -File .claude/skills/pr-review/engine/review.ps1 -Repo owner/repo -Target 14235 [-Fresh] [-DryRun]

Flow for a first review:
  prefetch (gh, 0 tokens) -> bundles per shard -> round 1: independent passes
  (A/B/C walk orders) in parallel -> evidence check (0 tokens) -> fetch any
  context the passes asked for (gh, 0 tokens) -> round 2: one gap pass per
  code shard (sees context + "already reported") -> evidence check -> one
  merge call over the findings only -> render HTML (0 tokens).
Re-review: only files changed since the last reviewed commit are passed, and
the merge call reconciles the prior finding IDs.
Every call's output is cached under .tmp/pr<N>/calls-<sha>/, so a run that
hits the usage limit resumes where it stopped when re-run.
#>
param(
    [Parameter(Mandatory = $true)][string]$Repo,
    [Parameter(Mandatory = $true)][string]$Target,
    [switch]$Fresh,
    [switch]$DryRun,                    # build bundles + plan, make no model calls
    [string]$PassModel = 'sonnet',
    [string]$MergeModel = 'sonnet',
    [string]$TestModel = 'haiku',       # test-code shards: lower risk, ~1/3 the cost
    [switch]$Quality,                   # everything on Sonnet, incl. tests
    [int]$MaxParallel = 4,
    [int]$ShardLines = 2500,
    [int]$FullFileMaxLines = 600        # modified files up to this size are shown whole
)
$ErrorActionPreference = 'Stop'
if ($Quality) { $TestModel = $PassModel }
$engineDir = $PSScriptRoot
$skillDir = Split-Path $engineDir
$root = (Resolve-Path (Join-Path $skillDir '..\..\..')).Path
$utf8 = New-Object Text.UTF8Encoding $false
function Write-Utf8($path, $text) { [IO.File]::WriteAllText($path, $text, $utf8) }
function Read-Utf8($path) { [IO.File]::ReadAllText($path, $utf8) }
function Say($msg) { Write-Host $msg }

# ---------------------------------------------------------------- claude.exe
$claudeExe = Get-ChildItem "$env:USERPROFILE\.vscode\extensions" -Directory -Filter 'anthropic.claude-code-*' -ErrorAction SilentlyContinue |
    Sort-Object Name -Descending | Select-Object -First 1 |
    ForEach-Object { Join-Path $_.FullName 'resources\native-binary\claude.exe' }
if (-not $DryRun -and (-not $claudeExe -or -not (Test-Path $claudeExe))) { throw 'claude.exe not found (is the Claude Code VS Code extension installed?)' }

# ---------------------------------------------------------------- resolve PR
if ($Target -match '^\d+$') { $pr = [int]$Target }
else {
    $found = gh pr list --repo $Repo --head $Target --state all --json number --jq '.[0].number'
    if (-not $found) { throw "No PR found for branch '$Target' in $Repo." }
    $pr = [int]$found
}
$light = gh pr view $pr --repo $Repo --json 'title,url,headRefOid,headRefName' | Out-String | ConvertFrom-Json
$sha = $light.headRefOid

# ---------------------------------------------------------------- output path + prior review
$projMatch = [regex]::Match($light.title, '([A-Z]{2,})-\s?\d+')
if (-not $projMatch.Success) { $projMatch = [regex]::Match($light.headRefName, '([A-Z]{2,})-\d+') }
$project = if ($projMatch.Success) { $projMatch.Groups[1].Value } else { 'MISC' }
$repoName = ($Repo -split '/')[1]
$outDir = Join-Path $root "reviews\$project\$repoName"
New-Item -ItemType Directory -Force $outDir | Out-Null
$existing = @(Get-ChildItem $outDir -Filter "pr$pr*.html" -ErrorAction SilentlyContinue | Where-Object { $_.Name -match "^pr$pr(-v(\d+))?\.html$" })
$versions = @($existing | ForEach-Object { if ($_.Name -match '-v(\d+)\.html$') { [int]$Matches[1] } else { 1 } })
$lastVersion = if ($versions.Count) { ($versions | Measure-Object -Maximum).Maximum } else { 0 }
$newVersion = $lastVersion + 1
$outFile = Join-Path $outDir ($(if ($newVersion -eq 1) { "pr$pr.html" } else { "pr$pr-v$newVersion.html" }))

$prior = $null
if ($lastVersion -gt 0) {
    $lastFile = Join-Path $outDir ($(if ($lastVersion -eq 1) { "pr$pr.html" } else { "pr$pr-v$lastVersion.html" }))
    $m = [regex]::Match((Read-Utf8 $lastFile), '<script type="application/json" id="review-state">(.*?)</script>', 'Singleline')
    if ($m.Success) { try { $prior = $m.Groups[1].Value.Replace('<\/', '</') | ConvertFrom-Json } catch { $prior = $null } }
}
if ($prior -and -not $Fresh -and $prior.headSha -eq $sha) {
    Say "No new commits since v$lastVersion (commit $($sha.Substring(0,7))). The existing review is current: $lastFile"
    exit 0
}
$reReview = [bool]($prior -and -not $Fresh)

# ---------------------------------------------------------------- prefetch (0 tokens)
$prDir = Join-Path $root ".tmp\pr$pr"
$metaPath = Join-Path $prDir 'meta.json'
$needPrefetch = $true
if (Test-Path $metaPath) { try { $needPrefetch = ((Read-Utf8 $metaPath | ConvertFrom-Json).headRefOid -ne $sha) } catch { } }
if ($needPrefetch) {
    if (Test-Path $prDir) { Remove-Item -Recurse -Force $prDir }
    & powershell -NoProfile -ExecutionPolicy Bypass -File (Join-Path $skillDir 'prefetch.ps1') -Repo $Repo -Pr $pr | ForEach-Object { Say $_ }
}
$meta = Read-Utf8 $metaPath | ConvertFrom-Json
$generated = '\.Designer\.cs$|package-lock\.json$|yarn\.lock$|pnpm-lock\.yaml$|\.snap$|\.min\.(js|css)$|\.map$'
$testPattern = '(^|/)[^/]*Tests?[^/]*/|\.spec\.ts$|Tests?\.cs$'
$allFiles = @($meta.files)
$reviewable = @($allFiles | Where-Object { $_.path -notmatch $generated })

# re-review scope: files changed since the last reviewed commit
$scope = $reviewable
$scopeNote = ''
if ($reReview) {
    try {
        $changed = @(gh api "repos/$Repo/compare/$($prior.headSha)...$sha" --jq '.files[].filename')
        if ($LASTEXITCODE -ne 0) { throw 'compare failed' }
        $scope = @($reviewable | Where-Object { $changed -contains $_.path })
        $scopeNote = "Re-review of v$lastVersion (commit $($prior.headSha.Substring(0,7))): $($scope.Count) files changed since then."
    } catch {
        $scopeNote = "Could not diff against the previous commit (force-push?), so the whole PR was in scope."
    }
}

# ---------------------------------------------------------------- per-file code views
$diffText = Read-Utf8 (Join-Path $prDir 'review.diff')
$sections = @{}
foreach ($chunk in ($diffText -split "(?m)^(?=diff --git )")) {
    $mm = [regex]::Match($chunk, '^diff --git a/.*? b/(.*)$', 'Multiline')
    if ($mm.Success) { $sections[$mm.Groups[1].Value.Trim()] = $chunk }
}
# Formatting-only files (every change is whitespace/indentation) need no model
# review: detect them here (0 tokens), drop them from the shards, and hand the
# list to the merge step so the report still notes the churn (L11).
$formatOnly = New-Object System.Collections.ArrayList
foreach ($f in @($scope)) {
    $sec = $sections[$f.path]
    if (-not $sec -or $f.changeType -ne 'MODIFIED') { continue }
    $plus = @(); $minus = @()
    foreach ($l in ($sec -split "`n")) {
        if ($l.StartsWith('+++') -or $l.StartsWith('---')) { continue }
        if ($l.StartsWith('+')) { $plus += ($l.Substring(1) -replace '\s', '') }
        elseif ($l.StartsWith('-')) { $minus += ($l.Substring(1) -replace '\s', '') }
    }
    $p = ($plus | Where-Object { $_ } | Sort-Object) -join "`n"; $m = ($minus | Where-Object { $_ } | Sort-Object) -join "`n"
    if ($p -eq $m) { [void]$formatOnly.Add($f.path) }
}
if ($formatOnly.Count) { $scope = @($scope | Where-Object { $formatOnly -notcontains $_.path }) }
function Get-DiffInfo($section) {
    $added = New-Object 'System.Collections.Generic.HashSet[int]'
    $removed = New-Object System.Collections.ArrayList
    $annot = New-Object Text.StringBuilder
    $old = 0; $new = 0; $inHunk = $false
    foreach ($l in ($section -split "`n")) {
        $h = [regex]::Match($l, '^@@ -(\d+)(?:,\d+)? \+(\d+)(?:,\d+)? @@')
        if ($h.Success) { $old = [int]$h.Groups[1].Value; $new = [int]$h.Groups[2].Value; $inHunk = $true; [void]$annot.Append("  ...`n"); continue }
        if (-not $inHunk -or $l.StartsWith('\')) { continue }
        if ($l.StartsWith('+')) { [void]$added.Add($new); [void]$annot.Append(('{0,5}+| {1}' -f $new, $l.Substring(1))).Append("`n"); $new++ }
        elseif ($l.StartsWith('-')) { [void]$removed.Add(('{0,5}-| {1}' -f $old, $l.Substring(1))); [void]$annot.Append(('     -| {0}' -f $l.Substring(1))).Append("`n"); $old++ }
        else { $t = if ($l.Length) { $l.Substring(1) } else { '' }; [void]$annot.Append(('{0,5} | {1}' -f $new, $t)).Append("`n"); $old++; $new++ }
    }
    @{ added = $added; removed = $removed; annotated = $annot.ToString() }
}
$codeCorpus = @{}   # path -> raw text used for evidence checks
function Get-FileView($f) {
    $path = $f.path
    $section = $sections[$path]
    $info = if ($section) { Get-DiffInfo $section } else { @{ added = (New-Object 'System.Collections.Generic.HashSet[int]'); removed = @(); annotated = '' } }
    $headPath = Join-Path $prDir ('head\' + ($path -replace '/', '\'))
    $kind = switch ($f.changeType) { 'ADDED' { 'added' } 'DELETED' { 'deleted' } default { 'modified' } }
    $sb = New-Object Text.StringBuilder
    [void]$sb.Append("### FILE: $path  ($kind, +$($f.additions)/-$($f.deletions))`n")
    $raw = ''
    if ($kind -ne 'deleted' -and (Test-Path $headPath)) {
        $raw = Read-Utf8 $headPath
        $lines = $raw -split "`r?`n"
        if ($kind -eq 'added' -or $lines.Count -le $FullFileMaxLines) {
            # Token trims that lose nothing reviewable: the standard license header is
            # dropped, consecutive using/import lines collapse to one line, and the
            # gutter has no padding. Line numbers stay exact.
            $i = 0
            while ($i -lt $lines.Count -and $lines[$i] -match '^\s*(//.*(-{5,}|Copyright|OSOS|disclosed|reproduced|authorization).*|//\s*)$') { $i++ }
            if ($i -gt 0) { [void]$sb.Append("1-$i|(license header)`n") }
            while ($i -lt $lines.Count) {
                $mark = if ($kind -eq 'added' -or $info.added.Contains($i + 1)) { '+' } else { ' ' }
                if ($lines[$i] -match '^\s*(using [\w.]+( = [\w.<>]+)?;|import .* from .*;)\s*$') {
                    $j = $i
                    while ($j + 1 -lt $lines.Count -and $lines[$j + 1] -match '^\s*(using [\w.]+( = [\w.<>]+)?;|import .* from .*;)\s*$') { $j++ }
                    if ($j -gt $i) {
                        $names = ($lines[$i..$j] | ForEach-Object { ($_ -replace '^\s*(using |import )', '' -replace ';\s*$', '').Trim() }) -join '; '
                        [void]$sb.Append(('{0}-{1}{2}|using {3}' -f ($i + 1), ($j + 1), $mark, $names)).Append("`n")
                        $i = $j + 1; continue
                    }
                }
                [void]$sb.Append(('{0}{1}|{2}' -f ($i + 1), $mark, $lines[$i])).Append("`n")
                $i++
            }
            if ($info.removed.Count) { [void]$sb.Append("Removed lines (old line numbers):`n").Append(($info.removed -join "`n")).Append("`n") }
        } else {
            [void]$sb.Append("(large file: only the changed hunks are shown)`n").Append($info.annotated)
        }
    } else {
        [void]$sb.Append($info.annotated)
    }
    $codeCorpus[$path] = $raw + "`n" + ($section -replace '(?m)^[+\- ]', '')
    $sb.ToString()
}

# ---------------------------------------------------------------- rules + PR context (shared prefix)
$guidelines = Read-Utf8 (Join-Path $root 'code-review-guidelines.md')
function Get-Section($text, $start, $end) {
    $m = [regex]::Match($text, "(?s)(^## $([regex]::Escape($start)).*?)(?=^## $([regex]::Escape($end)))", 'Multiline')
    if ($m.Success) { $m.Groups[1].Value.Trim() } else { '' }
}
$hasCs = [bool]($reviewable | Where-Object { $_.path -match '\.cs$' })
$hasNg = [bool]($reviewable | Where-Object { $_.path -match '\.(ts|html|scss)$' })
$rules = New-Object Text.StringBuilder
[void]$rules.Append((Get-Section $guidelines 'Team-Specific Rules' 'Stack-Specific Guides')).Append("`n`n")
[void]$rules.Append((Get-Section $guidelines 'Always-Enforced Checks' 'General Best Practices')).Append("`n`n")
if ($hasCs) { [void]$rules.Append((Read-Utf8 (Join-Path $root 'guides\C#_Checklist.md'))).Append("`n`n") }
if ($hasNg) { [void]$rules.Append((Read-Utf8 (Join-Path $root 'guides\Angular_Checklist.md'))).Append("`n`n") }
if (-not $hasCs -and -not $hasNg) { [void]$rules.Append((Get-Section $guidelines 'General Best Practices' 'Output Format')).Append("`n`n") }
[void]$rules.Append((Read-Utf8 (Join-Path $root 'guides\Naming_Conventions.txt')))

# all PR files, grouped by folder (compact cross-reference)
$byDir = $allFiles | Group-Object { ($_.path -split '/' | Select-Object -SkipLast 1) -join '/' } | Sort-Object Name
$fileIndex = ($byDir | ForEach-Object { "$($_.Name)/: " + (($_.Group | ForEach-Object { ($_.path -split '/')[-1] }) -join ', ') }) -join "`n"
# PR description: drop the repo's PR-template boilerplate (headings, admonitions,
# checklists, placeholders, HTML comments) and keep only what the author wrote.
$desc = "$($meta.body)"
$desc = [regex]::Replace($desc, '(?s)<!--.*?-->|</?(details|summary)>', '')
$desc = (($desc -split "`r?`n") | Where-Object {
    $_.Trim() -and $_ -notmatch '^\s*(#|>|- \[[ xX]\]|\[(Please provide|Provide a)[^\]]*\]\s*$|Happy Coding)' }) -join "`n"
if (-not $desc.Trim()) { $desc = '(empty: the PR template was left unfilled)' }
if ($desc.Length -gt 1500) { $desc = $desc.Substring(0, 1500) + ' ...' }
$reviewableLines = ($reviewable | Measure-Object -Property additions -Sum).Sum + ($reviewable | Measure-Object -Property deletions -Sum).Sum
$prHeader = @"
# PR
$Repo#$pr "$($meta.title)" by $($meta.author.login) | $($meta.baseRefName) <- $($meta.headRefName) | head $sha | state $($meta.state)
Reviewable changed lines in the whole PR: $reviewableLines across $($reviewable.Count) files ($($allFiles.Count - $reviewable.Count) generated files skipped).
Description:
$desc

# Team rules (priority: Team-Specific Rules > checklist > naming)
$($rules.ToString())

# All files in this PR (for cross-reference)
$fileIndex
"@

# ---------------------------------------------------------------- shards + call plan
function New-Shards($files, $prefix) {
    $result = New-Object System.Collections.ArrayList
    $cur = New-Object System.Collections.ArrayList; $curLines = 0
    foreach ($g in ($files | Group-Object { ($_.path -split '/' | Select-Object -First 5) -join '/' } | Sort-Object Name)) {
        $lines = ($g.Group | Measure-Object -Property additions -Sum).Sum + ($g.Group | Measure-Object -Property deletions -Sum).Sum
        if ($cur.Count -gt 0 -and $curLines + $lines -gt $ShardLines) { [void]$result.Add(@($cur)); $cur = New-Object System.Collections.ArrayList; $curLines = 0 }
        foreach ($f in ($g.Group | Sort-Object path)) { [void]$cur.Add($f) }
        $curLines += $lines
    }
    if ($cur.Count -gt 0) { [void]$result.Add(@($cur)) }
    for ($i = 0; $i -lt $result.Count; $i++) { [pscustomobject]@{ id = "$prefix$($i + 1)"; kind = $(if ($prefix -eq 'T') { 'tests' } else { 'code' }); files = @($result[$i]) } }
}
$scopeLines = ($scope | Measure-Object -Property additions -Sum).Sum + ($scope | Measure-Object -Property deletions -Sum).Sum
if ($scopeLines -le $ShardLines) {
    $shards = @([pscustomobject]@{ id = 'S1'; kind = 'code'; files = @($scope | Sort-Object path) })
} else {
    $shards = @(New-Shards @($scope | Where-Object { $_.path -notmatch $testPattern }) 'S') + @(New-Shards @($scope | Where-Object { $_.path -match $testPattern }) 'T')
}
$shards = @($shards | Where-Object { $_.files.Count -gt 0 })

$orders = @{
    A = 'Walk the files top to bottom in the order shown.'
    B = 'Walk the files bottom to top (last file first).'
    C = 'Walk by request flow: endpoint -> command/validator -> handler -> service -> mapping -> model/EF config -> migration, then any file not reached.'
}
function Get-Round1Orders($shard) {
    if ($reReview) { return @('A') }
    if ($shard.kind -eq 'tests') { return @('A') }
    if ($shards.Count -eq 1) { if ($scopeLines -le 300) { return @('A', 'B') } else { return @('A', 'B', 'C') } }
    return @('A', 'C')
}
$callsDir = Join-Path $prDir ("calls-" + $sha.Substring(0, 7) + $(if ($reReview) { "-re$lastVersion" } else { '' }))
New-Item -ItemType Directory -Force $callsDir | Out-Null
$shardBody = @{}
foreach ($s in $shards) {
    $sb = New-Object Text.StringBuilder
    [void]$sb.Append("`n# Files to review: shard $($s.id) ($($s.kind), $($s.files.Count) files)`n")
    foreach ($f in $s.files) { [void]$sb.Append((Get-FileView $f)).Append("`n") }
    $shardBody[$s.id] = $sb.ToString()
}

# ---------------------------------------------------------------- model calls
$passSchema = '{"type":"object","properties":{"findings":{"type":"array","items":{"type":"object","properties":{"file":{"type":"string"},"line":{"type":"string"},"severity":{"type":"string","enum":["must-fix","suggestion","nit"]},"lens":{"type":"string"},"title":{"type":"string"},"detail":{"type":"string"},"evidence":{"type":"string"}},"required":["file","line","severity","lens","title","detail","evidence"]}},"needContext":{"type":"array","items":{"type":"object","properties":{"name":{"type":"string"},"question":{"type":"string"}},"required":["name","question"]}},"disputed":{"type":"array","items":{"type":"object","properties":{"title":{"type":"string"},"reason":{"type":"string"}},"required":["title","reason"]}},"good":{"type":"array","items":{"type":"string"}}},"required":["findings","needContext","good"]}'
$mergeSchema = '{"type":"object","properties":{"risk":{"type":"string","enum":["Low","Medium","High"]},"summary":{"type":"array","items":{"type":"string"}},"findings":{"type":"array","items":{"type":"object","properties":{"keys":{"type":"array","items":{"type":"string"}},"severity":{"type":"string","enum":["must-fix","suggestion","nit"]},"title":{"type":"string"},"body":{"type":"string"}},"required":["keys","severity","title","body"]}},"good":{"type":"array","items":{"type":"object","properties":{"file":{"type":"string"},"title":{"type":"string"},"body":{"type":"string"}},"required":["file","title","body"]}},"prior":{"type":"array","items":{"type":"object","properties":{"id":{"type":"string"},"status":{"type":"string","enum":["fixed","partial","open","withdrawn"]},"line":{"type":"string"},"note":{"type":"string"}},"required":["id","status","note"]}}},"required":["risk","summary","findings","good"]}'

$usage = New-Object System.Collections.ArrayList
$limitHit = $false
function New-Call($label, $model, $systemFile, $inputText, $schema) {
    $in = Join-Path $callsDir "$label.in.md"
    Write-Utf8 $in $inputText
    [pscustomobject]@{ label = $label; model = $model; sys = $systemFile; in = $in; out = (Join-Path $callsDir "$label.out.json"); err = (Join-Path $callsDir "$label.err.txt"); schema = $schema; result = $null; proc = $null; tries = 0 }
}
function Read-CallResult($call) {
    if (-not (Test-Path $call.out)) { return $null }
    $txt = Read-Utf8 $call.out
    if ($txt -match 'hit your (session|usage) limit|usage limit reached') { $script:limitHit = $true; return $null }
    try { $j = $txt | ConvertFrom-Json } catch { return $null }
    if (-not $j.structured_output) { return $null }
    [void]$script:usage.Add([pscustomobject]@{ call = $call.label; model = $call.model; input = [int]$j.usage.input_tokens; cacheWrite = [int]$j.usage.cache_creation_input_tokens; cacheRead = [int]$j.usage.cache_read_input_tokens; output = [int]$j.usage.output_tokens })
    $j.structured_output
}
function Invoke-Calls($calls) {
    $pending = New-Object System.Collections.Queue
    foreach ($c in $calls) {
        $r = Read-CallResult $c          # resume: reuse a finished call from an earlier run
        if ($r) { $c.result = $r; Say "  [cached] $($c.label)" } else { $pending.Enqueue($c) }
    }
    if ($DryRun) { foreach ($c in $pending) { Say ("  [dry-run] {0}: ~{1:N0} input tokens" -f $c.label, ((Get-Item $c.in).Length / 3.6)) }; return }
    $running = New-Object System.Collections.ArrayList
    while (($pending.Count -gt 0 -and -not $script:limitHit) -or $running.Count -gt 0) {
        while ($pending.Count -gt 0 -and $running.Count -lt $MaxParallel -and -not $script:limitHit) {
            $c = $pending.Dequeue(); $c.tries++
            $schemaArg = $c.schema.Replace('"', '\"')
            $argLine = "-p --model $($c.model) --tools `"`" --system-prompt-file `"$($c.sys)`" --json-schema `"$schemaArg`" --output-format json --no-session-persistence --strict-mcp-config --disable-slash-commands --setting-sources `"`""
            $c.proc = Start-Process -FilePath $claudeExe -ArgumentList $argLine -RedirectStandardInput $c.in -RedirectStandardOutput $c.out -RedirectStandardError $c.err -WorkingDirectory $callsDir -NoNewWindow -PassThru
            [void]$running.Add($c)
            Say "  -> $($c.label) ($($c.model))"
        }
        Start-Sleep -Milliseconds 1500
        foreach ($c in @($running)) {
            if (-not $c.proc.HasExited) { continue }
            $running.Remove($c)
            $c.result = Read-CallResult $c
            if ($c.result) { Say "  <- $($c.label) done" }
            elseif ($script:limitHit) { Say "  !! $($c.label): usage limit hit" }
            elseif ($c.tries -lt 2) { Say "  !! $($c.label) failed, retrying"; $pending.Enqueue($c) }
            else { Say "  !! $($c.label) failed twice; see $($c.err)" }
        }
    }
}
function Stop-IfLimit {
    if ($script:limitHit) {
        Say "`nHit the usage limit. Every finished call is saved in $callsDir."
        Say "Re-run the same command after the limit resets; it continues from here instead of starting over."
        exit 2
    }
}

# ---------------------------------------------------------------- evidence check (0 tokens)
function Norm($s) { ([regex]::Replace("$s", '\s+', ' ')).Trim() }
$contextCorpus = New-Object Text.StringBuilder
function Test-Evidence($finding, $shard) {
    $ev = "$($finding.evidence)"
    if (-not $ev.Trim()) { return ($finding.lens -eq 'L11') }
    $ev = [regex]::Replace($ev, '(?m)^\s*\d+\s?[+ ]?\|\s?', '')        # strip copied gutters
    $ev = [regex]::Replace($ev, '(?m)^\s*-\|\s?', '')
    $hay = Norm ((($shard.files | ForEach-Object { $codeCorpus[$_.path] }) -join "`n") + "`n" + $contextCorpus.ToString())
    foreach ($frag in ($ev -split '\.\.\.|…|\r?\n\s*\r?\n')) {
        $n = Norm $frag
        if ($n.Length -lt 6) { continue }
        if (-not $hay.Contains($n)) {
            # tolerate one wrong line inside a multi-line quote: accept if every line >= 12 chars is found
            $lines = @($frag -split "`n" | ForEach-Object { Norm $_ } | Where-Object { $_.Length -ge 12 })
            if (-not $lines.Count) { return $false }
            foreach ($ln in $lines) { if (-not $hay.Contains($ln)) { return $false } }
        }
    }
    $true
}
$candidates = New-Object System.Collections.ArrayList
$goodNotes = New-Object System.Collections.ArrayList
$dropped = 0
function Add-Findings($result, $shard, $label) {
    $i = 0
    foreach ($f in @($result.findings)) {
        $i++
        if (Test-Evidence $f $shard) {
            [void]$script:candidates.Add([pscustomobject]@{ k = "$label-$i"; shard = $shard.id; severity = $f.severity; file = $f.file; line = $f.line; lens = $f.lens; title = $f.title; detail = $f.detail })
        } else { $script:dropped++ }
    }
    foreach ($g in @($result.good)) { [void]$script:goodNotes.Add($g) }
}

# ---------------------------------------------------------------- round 1: independent passes
# Prompt caching: the shard's code goes into the SYSTEM prompt, which Claude Code
# caches. Every pass over the same shard (A, B/C, gap) sends an identical system
# prompt, so the first pass writes the cache and the others read it at ~1/10 of
# the cost. Only the short task text differs, in the user message. (Measured:
# with the code in the user message each pass re-wrote ~80k tokens.)
$passSysBase = Read-Utf8 (Join-Path $engineDir 'pass-system.md')
$shardSys = @{}
function Get-ShardSystem($s) {
    if (-not $shardSys[$s.id]) {
        $p = Join-Path $callsDir "$($s.id).system.md"
        Write-Utf8 $p ($passSysBase + "`n`n" + $prHeader + $shardBody[$s.id])
        $shardSys[$s.id] = $p
    }
    $shardSys[$s.id]
}
function Get-ShardModel($s) { if ($s.kind -eq 'tests') { $TestModel } else { $PassModel } }
$prLevelShard = $shards[0].id
$round1a = New-Object System.Collections.ArrayList   # first pass per shard: writes the cache
$round1b = New-Object System.Collections.ArrayList   # further passes: read it
foreach ($s in $shards) {
    $first = $true
    foreach ($o in (Get-Round1Orders $s)) {
        $task = "Review pass $o over shard $($s.id). $($orders[$o])"
        if ($s.id -eq $prLevelShard) { $task += ' You also cover PR-level items (L11).' } else { $task += ' Skip PR-level items (L11); another pass covers them.' }
        $call = New-Call "$($s.id)-$o" (Get-ShardModel $s) (Get-ShardSystem $s) $task $passSchema
        if ($first) { [void]$round1a.Add($call); $first = $false } else { [void]$round1b.Add($call) }
    }
}
$round1 = @($round1a) + @($round1b)
Say "`nPR #$pr '$($meta.title)' | $($scope.Count) files in scope, $scopeLines changed lines | $($shards.Count) shard(s) | mode: $(if ($reReview) { "re-review of v$lastVersion" } else { 'first review' })"
if ($scopeNote) { Say $scopeNote }
Say "Round 1: $($round1.Count) independent passes ($($round1a.Count) first, then $($round1b.Count) reusing the cache)"
Invoke-Calls $round1a
Stop-IfLimit
if ($round1b.Count) { Invoke-Calls $round1b; Stop-IfLimit }

# ---------------------------------------------------------------- context requests (gh, 0 tokens)
$tree = $null
$ctxDir = Join-Path $prDir 'context'
function Get-ContextFile($name) {
    if (-not $script:tree) {
        $tp = Join-Path $prDir 'tree.txt'
        if (-not (Test-Path $tp)) { Write-Utf8 $tp ((gh api "repos/$Repo/git/trees/${sha}?recursive=1" --jq '.tree[].path') -join "`n") }
        $script:tree = (Read-Utf8 $tp) -split "`n"
    }
    $n = ($name -replace '\.(cs|ts)$', '').Trim()
    $hit = $script:tree | Where-Object { $_ -match "/$([regex]::Escape($n))\.(cs|ts)$" } | Select-Object -First 1
    if (-not $hit) { return $null }
    $dest = Join-Path $ctxDir ($hit -replace '/', '\')
    if (-not (Test-Path $dest)) {
        New-Item -ItemType Directory -Force (Split-Path $dest) | Out-Null
        $enc = ($hit -split '/' | ForEach-Object { [uri]::EscapeDataString($_) }) -join '/'
        $content = gh api -H 'Accept: application/vnd.github.raw' "repos/$Repo/contents/${enc}?ref=$sha" 2>$null
        if ($LASTEXITCODE -ne 0) { return $null }
        Write-Utf8 $dest ($content -join "`n")
    }
    [pscustomobject]@{ path = $hit; text = (Read-Utf8 $dest) }
}

foreach ($c in $round1) {
    if ($c.result) { $sid = ($c.label -split '-')[0]; Add-Findings $c.result ($shards | Where-Object { $_.id -eq $sid }) $c.label }
}

# ---------------------------------------------------------------- round 2: gap pass per code shard
$round2 = New-Object System.Collections.ArrayList
foreach ($s in ($shards | Where-Object { $_.kind -eq 'code' })) {
    $asks = @($round1 | Where-Object { $_.label -like "$($s.id)-*" -and $_.result } | ForEach-Object { @($_.result.needContext) }) | Where-Object { $_ }
    $ctxText = New-Object Text.StringBuilder
    $seen = @{}
    foreach ($a in ($asks | Select-Object -First 8)) {
        if ($seen[$a.name]) { continue }; $seen[$a.name] = $true
        $cf = Get-ContextFile $a.name
        if ($cf) {
            $lines = $cf.text -split "`r?`n"
            $shown = if ($lines.Count -gt 400) { ($lines[0..399] -join "`n") + "`n… (truncated)" } else { $cf.text }
            [void]$ctxText.Append("### CONTEXT FILE (not part of this PR): $($cf.path)`nQuestion from an earlier pass: $($a.question)`n$shown`n`n")
            [void]$contextCorpus.Append($cf.text).Append("`n")
        } else {
            [void]$ctxText.Append("### CONTEXT '$($a.name)' was not found in the repository. Question was: $($a.question)`n`n")
        }
    }
    $already = @($candidates | Where-Object { $_.shard -eq $s.id } | ForEach-Object { "- $($_.file):$($_.line) $($_.title)" }) -join "`n"
    if (-not $already) { $already = '(none)' }
    $task = "`n# Your task`nGap pass over shard $($s.id). Earlier passes already reported the issues listed below. Report ONLY genuine issues that are NOT on this list, and answer the context questions above (report the issue if the context confirms it). Dispute any listed item you believe is wrong via 'disputed' (use its title). An empty findings list is expected and fine.`n## Already reported`n$already"
    if ($reReview) { $task += "`nThis is a re-review: only the files shown changed since the last review." }
    $ctxBlock = if ($ctxText.Length) { "`n# Context requested by earlier passes`n" + $ctxText.ToString() } else { '' }
    [void]$round2.Add((New-Call "$($s.id)-G" (Get-ShardModel $s) (Get-ShardSystem $s) ($ctxBlock + $task) $passSchema))
}
if ($round2.Count) { Say "Round 2: $($round2.Count) gap pass(es)"; Invoke-Calls $round2; Stop-IfLimit }
$disputes = New-Object System.Collections.ArrayList
foreach ($c in $round2) {
    if (-not $c.result) { continue }
    $sid = ($c.label -split '-')[0]
    Add-Findings $c.result ($shards | Where-Object { $_.id -eq $sid }) $c.label
    foreach ($d in @($c.result.disputed)) { if ($d) { [void]$disputes.Add("[$sid] $($d.title): $($d.reason)") } }
}
$failedCalls = @(@($round1) + @($round2) | Where-Object { -not $_.result }).Count
if ($DryRun) {
    $mergeEst = 4000 + 250 * [Math]::Max(20, 8 * ($round1.Count + $round2.Count))
    Say ("`nDry run: {0} pass calls + 1 merge call (~{1:N0} tokens). Nothing was sent to the model." -f ($round1.Count + $round2.Count), $mergeEst)
    exit 0
}

# ---------------------------------------------------------------- merge call
$candJson = ($candidates | Select-Object k, severity, file, line, lens, title, detail | ConvertTo-Json -Depth 3 -Compress)
if (-not $candidates.Count) { $candJson = '[]' }
$mergeIn = New-Object Text.StringBuilder
[void]$mergeIn.Append("# PR`n$Repo#$pr `"$($meta.title)`" by $($meta.author.login) | $($meta.baseRefName) <- $($meta.headRefName) | state $($meta.state)$(if ($meta.mergedAt) { " (merged $($meta.mergedAt))" })`n")
[void]$mergeIn.Append("Reviewable: $reviewableLines changed lines in $($reviewable.Count) files; $($allFiles.Count - $reviewable.Count) generated files skipped. $scopeNote`nDescription (truncated): $desc`n`n")
[void]$mergeIn.Append("# Candidate findings (evidence already verified; $dropped unverifiable candidates were discarded)`n$candJson`n`n")
# Deterministic PR-hygiene checks (0 tokens, identical on every run).
if (-not $reReview) {
    $hyg = New-Object System.Collections.ArrayList
    if ($desc -like '(empty*') { [void]$hyg.Add('The PR description is the unfilled template (no What/Why), so reviewers have no stated intent to check the code against.') }
    if ("$($meta.title) $($meta.headRefName)" -match '\b[A-Z]{2,}-0+\b') { [void]$hyg.Add('The ticket reference is a placeholder (' + $Matches[0] + '), so the change cannot be traced to a requirement.') }
    if ($reviewableLines -gt 5000) { [void]$hyg.Add("The PR changes $reviewableLines reviewable lines in $($reviewable.Count) files; at this size review quality drops, so it should be split into smaller PRs.") }
    if ($hyg.Count) {
        [void]$candidates.Add([pscustomobject]@{ k = 'PR-HYGIENE'; shard = ''; severity = 'suggestion'; file = '(PR-level)'; line = ''; lens = 'L11'; title = 'PR hygiene'; detail = ($hyg -join ' ') })
        [void]$mergeIn.Append("# Machine-detected PR-hygiene facts (key PR-HYGIENE; always keep as one finding, merge any pass-reported duplicates into it):`n" + ($hyg -join "`n") + "`n`n")
    }
}
if ($formatOnly.Count) {
    [void]$mergeIn.Append("# Formatting-only files (every change is whitespace/indentation; machine-detected, not sent to review passes). Report once as a PR-hygiene nit using key FORMAT-ONLY if worthwhile:`n" + ($formatOnly -join "`n") + "`n`n")
    $fmtList = ($formatOnly | ForEach-Object { '`' + $_ + '`' }) -join ', '
    $fmtDetail = 'These files change only whitespace/indentation, which adds review noise to a functional PR: ' + $fmtList + '.'
    [void]$candidates.Add([pscustomobject]@{ k = 'FORMAT-ONLY'; shard = ''; severity = 'nit'; file = $formatOnly[0]; line = ''; lens = 'L11'; title = 'Formatting-only changes'; detail = $fmtDetail })
}
if ($disputes.Count) { [void]$mergeIn.Append("# Disputes raised by gap passes (weigh them)`n" + ($disputes -join "`n") + "`n`n") }
[void]$mergeIn.Append("# Strength notes from passes`n" + (($goodNotes | Select-Object -Unique) -join "`n") + "`n`n")
if ($reReview) {
    [void]$mergeIn.Append("# PRIOR FINDINGS (from v$lastVersion) with the current code at each location`n")
    foreach ($p in @($prior.findings | Where-Object { $_.status -in @('open', 'partial') })) {
        $excerpt = '(file not in this PR any more, or line unknown)'
        $hp = Join-Path $prDir ('head\' + ("$($p.file)" -replace '/', '\'))
        if ((Test-Path $hp) -and "$($p.line)" -match '^\d+') {
            $ls = (Read-Utf8 $hp) -split "`r?`n"; $ln = [int]($p.line -replace '\D.*$', '')
            $a = [Math]::Max(0, $ln - 13); $b = [Math]::Min($ls.Count - 1, $ln + 12)
            $excerpt = (($a..$b) | ForEach-Object { '{0,5}| {1}' -f ($_ + 1), $ls[$_] }) -join "`n"
        }
        [void]$mergeIn.Append("## $($p.id) [$($p.severity)] $($p.file):$($p.line) — $($p.title)`n$excerpt`n`n")
    }
}
$mergeCall = New-Call 'merge' $MergeModel (Join-Path $engineDir 'merge-system.md') $mergeIn.ToString() $mergeSchema
Say 'Merge: 1 call'
Invoke-Calls @($mergeCall); Stop-IfLimit
if (-not $mergeCall.result) { throw "Merge call failed; see $($mergeCall.err)" }
$final = $mergeCall.result

# ---------------------------------------------------------------- render (0 tokens)
function ConvertTo-HtmlText($s) { $e = [System.Net.WebUtility]::HtmlEncode("$s"); [regex]::Replace($e, '`([^`]+)`', '<code>$1</code>') }
function Card($fid, $statusHtml, $path, $title, $body) {
    $chip = if ($path) { "<code class=`"path-chip`" data-path=`"$(ConvertTo-HtmlText $path)`">$(ConvertTo-HtmlText $path)</code>" } else { '' }
    $idTag = if ($fid) { "<span class=`"fid`">$fid</span>" } else { '' }
    "<div class=`"finding-card`">`n  $idTag$statusHtml`n  $chip`n  <p><strong>$(ConvertTo-HtmlText $title).</strong> $(ConvertTo-HtmlText $body)</p>`n</div>"
}
function Loc($f) { if ($f.line) { "$($f.file):$($f.line)" } else { $f.file } }

$stateFindings = New-Object System.Collections.ArrayList
$nextId = 1
$prevSection = ''
if ($reReview) {
    $priorCards = New-Object System.Collections.ArrayList
    foreach ($p in @($prior.findings)) {
        $upd = @($final.prior) | Where-Object { $_.id -eq $p.id } | Select-Object -First 1
        $st = if ($upd) { $upd.status } else { $p.status }
        $line = if ($upd -and $upd.line) { $upd.line } else { $p.line }
        [void]$stateFindings.Add([ordered]@{ id = $p.id; severity = $p.severity; status = $st; file = $p.file; line = $line; lens = $p.lens; title = $p.title; body = $p.body; firstSeen = $p.firstSeen })
        if ($p.status -in @('open', 'partial')) {
            $note = if ($upd) { $upd.note } else { 'Not re-assessed.' }
            [void]$priorCards.Add((Card $p.id "<span class=`"status $st`">$st</span>" (Loc ([pscustomobject]@{ file = $p.file; line = $line })) $p.title $note))
        }
        $num = [int]("$($p.id)" -replace '\D', ''); if ($num -ge $nextId) { $nextId = $num + 1 }
    }
    $prevSection = "<section class=`"group previous`" id=`"previous`">`n<h2>Since v$lastVersion (commit $($prior.headSha.Substring(0,7)))</h2>`n" + ($priorCards -join "`n") + "`n</section>"
}
$candByKey = @{}; foreach ($c in $candidates) { $candByKey[$c.k] = $c }
# Machine-detected findings are facts: keep them even if the merge step left them out.
$usedKeys = @($final.findings | ForEach-Object { @($_.keys) })
foreach ($k in @('PR-HYGIENE', 'FORMAT-ONLY')) {
    if ($candByKey[$k] -and $usedKeys -notcontains $k) {
        $c = $candByKey[$k]
        $final.findings = @($final.findings) + [pscustomobject]@{ keys = @($k); severity = $c.severity; title = $c.title; body = '' }
    }
}
foreach ($f in @($final.findings)) {
    # The merge step returns candidate keys plus decisions; details, file and line
    # come from the passes (so the merge doesn't spend output tokens rewriting them).
    $srcs = @($f.keys | ForEach-Object { $candByKey[$_] } | Where-Object { $_ })
    if (-not $srcs.Count) { continue }
    $lead = $srcs[0]
    $leadStart = "$($lead.line)" -replace '\D.*$', ''
    $seenLoc = @{}
    $others = @($srcs | Select-Object -Skip 1 | Where-Object {
            $start = "$($_.line)" -replace '\D.*$', ''
            $key = "$($_.file)|$start"
            $dup = ($_.file -eq $lead.file -and $start -eq $leadStart) -or $seenLoc[$key] -or -not $_.file -or $_.file -eq '(PR-level)'
            $seenLoc[$key] = $true
            -not $dup
        } | ForEach-Object { Loc $_ })
    $body = if ("$($f.body)".Trim()) { $f.body } else { $lead.detail }
    if ($others.Count) { $body += ' Also at: ' + (($others | ForEach-Object { "``$_``" }) -join ', ') + '.' }
    $f = [pscustomobject]@{ severity = $f.severity; file = $lead.file; line = $lead.line; lens = $lead.lens; title = $f.title; body = $body }
    [void]$stateFindings.Add([ordered]@{ id = "F$nextId"; severity = $f.severity; status = 'open'; file = $f.file; line = $f.line; lens = $f.lens; title = $f.title; body = $f.body; firstSeen = "v$newVersion"; new = $true })
    $nextId++
}
$current = @($stateFindings | Where-Object { $_.status -in @('open', 'partial') })
function Cards($sev) {
    $cs = @($current | Where-Object { $_.severity -eq $sev } | ForEach-Object {
        $tag = if ($reReview -and $_.new) { '<span class="status new">new</span>' } elseif ($reReview) { "<span class=`"status $($_.status)`">$($_.status)</span>" } else { '' }
        Card $_.id $tag (Loc ([pscustomobject]$_)) $_.title $_.body })
    if ($cs.Count) { $cs -join "`n" } else { '<p class="empty-note">None.</p>' }
}
$goodHtml = @($final.good | ForEach-Object { Card '' '' $_.file $_.title $_.body }) -join "`n"
if (-not $goodHtml) { $goodHtml = '<p class="empty-note">None.</p>' }
$passCount = @(@($round1) + @($round2) | Where-Object { $_.result }).Count
$method = "<p class=`"empty-note`">Method: $passCount independent review calls over $($shards.Count) shard(s), evidence machine-checked ($dropped unverifiable candidates discarded)$(if ($failedCalls) { ", <strong>$failedCalls call(s) failed, so coverage is incomplete</strong>" }), then one merge call.</p>"
$summaryHtml = (@($final.summary | ForEach-Object { "<p>$(ConvertTo-HtmlText $_)</p>" }) -join "`n") + "`n" + $method

$stateObj = [ordered]@{ version = $newVersion; headSha = $sha; reviewedOn = (Get-Date -Format 'yyyy-MM-dd'); findings = @($stateFindings | ForEach-Object { $h = [ordered]@{}; foreach ($k in $_.Keys) { if ($k -ne 'new') { $h[$k] = $_[$k] } }; $h }) }
$stateJson = ($stateObj | ConvertTo-Json -Depth 6 -Compress).Replace('</', '<\/')
$usedGuides = @('code-review-guidelines.md') + $(if ($hasCs) { 'C#_Checklist.md' }) + $(if ($hasNg) { 'Angular_Checklist.md' }) + 'Naming_Conventions.txt'
$t = Read-Utf8 (Join-Path $skillDir 'template.html')
$map = [ordered]@{
    '{{PR_TITLE}}' = (ConvertTo-HtmlText $meta.title); '{{PR_URL}}' = $meta.url; '{{REPO}}' = $repoName; '{{PR_NUMBER}}' = "$pr"; '{{AUTHOR}}' = (ConvertTo-HtmlText $meta.author.login)
    '{{BASE_REF}}' = (ConvertTo-HtmlText $meta.baseRefName); '{{HEAD_REF}}' = (ConvertTo-HtmlText $meta.headRefName); '{{DATE_REVIEWED}}' = (Get-Date -Format 'yyyy-MM-dd')
    '{{GUIDES_USED}}' = ($usedGuides -join ', '); '{{RISK_LEVEL}}' = $final.risk; '{{RISK_CLASS}}' = "$($final.risk)".ToLower()
    '{{MUST_FIX_COUNT}}' = "$(@($current | Where-Object { $_.severity -eq 'must-fix' }).Count)"
    '{{SUGGESTIONS_COUNT}}' = "$(@($current | Where-Object { $_.severity -eq 'suggestion' }).Count)"
    '{{NITS_COUNT}}' = "$(@($current | Where-Object { $_.severity -eq 'nit' }).Count)"
    '{{GOOD_COUNT}}' = "$(@($final.good).Count)"
    '{{SUMMARY_HTML}}' = $summaryHtml; '{{PREVIOUS_SECTION}}' = $prevSection
    '{{MUST_FIX_HTML}}' = (Cards 'must-fix'); '{{SUGGESTIONS_HTML}}' = (Cards 'suggestion'); '{{NITS_HTML}}' = (Cards 'nit'); '{{GOOD_HTML}}' = $goodHtml
    '{{HEAD_SHA_SHORT}}' = $sha.Substring(0, 7); '{{STATE_JSON}}' = $stateJson
}
foreach ($k in $map.Keys) { $t = $t.Replace($k, "$($map[$k])") }
# Check only the template's own slots: reviewed code often contains {{...}}
# placeholders of its own (e.g. notification templates' {{Action}}), and
# PowerShell's -match is case-insensitive, so a generic pattern false-alarms.
$leftover = @($map.Keys | Where-Object { $t.Contains($_) })
if ($leftover.Count) { throw "Template placeholder left unfilled: $($leftover -join ', ')" }
if (Test-Path $outFile) { throw "Refusing to overwrite $outFile" }
Write-Utf8 $outFile $t

# ---------------------------------------------------------------- usage + reply
$tot = [pscustomobject]@{
    input = ($usage | Measure-Object input -Sum).Sum; cacheWrite = ($usage | Measure-Object cacheWrite -Sum).Sum
    cacheRead = ($usage | Measure-Object cacheRead -Sum).Sum; output = ($usage | Measure-Object output -Sum).Sum
}
$logDir = Join-Path $root '.tmp\logs'; New-Item -ItemType Directory -Force $logDir | Out-Null
Write-Utf8 (Join-Path $logDir ("usage-pr$pr-{0:yyyyMMdd-HHmmss}.json" -f (Get-Date))) ($usage | ConvertTo-Json -Depth 3)
$mf = $map['{{MUST_FIX_COUNT}}']; $sg = $map['{{SUGGESTIONS_COUNT}}']; $nt = $map['{{NITS_COUNT}}']
Say "`n$($meta.title)`n$($meta.url)"
Say "Risk: $($final.risk) | $mf must-fix, $sg suggestions, $nt notes"
if ($reReview) {
    $st = @($stateFindings | Where-Object { -not $_.new })
    Say ("Since v{0}: {1} fixed, {2} partial, {3} still open, {4} withdrawn, {5} new" -f $lastVersion, @($st | Where-Object { $_.status -eq 'fixed' }).Count, @($st | Where-Object { $_.status -eq 'partial' }).Count, @($st | Where-Object { $_.status -eq 'open' }).Count, @($st | Where-Object { $_.status -eq 'withdrawn' }).Count, @($final.findings).Count)
}
if ($failedCalls) { Say "WARNING: $failedCalls review call(s) failed; the report says coverage is incomplete. Re-run to retry just those." }
Say "Report: $outFile$(if ($newVersion -gt 1) { " (v$newVersion)" })"
Say ("Tokens: {0:N0} input + {1:N0} cache-write + {2:N0} cache-read + {3:N0} output over {4} calls" -f $tot.input, $tot.cacheWrite, $tot.cacheRead, $tot.output, $usage.Count)
if (-not $failedCalls) { Remove-Item -Recurse -Force $prDir }
