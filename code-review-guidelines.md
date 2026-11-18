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

### EF Core migrations and new DbContexts follow the shared module convention (backend)

_(Source: Confluence OBP → Guidelines → "Migrations and Database Context", mandatory for new work.)_
When a PR adds a migration or a new module/DbContext, check:
- **Names:** schema name = module name = folder under `Modules/` (legacy exception: `Emc` → `HumanResource`;
  no new mismatches). Contexts are `{Module}DbContext` (base), `{Module}PostgresDbContext`,
  `{Module}SqlServerDbContext`. Migrations live in `Migrations/PostgreSQL/{Schema}/` and
  `Migrations/SqlServer/{Schema}/` inside `Modules/{Module}/{Module}.Infrastructure`.
- **Both providers:** a model change ships a migration for **both** PostgreSQL and SQL Server (generated
  with `src/scripts/Add-MigrationBothProviders.ps1`), unless PostgreSQL is deliberately maintained by manual
  scripts. A migration for only one provider with no explanation is a gap.
- **Base DbContext:** a `protected` design-time constructor plus a `public` runtime constructor marked
  `[ActivatorUtilitiesConstructor]`. `OnModelCreating` sets `HasDefaultSchema(...)` and calls
  `FixCascadeDeletesForSqlServer(...)` (otherwise SQL Server hits "multiple cascade paths").
- **Registration:** `DependencyInjection.cs` registers the context with `options.UseConfiguredDatabase(...)`;
  never call `UseNpgsql`/`UseSqlServer` directly. New contexts are also registered in
  `DbMigrator/Services/MigrationContextFactories.cs`, and have design-time factories using
  `MigrationsHistoryTable("__EFMigrationsHistory", "<Schema>")`.
- **Nullable FKs:** use `Guid?` and assign `null` for "no related entity", not `Guid.Empty` (avoids SQL Server
  FK and unique-index failures).
- **JSON columns:** store JSON as a `string`/`string?` property decorated with `[JsonColumn]`
  (`Shared.Domain.ActionFilters`); the convention maps it to `jsonb` / `nvarchar(max)`. Flag `JsonDocument`,
  `object` or a concrete class as the property type, a manual `HasColumnType()` for it, or hand-rolled
  serialization instead of `Deserialize<T>()` / `SerializeToJsonColumn()` / `HasJsonValue()`.
  Check the generated migrations show `jsonb` (PostgreSQL) and `nvarchar(max)` (SQL Server).

### Group-based OData filters use the `{group(...)}` pattern

_(Source: Confluence OBP → Guidelines → "Filter Pattern for Group-based conditions (OData)".)_
Hand-built filter strings (or `setMultipleFilters` in `odata.factory.ts`, which takes `FilterItem[]` and
groups by `fieldKey`) must follow these rules: groups sit inside `{}` and come **first**; inside
`group(...)` use `||` for OR and `&` for AND (never the words `and`/`or`); after the closing `}` use
normal `and`/`or`. A group written with `and`/`or` words, or placed after a normal condition, will not parse.

### Branch naming and PR target

_(Source: Confluence OBP → Guidelines → "Git Branching".)_ Feature branches are
`feature/<module>/<jiraid>/<description>` (e.g. `feature/platform/OBPP-1010/form-builder-q1`) and target the
relevant `version/x.x.x` branch; developer branches `develop/...` target their `feature/...` branch. Report a
mismatched branch name or PR target as a **Nit** (or a Suggestion if the PR targets the wrong branch).
### Backend query count, time complexity and unused code are MUST-FIX

_(Source: tech lead review of the Pre-Bid Clarification service, PR #15062.)_ For every new or changed backend
service method (`Modules/*/**/Services/*.cs`, handlers, extensions), the review must do all three and file each
violation under **Must-Fix**, not Suggestions:
- **Query count:** count the DB round trips one request makes, including nested helper methods. Repeated queries to the
  same repository for the same data, a query inside a loop or per hierarchy level (for example a parent-by-parent walk
  to the root), and a re-query after a write only to rebuild the DTO are violations. Merge them into one query
  (`Contains`/`Include`/projection), keep the `IQueryable` and use `AnyAsync`/`FirstOrDefaultAsync`, or build the
  result from the entity already in memory.
- **One retrieval per repository per method:** count the calls to each repository in the method and in the helper
  methods it calls. Two or more queries against the same repository (any mix of `GetAsync`, `GetListAsync`,
  `GetQueryableAsync`, `AnyAsync`, `CountAsync`, any predicates) are a violation: retrieve the needed rows once in a
  single query, then filter, count, check existence and pick first/fallback in memory, and pass the loaded data to
  helpers as parameters. Examples only: `CountAsync(predicate)` then `GetQueryableAsync(predicate: predicate, ...)`;
  `GetAsync(id)` then `AnyAsync(ParentId == id)`; `GetAsync(a)` then fallback `GetAsync(b)`; lookup, parent walk, then
  a re-read of the same row to build the DTO. For paged lists the retrieval must stay bounded (page and total in one
  query, for example a `COUNT(*) OVER()` projection); use `Id IN (a, b)` for a primary plus fallback lookup.
- **Time complexity:** state the big-O and the round-trip count in the finding. Loading an unfiltered list (all suppliers,
  all users, another module's whole data set) per request and then filtering or building a dictionary from it is
  O(table) per request and is a violation: filter by the needed ids or cache a stable lookup. Also flag
  `ToLower()` on a column inside `Contains`, paging without a unique tie-breaker, whole entities loaded for an
  existence check, and filter/sort columns with no matching index. List the indexes to confirm.
- **Unused code:** a method, interface member, DTO, extension, constant, parameter or injected dependency with no caller, and a
  call or check whose result is discarded, must be removed in the same PR. A rule that is implemented but never called
  (for example an ownership check) is reported as a missing call. Say that no caller was found.

Full rules: `guides/C#_Code_Review.txt` → Query Optimization, Rules 1-4 (`guides/C#_Checklist.md` has the one-line
versions). Cite the exact lines, and say which query should be merged or removed.

### Long backend methods must be split into separate methods (MUST-FIX)

A method body longer than about 40 lines (excluding blank lines, comments and the signature) is hard to manage and
must be split into private methods that each do one thing. Also split a method that does several unrelated steps or
nests deeper than 3 levels, even if it is shorter. Load data once in the caller and pass it to the extracted methods as
parameters, so the split does not add queries (see "One retrieval per repository per method"). Report the method name,
its line range and line count, and suggest the extracted method names. Full rule: `guides/C#_Code_Review.txt` Rule 5.

### Templates and images must live in the module's Resources folder (MUST-FIX)

Each violation is a **Must-Fix**. Every email/SMS/HTML/document template and static image a module uses belongs in that
module's own `<Module>.Application/Resources` folder:
- Images: `Resources/Images/` (e.g. `dummy-profile-pic-male.png`, `landing-page-banner.png`).
- Templates: `Resources/Templates/Templates.resx` plus its `Templates.Designer.cs`, read via the generated `Templates` class.
- Reference: `src/Modules/Configuration/Configuration.Application/Resources`.
- Violations: a template body hard-coded as a string in a service/handler, a template or image added to the API/host
  project, `wwwroot`, or another module's Resources folder, or a file added outside `Resources`. Name the file and the
  target subfolder.

### SOLID principles must be followed in new and changed backend code (MUST-FIX)

Each violation is a **Must-Fix**; name the principle, the class or method, and the concrete split or abstraction.
- **S:** one reason to change. A service that validates, queries, maps, uploads files, resolves names from other modules
  and builds DTOs must be split into focused services, helpers or extension methods. A handler must not do
  validation, logging, auditing, persistence and notification together. About 7 or more constructor dependencies
  is a signal of this.
- **O:** add behaviour with a new implementation, strategy or handler, not another `if`/`switch` branch on a type,
  status or code in an existing class.
- **L:** implementations honour the base contract: no `NotImplementedException`/`NotSupportedException` for inherited
  members, no narrowed inputs, no new nulls.
- **I:** small, role-specific interfaces; no members that only some implementers need.
- **D:** depend on injected abstractions; no `new` of concrete services or repositories, no stateful statics, no
  service locator, no `IHttpContextAccessor`/`BaseService` in services.

Full rule: `guides/C#_Code_Review.txt` Rule 6.

### try/catch must be handled properly in backend code (MUST-FIX)

Every new or changed `try/catch` is checked and each violation is a **Must-Fix**:
- It must do something useful (compensate, clean up, add context, convert to a domain exception, or tolerate a
  non-critical failure). Wrapping a whole method just to log and rethrow is not useful: the global exception middleware
  already does that.
- Catch the most specific expected exception. A bare `catch` or `catch (Exception)` must rethrow or be a logged,
  deliberate best-effort step.
- Never swallow: no empty catch, no catch that only returns `null`/`default`/`false`.
- Rethrow with `throw;`, never `throw ex;`. When wrapping, keep the original as the inner exception and use the
  module's exception types (`BadRequestException`, `NotFoundException`, `CustomValidationException`, ...).
- Code inside `catch` can throw: a compensating or cleanup call (delete the uploaded file or created record,
  `RollbackAsync`) needs its own protected try/catch with logging, so it cannot hide the original exception.
- Everything that can fail after something was created in an external system (DMS, OBP, upstream API), including
  parsing its response, must be inside the protected region.
- Use `finally`/`using` for cleanup that must always run. Do not swallow `OperationCanceledException`. Do not use
  exceptions for control flow (use `TryParse`/`TryGetValue`/`AnyAsync`).
- Log once, structured, with ids and at the right level, and never return `ex.Message` or a stack trace to the client.

Report the line of the try/catch, what is wrong and the corrected handling. Full rule: `guides/C#_Code_Review.txt`
Rule 7.

### API endpoint route names must be kebab-case (backend)

Every new or changed endpoint route segment must be lowercase kebab-case (`[HttpGet("get-by-id")]`,
`[Route("api/purchase-orders")]`, `MapPost("/approve-request")`). Flag camelCase, PascalCase, snake_case or
mixed-case segments (`GetById`, `getById`, `get_by_id`) with the kebab-case equivalent. Route parameters in braces
(`{id}`) and the controller-token placeholder (`[controller]`) are not flagged. Severity: **Suggestion**, or
**Must-Fix** when the PR renames an already-published route (breaking change).

### Input character limits must be enforced on BOTH frontend and backend

_(Source: Confluence OBP → Guidelines → "Standard Guideline for Implementing Character Limitations".)_
Every new or changed text/number input must have the limit and character rules below enforced
**independently** on each side: the frontend in the reactive form (`Validators.maxLength`/`minLength`/`pattern`,
numeric validators; mirror the limit with `maxlength` on the input), and the backend in the Command's
FluentValidation `AbstractValidator` (`MaximumLength`, `Matches`, `GreaterThanOrEqualTo`, `EmailAddress`, ...).
One side alone is not enough. For each field in the diff, find the field type, look up its row, then check both
sides. Where the field is not listed, the closest row applies, or the PR should state the agreed limit.

| Field type | Max length | Allowed characters | Arabic | Other |
|---|---|---|---|---|
| Textbox (name/title) | 70 incl. spaces (list view tooltip after 50) | A-Z a-z 0-9 and `$ & . , - _ ' ( ) [ ] { } " : ; / \` | Yes | |
| Short code | 10 (by context) | A-Z a-z 0-9 only | No | no special characters |
| Document code | 25 | A-Z a-z 0-9 and `/ \ - _` only | No | |
| Text area | 1000 incl. spaces (by context) | same as Textbox | Yes | |
| Email | 254 | A-Z a-z 0-9 and `@ . - _` | No | no spaces |
| URL | 2083 | A-Z a-z 0-9 and `@ . - _ / \` | No | no spaces |
| Amount | 10 | digits, `.` `,` | No | no spaces, no negatives, decimals per currency settings, thousands separators allowed |
| Qty | 10 | digits, `.` `,` | n/a | no spaces, no negatives, 2 decimals |
| Year | 4 | digits only | n/a | no decimals, no negatives |
| Month | 2 | digits only | n/a | no decimals, no negatives |
| Phone | 20 | digits, `+` at the start only | n/a | |
| Password (numeric fields) | min 4, max 13 | digits only | n/a | |
| Bookmark folder name | min 1 (more than zero), max 25 | letters, digits and `. , - _ ' ( ) [ ] { } " : ; / \` | n/a | |

Severity: a write-path field with **no backend length/format validation** — or a backend limit looser than
the table — is **MUST-FIX**. A field with no frontend validator, or frontend and backend limits that don't
match each other, is a **Suggestion**. Also check the limit is consistent with the entity's configured
column length (`HasMaxLength`) where one exists.
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
- Exception (backend): the Team-Specific Rule "Backend query count, time
  complexity and unused code are MUST-FIX" overrides the exposure judgement.
  Repeated queries, per-request full-table loads and unused methods/calls are
  always Must-Fix.

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
