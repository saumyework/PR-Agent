<#
Fetches everything a PR review needs into .tmp/pr<N>/ in one go, so the review
passes read local files instead of each re-fetching from GitHub (which costs
tokens on every pass). Runs outside the model: its output is the only thing
that lands in context, and it is kept short.

  powershell -NoProfile -ExecutionPolicy Bypass -File .claude/skills/pr-review/prefetch.ps1 -Repo owner/repo -Pr 14235

Writes:
  meta.json     PR metadata (title, refs, headRefOid, state, files, ...)
  full.diff     gh pr diff
  review.diff   full.diff minus generated files
  head/<path>   every non-generated, non-deleted changed file at the head commit
  shards.json   deterministic groups of files for large PRs (same PR -> same shards)
  files.txt     one line per file: +adds/-dels, shard, and a "generated" marker
#>
param(
    [Parameter(Mandatory = $true)][string]$Repo,
    [Parameter(Mandatory = $true)][int]$Pr,
    [int]$ShardLines = 2500   # max changed lines per shard (sized for Sonnet passes)
)
$ErrorActionPreference = 'Stop'
$root = Resolve-Path (Join-Path $PSScriptRoot '..\..\..')
$out = Join-Path $root ".tmp\pr$Pr"
New-Item -ItemType Directory -Force $out, (Join-Path $out 'head') | Out-Null
$utf8 = New-Object Text.UTF8Encoding $false

$metaJson = gh pr view $Pr --repo $Repo --json 'number,title,url,author,body,state,mergedAt,baseRefName,headRefName,headRefOid,additions,deletions,files' | Out-String
[IO.File]::WriteAllText((Join-Path $out 'meta.json'), $metaJson, $utf8)
$meta = $metaJson | ConvertFrom-Json

# `gh pr view --json files` silently caps at 100 files, so take the file list
# from the paginated REST endpoint instead (up to GitHub's 3000-file limit).
# (No quotes inside the jq filter: PowerShell 5.1 strips them when calling gh.)
$restFiles = gh api "repos/$Repo/pulls/$Pr/files?per_page=100" --paginate --jq '.[]' |
    ForEach-Object {
        $f = $_ | ConvertFrom-Json
        [pscustomobject]@{
            path       = $f.filename
            additions  = $f.additions
            deletions  = $f.deletions
            changeType = if ($f.status -eq 'removed') { 'DELETED' } else { $f.status.ToUpper() }
        }
    }
$meta.files = @($restFiles)
[IO.File]::WriteAllText((Join-Path $out 'meta.json'), ($meta | ConvertTo-Json -Depth 5), $utf8)

$diff = (gh pr diff $Pr --repo $Repo) -join "`n"
[IO.File]::WriteAllText((Join-Path $out 'full.diff'), $diff, $utf8)

$generated = '\.Designer\.cs$|package-lock\.json$|yarn\.lock$|pnpm-lock\.yaml$|\.snap$|\.min\.(js|css)$|\.map$'

# review.diff = full.diff without generated file sections
$sb = New-Object Text.StringBuilder
$skip = $false
foreach ($line in $diff -split "`n") {
    if ($line.StartsWith('diff --git ')) { $skip = $line -match $generated }
    if (-not $skip) { [void]$sb.Append($line).Append("`n") }
}
[IO.File]::WriteAllText((Join-Path $out 'review.diff'), $sb.ToString(), $utf8)

# head versions of reviewable files
$reviewable = @($meta.files | Where-Object { $_.path -notmatch $generated })
$failed = 0
foreach ($f in $reviewable) {
    if ($f.changeType -eq 'DELETED') { continue }
    $dest = Join-Path (Join-Path $out 'head') ($f.path -replace '/', '\')
    New-Item -ItemType Directory -Force (Split-Path $dest) | Out-Null
    $enc = ($f.path -split '/' | ForEach-Object { [uri]::EscapeDataString($_) }) -join '/'
    # Retry transient GitHub errors (502s happen on large PRs); never abort the whole prefetch.
    $ok = $false
    for ($try = 1; $try -le 3 -and -not $ok; $try++) {
        try {
            $ErrorActionPreference = 'Continue'
            $content = gh api -H 'Accept: application/vnd.github.raw' "repos/$Repo/contents/${enc}?ref=$($meta.headRefOid)" 2>$null
            $ok = ($LASTEXITCODE -eq 0)
        } catch { $ok = $false } finally { $ErrorActionPreference = 'Stop' }
        if (-not $ok) { Start-Sleep -Seconds (2 * $try) }
    }
    if ($ok) { [IO.File]::WriteAllText($dest, ($content -join "`n"), $utf8) } else { $failed++; Write-Output "head fetch failed: $($f.path)" }
}

# Deterministic shards: production code (S1..Sn) and test code (T1..Tn) are
# packed separately, each grouped by feature folder (first 5 path segments),
# sorted by path, up to $ShardLines changed lines per shard. Same PR -> same shards.
$testPattern = '(^|/)[^/]*Tests?[^/]*/|\.spec\.ts$|Tests?\.cs$'
function New-Shards($files, $prefix) {
    $result = New-Object System.Collections.ArrayList
    $cur = New-Object System.Collections.ArrayList; $curLines = 0
    $groups = $files | Group-Object { ($_.path -split '/' | Select-Object -First 5) -join '/' } | Sort-Object Name
    foreach ($g in $groups) {
        $lines = ($g.Group | Measure-Object -Property additions -Sum).Sum + ($g.Group | Measure-Object -Property deletions -Sum).Sum
        if ($cur.Count -gt 0 -and $curLines + $lines -gt $ShardLines) { [void]$result.Add(@($cur)); $cur = New-Object System.Collections.ArrayList; $curLines = 0 }
        foreach ($f in ($g.Group | Sort-Object path)) { [void]$cur.Add($f.path) }
        $curLines += $lines
    }
    if ($cur.Count -gt 0) { [void]$result.Add(@($cur)) }
    @(for ($i = 0; $i -lt $result.Count; $i++) { [ordered]@{ id = "$prefix$($i + 1)"; kind = $(if ($prefix -eq 'T') { 'tests' } else { 'code' }); files = @($result[$i]) } })
}
$shardObjs = @(New-Shards @($reviewable | Where-Object { $_.path -notmatch $testPattern }) 'S') + @(New-Shards @($reviewable | Where-Object { $_.path -match $testPattern }) 'T')
[IO.File]::WriteAllText((Join-Path $out 'shards.json'), (ConvertTo-Json @($shardObjs) -Depth 4), $utf8)

$shardOf = @{}; foreach ($s in $shardObjs) { foreach ($p in $s.files) { $shardOf[$p] = $s.id } }
$list = foreach ($f in $meta.files) {
    $tag = if ($f.path -match $generated) { 'generated' } else { $shardOf[$f.path] }
    "{0,6} {1,6}  {2,-9} {3}" -f "+$($f.additions)", "-$($f.deletions)", $tag, $f.path
}
[IO.File]::WriteAllText((Join-Path $out 'files.txt'), ($list -join "`n"), $utf8)

$reviewLines = ($reviewable | Measure-Object -Property additions -Sum).Sum + ($reviewable | Measure-Object -Property deletions -Sum).Sum
"PR #$Pr $($meta.state) head=$($meta.headRefOid.Substring(0,7)) | files: $($meta.files.Count) total, $($reviewable.Count) reviewable, $($meta.files.Count - $reviewable.Count) generated | reviewable changed lines: $reviewLines | shards: $(@($shardObjs | Where-Object { $_.kind -eq "code" }).Count) code + $(@($shardObjs | Where-Object { $_.kind -eq "tests" }).Count) tests | head fetch failures: $failed"
"Wrote $out (meta.json, full.diff, review.diff, head/, shards.json, files.txt)"
