<#
Reviews a GitHub PR from a plain terminal.

Usage:
  .\pr-review.ps1 owner/repo 13219
  .\pr-review.ps1 owner/repo some-branch-name
  .\pr-review.ps1 owner/repo 13219 -Fresh        # ignore earlier reviews, full review from scratch
  .\pr-review.ps1 owner/repo 13219 -DryRun       # show the plan and token estimate, send nothing
  .\pr-review.ps1 owner/repo 13219 -Model opus   # stronger final merge/judgement step (costs more)
  .\pr-review.ps1 owner/repo 13219 -Quality      # review test code with Sonnet too (costs more)

This calls the review engine directly: no AI agent drives it. Every model call
is a single request with no tools, which keeps token use low. The engine prints
the tokens used at the end. If a run hits the usage limit, re-run the same
command after the reset: finished calls are reused, not repeated.
#>
param(
    [Parameter(Mandatory = $true, Position = 0)][string]$Repo,
    [Parameter(Mandatory = $true, Position = 1)][string]$Target,
    [switch]$Fresh,
    [switch]$DryRun,
    [switch]$Quality,   # tests reviewed by Sonnet too (default: Haiku, cheaper)
    [ValidateSet('sonnet', 'opus')][string]$Model = 'sonnet'
)
$projectRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
$engine = Join-Path $projectRoot '.claude\skills\pr-review\engine\review.ps1'
$logDir = Join-Path $projectRoot '.tmp\logs'
New-Item -ItemType Directory -Force $logDir | Out-Null
$log = Join-Path $logDir ("{0}-{1}-{2:yyyyMMdd-HHmmss}.log" -f ($Repo -replace '/', '_'), ($Target -replace '[\\/]', '-'), (Get-Date))

$engineArgs = @('-NoProfile', '-ExecutionPolicy', 'Bypass', '-File', $engine, '-Repo', $Repo, '-Target', $Target, '-MergeModel', $Model)
if ($Fresh) { $engineArgs += '-Fresh' }
if ($DryRun) { $engineArgs += '-DryRun' }
if ($Quality) { $engineArgs += '-Quality' }

Push-Location $projectRoot
try {
    & powershell @engineArgs 2>&1 | ForEach-Object { $line = "$_"; Write-Host $line; Add-Content -Path $log -Value $line -Encoding UTF8 }
    Write-Host "`nLog: $log" -ForegroundColor DarkGray
}
finally {
    Pop-Location
}
