---
name: pr-review
description: Review a GitHub PR or branch against code-review-guidelines.md and general best practices. Fetches the diff via the gh CLI (no manual pasting required), renders a structured summary/must-fix/suggestions/nits/praise report as HTML (via template.html) into reviews/, and replies in chat with just a short pointer to the file. Use when the user asks to review a PR, branch, or gives a repo + PR number/branch to check.
---

# PR Review

The review is done by a script, not by you. `engine/review.ps1` fetches the
PR, splits it into shards, runs several independent single-request review
passes plus gap passes, machine-checks every finding's quoted evidence,
merges the results in one request, and renders the HTML report. It is built
this way to keep token use low. **Don't re-implement any of it by reading
the diff or running your own review passes.** That is exactly what used to
exhaust the usage limit.

## Input

```
/pr-review owner/repo 13219
/pr-review owner/repo some-branch-name
/pr-review owner/repo 13219 --fresh
```

## Steps

1. Run `gh auth status`. If it isn't authenticated, tell the user to run
   `gh auth login` and stop.
2. Run exactly this, with a 10-minute timeout, from the project root. Add
   `-Fresh` if the user passed `--fresh` or asked for a complete review from
   scratch. Add `-MergeModel opus` only if they ask for Opus.
   `powershell -NoProfile -ExecutionPolicy Bypass -File .claude/skills/pr-review/engine/review.ps1 -Repo <owner/repo> -Target <number-or-branch>`
   For big PRs (over ~3000 changed lines) run it in the background and wait
   for the completion notice. Don't poll.
3. Relay the engine's last lines to the user as they are: title, link,
   risk, counts, the since-last-review line if present, the report path,
   and tokens used. Don't open or summarise the report yourself, because
   that spends tokens re-reading it.
4. If the engine prints that it hit the usage limit, tell the user to re-run
   the same command after the reset. Finished calls are cached and reused.
   Exit code 2 means the limit was hit.
5. Never post anything to GitHub.

## Behaviour the engine guarantees

These are documented in `engine/README.md`.
- **First review is complete.** Several independent passes per shard with
  different walk orders, plus a gap pass that sees "already reported" and
  any context files the passes asked for.
- **Re-reviews converge.** Only files changed since the last reviewed
  commit are reviewed. Prior findings keep their IDs (F1…) and get
  fixed/partial/open/withdrawn. The same commit twice means no new report.
- **Reports are versioned**, never overwritten:
  `reviews/<PROJECT>/<repo>/pr<N>.html`, then `-v2`, `-v3` and so on.
  PROJECT is the ticket prefix taken from the title or the branch, or
  `MISC` if there is none.

## Remembering new rules

If the user says "remember: we always require X" or "add a rule about Y",
append it to **Team-Specific Rules** in `code-review-guidelines.md` and
confirm. The engine sends that section to every pass automatically. If they
change a full guide in `guides/`, regenerate its `*_Checklist.md`, because
the passes read the checklists, not the full guides.
