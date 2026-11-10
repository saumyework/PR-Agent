Distilled from guides/Angular Code Review.txt — grep the full guide when a rule needs more detail.

## Library Architecture [Libraries]
- `libs/core/` must not depend on any other library.
- `libs/shared/` may depend only on core.
- `libs/features/<x>` may depend on core and shared, never on another feature library directly.
- Cross-feature functionality moves to a shared library, not duplicated in features.

## Files
- kebab-case filenames, e.g. `user-profile.component.ts`. [1. File Naming]
- Names must reflect content; avoid vague `utils.ts`/`helpers.ts` (prefer `date-utils.ts`). [1]
- No redundant suffixes, e.g. `auth.guard.ts` not `auth-guard.guard.ts`. [1]
- Suffix conventions: `.component.ts/html/scss/spec.ts`, `.service.ts`, `.directive.ts`, `.pipe.ts`, `.model.ts` (interfaces), `.enum.ts`, `.util.ts`/`.helper.ts`, `.guard.ts`, `.interceptor.ts`, `.resolver.ts`. [1]
- Place code in correct Nx `src/`/`libs/` location by domain; co-locate component+html+scss+spec. [2]
- Reusable DOM elements → shared; reusable business objects → core. [2]
- Keep files under ~300 lines; split into services/helpers/components as they grow. [3]
- `index.ts` barrels re-export public API in shared/domain libs; feature-library barrel exports routes only. [4]
- Remove unused/dead files and WIP placeholders as part of the change. [7]
- No leaking components/services between feature modules; shared functionality belongs in shared libs (nx.json tags enforce it). [8]
- `environment.ts` stays minimal; never commit secrets. [10]

## Methods [Methods 4.0–4.1.5]
- Name must contain a verb describing the action (`GetStudents`, not `Students`).
- Async methods suffixed `Async` (`GetStudentsAsync`).
- Parameter names state what they represent (`studentName` not `text`/`name`).
- Name params after the specific field/action used (`GetStudentByIdAsync(studentId)` not generic `GetStudentAsync`).
- Use named arguments when the passed variable name doesn't match the parameter name/alias.
- Encapsulate repeated logic into its own method; keep each method at one level of detail.
- One-line bodies use fat-arrow (`=>`); break after `=>` with extra indent if line exceeds 120 chars.
- Multi-statement or chained-call bodies need a `{ }` block, not a fat arrow (unless only the param list wraps).
- Blank line between method logic and the final `return`.
- Method declaration ≤120 chars; wrap parameters onto new lines if needed, one per line (don't mix wrapped + inline).
- Chained calls (`Where().Select().ToList()`): indent each subsequent call one step further ("uglification") rather than left-aligning.

## Variables
- camelCase for variables/constants; UPPER_SNAKE_CASE only for module-level/global constants (`DEFAULT_TIMEOUT`). [1]
- Avoid unclear abbreviations; use descriptive names (`userList` not `data1`/`res`/`x`). [1]
- `const` by default, `let` only when reassigned, never `var`. [2]
- Suffix observables with `$` (`userList$`). [3]
- Consistent prefixes: `form` for reactive forms, `control` for form controls, `el` for `@ViewChild`/DOM refs. [3]
- No magic numbers/strings — declare named constants instead (`MAX_RETRIES = 3`, not bare `3`). [4]
- Explicitly type public variables, interfaces, and return types; avoid `any` (document if unavoidable). [5]

## Functions
- Clear, action-based names (`fetchUser`, not `handleStuff`/`doThings`). [1]
- Prefix boolean-returning functions with `is`/`has`/`should`. [2]
- Single-responsibility (`calculateTotal`, not `validateAndSubmit`). [3]
- Explicit parameter and return types even when TS could infer them. [4]
- Pure functions must not mutate external/outer state as a side effect. [5]
- Arrow functions for short inline callbacks (`items.map(item => item.name)`). [6]
- Async/await with try/catch; prefer Observables + async pipe over promise chains lacking `.catch()`. [7]
- Keep lifecycle hooks (`ngOnInit`) thin — delegate to well-named methods, don't cram multiple concerns inline. [8]
- Extract/reuse duplicated logic into utils/services instead of repeating across components. [9]

## Observables
- Suffix observable variables with `$` (`user$`, not `user`). [1]
- Prefer `async` pipe in templates over manual `.subscribe()` assignment. [2]
- If not using `async` pipe, unsubscribe explicitly (`takeUntil(destroy$)` + `ngOnDestroy`) to avoid leaks, including on HTTP requests. `takeUntil` must be the **last** operator in the `pipe`. [3]
- Compose with RxJS operators (`switchMap`) instead of nesting `.subscribe()` inside `.subscribe()`. [4]
- Put side effects in `tap()`, not inside `map`/`switchMap` callbacks. [5]
- Avoid `.subscribe()` in components just to assign a value to a property when async pipe would work. [6]
- Name Subjects/BehaviorSubjects clearly (`destroy$`, `refreshTrigger$`), not `data`/`update`. [7]
- Don't overuse raw `BehaviorSubject`s for shared state; prefer NgRx or a facade/service pattern. [8]

## Classes
- PascalCase, noun-based names (`UserService`, not `userService`). [1]
- Single-responsibility per class; don't merge unrelated concerns into one service. [2]
- Declare `public`/`private`/`protected` explicitly on all members, not implicit default. [3]
- Inject dependencies via `inject()`/constructor injection; never `new` a service manually. [4]
- Constructors limited to DI/simple init; no API calls or heavy logic in constructors. [5]
- Mark properties that never change as `readonly`. [6]
- Split large classes into smaller focused ones rather than one monolithic service. [7]
- Getters stay side-effect-free and simple; no logging/computation side effects in a getter. [8]

## Performance
- Feature modules/routes use lazy loading (`loadChildren: () => import(...)`), not eager root imports.
- Pipes declared `pure: true` unless impurity is required.
- Profile performance-sensitive changes (Angular DevTools/Lighthouse), don't ship unverified.

## Functionality & Business Logic
- Domain/feature-specific logic belongs in `libs/features/<name>`, not core or shared. [1]
- App-wide concerns (auth, interceptors, guards, resolvers) belong in `libs/core/`, not feature code. [2]
- Generic, feature-agnostic UI/components/directives/pipes belong in `libs/shared/`. [3]
- Respect Nx dependency constraints (`nx.json`); core/shared stay feature-agnostic. [4]
- Feature routes lazily loaded via `loadChildren` in `app-routes.ts`. [5]
- Public library APIs documented (e.g. README) and kept current. [7]

## Coding Standards
- Single quotes for strings; use template literals if the string contains a `'`. [1]
- 2-space indentation. [2]
- No trailing whitespace; remove unused variables/imports. [3]
- `const` for values that don't change. [4]
- Prefer template literals over string concatenation. [5]

**The six sections below (Reuse of Shared Code, API Services & Containers, Form Validation Errors, Type & Constant Placement, Status & Value Comparisons, Date & Time Formatting) are MUST-FIX: violations block approval.**

## Reuse of Shared Code [Reuse of Shared Components, Pipes & Directives]
- Before a new component/pipe/directive/helper, check `libs/shared/{components,directives,pipes,features}` (`@osos/shared-components`, `@shared-directives`, `@shared-pipes`, `@shared-features`); if a shared one exists or can cover the case, it MUST be used — a parallel implementation is must-fix. [1]
- Example: tabular data must use shared `datatable-v2` when feasible; no separate table/tab/grid component or hand-rolled `<table>`. [1]
- If the shared component almost fits, extend it (backward compatible) rather than fork it; the review comment must name the shared item that should have been used. [1]
- Same component/block/pipe/helper used repeatedly within one module → extract once into a `shared` folder inside that module and reuse it as that module's common component; no copy-paste. Needed by multiple features → move to `libs/shared`. [2]

- Services/models/constants/enums/utils: check `libs/core` and the module's `core` folder for an existing one before adding; reuse it, and name it in the comment. [3]
- Used by several components inside one module → move to that module's `core` folder (e.g. `libs/features/cms/src/lib/core/{constants,enums,guards,models,resolvers,services,validators}`); no redefining per component. [3]
- Used by more than one module → move to main `libs/core` (`@osos/core/...`); never import from another feature library or copy it per module. [3]

## API Services & Containers
- API/data services (HttpClient or backend services) must NOT be injected in presentational components; inject them only in the container (page) component, which passes data via `@Input()`/signal inputs and handles `@Output()` events. [API Services]

## Form Validation Errors [Validation Error Display]
- Validation errors in templates must use the OSOS error directive: `<mat-error [ososError]="formControls.code" />` inside the `mat-form-field` (reference: `libs/features/accounts-payable/src/lib/transaction/payment-voucher/components/payment-voucher-header-form/payment-voucher-header-form.component.html`). [Validation Error Display]
- Flag as must-fix: hand-written `<mat-error>` with custom text, e.g. `@for (flagError of itemFlagErrors ...) { @if (inputForm.hasError(flagError.key)) { <mat-error>{{ flagError.translationKey | translate }}</mat-error> } }` or per-error `@if (control.hasError(...))` blocks; the comment must point to `[ososError]`. [Validation Error Display]

## Type & Constant Placement [Folder Placement]
- Exported `interface`/`type`/`class` models, `const`s and `enum`s must live in their dedicated folder and file, not in a component, service, container or other unrelated file: models → `models/*.model.ts`, enums → `enums/*.enum.ts`, constants → `constants/*.constant.ts` (or the repo's existing suffix), inside the owning module's `core` folder (e.g. `libs/features/cms/src/lib/core/{models,enums,constants}`) or the feature's own `models/enums/constants` folder; shared across modules → `libs/core`. [Folder Placement]
- Flag an `export interface/enum/const` declared inside a `.component.ts`, `.service.ts`, `.routes.ts` or a mixed file. The comment must name the target folder/file. [Folder Placement]

## Status & Value Comparisons [Enums Instead of Strings]
- No string (or magic number) comparison for business logic in `.ts` or templates, e.g. `status === 'active'`, `row.type !== 'Draft'`, `@if (item.status == 'Approved')`, `[class.x]="status === 'pending'"`, `case 'Pending':`. Compare against an enum (`status === TenderStatus.Active`) or a named constant; never inline literals. The values must mirror the backend enum/constant. [Enums Instead of Strings]
- The comment must name the literal and the enum to use; reuse an existing one from `libs/core` (`@osos/core/enums`) or the module's `core/enums` folder before adding a new one (see Reuse of Shared Code). Expose the enum to the template through a component field (e.g. `protected readonly TenderStatus = TenderStatus;`). [Enums Instead of Strings]

## Date & Time Formatting
- Date/time formats must follow the common settings-driven implementation (reference: `payment-voucher-header-form.component.ts`): component `providers` supply `DateAdapter` → `MomentDateAdapter` (deps `MAT_DATE_LOCALE`, `MAT_MOMENT_DATE_ADAPTER_OPTIONS`) and `MAT_DATE_FORMATS` → `dateFormatFactory` (`@osos/core/services`, deps `GeneralSettingService`). [Date & Time Formatting]
- Use `DATE_FORMAT`/`DEFAULT_DATE_FORMAT` from `@osos/core/constants` for defaults; no hard-coded `'dd/MM/yyyy'`/`'yyyy-MM-dd'` strings or custom adapters/format objects. Datepickers without this provider setup ignore the user's configured format. [Date & Time Formatting]
- Use existing shared date pipes/utils for display formatting. [Date & Time Formatting]

## Angular 17 Specifics
- Prefer standalone components; import deps directly in the component, avoid NgModules for simple cases. [1]
- Use Signals for local state, `computed()` for derived state; don't use Signals as an NgRx substitute for global state. [2]
- Use `inject()` in functional contexts (guards, standalone functions); use constructor injection inside classes. [3]
- Bind Observables in templates with `async` pipe rather than manual subscription for template-only use. [4]
- Use `NgOptimizedImage` (`ngSrc`) instead of plain `<img>`. [5]
- Use `@defer` blocks to defer non-critical UI instead of eager rendering. [6]
