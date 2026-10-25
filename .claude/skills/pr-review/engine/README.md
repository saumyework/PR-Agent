# PR review engine: how it works and why

## Why it's a script and not an AI agent

Agent-driven reviews were exhausting the usage limit. Every agent step
re-sends the agent's whole context, plus about 15k tokens of built-in
system prompt and tool definitions. A review pass that read 60k tokens of
code over 25 steps cost around 1.5M tokens, and a big PR needed about 19
passes. The engine calls the model with `claude -p --tools ""`: **one
request per pass, no tools, about 740 tokens of overhead**. Everything that
needs no judgement runs in PowerShell and uses no tokens.

## Flow

| Step | Done by | Tokens |
|---|---|---|
| Fetch metadata, all files (paginated, past the 100-file cap), diff, head versions of the files | `../prefetch.ps1` (gh) | 0 |
| Drop generated files (EF `*.Designer.cs`, lockfiles, …) | script | 0 |
| Shard: production (S*) and tests (T*) separately, up to 2500 changed lines each, grouped by folder. The same PR always gives the same shards. | script | 0 |
| Build each shard's input: PR header, team rules and checklist, a compact index of all PR files, then each file with head line numbers and `+` on changed lines. License headers and using blocks are compacted. | script | 0 |
| Round 1: independent passes, in parallel (up to 4 at a time) | model, Sonnet | 1 request each |
| Check each quoted `evidence` against the real code; drop unverifiable findings | script | 0 |
| Resolve the passes' `needContext` names against the repo tree and fetch those files | script (gh) | 0 |
| Round 2: one gap pass per code shard (context files plus "already reported" list) | model, Sonnet | 1 request each |
| Merge: dedupe by root cause, set final severity, write summary and strengths; reconcile prior IDs on re-review | model, Sonnet (or `-MergeModel opus`) | 1 request |
| Render HTML from `template.html` and embed the state JSON | script | 0 |

Passes per shard:

| Case | Round 1 | Round 2 |
|---|---|---|
| ≤ 300 changed lines | A, B | gap |
| ≤ 2500 (one shard) | A, B, C | gap |
| larger, code shard | A, C | gap |
| larger, test shard | A | none |
| re-review (changed files only) | A | gap |

Walk orders: A = top to bottom, B = bottom to top, C = request flow. Using
different orders is what makes the passes independent. Each one alone
misses different things, and the union is what makes v1 complete.

## Token optimisations (in order of impact)

1. **One request per pass, no tools.** No agent turns re-sending context,
   and about 740 tokens of overhead instead of ~15k per turn.
2. **Prompt caching per shard.** The shard's code lives in the *system*
   prompt, which Claude Code caches. Pass A writes it; passes B/C and the
   gap pass send an identical system prompt and read it at ~1/10 the cost,
   with only the short task in the user message. Measured on 14235 before
   this change: each pass re-wrote ~80k tokens. Passes run in waves (all
   the first passes, then the rest), so the cache is warm when needed. A
   re-run shortly after a previous one also hits the cache.
3. **Haiku for test shards** (`-TestModel`, or `-Quality` for Sonnet).
4. **The merge step writes decisions, not prose.** It returns candidate
   keys, severity and title; bodies are reused from the passes. Output
   tokens are the most expensive kind, and this took the merge from ~18k
   to ~2k of them.
5. **Deterministic work, 0 tokens:** formatting-only files are detected and
   skipped, PR-hygiene facts (empty template, placeholder ticket, PR size)
   are raised by the script, evidence is checked, and the HTML is rendered.
6. **Input trimming:** template boilerplate, license headers, using blocks
   and gutter padding are stripped.

## Cost reference (measured and estimated)

- PR 14270 (151 lines): 4 requests, about 63k tokens in total (measured).
- PR 14235 (298 files, 18.4k lines): 19 pass requests of 25–55k input each
  plus a merge, about 750k input tokens (dry-run estimate). The agent
  version used a whole usage window without finishing.

Run with `-DryRun` to see the plan and per-request size before spending
anything. Each real run prints the tokens used and saves a per-call
breakdown to `.tmp/logs/usage-pr<N>-*.json`.

## Resume after hitting the limit

Every request's output is cached in `.tmp/pr<N>/calls-<sha7>/`. On a re-run
at the same commit, finished requests are reused and only the missing ones
are sent. The folder is deleted after a successful run.

## Trade-offs to know about

- Passes can't browse the repo freely. Instead they name classes they need
  (`needContext`), and the script fetches those for the gap pass. Insights
  that need repository *history* (e.g. "PR #14211 already did this rename")
  are out of reach. The old agent version sometimes found those.
- Quotes that can't be matched in the code are discarded. That removes
  hallucinated findings, but a finding with a sloppy quote is lost too. The
  report states how many were discarded.

## Files

- `review.ps1`: the driver.
- `pass-system.md`: system prompt for review and gap passes (lenses L1–L12,
  severity, output rules).
- `merge-system.md`: system prompt for the merge step.
- `../prefetch.ps1`: fetching.
- `../template.html`: the report template.
