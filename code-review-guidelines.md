# Code Review Guidelines

This file is the entry point the PR review agent checks every PR against.
Edit it directly any time, or just tell the agent "remember: ..." during a
review conversation and it will add the rule here under **Team-Specific Rules**.

Priority order when rules conflict: **Team-Specific Rules** (below) >
**Stack-Specific Guides** > **General Best Practices** (fallback only).

---

## Team-Specific Rules

### Generic list `path` values must match a real backend property chain, at the right depth

Any column with `"isInsideObject": true` in a list-column JSON config
(`src/assets/data/**/*.json`) sends its `path` verbatim as the OData-style `$orderby`/`$filter`
field to the backend's generic sort/filter engine
(`BuildingBlocks/Pagination/CriteriaBuilder.cs` → `GetPropertyAccessExpression`, shared by every
module's `Repository<T>.ListAsync`). As of 2026-08, property-name **casing** in that path is
resolved case-insensitively — a lowercase `path` like `"department/name"` correctly matches the
backend's PascalCase `Department.Name` — so casing mismatches are no longer a bug class to flag.

What still breaks: the path's **depth** must exactly match a real navigation chain on the backend
entity. A `path` that references a property that doesn't exist at that depth (e.g. a flat
`"serviceUnit"` when the entity only exposes `ServiceUnit` two levels down, via
`Department.ServiceUnit`) throws `InfrastructureException` on **every** sort/filter attempt against
that column — not a silent no-op, and not something a quick UI smoke-test will necessarily catch if
the column isn't sorted/filtered during testing. When a PR adds or changes a `path` for an
`isInsideObject: true` column, cross-check it against the actual backend entity's navigation
properties (open the corresponding `Domain/Models/*.cs`) — don't assume the path is correct just
because it reads correctly.

_(Found and fixed via OOTB bug: "Sort not working for Technician/Service Unit fields" in
SDM Requests — root cause was this exact class of defect, compounded by a case-sensitivity bug in
`CriteriaBuilder` that's now fixed platform-wide.)_

### Dropdown filters require `dataType: "Toolbox"`, not `"Text"`

The shared filter-panel component
(`libs/shared/components/.../base-list-actions/base-list-actions-header.component.ts`) only renders
a dropdown (`<mat-select>` populated via `getDictionaryItems`/`getToolboxValues`) for columns with
`"dataType": "Toolbox"` in their JSON config. If a PR adds a route resolver that calls
`setDictionaryItems(columnName, ...)` to pre-load dropdown options for a column, but that column's
JSON config still has `"dataType": "Text"`, the resolver's output is never read — the filter
renders as a plain text input with no options, and the dictionary-population code is effectively
dead. Flag this whenever a PR adds/changes a filter resolver without also checking its target
column's `dataType`, or vice versa.

---

## Stack-Specific Guides

These live in `guides/` and are the authoritative source for their stack —
don't duplicate their content here, edit the files directly instead. The
agent reads the relevant one(s) based on what kind of files changed in the PR.

| File | Applies to |
|---|---|
| `guides/Angular Code Review.txt` | `.ts`, `.html`, `.scss` files in the Angular/ososerp-web frontend |
| `guides/C#_Code_Review.txt` | `.cs` files in the .NET backend (Modules/*) |
| `guides/Naming_Conventions.txt` | Cross-cutting naming rules (files, classes, functions, variables, constants) — applies to both stacks |
| `guides/C#_Coding_Conventions_&_Best_Practice.txt` | Pointers to external C# standard references |
| `guides/C#_Checklist.md`, `guides/Angular_Checklist.md` | Compact, rule-per-line versions of the two big guides. The review passes read these **instead of** the full guides to save tokens. **Regenerate a checklist whenever its full guide changes.** |

If a PR touches a stack with no guide here, fall back to **General Best
Practices** below.

---

## Always-Enforced Checks

Unlike the fallback-only General Best Practices below, these two apply on
**every** review, on top of whatever Stack-Specific Guide matches — they are
never skipped just because a stack guide already covered other ground.

Severity for both is decided per finding, not fixed to one section: file
each instance under **Must-Fix**, **Suggestions**, or **Nits** based on its
actual real-world impact — don't default every performance/validation
observation into "Suggestions" out of habit.

### Performance
- N+1 queries, unbounded loops over unbounded data, repeated work that could
  be cached/memoized/paginated (backend).
- Unnecessary change detection triggers, missing `OnPush`, subscriptions
  without `async` pipe or teardown, large unoptimized bundles/images, missing
  lazy-loading for feature routes (Angular frontend).
- Judge severity by exposure: a hot-path endpoint or a list page used
  constantly is Must-Fix territory if it clearly won't scale; a rarely-hit
  admin screen with a minor inefficiency is a Suggestion or Nit.

### Validation (frontend AND backend — check both, independently)
- **Backend**: every write path (Command) has FluentValidation (or
  equivalent) coverage — required fields, enum ranges, GUID/empty checks,
  cross-field rules — consistent with how sibling commands in the same
  module already validate.
- **Frontend**: reactive form validators matching the backend's rules
  (required/format/range), disabled submit until valid, API validation
  errors surfaced to the user rather than swallowed.
- Treat frontend and backend validation as *independent* checks, not
  substitutes for each other: backend validation exists for correctness and
  security (the frontend can always be bypassed), frontend validation exists
  for UX. A PR that only validates on one side is missing the other,
  regardless of which side "already caught it."
- Missing backend validation that lets bad/dangerous data through is
  Must-Fix. Missing frontend validation that only affects UX polish is
  usually a Suggestion.

---

## General Best Practices

_(Fallback only — used when a PR touches a language/stack not covered by a
Stack-Specific Guide above.)_

### Correctness & Logic
- Does the code do what the PR description claims? Check for off-by-one errors,
  incorrect conditionals, unhandled edge cases (empty input, null/undefined,
  zero, negative numbers, max size).
- Are there race conditions or ordering assumptions in async/concurrent code?
- Do changed functions still satisfy all existing call sites?

### Security
- No secrets, tokens, or credentials committed.
- User input is validated/sanitized at trust boundaries (SQL injection, XSS,
  command injection, path traversal).
- Auth/authorization checks aren't weakened, bypassed, or removed.
- Dependencies added aren't obviously abandoned/unmaintained or have known CVEs.

### Readability & Maintainability
- Names are descriptive; no unexplained abbreviations.
- Functions do one thing; deeply nested logic is a smell.
- No dead code, commented-out blocks, or leftover debug statements.
- Comments explain *why*, not *what* — flag comments that just restate the code.
- No unnecessary abstraction, premature generalization, or speculative
  "future-proofing" for requirements that don't exist yet.

### Testing
- New logic has test coverage for the happy path and at least one edge case.
- Tests actually assert meaningful behavior (not just "doesn't throw").
- Bug fixes include a regression test.

### Error Handling
- Errors are handled at the right layer — not swallowed silently, not
  over-caught with generic try/catch that hides root cause.
- Failure modes are user-comprehensible where user-facing.

### PR Hygiene
- PR is scoped to one logical change (flag if it's actually 2-3 unrelated
  changes bundled together).
- Commit messages / PR description explain *why*, not just *what*.
- No unrelated formatting/reformatting noise mixed into a functional change.

### Documentation
- Public APIs, config changes, and new env vars are documented.
- README/CHANGELOG updated if the change affects setup or user-facing behavior.

---

## Output Format

Every review should return, in this order:

1. **Summary** — what the PR does, and an overall risk level (Low/Medium/High).
2. **Must-Fix** — bugs, security issues, or guideline violations that should
   block merge. Cite file:line.
3. **Suggestions** — not blocking, but "this could be done better" with the
   concrete better alternative. Cite file:line.
4. **Nits** — optional style/minor polish. Cite file:line.
5. **What's Good** — things worth keeping or calling out positively.

This goes to an HTML file (rendered via `.claude/skills/pr-review/template.html`)
under `reviews/<project>/<repo>/pr<number>.html` — one master folder per
ticket-prefix project (e.g. `OOTB`, `CRM` — not the individual ticket
number), with a subfolder per repo (`ososerp` backend, `ososerp-web`
frontend) so a project spanning both stays together. Chat only gets a short
pointer (risk level, finding counts, file path). Never post this output to
GitHub automatically — the tech lead decides what to relay to the PR.
