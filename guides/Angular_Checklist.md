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
- Method names and parameter names (components, services, functions, callbacks, `@Input()`/`@Output()` handlers) must be spelled correctly in English, e.g. `getEmployeeDetails(employeeId)`, not `getEmplyeeDetials(empId)`/`getEmployeDetail(emploeeId)`. Check every method and parameter added or renamed in the PR; the comment must quote the misspelled name and give the corrected spelling. Don't flag established domain abbreviations or names inherited from existing code the PR doesn't touch.
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
- Declare `public`/`protected` explicitly on members; injected services and internals use `#private` fields (see Modern Angular Syntax). [3]
- Inject dependencies via `inject()` (constructor injection only where a base class requires it); never `new` a service manually. [4]
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

**The sections below from "Reuse of Shared Code" to "RxJS Cleanup" (Reuse of Shared Code, API Services & Containers, Form Validation Errors, Type & Constant Placement, Status & Value Comparisons, Date & Time Formatting, Colors & Design Tokens, No Restyling, Component Choice, Modern Angular Syntax, i18n & RTL, RxJS Cleanup) are MUST-FIX: violations block approval.**
_(Source for the last six: the `osos-frontend-dev` skill, rule IDs from `ososerp-web` `/review`. Where a repo doc and the code disagree, the code wins; see "Known repo-doc vs code differences" at the end.)_

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

## Colors & Design Tokens [COL-1, COL-2, COL-3]
- Every color in `.scss`, `.html`, templates and inline bindings must be `var(--token)` from `src/scss/_variables.scss` (Tailwind: `bg-[var(--color-surface)]`, `text-[var(--color-500)]`; `bg-primary`/`text-text` are token-safe). Flag any hex, `rgb()`/`rgba()`/`hsl()`, `white`/`black`, or Tailwind palette class (`bg-white`, `text-gray-500`, `bg-gray-100`, `border-neutral-*`). The comment must name the literal and suggest the closest token. [COL-1, COL-2]
- Only `_variables.scss` may contain hex values and only the UI/UX team edits it; flag any new/changed token, theme or dark-mode block, or edit to `_custommaterial.scss`, `styles.scss`, `_meterial-icons.scss` or `scripts/generate-syncfusion-dark.js` in a feature PR (raise a UI/UX request instead). [COL-3]
- Allowed exceptions (don't flag): `var(--color-white)` on a genuinely solid fixed-colour background (status badge, filled button, avatar circle), and a self-contained floating element (e.g. chart tooltip) with its own fixed dark background and light text.
- Inline styles carrying colour must be built from a token (`[style.background]="'var(--x)'"`), never a literal string.
- Dark mode: a new `ejs-richtexteditor` must bind `[iframeSettings]` from `injectRteIframeSettings()`; a new Syncfusion chart/treemap must bind `[theme]="chartTheme()"` (`injectChartTheme()`); an ECharts chart must bind `[theme]="echartsTheme()"` (`buildEchartsDarkTheme()` + `resolveCssColor()`). A chart or RTE without it stays light-only. A `z-index` needs a `position` on the same element.

## No Restyling [NG-9, NG-10, CSS-2]
- No `::ng-deep` (critical, always must-fix). [NG-10]
- No inline `style="..."` with visual values, no `<style>` blocks, no `!important` (developers use none; global overrides belong to the UI/UX team), no one-off classes that duplicate `_custommaterial.scss` or a shared component. [NG-9, CSS-2]
- Component-scoped `.scss` from the UI/UX handoff may stay; changing its visual values, or choosing spacing/radius/font size/icon/dialog width, is a UI/UX request. Sizes use `rem`, not `px` (no arbitrary `gap-[20px]`). SCSS nesting max 3 levels. [CSS-1]
- No business logic in templates (move to methods/`computed()`). [NG-8]

## Component Choice [Design-system -v2 variants]
- New code must use the current variants; the older ones are must-fix in **new** usage (don't ask to migrate untouched existing screens unless the ticket says so):
  - Button: `<osos-button-v1 variant="primary-v2|secondary-v2" textKey="...">`, not `<app-button>`; don't mix `-v2` and base variants in one row.
  - Table/list: `app-datatable-v2`, not `app-datatable-v1`/`app-datatable` or a hand-rolled `<table>`.
  - Dropdown (single or multi): `app-searchable-dropdown-v2` (`[multiple]`), not bare `<mat-select>`, `app-searchable-dropdown`, `app-dropdownbase` or `app-dropdownmultibase`.
  - Text field: `<mat-form-field class="form-control form-control-v2">` with `<mat-label>` as a **sibling before** the field, not nested inside it.
  - Accordion `class="accordion-v2"`, tabs `class="custom-tabs-v2"`; a bare `<mat-accordion>`/`<mat-tab-group>` or `accordion-old-v1` is a violation.
  - Date: `app-osos-date-time-picker`; toggle: `mat-slide-toggle` (+`appRtl="checkbox"`) or `app-cm-labeled-toggle`; checkbox: `mat-checkbox` bound to a `FormControl`.
  - Dialogs: `DeleteDialogComponent` (`panelClass: 'delete-dialog'`), `ConfirmationDialogComponent`, `UnsavedDialogV2Component` (not `UnsavedDialogComponent`), general `panelClass: 'default-preview-dialog'`; no bespoke confirm dialog and no new panelClass per dialog. Side drawer: `app-common-side-drawer`. Toast: `SnackBarNotificationService`, never `MatSnackBar` directly.
  - List base classes: `MasterListBasePageV1Component` (lists), `MasterDetailBasePageComponent` (detail), `DynamicFormBasePageComponent` (dynamic forms), `MasterDetailListFactory` (small unpaginated sub-grid); not `MasterListBasePageComponent` or hand-built save/mode handling.
  - Rich text `ejs-richtexteditor`; file upload `app-file-drag-and-drop`/`app-file-upload` (not `app-file-uploader`); address forms `app-address-template`; large server-paged multi-select `app-paginated-multi-select-list`; multi-step forms `mat-stepper` (linear, per-step `[completed]`).
- Lists page through OData (`$top`/`$skip`/`$orderby`/`$filter`) via the base class; no client-side sort/filter/paging over a full server dataset.
- Icons: Material Symbols Outlined (`<mat-icon>name</mat-icon>` / `material-symbols-outlined`); no SVG sprites, no `material-icons-outlined` in new code.
- Display pipes: dates `| timeZoneDate` (not raw `| date`), avatar `| initials` / `| defaultProfileImage`, relative time `| timeAgo`, `| truncateText`, `| fileSize`; no hand-rolled equivalents.
- Permission gating: `@if (checkAccess(grant.X) | async)` (hide, not disable), not a local boolean; routes use `canActivate: [accessGuard]` + `data: { permission: [MENUID.X, Grant.ReadOnly] }`; feature toggles via `FeatureFlagService`/`*obpFeatureFlag`, not hard-coded booleans. [NG-17]

## Modern Angular Syntax [NG-1…4, NG-18, TS-1, TS-3, TS-5, TS-9]
- Standalone components only, no NgModules; do not add `standalone: true` to new code and **don't flag its absence** (implicit since Angular 20). [NG-1]
- `input()`/`input.required()`/`output()`, not `@Input()`/`@Output()`. [NG-2] `inject()`, not constructor-parameter DI, in new code (base-class constructors such as `MasterListBasePageV1Component` are the exception). [NG-3] `@if`/`@for`/`@switch`, not `*ngIf`/`*ngFor`/`*ngSwitch`. [NG-4] `viewChild()`/`viewChildren()`/`contentChild()`/`contentChildren()`, not the decorators. [NG-18]
- No `any` (use types, generics, or `unknown` with a guard). [TS-1] No `console.log`/`console.debug` (`warn`/`error` only). [TS-5]
- Injected services and internals use `#private` fields, not the `private` keyword. [TS-3]
- Across library boundaries use the path aliases `@osos/core`, `@osos/shared-components`, `@shared-directives`, `@shared-pipes`, never relative paths and never `@core`. [TS-9]
- Feature routes lazy-loaded (`loadChildren`/`loadComponent`); guards and interceptors are functional (`CanActivateFn`, `HttpInterceptorFn`). [NG-12, NG-13, NG-14]
- Reactive Forms (`FormControl` + `Validators.required` + `formControlName`), no `ngModel`; mark controls touched on submit; use `getFormControls<T>()`. [NG-19]
- Signal dialogs derive signals with `toSignal(control.valueChanges, …)` and toggle `disable()`/`enable()` in an `effect()`.
- Presentational components inject nothing and make no HTTP calls. [NG-11] HTTP only in services that extend `ProjectBaseService` and return `Observable<T>` (`DataResponse<T>` for lists, `HttpParams` for queries); services never subscribe. [ARCH-3, ARCH-6, RX-5] No circular dependencies. [ARCH-5]
- Never add the `X-Sec-Token` header manually; `securityTokenInterceptor` does it. [ARCH-10]
- New public symbols exported from the library's root `src/index.ts`; don't add local `index.ts` barrels inside `models/`, `services/`, `constants/`, `utils/`; type-only symbols use `export type { }`. [ARCH-4]

## i18n & RTL [I18N-1, I18N-2, NG-16]
- Every user-facing string (labels, buttons, hints, tooltips, placeholders, error text) goes through `| translate` with a key; no hard-coded English. [I18N-1]
- Keys follow `<module>.<section>.<entity>.<key>` and are added to `src/assets/i18n/en.json` and every other language file the app ships. [I18N-2]
- Every dialog/drawer/popup root carries `ososDirection`.
- Every directional Tailwind class (`mr-*`/`ml-*`/`pr-*`/`pl-*`/`left-*`/`right-*`/`text-left`/`text-right`/`rounded-l-*`/`rounded-r-*`) has an `appRtl rtlClass="a|b"` pair mirroring it; an unpaired one is a violation. Also applies to `libs/shared` and global styles. [NG-16]

## RxJS Cleanup [RX-1, RX-2, RX-3, RX-4, ARCH-8]
- Every `subscribe()` is cleaned up (`takeUntil(this.destroy$)` as the **last** operator, `takeUntilDestroyed()`, `DestroyRef`, or the `async` pipe), including HTTP calls. [RX-1]
- `MatDialog.afterClosed()` is always cleaned up the same way. [ARCH-8]
- No nested subscribes; use `switchMap`/`exhaustMap`/`mergeMap`. [RX-2] `catchError` on calls. [RX-3] No `async/await` over observables. [RX-4]
- State tool matches scope: `signalStore` for global, `RxState` for page streams, `signal()` locally, `Subject` + `takeUntil` between components.

## Known repo-doc vs code differences (follow the code)
- Aliases are `@osos/core` and `@osos/shared-components`; `@core` is not defined.
- Required-field messages use `<mat-error [ososError]>`; the `@if (control.hasError('required') && control.touched)` form in older docs is not the standard.
- Tests are Jest (not Vitest); build/lint via Nx + Yarn (`yarn build`, `yarn lint:all`), not `ng build`.
- Stack is Angular 21, Angular Material 21, Nx 23, NgRx Signals 21, Tailwind 3.3, Syncfusion 33; Reactive Forms remain the house standard.

## Angular 21 Specifics
- Prefer standalone components; import deps directly in the component, avoid NgModules for simple cases. [1]
- Use Signals for local state, `computed()` for derived state; don't use Signals as an NgRx substitute for global state. [2]
- Use `inject()` in functional contexts (guards, standalone functions) and in new classes; constructor injection only where a base class requires it. [3]
- Bind Observables in templates with `async` pipe rather than manual subscription for template-only use. [4]
- Use `NgOptimizedImage` (`ngSrc`) instead of plain `<img>`. [5]
- Use `@defer` blocks to defer non-critical UI instead of eager rendering. [6]
