// ----------------------------------------------------------------------
// Copyright (C) 2026, by OSOS. All rights reserved.
// The information and source code contained herein is the exclusive
// property of OSOS and may not be disclosed, examined or reproduced
// in whole or in part without explicit written authorization from OSOS.
// ----------------------------------------------------------------------

using Toolbox.CommonServices.Enums;
using Toolbox.CommonServices.Models;

namespace Toolbox.CommonServices
{
    public partial class SystemTranslations
    {
        private static IEnumerable<SystemTranslation> GetEdmArOm()
        {
            // EDM ΓåÆ Arabic (Oman)
            #region EDM ΓåÆ Country Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.commonButtons.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.commonButtons.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.actionButtons.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.actionButtons.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.actionButtons.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "entity.countryMaster",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.inactive",
                TranslationValue = "╪║┘è╪▒ ┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.countryName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.iso3Code",
                TranslationValue = "╪▒┘à╪▓ ISO 3",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.isoNumericCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪▒┘é┘à┘è ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.region",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.nationalityName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¼┘å╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.uploadFlag",
                TranslationValue = "╪▒┘ü╪╣ ╪ú┘è┘é┘ê┘å╪⌐ ╪º┘ä╪╣┘ä┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.browseDocument",
                TranslationValue = "╪º╪│╪¬╪╣╪▒╪º╪╢ ╪º┘ä┘à╪│╪¬┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.defaultCurrency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.vatApplicable",
                TranslationValue = "╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.vatApplicableDescription",
                TranslationValue = "╪¬┘ü╪╣┘è┘ä ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐ ┘ä┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.defaultLanguage",
                TranslationValue = "╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.timeZone",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.labels.geographicalStructure",
                TranslationValue = "╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.sectionHeaders.generalInformation",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.sectionHeaders.localizationSettings",
                TranslationValue = "╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä┘ä╪║╪⌐ ┘ê╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.sectionHeaders.financialTaxConfiguration",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä┘à╪º┘ä┘è╪⌐ ┘ê╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.sectionHeaders.addressTemplate",
                TranslationValue = "┘é╪º┘ä╪¿ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.sectionHeaders.geographicalStructure",
                TranslationValue = "╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.isoCode",
                TranslationValue = "╪▒┘à╪▓ ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.countryName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.flag",
                TranslationValue = "╪╣┘ä┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.tableHeaders.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.selectLevel",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.countryName",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.iso3Code",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ ISO 3",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.isoNumericCode",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪▒┘é┘à┘è ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.nationalityName",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪¼┘å╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.enterLevelName",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.enterDisplayLabel",
                TranslationValue = "╪ú╪»╪«┘ä ╪¬╪│┘à┘è╪⌐ ╪º┘ä╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.defaultLanguage",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ä╪║╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.timeZone",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.placeholders.defaultCurrency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Address Template
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fieldKey",
                TranslationValue = "┘à┘ü╪¬╪º╪¡ ╪º┘ä╪¡┘é┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.displayLabel",
                TranslationValue = "╪¬╪│┘à┘è╪⌐ ╪º┘ä╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.visibility",
                TranslationValue = "╪º┘ä╪╕┘ç┘ê╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.line1",
                TranslationValue = "╪º┘ä╪│╪╖╪▒ 1",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.line2",
                TranslationValue = "╪º┘ä╪│╪╖╪▒ 2",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.line3",
                TranslationValue = "╪º┘ä╪│╪╖╪▒ 3",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.geolocation",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.postalCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.fields.poBox",
                TranslationValue = "╪╡┘å╪»┘ê┘é ╪º┘ä╪¿╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.areaDistrict",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐ / ╪º┘ä┘ê┘ä╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.wayStreet",
                TranslationValue = "╪º┘ä╪│┘â╪⌐ / ╪º┘ä╪┤╪º╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.buildingHouseNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘à╪¿┘å┘ë / ╪º┘ä┘à┘å╪▓┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.city",
                TranslationValue = "╪º┘ä┘à╪»┘è┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.postalCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.addressTemplate.poBox",
                TranslationValue = "╪╡┘å╪»┘ê┘é ╪º┘ä╪¿╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Country Master ΓåÆ Validation
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.validation.isoCodeFormat",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è╪¬┘â┘ê┘å ┘à┘å 3 ╪ú╪¡╪▒┘ü ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.sectionheader.levels",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.sectionheader.generalinfo",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.levels",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.levelname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.createddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.createdby",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.countryCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.geolocationcode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.columnheader.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.actionbutton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.actionbutton.addchildlevel",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪│╪¬┘ê┘ë ┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.actionbutton.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.actionbutton.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.commonButtons.add",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.header.managechildlevel",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.header.editmainlevel",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä╪▒╪ª┘è╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.header.editvalues",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘é┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.value",
                TranslationValue = "╪º┘ä┘é┘è┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.parentlevel",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä╪ú╪╣┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.selectedlevel",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.newlevelname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä╪¼╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.countryiso3code",
                TranslationValue = "╪▒┘à╪▓ ISO 3 ┘ä┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.status.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.status.inactive",
                TranslationValue = "╪║┘è╪▒ ┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.placeholder.description",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.placeholder.enterlevelname",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.placeholder.selectcountry",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.placeholder.countryiso3code",
                TranslationValue = "┘è╪¬┘à ╪º┘ä╪¬╪╣╪¿╪ª╪⌐ ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ┘à┘å ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.validation.newlevelname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä╪¼╪»┘è╪» ┘à╪╖┘ä┘ê╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.validation.levelnameblank",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪¬╪▒┘â ╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë ┘ü╪º╪▒╪║┘ï╪º.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.validation.addresstemplateinuse",
                TranslationValue = "┘é╪º┘ä╪¿ ╪º┘ä╪╣┘å┘ê╪º┘å ┘é┘è╪» ╪º┘ä╪º╪│╪¬╪«╪»╪º┘à ╪¿╪º┘ä┘ü╪╣┘ä╪î ┘ä╪º ┘è┘à┘â┘å ╪¬╪╣╪»┘è┘ä ╪º┘ä┘ç┘è┘â┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.notification.savesuccess",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.notification.updatesuccess",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.notification.deletesuccess",
                TranslationValue = "╪¬┘à ╪¡╪░┘ü ╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.notification.renamesuccess",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ┘à╪│╪¬┘ê┘ë ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.notification.countriesloadfailed",
                TranslationValue = "┘ü╪┤┘ä ╪¬╪¡┘à┘è┘ä ╪º┘ä╪»┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.confirmation.deletelevel",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪¡╪░┘ü ┘ç╪░╪º ╪º┘ä┘à╪│╪¬┘ê┘ë ┘ê╪¼┘à┘è╪╣ ┘à╪│╪¬┘ê┘è╪º╪¬┘ç ╪º┘ä┘ü╪▒╪╣┘è╪⌐╪ƒ ┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¬╪▒╪º╪¼╪╣ ╪╣┘å ┘ç╪░╪º ╪º┘ä╪Ñ╪¼╪▒╪º╪í!",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.confirmation.deleterecord",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪ú┘å┘â ╪¬╪▒┘è╪» ╪¡╪░┘ü ┘ç╪░╪º╪ƒ ┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¬╪▒╪º╪¼╪╣ ╪╣┘å ┘ç╪░╪º ╪º┘ä╪Ñ╪¼╪▒╪º╪í!",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Labels ΓåÆ Breadcrumbs
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.breadcrumb",
                TranslationValue = "┘ç┘è┘â┘ä ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.breadcrumbadd",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ┘ç┘è┘â┘ä ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.breadcrumbedit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ┘ç┘è┘â┘ä ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.breadcrumbview",
                TranslationValue = "╪╣╪▒╪╢ ┘ç┘è┘â┘ä ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Structure ΓåÆ Labels ΓåÆ Default Level Names
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.stateprovincegovernorate",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐/╪º┘ä╪Ñ┘é┘ä┘è┘à/╪º┘ä┘à╪¡╪º┘ü╪╕╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.districtcounty",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐/╪º┘ä┘à┘é╪º╪╖╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.wilayahmunicipality",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐/╪º┘ä╪¿┘ä╪»┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationstructure.label.cityarea",
                TranslationValue = "╪º┘ä┘à╪»┘è┘å╪⌐/╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.sectionheader.generalinformation",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.sectionheader.levels",
                TranslationValue = "┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.countrycode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.readonlymode",
                TranslationValue = "┘ê╪╢╪╣ ╪º┘ä┘é╪▒╪º╪í╪⌐ ┘ü┘é╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.parentlevel",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë ╪º┘ä╪ú╪╣┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.values",
                TranslationValue = "╪º┘ä┘é┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.breadcrumb",
                TranslationValue = "╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.breadcrumbadd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.breadcrumbedit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.label.breadcrumbview",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.confirmation.deleterecord",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪ú┘å┘â ╪¬╪▒┘è╪» ╪¡╪░┘ü ┘ç╪░╪º╪ƒ ┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¬╪▒╪º╪¼╪╣ ╪╣┘å ┘ç╪░╪º ╪º┘ä╪Ñ╪¼╪▒╪º╪í!",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.reset",
                TranslationValue = "╪Ñ╪╣╪º╪»╪⌐ ╪¬╪╣┘è┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.save",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.close",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.addchildvalues",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘é┘è┘à ┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.addvalue",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘é┘è┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.countrycode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.levels",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.createddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.createdby",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.levelname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.valuescount",
                TranslationValue = "╪╣╪»╪» ╪º┘ä┘é┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.columnheader.noofvalues",
                TranslationValue = "╪╣╪»╪» ╪º┘ä┘é┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.header.managevalues",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘é┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.notification.nostructure",
                TranslationValue = "┘ä┘à ┘è╪¬┘à ╪Ñ╪╣╪»╪º╪» ╪º┘ä┘ç┘è┘â┘ä ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ┘ä┘ä╪¿┘ä╪» ╪º┘ä┘à╪¡╪»╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.notification.savesuccess",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.notification.updatesuccess",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.notification.deletesuccess",
                TranslationValue = "╪¬┘à ╪¡╪░┘ü ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.notification.savehierarchyfailed",
                TranslationValue = "┘ü╪┤┘ä ╪¡┘ü╪╕ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä┘à┘ê┘é╪╣ ╪º┘ä╪¼╪║╪▒╪º┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.placeholder.entervaluename",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘é┘è┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.placeholder.selectcountry",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.placeholder.countrycode",
                TranslationValue = "┘è╪¬┘à ╪º┘ä╪¬╪╣╪¿╪ª╪⌐ ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ┘à┘å ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Action Button
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.saveAsDraft",
                TranslationValue = "╪¡┘ü╪╕ ┘â┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.saveAndSubmit",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.saveAndPublish",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘å╪┤╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.publish",
                TranslationValue = "┘å╪┤╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪┤┘ç╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪│╪º┘ç┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪▒╪¼╪╣ ╪╣┘à┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.actionButton.add",
                TranslationValue = "╪ú╪╢┘ü ┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¼┘ç╪⌐ ╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪¼┘ç╪⌐ ╪º╪¬╪╡╪º┘ä ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.actionButton.addCurrency",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬┘ü╪º╪╡┘è┘ä ╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Confirmation
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.confirmation.confirmPublish",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪▒╪║╪¿╪¬┘â ┘ü┘è ┘å╪┤╪▒ ┘ç╪░╪º ╪º┘ä┘à┘ê╪▒╪»╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Label
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.businessCategory",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.subBusinessCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘ä┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierCategory",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierGroup",
                TranslationValue = "┘à╪¼┘à┘ê╪╣╪⌐ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierShortName",
                TranslationValue = "╪º┘ä╪º╪│┘à ╪º┘ä┘à╪«╪¬╪╡╪▒ ┘ä┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.commercialRegistrationNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.primaryEmail",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è ╪º┘ä╪▒╪ª┘è╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.leadTimeDays",
                TranslationValue = "┘à╪»╪⌐ ╪º┘ä╪¬┘ê╪▒┘è╪» (╪ú┘è╪º┘à)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.icvCategory",
                TranslationValue = "┘ü╪ª╪⌐ ICV",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.icvSubCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ICV",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.yearEstablished",
                TranslationValue = "╪│┘å╪⌐ ╪º┘ä╪¬╪ú╪│┘è╪│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.supplierWebsite",
                TranslationValue = "┘à┘ê┘é╪╣ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.productAndServiceDescription",
                TranslationValue = "┘ê╪╡┘ü ╪º┘ä┘à┘å╪¬╪¼╪º╪¬ ┘ê╪º┘ä╪«╪»┘à╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.creditPeriod",
                TranslationValue = "┘ü╪¬╪▒╪⌐ ╪º┘ä╪º╪ª╪¬┘à╪º┘å (╪ú┘è╪º┘à)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.creditPeriodDaysSuffix",
                TranslationValue = "╪ú┘è╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.sourceSystem",
                TranslationValue = "┘à╪╡╪»╪▒ ╪º┘ä┘å╪╕╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.sme",
                TranslationValue = "┘à┘å╪┤╪ó╪¬ ╪╡╪║┘è╪▒╪⌐ ┘ê┘à╪¬┘ê╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.directSourceSystem",
                TranslationValue = "╪│╪¼┘ä ┘à┘ê╪▒╪» ┘à╪¿╪º╪┤╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.registrationSourceSystem",
                TranslationValue = "╪¬╪│╪¼┘è┘ä ┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.label.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪┤┘ç╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.label.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪┤┘ç╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.label.expiryDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪º┘å╪¬┘ç╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.label.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪│╪º┘ç┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.label.percent",
                TranslationValue = "┘å╪│╪¿╪⌐ ╪º┘ä╪¡╪╡╪⌐ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.label.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪╣┘à┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.label.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è ┘ä┘ä╪╣┘à┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.addressName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.addressLine",
                TranslationValue = "╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.province",
                TranslationValue = "╪º┘ä┘à╪¡╪º┘ü╪╕╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.district",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.dsArea",
                TranslationValue = "┘à┘å╪╖┘é╪⌐ DS",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.postalCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.phoneNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.linkedContacts",
                TranslationValue = "╪¼┘ç╪º╪¬ ╪º┘ä╪º╪¬╪╡╪º┘ä ╪º┘ä┘à╪▒╪¬╪¿╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.makeActive",
                TranslationValue = "╪¬┘ü╪╣┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.makeActiveHint",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è┘â┘ê┘å ┘ç╪░╪º ╪º┘ä╪│╪¼┘ä ┘å╪┤╪╖┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.siteName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.taxLandType",
                TranslationValue = "┘å┘ê╪╣ ╪ú╪▒╪╢ ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.addressType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.label.isPrimary",
                TranslationValue = "╪ú╪│╪º╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.label.isPrimaryHint",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è┘â┘ê┘å ┘ç╪░╪º ╪º┘ä╪╣┘å┘ê╪º┘å ┘ç┘ê ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪ú╪│╪º╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.contactPersonName",
                TranslationValue = "╪º╪│┘à ╪¼┘ç╪⌐ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.salutation",
                TranslationValue = "╪º┘ä┘ä┘é╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.contactType",
                TranslationValue = "┘å┘ê╪╣ ╪¼┘ç╪⌐ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.firstName",
                TranslationValue = "╪º┘ä╪º╪│┘à ╪º┘ä╪ú┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.middleName",
                TranslationValue = "╪º┘ä╪º╪│┘à ╪º┘ä╪ú┘ê╪│╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.lastName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪╣╪º╪ª┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.landPhone",
                TranslationValue = "┘ç╪º╪¬┘ü ╪ú╪▒╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.mobile",
                TranslationValue = "╪º┘ä╪¼┘ê╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.label.isPrimaryHint",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│╪¬┘â┘ê┘å ╪¼┘ç╪⌐ ╪º┘ä╪º╪¬╪╡╪º┘ä ┘ç╪░┘ç ┘ç┘è ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.defaultCurrency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.defaultBadge",
                TranslationValue = "╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.paymentMethod",
                TranslationValue = "╪╖╪▒┘è┘é╪⌐ ╪º┘ä╪»┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.creditLimit",
                TranslationValue = "╪¡╪» ╪º┘ä╪º╪ª╪¬┘à╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.supplierNameOnCheque",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ê╪▒╪» ╪╣┘ä┘ë ╪º┘ä╪┤┘è┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.retentionPercent",
                TranslationValue = "┘å╪│╪¿╪⌐ ╪º┘ä╪º╪¡╪¬╪¼╪º╪▓ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.paymentTerm",
                TranslationValue = "╪┤╪▒┘ê╪╖ ╪º┘ä╪»┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.bankName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.branchName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.accountName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.accountNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.swiftCode",
                TranslationValue = "╪▒┘à╪▓ SWIFT",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.ibanNumber",
                TranslationValue = "╪▒┘é┘à IBAN",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.label.isPrimaryHint",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è┘â┘ê┘å ┘ç╪░╪º ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä╪¿┘å┘â┘è ┘ç┘ê ╪º┘ä╪ú╪│╪º╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Section Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.sectionHeader.general",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.sectionHeader.corporate",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.sectionHeader.addressContacts",
                TranslationValue = "╪º┘ä╪╣┘å╪º┘ê┘è┘å ┘ê╪¼┘ç╪º╪¬ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.sectionHeader.contact",
                TranslationValue = "╪¼┘ç╪⌐ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.sectionHeader.finance",
                TranslationValue = "╪º┘ä╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.sectionHeader.title",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.sectionHeader.title",
                TranslationValue = "╪┤┘ç╪º╪»╪º╪¬ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.sectionHeader.title",
                TranslationValue = "╪º┘ä┘à╪│╪º┘ç┘à┘ê┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.sectionHeader.title",
                TranslationValue = "┘à╪▒╪º╪¼╪╣ ╪º┘ä╪╣┘à┘ä╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.sectionHeader.title",
                TranslationValue = "┘à┘ê╪º┘é╪╣ ╪º┘ä┘à┘ê╪▒╪»┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.sectionHeader.title",
                TranslationValue = "╪¼┘ç╪º╪¬ ╪º╪¬╪╡╪º┘ä ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.sectionHeader.title",
                TranslationValue = "╪º┘ä╪»┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.sectionHeader.bankTitle",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Column Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.supplierCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.supplierName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.supplierType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.creditPeriod",
                TranslationValue = "┘ü╪¬╪▒╪⌐ ╪º┘ä╪º╪ª╪¬┘à╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.sourceSystem",
                TranslationValue = "┘à╪╡╪»╪▒ ╪º┘ä┘å╪╕╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Placeholder
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.corporate",
                TranslationValue = "╪º┘ä╪┤┘ç╪º╪»╪º╪¬ ┘ê╪º┘ä┘à╪│╪º┘ç┘à┘ê┘å ┘ê┘à╪▒╪º╪¼╪╣ ╪º┘ä╪╣┘à┘ä╪º╪í.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.finance",
                TranslationValue = "╪ú┘é╪│╪º┘à ╪º┘ä╪»┘ü╪╣ ┘ê╪º┘ä╪¿┘å┘â ┘ê╪º┘ä╪╢╪▒┘è╪¿╪⌐ ┘ê╪¡╪│╪º╪¿╪º╪¬ ╪º┘ä╪ú╪│╪¬╪º╪░.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.addressContacts",
                TranslationValue = "╪╣┘å╪º┘ê┘è┘å ╪º┘ä┘à┘ê╪▒╪» ┘ê╪¼┘ç╪º╪¬ ╪º┘ä╪º╪¬╪╡╪º┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.placeholder.namePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪┤┘ç╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.certification.placeholder.codePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ ╪º┘ä╪┤┘ç╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.placeholder.namePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à╪│╪º┘ç┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.shareHolders.placeholder.percentPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘å╪│╪¿╪⌐ ╪º┘ä╪¡╪╡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.placeholder.namePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪╣┘à┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.customerReference.placeholder.emailPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è ┘ä┘ä╪╣┘à┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.siteNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.addressNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.countryPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.addressLinePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.provincePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘à╪¡╪º┘ü╪╕╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.districtPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.dsAreaPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘à┘å╪╖┘é╪⌐ DS",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.postalCodePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.phoneNumberPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.emailPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.addressTypePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘å┘ê╪╣ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.contactTypePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘å┘ê╪╣ ╪¼┘ç╪⌐ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.firstNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à ╪º┘ä╪ú┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.middleNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à ╪º┘ä╪ú┘ê╪│╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.lastNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪╣╪º╪ª┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.landPhonePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü ╪º┘ä╪ú╪▒╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.mobilePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪¼┘ê╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.bankNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.branchNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.accountNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.accountNumberPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.swiftCodePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ SWIFT",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.ibanNumberPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à IBAN",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.address.placeholder.taxLandTypePlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä╪ú╪▒╪╢ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.addressesPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘ê┘é╪╣ (╪º┘ä┘à┘ê╪º┘é╪╣)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.contact.placeholder.salutationPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ä┘é╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.creditLimitPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪¡╪» ╪º┘ä╪º╪ª╪¬┘à╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.defaultCurrencyPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.paymentMethodPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪╖╪▒┘è┘é╪⌐ ╪º┘ä╪»┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.retentionPercentPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘å╪│╪¿╪⌐ ╪º┘ä╪º╪¡╪¬╪¼╪º╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.placeholder.supplierNameOnChequePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à┘ê╪▒╪» ╪╣┘ä┘ë ╪º┘ä╪┤┘è┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.commercialRegistrationNumberPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.creditPeriodPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘ü╪¬╪▒╪⌐ ╪º┘ä╪º╪ª╪¬┘à╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.leadTimeDaysPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘à╪»╪⌐ ╪º┘ä╪¬┘ê╪▒┘è╪» ╪¿╪º┘ä╪ú┘è╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.productAndServiceDescriptionPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘ê╪╡┘ü ╪º┘ä┘à┘å╪¬╪¼ ┘ê╪º┘ä╪«╪»┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.smePlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪º┘ä╪⌐ ╪º┘ä┘à┘å╪┤╪ú╪⌐ ╪º┘ä╪╡╪║┘è╪▒╪⌐ ┘ê╪º┘ä┘à╪¬┘ê╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.sourceSystemPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å╪╕╪º┘à ╪º┘ä┘à╪╡╪»╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.supplierNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.supplierShortNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à ╪º┘ä┘à╪«╪¬╪╡╪▒ ┘ä┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.supplierWebsitePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ┘à┘ê┘é╪╣ ╪º┘ä┘à┘ê╪▒╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.placeholder.yearEstablishedPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪│┘å╪⌐ ╪º┘ä╪¬╪ú╪│┘è╪│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Notification
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.finance.notification.bankDuplicateError",
                TranslationValue = "┘è┘ê╪¼╪» ╪¬┘ü╪º╪╡┘è┘ä ╪¿┘å┘â ╪¿┘å┘ü╪│ ╪º╪│┘à ╪º┘ä╪¿┘å┘â ┘ê╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿ ╪¿╪º┘ä┘ü╪╣┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.notification.draftSaved",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ┘à╪│┘ê╪»╪⌐ ╪º┘ä┘à┘ê╪▒╪» ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.notification.duplicateError",
                TranslationValue = "┘ç╪░╪º ╪º┘ä╪Ñ╪»╪«╪º┘ä ┘à┘ê╪¼┘ê╪» ╪¿╪º┘ä┘ü╪╣┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Action Button
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ê╪¡╪»╪⌐ ╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.actionButton.view",
                TranslationValue = "╪╣╪▒╪╢ ┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.actionButton.button",
                TranslationValue = "┘å╪┤╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Label
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.buId",
                TranslationValue = "╪º┘ä┘à╪╣╪▒┘æ┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.phoneNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.timeZone",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.defaultLanguage",
                TranslationValue = "╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.department",
                TranslationValue = "╪º┘ä┘é╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.legalEntity",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.branch",
                TranslationValue = "╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.financeCenter",
                TranslationValue = "╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.legalEntities",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.availableLabel",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐ ╪º┘ä┘à╪¬╪º╪¡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.departments",
                TranslationValue = "╪º┘ä╪Ñ╪»╪º╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.availableDepartment",
                TranslationValue = "╪º┘ä╪Ñ╪»╪º╪▒╪º╪¬ ╪º┘ä┘à╪¬╪º╪¡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.label.departmentDisabledHint",
                TranslationValue = "╪º┘ä╪▒╪¼╪º╪í ╪º╪«╪¬┘è╪º╪▒ ┘â┘è╪º┘å ┘é╪º┘å┘ê┘å┘è ╪ú┘ê┘ä╪º┘ï",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Placeholder
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.code",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.name",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.phoneNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.email",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.description",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.searchLegalEntity",
                TranslationValue = "╪º┘ä╪¿╪¡╪½ ╪╣┘å ┘â┘è╪º┘å ┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.placeholder.searchDepartment",
                TranslationValue = "╪º┘ä╪¿╪¡╪½ ╪╣┘å ╪Ñ╪»╪º╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Section Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.sectionHeader.generalInformation",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Column Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.buId",
                TranslationValue = "╪º┘ä┘à╪╣╪▒┘æ┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.buCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.buName",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.email",
                TranslationValue = "╪¿╪▒┘è╪» ╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.linkedlegalEntity",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è ╪º┘ä┘à╪▒╪¬╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.contactInformation",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.columnHeader.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ Confirmation
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.confirmation.confirmPublish",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪▒╪║╪¿╪¬┘â ┘ü┘è ┘å╪┤╪▒ ┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä ┘ç╪░┘ç╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Business Unit ΓåÆ SectionHeader
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.businessUnit.sectionHeader.organizationalAssignments",
                TranslationValue = "╪º┘ä╪¬╪╣┘è┘è┘å╪º╪¬ ╪º┘ä╪¬┘å╪╕┘è┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ Action Button
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.header.title",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘ü╪▒┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.header.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.header.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.header.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ SectionHeader
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.sectionHeader.title",
                TranslationValue = "╪º┘ä╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.sectionHeader.addLocation",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ Label
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.businessUnit",
                TranslationValue = "╪º┘ä┘ê╪¡╪»╪⌐ ╪º┘ä╪¬╪¼╪º╪▒┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.financeCentre",
                TranslationValue = "╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.manager",
                TranslationValue = "┘à╪»┘è╪▒ ╪º┘ä┘ü╪▒╪╣ / ╪º┘ä╪┤╪«╪╡ ╪º┘ä┘à╪│╪ñ┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è ┘ä┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.phoneNumber",
                TranslationValue = "╪▒┘é┘à ┘ç╪º╪¬┘ü ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.effectiveStartDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪¿╪»╪í ╪º┘ä╪│╪▒┘è╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.effectiveEndDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪│╪▒┘è╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.addLocationCode",
                TranslationValue = "╪º┘ä┘â┘ê╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.addLocationName",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.addLocationCountry",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.label.addLocationDescription",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ Placeholder
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.placeholder.code",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.placeholder.name",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.placeholder.shortCode",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.placeholder.email",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è ┘ä┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.placeholder.phoneNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ┘ç╪º╪¬┘ü ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Branch Master ΓåÆ ColumnHeader
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.manager",
                TranslationValue = "┘à╪»┘è╪▒ ╪º┘ä┘ü╪▒╪╣/╪º┘ä╪┤╪«╪╡ ╪º┘ä┘à╪│╪ñ┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.phoneNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪º╪¬╪╡╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.branchMaster.columnHeader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address ΓåÆ Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.breadcrumb.title",
                TranslationValue = "╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.rules.breadcrumb.title",
                TranslationValue = "┘é┘ê╪º╪╣╪» ┘å┘ê╪╣ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.breadcrumb.title",
                TranslationValue = "┘à╪¬╪╖┘ä╪¿╪º╪¬ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.navbar.title",
                TranslationValue = "╪ú┘å┘ê╪º╪╣ ╪º┘ä╪╣┘å╪º┘ê┘è┘å ({{count}})",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.navbar.title",
                TranslationValue = "╪ú┘å┘ê╪º╪╣ ╪º┘ä┘â┘è╪º┘å╪º╪¬ ({{count}})",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.manageAddressTypes.title",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪ú┘å┘ê╪º╪╣ ╪º┘ä╪╣┘å╪º┘ê┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.purpose.title",
                TranslationValue = "╪º┘ä╪║╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.title.suffix",
                TranslationValue = "┘à╪¬╪╖┘ä╪¿╪º╪¬ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Type Rules ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.columns.fieldKey",
                TranslationValue = "┘à┘ü╪¬╪º╪¡ ╪º┘ä╪¡┘é┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.columns.displayLabel",
                TranslationValue = "╪¬╪│┘à┘è╪⌐ ╪º┘ä╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.columns.visible",
                TranslationValue = "┘à╪▒╪ª┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.columns.required",
                TranslationValue = "┘à╪╖┘ä┘ê╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ATR",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Requirements ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.columns.addressType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.columns.purpose",
                TranslationValue = "╪º┘ä╪║╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.columns.mandatory",
                TranslationValue = "╪Ñ┘ä╪▓╪º┘à┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.columns.enforcedAt",
                TranslationValue = "┘è┘Å╪╖╪¿┘é ╪╣┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Requirements ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.addButton",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪ú┘å┘ê╪º╪╣ ╪╣┘å╪º┘ê┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Requirements ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.emptyState",
                TranslationValue = "┘ä┘à ┘è╪¬┘à ╪¬┘â┘ê┘è┘å ╪ú┘è ╪ú┘å┘ê╪º╪╣ ╪╣┘å╪º┘ê┘è┘å. ╪º┘å┘é╪▒ ┘ü┘ê┘é \"╪Ñ╪╢╪º┘ü╪⌐ ╪ú┘å┘ê╪º╪╣ ╪╣┘å╪º┘ê┘è┘å\" ┘ä┘ä╪¿╪»╪í.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.allTypesAdded",
                TranslationValue = "╪¬┘à╪¬ ╪Ñ╪╢╪º┘ü╪⌐ ╪¼┘à┘è╪╣ ╪ú┘å┘ê╪º╪╣ ╪º┘ä╪╣┘å╪º┘ê┘è┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Requirements ΓåÆ Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.removeConfirm",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪▒╪║╪¿╪¬┘â ┘ü┘è ╪Ñ╪▓╪º┘ä╪⌐ ┘å┘ê╪╣ ╪º┘ä╪╣┘å┘ê╪º┘å ┘ç╪░╪º╪ƒ ┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¬╪▒╪º╪¼╪╣ ╪╣┘å ┘ç╪░╪º ╪º┘ä╪Ñ╪¼╪▒╪º╪í!",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Requirements ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.requirements.cannotDeleteMandatory",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪Ñ╪▓╪º┘ä╪⌐ ╪ú┘å┘ê╪º╪╣ ╪º┘ä╪╣┘å╪º┘ê┘è┘å ╪º┘ä╪Ñ┘ä╪▓╪º┘à┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.toggleMenu",
                TranslationValue = "╪¬╪¿╪»┘è┘ä ╪º┘ä┘é╪º╪ª┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.breadcrumb.title",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.breadcrumb.titleAdd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘â┘è╪º┘å ┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.breadcrumb.titleView",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.breadcrumb.titleEdit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.sectionheader.generalInformation",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.sectionheader.financeDetails",
                TranslationValue = "╪º┘ä╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.sectionheader.contactAddressDetails",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪º╪¬╪╡╪º┘ä ┘ê╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.sectionheader.configurations",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.sectionheader.linkedBusinessUnit",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä ╪º┘ä┘à╪▒╪¬╪¿╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ General Information
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.companyRegistrationNo",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.addLocation",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.phoneNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.defaultLanguage",
                TranslationValue = "╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.timeZone",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.industryType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪╡┘å╪º╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.websiteUrl",
                TranslationValue = "╪▒╪º╪¿╪╖ ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.logo",
                TranslationValue = "╪º┘ä╪┤╪╣╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.browseLogo",
                TranslationValue = "╪º╪│╪¬╪╣╪▒╪º╪╢ ╪º┘ä╪┤╪╣╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.logoAdd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪┤╪╣╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.groupOfLegalEntities",
                TranslationValue = "┘à╪¼┘à┘ê╪╣╪⌐ ┘â┘è╪º┘å╪º╪¬ ┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.groupOfLegalEntitiesDescription",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ┘ç╪░╪º ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è ┘â┘à╪¼┘à┘ê╪╣╪⌐ ┘à┘å ╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.shareMasterAcrossLegalEntity",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐ ╪º┘ä╪¿┘è╪º┘å╪º╪¬ ╪º┘ä╪▒╪ª┘è╪│┘è╪⌐ ╪╣╪¿╪▒ ╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.shareMasterDescription",
                TranslationValue = "╪¬╪╣┘è┘è┘å ┘ç╪░╪º ┘â┘à╪▒╪¼╪╣ ╪▒╪ª┘è╪│┘è ╪╣╪¿╪▒ ╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.parentLegalEntity",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è ╪º┘ä╪ú╪╡┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ Finance Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.functionalCurrency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘ê╪╕┘è┘ü┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.reportingCurrency",
                TranslationValue = "╪╣┘à┘ä╪⌐ ╪º┘ä╪¬┘é╪º╪▒┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.consolidationCurrency",
                TranslationValue = "╪╣┘à┘ä╪⌐ ╪º┘ä╪¬┘ê╪¡┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.vatRegistered",
                TranslationValue = "┘à╪│╪¼┘ä ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.vatRegisteredDescription",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è╪ñ┘â╪» ╪ú┘å┘â ┘à╪│╪¼┘ä ┘ü┘è ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.vatRegistrationNo",
                TranslationValue = "╪▒┘é┘à ╪¬╪│╪¼┘è┘ä ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.taxCardNo",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¿╪╖╪º┘é╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.defaultPaymentTerm",
                TranslationValue = "╪┤╪▒╪╖ ╪º┘ä╪»┘ü╪╣ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.financeDetails.defaultSellingTerm",
                TranslationValue = "╪┤╪▒╪╖ ╪º┘ä╪¿┘è╪╣ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ Contact & Address Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.phoneNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.city",
                TranslationValue = "╪º┘ä┘à╪»┘è┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.area",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.way",
                TranslationValue = "╪º┘ä╪╖╪▒┘è┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.building",
                TranslationValue = "╪º┘ä┘à╪¿┘å┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.postalCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.contactAddressDetails.poBox",
                TranslationValue = "╪╡┘å╪»┘ê┘é ╪º┘ä╪¿╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ Configurations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.configurations.timeZone",
                TranslationValue = "╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.configurations.defaultLanguage",
                TranslationValue = "╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.configurations.calendar",
                TranslationValue = "╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Labels ΓåÆ Linked Business Unit
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.linkedBusinessUnit.businessUnits",
                TranslationValue = "┘ê╪¡╪»╪º╪¬ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.linkedBusinessUnit.searchPlaceholder",
                TranslationValue = "╪º┘ä╪¿╪¡╪½ ╪╣┘å ┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.linkedBusinessUnit.availableBusinessUnits",
                TranslationValue = "┘ê╪¡╪»╪º╪¬ ╪º┘ä╪ú╪╣┘à╪º┘ä ╪º┘ä┘à╪¬╪º╪¡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Navigation
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.title",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.toggleMenu",
                TranslationValue = "╪¬╪¿╪»┘è┘ä ╪º┘ä┘é╪º╪ª┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.general.label",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.general.description",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐ ┘ä┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.finance.label",
                TranslationValue = "╪º┘ä╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.finance.description",
                TranslationValue = "╪º┘ä╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä┘à╪º┘ä┘è╪⌐ ┘ä┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.contactAddress.label",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪º╪¬╪╡╪º┘ä ┘ê╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.contactAddress.description",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪º╪¬╪╡╪º┘ä ┘ê╪º┘ä┘à┘ê┘é╪╣ ┘ä┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.configurations.label",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.configurations.description",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐ ┘ä┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.linkedBusinessUnit.label",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä ╪º┘ä┘à╪▒╪¬╪¿╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.navigation.linkedBusinessUnit.description",
                TranslationValue = "┘ê╪¡╪»╪º╪¬ ╪º┘ä╪ú╪╣┘à╪º┘ä ╪º┘ä┘à╪▒╪¬╪¿╪╖╪⌐ ╪¿╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.menu.edm.company",
                TranslationValue = "╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Menu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ List ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.addLegalEntity",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘â┘è╪º┘å ┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.crNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.list.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Table Headers ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.legalEntityCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.legalEntityName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.crNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.actionbutton.draft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.actionbutton.saveAndContinue",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘à╪¬╪º╪¿╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Placeholders ΓåÆ General Information
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.code",
                TranslationValue = "╪¡┘é┘ä ┘è╪¬┘à ╪Ñ┘å╪┤╪º╪ñ┘ç ╪¬┘ä┘é╪º╪ª┘è┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.name",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.companyRegistrationNo",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪│╪¼┘ä ╪º┘ä╪¬╪¼╪º╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.location",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.description",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.phoneNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.email",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.defaultLanguage",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.timeZone",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.industryType",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä╪╡┘å╪º╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.generalInformation.websiteUrl",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒╪º╪¿╪╖ ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Placeholders ΓåÆ Finance Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.functionalCurrency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘ê╪╕┘è┘ü┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.reportingCurrency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪╣┘à┘ä╪⌐ ╪º┘ä╪¬┘é╪º╪▒┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.consolidationCurrency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪╣┘à┘ä╪⌐ ╪º┘ä╪¬┘ê╪¡┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.vatRegistrationNo",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪¬╪│╪¼┘è┘ä ╪º┘ä╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.taxCardNo",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪¿╪╖╪º┘é╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.defaultPaymentTerm",
                TranslationValue = "╪º╪«╪¬╪▒ ╪┤╪▒┘ê╪╖ ╪º┘ä╪»┘ü╪╣ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.financeDetails.defaultSellingTerm",
                TranslationValue = "╪º╪«╪¬╪▒ ╪┤╪▒┘ê╪╖ ╪º┘ä╪¿┘è╪╣ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Placeholders ΓåÆ Contact & Address Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.location",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.phoneNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.email",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.country",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.city",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘à╪»┘è┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.area",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.way",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪┤╪º╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.building",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘à╪¿┘å┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.postalCode",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪¿╪▒┘è╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.contactAddressDetails.poBox",
                TranslationValue = "╪ú╪»╪«┘ä ╪╡┘å╪»┘ê┘é ╪º┘ä╪¿╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Placeholders ΓåÆ Configurations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.configurations.timeZone",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘å╪╖┘é╪⌐ ╪º┘ä╪▓┘à┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.configurations.defaultLanguage",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ä╪║╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.placeholders.configurations.calendar",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.logoSuccess",
                TranslationValue = "╪¬┘à ╪▒┘ü╪╣ ╪º┘ä╪┤╪╣╪º╪▒ ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.logoFail",
                TranslationValue = "┘ü╪┤┘ä ╪▒┘ü╪╣ ╪º┘ä╪┤╪╣╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.logoRemoveFail",
                TranslationValue = "┘ü╪┤┘ä ╪¡╪░┘ü ╪º┘ä╪┤╪╣╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.locationCreateFail",
                TranslationValue = "┘ü╪┤┘ä ╪Ñ┘å╪┤╪º╪í ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.businessUnitAssignFail",
                TranslationValue = "┘ü╪┤┘ä ╪¬╪¡╪»┘è╪½ ╪¬╪╣┘è┘è┘å ┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.loadError",
                TranslationValue = "┘ü╪┤┘ä ╪¬╪¡┘à┘è┘ä ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.saveSuccess",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.saveError",
                TranslationValue = "┘ü╪┤┘ä ╪¡┘ü╪╕ ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.createSuccess",
                TranslationValue = "╪¬┘à ╪Ñ┘å╪┤╪º╪í ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.createError",
                TranslationValue = "┘ü╪┤┘ä ╪Ñ┘å╪┤╪º╪í ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.formInvalid",
                TranslationValue = "┘è╪▒╪¼┘ë ╪¬╪╡╪¡┘è╪¡ ╪º┘ä╪ú╪«╪╖╪º╪í ┘é╪¿┘ä ╪º┘ä╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.commonButtons.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.itemCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.companyName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.itemName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.itemShortDescription",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü ╪º┘ä┘à╪«╪¬╪╡╪▒ ┘ä┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.itemFinanceCategory",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.financeSubCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.itemType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.primaryUom",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä┘é┘è╪º╪│ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.alternativeUom",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä┘é┘è╪º╪│ ╪º┘ä╪¿╪»┘è┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.isSubItem",
                TranslationValue = "╪╡┘å┘ü ┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.isSubItemDescription",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è╪¬┘à ╪¬╪╣┘è┘è┘å ┘ç╪░╪º ╪º┘ä╪╡┘å┘ü ┘â╪╡┘å┘ü ┘ü╪▒╪╣┘è ┘ä╪╡┘å┘ü ╪ó╪«╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.posType",
                TranslationValue = "┘å┘ê╪╣ ┘å╪╕╪º┘à ┘å┘é╪º╪╖ ╪º┘ä╪¿┘è╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.vatSubCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘ä╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.uploadDocument",
                TranslationValue = "╪¬╪¡┘à┘è┘ä ┘à╪│╪¬┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.auditCategory",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪¬╪»┘é┘è┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.mainCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä╪▒╪ª┘è╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.subCategory01",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 01",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.subCategory02",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 02",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.field.subCategory03",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 03",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Placeholder
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.itemCodePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.itemNamePlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.itemShortDescriptionPlaceholder",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘ê╪╡┘ü ╪º┘ä┘à╪«╪¬╪╡╪▒ ┘ä┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.itemFinanceCategoryPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.financeSubCategoryPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.auditCategoryPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘ü╪ª╪⌐ ╪º┘ä╪¬╪»┘é┘è┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.itemTypePlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.mainCategoryPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä╪▒╪ª┘è╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.subCategory01Placeholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 01",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.subCategory02Placeholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 02",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.subCategory03Placeholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ 03",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.primaryUomPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘ê╪¡╪»╪⌐ ╪º┘ä┘é┘è╪º╪│ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.alternativeUomPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘ê╪¡╪»╪⌐ ╪º┘ä┘é┘è╪º╪│ ╪º┘ä╪¿╪»┘è┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.posTypePlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ┘å╪╕╪º┘à ┘å┘é╪º╪╖ ╪º┘ä╪¿┘è╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.itemMaster.placeholder.vatSubCategoryPlaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘ä╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Attachment
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.ariaRemoveAttachment",
                TranslationValue = "╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.ariaDropzone",
                TranslationValue = "╪ú┘ü┘ä╪¬ ╪º┘ä┘à┘ä┘ü ┘ç┘å╪º ┘ä┘ä╪▒┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.browseDocument",
                TranslationValue = "╪¬╪╡┘ü╪¡ ╪ú┘ê ╪ú┘ü┘ä╪¬ ╪º┘ä┘à╪│╪¬┘å╪» ┘ç┘å╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.uploadFailed",
                TranslationValue = "┘ü╪┤┘ä ╪▒┘ü╪╣ ╪º┘ä┘à╪│╪¬┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.removeFailed",
                TranslationValue = "┘ü╪┤┘ä ╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä┘à╪│╪¬┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.generalInformation.title",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.itemCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.itemType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.partNo",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘é╪╖╪╣╪⌐ / ╪º┘ä╪▒┘é┘à ╪º┘ä┘à╪▒╪¼╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.itemDescription",
                TranslationValue = "┘ê╪╡┘ü ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.uom",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä┘é┘è╪º╪│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.financeCategory",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.financeSubCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.primaryCompany",
                TranslationValue = "╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä╪▒╪ª┘è╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.tableHeaders.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.label.breadcrumb.title",
                TranslationValue = "╪│╪¼┘ä ╪º┘ä╪ú╪╡┘å╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.label.breadcrumb.titleAdd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.label.breadcrumb.titleEdit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.label.breadcrumb.titleView",
                TranslationValue = "╪╣╪▒╪╢ ╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.breadcrumb",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.breadcrumbAdd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.breadcrumbEdit",
                TranslationValue = "╪¬╪¡╪▒┘è╪▒ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.breadcrumbView",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.company",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.primary",
                TranslationValue = "╪º┘ä╪╣┘å┘ê╪º┘å ╪º┘ä╪ú╪│╪º╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.primaryHint",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬╪╣┘è┘è┘å ┘ç╪░╪º ╪º┘ä┘à┘ê┘é╪╣ ┘â╪╣┘å┘ê╪º┘å ╪ú╪│╪º╪│┘è.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.country",
                TranslationValue = "╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.labels.locationType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.code",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.name",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.shortCode",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.country",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪¿┘ä╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.locationType",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.placeholders.enterHere",
                TranslationValue = "Enter here",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.sectionHeaders.generalInformation",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.sectionHeaders.address",
                TranslationValue = "╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.actionButtons.add",
                TranslationValue = "╪ú╪╢┘ü ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.isPrimary",
                TranslationValue = "╪ú╪│╪º╪│┘è",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.columnHeaders.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Location Master ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.notifications.createFailed",
                TranslationValue = "┘ü╪┤┘ä ┘ü┘è ╪¡┘ü╪╕ ╪º┘ä╪¿┘è╪º┘å╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.location.notifications.updateFailed",
                TranslationValue = "┘ü╪┤┘ä ┘ü┘è ╪¬╪¡╪»┘è╪½ ╪º┘ä╪¿┘è╪º┘å╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LOC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.breadcrumb.title",
                TranslationValue = "╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.breadcrumb.title.edit",
                TranslationValue = "╪¬╪¡╪▒┘è╪▒ ╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.breadcrumb.title.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.commonButtons.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪▒┘â╪▓ ┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.title",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.field.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.field.name",
                TranslationValue = "╪º┘ä╪Ñ╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.field.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.field.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.detail.generalInformation.field.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.name",
                TranslationValue = "╪º┘ä╪Ñ╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.tableHeaders.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Centre ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.alertMessage.delete.title",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.enterpriseStructure.financialCentre.alertMessage.delete.message",
                TranslationValue = "┘ç╪░╪º ╪º┘ä┘à╪▒┘â╪▓ ╪º┘ä┘à╪º┘ä┘è ┘é┘è╪» ╪º┘ä╪º╪│╪¬╪«╪»╪º┘à ┘ê┘ä╪º ┘è┘à┘â┘å ╪¡╪░┘ü┘ç.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.breadcrumb.title",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.breadcrumb.title.edit",
                TranslationValue = "╪¬╪¡╪▒┘è╪▒ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.breadcrumb.title.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.commonButtons.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.placeholder.code",
                TranslationValue = "╪¡┘é┘ä ┘è╪¬┘à ╪Ñ┘å╪┤╪º╪ñ┘ç ╪¬┘ä┘é╪º╪ª┘è┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.placeholder.name",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.title",
                TranslationValue = "╪º┘ä┘ç┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.title",
                TranslationValue = "╪¬╪«╪╡┘è╪╡ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.field.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.field.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.field.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.legalEntity",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.businessUnit",
                TranslationValue = "┘ê╪¡╪»╪⌐ ╪º┘ä╪ú╪╣┘à╪º┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.branch",
                TranslationValue = "╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.location",
                TranslationValue = "╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.field.isDefault",
                TranslationValue = "╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.identity.field.isDefaultHint",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä ┘è╪╡╪¿╪¡ ┘ç╪░╪º ╪º┘ä┘à╪│╪¬┘ê╪»╪╣ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.allocation.field.addressLine",
                TranslationValue = "╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.placeholder.addressLine",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.type.Physical",
                TranslationValue = "┘à╪º╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.type.Logical",
                TranslationValue = "┘à┘å╪╖┘é┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.type.InTransit",
                TranslationValue = "┘é┘è╪» ╪º┘ä┘å┘é┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.title",
                TranslationValue = "╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä╪¬╪«╪▓┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.field.depth",
                TranslationValue = "╪╣┘à┘é ╪º┘ä╪¬╪│┘ä╪│┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.depth.flat",
                TranslationValue = "┘à╪│╪╖┘æ╪¡ (╪¿╪»┘ê┘å ╪╡┘å╪º╪»┘è┘é)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.depth.warehouseBin",
                TranslationValue = "┘à╪│╪¬┘ê╪»╪╣ ΓåÉ ╪╡┘å╪»┘ê┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.depth.warehouseZoneBin",
                TranslationValue = "┘à╪│╪¬┘ê╪»╪╣ ΓåÉ ┘à┘å╪╖┘é╪⌐ ΓåÉ ╪╡┘å╪»┘ê┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.items",
                TranslationValue = "╪ú╪╡┘å╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.assign",
                TranslationValue = "╪Ñ╪│┘å╪º╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.addBin",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╡┘å╪»┘ê┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.addZone",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à┘å╪╖┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.storage.saveFirst",
                TranslationValue = "╪º╪¡┘ü╪╕ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣ ╪ú┘ê┘ä┘ï╪º ┘ä╪¬┘ç┘è╪ª╪⌐ ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä┘ç╪▒┘à┘è ┘ä┘ä╪¬╪«╪▓┘è┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.title",
                TranslationValue = "╪Ñ╪│┘å╪º╪» ╪º┘ä╪ú╪╡┘å╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.subtitle",
                TranslationValue = "╪º┘ä╪Ñ╪│┘å╪º╪» ╪Ñ┘ä┘ë {{node}} ┬╖ ╪╣╪▒╪╢ ╪º┘ä╪ú╪╡┘å╪º┘ü ╪º┘ä┘ü╪╣┘æ╪º┘ä╪⌐ ┘ê╪º┘ä┘à╪╣╪¬┘à╪»╪⌐ ┘ü┘é╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.search",
                TranslationValue = "╪¿╪¡╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.allCategory",
                TranslationValue = "┘â┘ä ╪º┘ä╪¬╪╡┘å┘è┘ü╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.subCategory",
                TranslationValue = "╪º┘ä╪¬╪╡┘å┘è┘ü ╪º┘ä┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.column.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.column.item",
                TranslationValue = "╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.column.category",
                TranslationValue = "╪º┘ä╪¬╪╡┘å┘è┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.detail.assign.column.subCategory",
                TranslationValue = "╪º┘ä╪¬╪╡┘å┘è┘ü ╪º┘ä┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Warehouse ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.entityBranch",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å / ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.storage",
                TranslationValue = "╪º┘ä╪¬╪«╪▓┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.isDefault",
                TranslationValue = "╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.warehouse.tableHeaders.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-WH",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Action Button
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¡╪│╪º╪¿ ╪¿┘å┘â┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.bankDetails.sectionHeader.title",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.sectionHeader.title",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.sectionHeader.title",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.otherDetails.sectionHeader.title",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪ú╪«╪▒┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.bank",
                TranslationValue = "╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.branch",
                TranslationValue = "╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.accountName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.accountNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.ibanNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪ó┘è╪¿╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.createdBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪Ñ┘å╪┤╪º╪í ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.updatedBy",
                TranslationValue = "╪¬┘à ╪º┘ä╪¬╪¡╪»┘è╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "entity.bankAccount",
                TranslationValue = "╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä╪¿┘å┘â┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.breadcrumb.title",
                TranslationValue = "╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä╪¿┘å┘â┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.breadcrumb.title.view",
                TranslationValue = "╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä╪¿┘å┘â┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Labels ΓåÆ Bank Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.bankName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.bankCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.swiftCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪│┘ê┘è┘ü╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Labels ΓåÆ Branch Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.branchName",
                TranslationValue = "╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.contactPerson",
                TranslationValue = "╪º┘ä╪┤╪«╪╡ ╪º┘ä┘à╪│╪ñ┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.branchCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.telephone",
                TranslationValue = "╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.email",
                TranslationValue = "╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.branchAddress",
                TranslationValue = "╪╣┘å┘ê╪º┘å ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Labels ΓåÆ Account Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.accountNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.accountName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.accountType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.ibanNumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪ó┘è╪¿╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.accountCreatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪Ñ┘å╪┤╪º╪í ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Labels ΓåÆ Other Details
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.glCode",
                TranslationValue = "╪▒┘à╪▓ ╪»┘ü╪¬╪▒ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪º┘ä╪╣╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.chequePrintedStartingNumber",
                TranslationValue = "╪º┘ä╪▒┘é┘à ╪º┘ä╪ú┘ê┘ä┘è ┘ä╪╖╪¿╪º╪╣╪⌐ ╪º┘ä╪┤┘è┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.salaryBank",
                TranslationValue = "╪¿┘å┘â ╪º┘ä╪▒╪º╪¬╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.salaryBankDescription",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘à┘â┘å ╪º╪«╪¬┘è╪º╪▒┘ç ┘ü┘è ┘å╪╕╪º┘à ╪º┘ä┘à┘ê╪º╪▒╪» ╪º┘ä╪¿╪┤╪▒┘è╪⌐ ╪ú╪½┘å╪º╪í ╪»┘ü╪╣ ╪º┘ä╪▒┘ê╪º╪¬╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.temporaryAccount",
                TranslationValue = "╪¡╪│╪º╪¿ ┘à╪ñ┘é╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.temporaryAccountDescription",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è┘â┘ê┘å ┘ç╪░╪º ╪¡╪│╪º╪¿┘ï╪º ┘à╪ñ┘é╪¬┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.temporaryStartDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪ñ┘é╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.temporaryEndDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ┘å┘ç╪º┘è╪⌐ ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪ñ┘é╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.label.note",
                TranslationValue = "┘à┘ä╪º╪¡╪╕╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.bankDetails.placeholder.bankName",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º╪│┘à ╪º┘ä╪¿┘å┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.placeholder.branchName",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º╪│┘à ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.placeholder.contactPerson",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪┤╪«╪╡ ╪º┘ä┘à╪│╪ñ┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.placeholder.telephone",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä┘ç╪º╪¬┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.placeholder.email",
                TranslationValue = "╪ú╪»╪«┘ä ╪╣┘å┘ê╪º┘å ╪º┘ä╪¿╪▒┘è╪» ╪º┘ä╪Ñ┘ä┘â╪¬╪▒┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.branchDetails.placeholder.branchAddress",
                TranslationValue = "╪ú╪»╪«┘ä ╪╣┘å┘ê╪º┘å ╪º┘ä┘ü╪▒╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.accountType",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.accountNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.accountName",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.currency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.ibanNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘é┘à ╪º┘ä╪ó┘è╪¿╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.accountDetails.placeholder.glCode",
                TranslationValue = "╪º╪«╪¬╪▒ ╪▒┘à╪▓ ╪»┘ü╪¬╪▒ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪º┘ä╪╣╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.otherDetails.placeholder.chequePrintedStartingNumber",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘é┘à ╪º┘ä╪ú┘ê┘ä┘è ┘ä╪╖╪¿╪º╪╣╪⌐ ╪º┘ä╪┤┘è┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.otherDetails.placeholder.note",
                TranslationValue = "╪ú╪╢┘ü ┘à┘ä╪º╪¡╪╕╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.validation.accountNumberDigitsOnly",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è╪¡╪¬┘ê┘è ╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿ ╪╣┘ä┘ë ╪ú╪▒┘é╪º┘à ┘ü┘é╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.validation.temporaryStartBeforeCreatedDate",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪¿╪»╪í ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪ñ┘é╪¬ ┘é╪¿┘ä ╪¬╪º╪▒┘è╪« ╪Ñ┘å╪┤╪º╪í ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.validation.temporaryEndBeforeStartDate",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪ñ┘é╪¬ ┘é╪¿┘ä ╪¬╪º╪▒┘è╪« ╪¿╪»╪í ╪º┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪ñ┘é╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Labels ΓåÆ Breadcrumbs
            yield return new SystemTranslation
            {
                KeyName = "entity.financialTemplate",
                TranslationValue = "╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.financialtemplate.label.breadcrumb",
                TranslationValue = "╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.financialtemplate.label.breadcrumbadd",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ┘é╪º┘ä╪¿ ┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.financialtemplate.label.breadcrumbedit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ┘é╪º┘ä╪¿ ┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.financialtemplate.label.breadcrumbview",
                TranslationValue = "╪╣╪▒╪╢ ┘é╪º┘ä╪¿ ┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.financialtemplate.label.breadcrumbconfigure",
                TranslationValue = "╪¬┘ç┘è╪ª╪⌐ ┘é╪º┘ä╪¿ ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.commonButtons.actionbutton.createTemplate",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.draft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.saveAndContinue",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘à╪¬╪º╪¿╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.assignUsers",
                TranslationValue = "╪¬╪╣┘è┘è┘å ┘à╪│╪¬╪«╪»┘à┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.removeUser",
                TranslationValue = "╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä┘à╪│╪¬╪«╪»┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.configure",
                TranslationValue = "╪¬┘ç┘è╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.restore",
                TranslationValue = "╪º╪│╪¬╪╣╪º╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addNewHeader",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪▒╪ú╪│ ╪¼╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.copyFromTemplate",
                TranslationValue = "┘å╪│╪« ┘à┘å ┘é╪º┘ä╪¿ ┘à┘ê╪¼┘ê╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.applyNow",
                TranslationValue = "╪¬╪╖╪¿┘è┘é ╪º┘ä╪ó┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addRow",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addSubCategory",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪ª╪⌐ ┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.manageInclusion",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä╪¬╪╢┘à┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.unlinkGl",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í ╪▒╪¿╪╖ ╪º┘ä╪ú╪│╪¬╪º╪░",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.linkGlCodes",
                TranslationValue = "╪▒╪¿╪╖ ╪▒┘à┘ê╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.yes",
                TranslationValue = "┘å╪╣┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.no",
                TranslationValue = "┘ä╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.noAssignedUsers",
                TranslationValue = "┘ä┘à ┘è╪¬┘à ╪¬╪╣┘è┘è┘å ╪ú┘è ┘à╪│╪¬╪«╪»┘à┘è┘å ╪¿╪╣╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.inactive",
                TranslationValue = "╪║┘è╪▒ ┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.companies",
                TranslationValue = "╪º┘ä╪┤╪▒┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.companiesWarning",
                TranslationValue = "╪│┘è╪¬┘à ╪¬╪╣┘è┘è┘å ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿ ╪¬┘ä┘é╪º╪ª┘è┘ï╪º ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬ ╪º┘ä┘à╪¡╪»╪»╪⌐ ╪¿╪¡╪º┘ä╪⌐ ╪║┘è╪▒ ┘å╪┤╪╖. ┘è╪¼╪¿ ╪╣┘ä┘ë ┘â┘ä ╪┤╪▒┘â╪⌐ ╪¬┘ü╪╣┘è┘ä┘ç ┘é╪¿┘ä ╪º┘ä╪º╪│╪¬╪«╪»╪º┘à.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isPublic",
                TranslationValue = "┘à╪▒╪ª┘è ┘ü┘è ╪º┘ä╪¬┘é╪º╪▒┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isPublicDesc",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è╪╕┘ç╪▒ ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿ ┘ü┘è ┘é╪º╪ª┘à╪⌐ ╪º┘ä╪¬┘é╪º╪▒┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isDefault",
                TranslationValue = "╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isDefaultDesc",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘â┘ê┘å ┘ç╪░╪º ┘ç┘ê ╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è ┘ä┘ä┘å┘ê╪╣ ╪º┘ä┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.templateAction",
                TranslationValue = "╪Ñ╪¼╪▒╪º╪í ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.sourceTemplate",
                TranslationValue = "╪▒╪¿╪╖ ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.linkEquals",
                TranslationValue = "╪▒╪¿╪╖ =",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyMode",
                TranslationValue = "┘ê╪╢╪╣ ╪º┘ä┘å╪│╪«",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintIndividual",
                TranslationValue = "┘é╪º┘ä╪¿ ┘ü╪▒╪»┘è ΓÇö ┘è╪«╪╡ ┘ç╪░┘ç ╪º┘ä╪┤╪▒┘â╪⌐ ┘ü┘é╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintGlobalTitle",
                TranslationValue = "┘é╪º┘ä╪¿ ╪╣╪º┘à ΓÇö ╪º╪«╪¬╪▒ ┘â┘è┘ü┘è╪⌐ ╪Ñ┘å╪┤╪º╪ª┘ç",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintGlobalBody",
                TranslationValue = "╪º┘ä╪▒╪¿╪╖ ┘è╪╣╪¬┘à╪» ╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä┘à╪¡╪»╪» ╪¿╪º┘ä┘â╪º┘à┘ä. ╪│╪¬╪┤╪º╪▒┘â ┘ç╪░┘ç ╪º┘ä╪┤╪▒┘â╪⌐ ┘å┘ü╪│ ╪▒┘à┘ê╪▓ ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ┘ê╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä╪«╪º╪╡ ╪¿╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä╪ú╪╡┘ä┘è╪⌐. ┘ä╪º ┘è┘à┘â┘å ╪Ñ┘å╪┤╪º╪í ╪▒┘à┘ê╪▓ ╪¼╪»┘è╪»╪⌐ ╪¿╪┤┘â┘ä ┘à╪│╪¬┘é┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.primaryFilter",
                TranslationValue = "╪º┘ä┘ü┘ä╪¬╪▒ ╪º┘ä╪ú╪│╪º╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.allowCrossPeriod",
                TranslationValue = "╪º┘ä╪│┘à╪º╪¡ ╪╣╪¿╪▒ ╪º┘ä┘ü╪¬╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.allowCrossPeriodDesc",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘à┘â┘å ┘ä┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿ ╪│╪¡╪¿ ╪º┘ä╪¿┘è╪º┘å╪º╪¬ ╪╣╪¿╪▒ ╪╣╪»╪⌐ ┘ü╪¬╪▒╪º╪¬ ┘à╪º┘ä┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.consolidationDesc",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è┘â┘ê┘å ╪º┘ä┘é╪º┘ä╪¿ ┘é╪º┘ä╪¿ ╪¬┘ê╪¡┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.codeConfigInfo",
                TranslationValue = "╪¬╪¬╪¡┘â┘à ┘ç╪░┘ç ╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬ ┘ü┘è ┘â┘è┘ü┘è╪⌐ ╪Ñ┘å╪┤╪º╪í ╪▒┘à┘ê╪▓ ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪╢┘à┘å ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿. ┘è╪¬┘à ┘é┘ü┘ä┘ç╪º ╪¿┘à╪¼╪▒╪» ╪Ñ┘å╪┤╪º╪í ╪ú┘ê┘ä ╪¡╪│╪º╪¿ ╪ú╪│╪¬╪º╪░ ╪╣╪º┘à. ┘é┘à ╪¿╪º┘ä╪¬┘â┘ê┘è┘å ╪¿╪╣┘å╪º┘è╪⌐ ┘é╪¿┘ä ╪º┘ä╪¬┘ü╪╣┘è┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.maxTotalCodeLength",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪Ñ╪¼┘à╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.coaSerialLength",
                TranslationValue = "╪╖┘ê┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ┘ä╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.maxNumberOfLevels",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä┘ä┘à╪│╪¬┘ê┘è╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.uniformLengthPadding",
                TranslationValue = "╪¬╪╣╪¿╪ª╪⌐ ╪¼┘à┘è╪╣ ╪▒┘à┘ê╪▓ ╪º┘ä╪ú┘ê╪▒╪º┘é ╪¿╪º┘ä╪ú╪╡┘ü╪º╪▒ ╪º┘ä┘ä╪º╪¡┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.uniformLengthPaddingDesc",
                TranslationValue = "┘è╪╢┘à┘å ┘ê╪╡┘ê┘ä ╪¼┘à┘è╪╣ ╪▒┘à┘ê╪▓ ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪Ñ┘ä┘ë ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä┘ä╪╖┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialLengthMode",
                TranslationValue = "╪º┘ä┘ê╪╢╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialLength",
                TranslationValue = "╪╖┘ê┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ╪º┘ä╪½╪º╪¿╪¬ (┘ä┘â┘ä ┘à╪│╪¬┘ê┘ë)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.level",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelLabel",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë {{level}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScope0",
                TranslationValue = "╪ú╪╡┘ä / ╪º┘ä╪¬╪▓╪º┘à / ╪¡┘é┘ê┘é ┘à┘ä┘â┘è╪⌐ / ╪Ñ┘è╪▒╪º╪» / ┘à╪╡╪▒┘ê┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeBs0",
                TranslationValue = "╪ú╪╡┘ä / ╪º┘ä╪¬╪▓╪º┘à / ╪¡┘é┘ê┘é ┘à┘ä┘â┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopePl0",
                TranslationValue = "╪Ñ┘è╪▒╪º╪» / ┘à╪╡╪▒┘ê┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeCf0",
                TranslationValue = "╪¬╪┤╪║┘è┘ä┘è / ╪º╪│╪¬╪½┘à╪º╪▒┘è / ╪¬┘à┘ê┘è┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeCe0",
                TranslationValue = "╪▒╪ú╪│ ╪º┘ä┘à╪º┘ä / ╪º┘ä╪º╪¡╪¬┘è╪º╪╖┘è╪º╪¬ / ╪º┘ä╪ú╪▒╪¿╪º╪¡ ╪º┘ä┘à╪¡╪¬╪¼╪▓╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeSubCategory",
                TranslationValue = "┘ü╪ª╪⌐ ┘ü╪▒╪╣┘è╪⌐ {{index}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.categoryScope",
                TranslationValue = "┘å╪╖╪º┘é ╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialDigits",
                TranslationValue = "╪ú╪▒┘é╪º┘à ╪º┘ä╪¬╪│┘ä╪│┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.computedPrefixLength",
                TranslationValue = "╪╖┘ê┘ä ╪º┘ä╪¿╪º╪»╪ª╪⌐ ╪º┘ä┘à╪¡╪│┘ê╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.computedPrefixLengthValue",
                TranslationValue = "{{count}} ╪▒┘é┘à/╪ú╪▒┘é╪º┘à ╪Ñ╪¼┘à╪º┘ä┘è ╪º┘ä╪¿╪º╪»╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.fixed",
                TranslationValue = "╪½╪º╪¿╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.previewLabel",
                TranslationValue = "┘å┘à┘ê╪░╪¼ ╪▒┘à╪▓ ╪¡╪│╪º╪¿ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪º┘ä╪╣╪º┘à ╪¿┘å╪º╪í┘ï ╪╣┘ä┘ë ╪º┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪¡╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.previewExample",
                TranslationValue = "┘à╪½╪º┘ä ╪º┘ä┘à╪│╪º╪▒: ╪º┘ä╪ú╪╡┘ê┘ä (┘à1) ΓåÉ ╪º┘ä╪ú╪╡┘ê┘ä ╪º┘ä┘à╪¬╪»╪º┘ê┘ä╪⌐ (┘à2) ΓåÉ ╪º┘ä┘å┘é╪» ┘ä╪»┘ë ╪º┘ä╪¿┘å┘â (╪ú╪│╪¬╪º╪░)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.noRecords",
                TranslationValue = "┘ä╪º ╪¬┘ê╪¼╪» ╪│╪¼┘ä╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.columnComingSoon",
                TranslationValue = "╪│╪¬┘â┘ê┘å ╪¬┘ç┘è╪ª╪⌐ ╪º┘ä╪ú╪╣┘à╪»╪⌐ ┘à╪¬╪º╪¡╪⌐ ┘é╪▒┘è╪¿┘ï╪º.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.selectedCount",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪» {{count}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.unmappedGlCodes",
                TranslationValue = "╪ú┘â┘ê╪º╪» ╪»┘ü╪¬╪▒ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪║┘è╪▒ ╪º┘ä┘à╪▒╪¿┘ê╪╖╪⌐: {{count}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.selectedGlCount",
                TranslationValue = "{{count}} ┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.searchGlCodes",
                TranslationValue = "╪¿╪¡╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.prefixLengthHint",
                TranslationValue = "╪ú╪¿╪¼╪»┘è ╪▒┘é┘à┘è ┘ê┘è╪¼╪¿ ╪ú┘å ┘è┘å╪¬┘ç┘è ╪¿╪▒┘é┘à. ┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪º┘ä╪╖┘ê┘ä ╪ú┘é┘ä ┘à┘å ╪╖┘ê┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ({{serialLength}}).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.childLengthHint",
                TranslationValue = "╪╖┘ê┘ä ╪º┘ä┘ü╪▒╪╣ ┘ç┘ê ╪╖┘ê┘ä ╪º┘ä╪ú╪╡┘ä ({{parent}}) ╪▓╪º╪ª╪» 1 ┘ê┘è╪¼╪¿ ╪ú┘å ┘è╪¿┘é┘ë ╪ú┘é┘ä ┘à┘å ╪╖┘ê┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ({{serialLength}}).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.inclusionHint",
                TranslationValue = "╪¿╪»┘æ┘ä ╪º┘ä╪╡┘ü┘ê┘ü ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘ä╪¬╪╢┘à┘è┘å┘ç╪º ╪ú┘ê ╪º╪│╪¬╪¿╪╣╪º╪»┘ç╪º ┘à┘å ┘ç╪░╪º ╪º┘ä╪ú╪╡┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.prefixHint",
                TranslationValue = "┘è╪¬┘à ╪Ñ┘å╪┤╪º╪í ╪º┘ä╪¿╪º╪»╪ª╪⌐ ╪¬┘ä┘é╪º╪ª┘è┘ï╪º ┘à┘å ╪¿╪º╪»╪ª╪⌐ ╪º┘ä╪ú╪╡┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.lengthHint",
                TranslationValue = "┘è┘Å╪¡╪│╪¿ ╪º┘ä╪╖┘ê┘ä ┘à┘å ╪º┘ä╪¿╪º╪»╪ª╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.unmappedGlCodes",
                TranslationValue = "{{count}} ╪▒┘à┘ê╪▓ ╪ú╪│╪¬╪º╪░ ╪║┘è╪▒ ┘à╪▒╪¬╪¿╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.startWithZero",
                TranslationValue = "╪º┘ä╪¿╪»╪í ┘à┘å 0",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.filterAndSearch",
                TranslationValue = "╪¬╪╡┘ü┘è╪⌐ ┘ê╪º┘ä╪¿╪¡╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.chartOfAccounts",
                TranslationValue = "╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.balanceSheet",
                TranslationValue = "╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.pnl",
                TranslationValue = "╪º┘ä╪ú╪▒╪¿╪º╪¡ ┘ê╪º┘ä╪«╪│╪º╪ª╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.scope",
                TranslationValue = "╪º┘ä┘å╪╖╪º┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.templateType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.templateGroup",
                TranslationValue = "┘à╪¼┘à┘ê╪╣╪⌐ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.category",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.consolidation",
                TranslationValue = "╪º┘ä╪¬┘ê╪¡┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.public",
                TranslationValue = "╪╣╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.default",
                TranslationValue = "╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.prefix",
                TranslationValue = "╪º┘ä╪¿╪º╪»╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.length",
                TranslationValue = "╪º┘ä╪╖┘ê┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.sortOrder",
                TranslationValue = "╪¬╪▒╪¬┘è╪¿ ╪º┘ä┘ü╪▒╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.hide",
                TranslationValue = "╪Ñ╪«┘ü╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.controlAccount",
                TranslationValue = "╪¡╪│╪º╪¿ ╪º┘ä╪▒┘é╪º╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.mappedTo",
                TranslationValue = "┘à╪▒╪¬╪¿╪╖ ╪¿┘Ç",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.accountType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪¡╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.glCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.templateHeader",
                TranslationValue = "╪▒╪ú╪│ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.codeConfiguration",
                TranslationValue = "╪¬┘â┘ê┘è┘å ╪º┘ä╪¬╪▒┘à┘è╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.flagsVisibility",
                TranslationValue = "╪º┘ä╪ú╪╣┘ä╪º┘à ┘ê╪º┘ä╪╕┘ç┘ê╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.generalInformation",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.templateGroupAction",
                TranslationValue = "┘à╪¼┘à┘ê╪╣╪⌐ ╪º┘ä┘é╪º┘ä╪¿ ┘ê╪º┘ä╪Ñ╪¼╪▒╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.reportingFiltering",
                TranslationValue = "╪º┘ä╪¬┘é╪º╪▒┘è╪▒ ┘ê╪º┘ä╪¬╪╡┘ü┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.companiesApplicable",
                TranslationValue = "╪º┘ä╪┤╪▒┘â╪º╪¬ ╪º┘ä┘à╪╖╪¿┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.flagsVisibility",
                TranslationValue = "╪º┘ä╪ú╪╣┘ä╪º┘à ┘ê╪º┘ä╪╕┘ç┘ê╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.assignedUsers",
                TranslationValue = "╪º┘ä┘à╪│╪¬╪«╪»┘à┘ê┘å ╪º┘ä┘à╪╣┘è┘å┘ê┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.codeConfiguration",
                TranslationValue = "╪Ñ╪╣╪»╪º╪» ╪╖┘ê┘ä ╪º┘ä┘â┘ê╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.serialLengthPerLevel",
                TranslationValue = "╪╖┘ê┘ä ╪º┘ä╪¬╪│┘ä╪│┘ä ┘ä┘â┘ä ┘à╪│╪¬┘ê┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.liveCodePreview",
                TranslationValue = "┘à╪╣╪º┘è┘å╪⌐ ╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪¿╪º╪┤╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.rowConfiguration",
                TranslationValue = "╪¬┘ç┘è╪ª╪⌐ ╪º┘ä╪╡┘ü┘ê┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.columnConfiguration",
                TranslationValue = "╪¬┘ç┘è╪ª╪⌐ ╪º┘ä╪ú╪╣┘à╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.criteriaItems",
                TranslationValue = "╪╣┘å╪º╪╡╪▒ ╪º┘ä┘à╪╣╪º┘è┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.invalidCategoryForTypeTitle",
                TranslationValue = "┘ü╪ª╪⌐ ┘é╪º┘ä╪¿ ╪║┘è╪▒ ╪╡╪º┘ä╪¡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.invalidCategoryForType",
                TranslationValue = "╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ┘ê╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪╡╪º┘ä╪¡╪º┘å ┘ü┘é╪╖ ┘ä┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐ ╪ú┘ê ╪º┘ä╪ú╪▒╪¿╪º╪¡ ┘ê╪º┘ä╪«╪│╪º╪ª╪▒.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.activeDefaultCoaExistsTitle",
                TranslationValue = "╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪║┘è╪▒ ┘à╪¬╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.activeDefaultCoaExists",
                TranslationValue = "┘è┘ê╪¼╪» ╪¿╪º┘ä┘ü╪╣┘ä ┘é╪º┘ä╪¿ ╪»┘ä┘è┘ä ╪¡╪│╪º╪¿╪º╪¬ ┘å╪┤╪╖ ┘ê╪º┘ü╪¬╪▒╪º╪╢┘è ┘ä┘Ç {{templateType}} - {{reportName}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeleteActive",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪¡╪░┘ü ╪º┘ä┘é┘ê╪º┘ä╪¿ ╪º┘ä┘å╪┤╪╖╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateTitle",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪Ñ┘ä╪║╪º╪í ╪¬┘å╪┤┘è╪╖ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateWithGlCodes",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪Ñ┘ä╪║╪º╪í ╪º┘ä╪¬┘å╪┤┘è╪╖: ╪¬┘ê╪¼╪» ╪▒┘à┘ê╪▓ ╪»┘ü╪¬╪▒ ╪ú╪│╪¬╪º╪░ ╪╣╪º┘à ╪¬╪¡╪¬ ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateWithBudget",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪Ñ┘ä╪║╪º╪í ╪º┘ä╪¬┘å╪┤┘è╪╖: ╪¬┘à ╪¬╪╣╪▒┘è┘ü ┘à┘è╪▓╪º┘å┘è╪⌐ ╪¿╪º╪│╪¬╪«╪»╪º┘à ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotClearDefaultTitle",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪Ñ┘ä╪║╪º╪í ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotClearDefault",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪¬╪╣┘è┘è┘å ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è ╪Ñ┘ä┘ë ┘ä╪º ╪¿┘è┘å┘à╪º ╪¬┘ê╪¼╪» ╪▒┘à┘ê╪▓ ╪»┘ü╪¬╪▒ ╪ú╪│╪¬╪º╪░ ╪╣╪º┘à ╪¬╪¡╪¬ ┘é╪º┘ä╪¿ ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ┘ç╪░╪º.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2Title",
                TranslationValue = "╪¬┘å╪¿┘è┘ç",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2Body",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë 1 ┘à┘é┘è╪» ╪¿╪▒┘é┘à ┘ê╪º╪¡╪» (┘è╪║╪╖┘è ╪º┘ä╪ú╪╡┘ä ┘ê╪º┘ä╪º┘ä╪¬╪▓╪º┘à ┘ê╪¡┘é┘ê┘é ╪º┘ä┘à┘ä┘â┘è╪⌐ ┘ê╪º┘ä╪Ñ┘è╪▒╪º╪» ┘ê╪º┘ä┘à╪╡╪▒┘ê┘ü ΓÇö ╪¿╪¡╪» ╪ú┘é╪╡┘ë 5 ┘é┘è┘à). ┘é┘à ╪¿╪¬┘â┘ê┘è┘å ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ┘à┘å 2 ┘ü╪╡╪º╪╣╪»┘ï╪º. ┘è╪¼╪¿ ╪ú┘ä╪º ┘è╪¬╪¼╪º┘ê╪▓ ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyBs",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë 1 ┘à┘é┘è╪» ╪¿╪▒┘é┘à ┘ê╪º╪¡╪» (┘è╪║╪╖┘è ╪º┘ä╪ú╪╡┘ä ┘ê╪º┘ä╪º┘ä╪¬╪▓╪º┘à ┘ê╪¡┘é┘ê┘é ╪º┘ä┘à┘ä┘â┘è╪⌐ ΓÇö ╪¿╪¡╪» ╪ú┘é╪╡┘ë 3 ┘é┘è┘à). ┘é┘à ╪¿╪¬┘â┘ê┘è┘å ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ┘à┘å 2 ┘ü╪╡╪º╪╣╪»┘ï╪º. ┘è╪¼╪¿ ╪ú┘ä╪º ┘è╪¬╪¼╪º┘ê╪▓ ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyPl",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë 1 ┘à┘é┘è╪» ╪¿╪▒┘é┘à ┘ê╪º╪¡╪» (┘è╪║╪╖┘è ╪º┘ä╪Ñ┘è╪▒╪º╪» ┘ê╪º┘ä┘à╪╡╪▒┘ê┘ü ΓÇö ╪¿╪¡╪» ╪ú┘é╪╡┘ë ┘é┘è┘à╪¬┘è┘å). ┘é┘à ╪¿╪¬┘â┘ê┘è┘å ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ┘à┘å 2 ┘ü╪╡╪º╪╣╪»┘ï╪º. ┘è╪¼╪¿ ╪ú┘ä╪º ┘è╪¬╪¼╪º┘ê╪▓ ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyCf",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë 1 ┘à┘é┘è╪» ╪¿╪▒┘é┘à ┘ê╪º╪¡╪» (┘è╪║╪╖┘è ╪º┘ä╪¬╪┤╪║┘è┘ä┘è ┘ê╪º┘ä╪º╪│╪¬╪½┘à╪º╪▒┘è ┘ê╪º┘ä╪¬┘à┘ê┘è┘ä┘è ΓÇö ╪¿╪¡╪» ╪ú┘é╪╡┘ë 3 ┘é┘è┘à). ┘é┘à ╪¿╪¬┘â┘ê┘è┘å ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ┘à┘å 2 ┘ü╪╡╪º╪╣╪»┘ï╪º. ┘è╪¼╪¿ ╪ú┘ä╪º ┘è╪¬╪¼╪º┘ê╪▓ ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyCe",
                TranslationValue = "╪º┘ä┘à╪│╪¬┘ê┘ë 1 ┘à┘é┘è╪» ╪¿╪▒┘é┘à ┘ê╪º╪¡╪» (┘è╪║╪╖┘è ╪▒╪ú╪│ ╪º┘ä┘à╪º┘ä ┘ê╪º┘ä╪º╪¡╪¬┘è╪º╪╖┘è╪º╪¬ ┘ê╪º┘ä╪ú╪▒╪¿╪º╪¡ ╪º┘ä┘à╪¡╪¬╪¼╪▓╪⌐ ΓÇö ╪¿╪¡╪» ╪ú┘é╪╡┘ë 3 ┘é┘è┘à). ┘é┘à ╪¿╪¬┘â┘ê┘è┘å ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ┘à┘å 2 ┘ü╪╡╪º╪╣╪»┘ï╪º. ┘è╪¼╪¿ ╪ú┘ä╪º ┘è╪¬╪¼╪º┘ê╪▓ ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.hierarchyLengthMismatch",
                TranslationValue = "╪╣┘å╪» ╪Ñ┘è┘é╪º┘ü ╪º┘ä╪¡╪┤┘ê ╪º┘ä┘à┘ê╪¡╪» ┘ä┘ä╪╖┘ê┘ä╪î ┘è╪¼╪¿ ╪ú┘å ┘è╪│╪º┘ê┘è ┘à╪¼┘à┘ê╪╣ ╪ú╪▒┘é╪º┘à ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘à╪╖╪▒┘ê╪¡┘ï╪º ┘à┘å┘ç ╪╖┘ê┘ä ╪¬╪│┘ä╪│┘ä ╪»┘ä┘è┘ä ╪º┘ä╪¡╪│╪º╪¿╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.noAssignableUsers",
                TranslationValue = "┘ä╪º ┘è┘ê╪¼╪» ┘à╪│╪¬╪«╪»┘à┘ê┘å ┘é╪º╪¿┘ä┘ê┘å ┘ä┘ä╪¬╪╣┘è┘è┘å ┘ä┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.usersAssigned",
                TranslationValue = "╪¬┘à ╪¬╪╣┘è┘è┘å ╪º┘ä┘à╪│╪¬╪«╪»┘à┘è┘å ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.userRemoved",
                TranslationValue = "╪¬┘à╪¬ ╪Ñ╪▓╪º┘ä╪⌐ ╪¬╪╣┘è┘è┘å ╪º┘ä┘à╪│╪¬╪«╪»┘à ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.configureComingSoon",
                TranslationValue = "╪│╪¬┘â┘ê┘å ╪¬┘ç┘è╪ª╪⌐ ╪º┘ä┘é╪º┘ä╪¿ ┘à╪¬╪º╪¡╪⌐ ┘é╪▒┘è╪¿┘ï╪º.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.restored",
                TranslationValue = "╪¬┘à╪¬ ╪º╪│╪¬╪╣╪º╪»╪⌐ ╪º┘ä┘é╪º┘ä╪¿ ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.glUnlinked",
                TranslationValue = "╪¬┘à ╪Ñ┘ä╪║╪º╪í ╪▒╪¿╪╖ ╪▒┘à╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowHidden",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ╪╕┘ç┘ê╪▒ ╪º┘ä╪╡┘ü ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.headerSaved",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ╪º┘ä╪▒╪ú╪│ ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.subCategoriesSaved",
                TranslationValue = "╪¬┘à ╪¡┘ü╪╕ ╪º┘ä┘ü╪ª╪º╪¬ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowsCopied",
                TranslationValue = "╪¬┘à ┘å╪│╪« ╪º┘ä╪╡┘ü┘ê┘ü ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.glLinked",
                TranslationValue = "╪¬┘à ╪▒╪¿╪╖ ╪▒┘à┘ê╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowDeleted",
                TranslationValue = "╪¬┘à ╪¡╪░┘ü ╪º┘ä╪╡┘ü ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.inclusionSaved",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ╪º┘ä╪¬╪╢┘à┘è┘å ╪¿┘å╪¼╪º╪¡.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeleteWithChildren",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪¡╪░┘ü ┘ç╪░╪º ╪º┘ä╪╡┘ü ┘ä╪ú┘å┘ç ┘è╪¡╪¬┘ê┘è ╪╣┘ä┘ë ╪╡┘ü┘ê┘ü ┘ü╪▒╪╣┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.duplicateSortOrder",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪¬╪▒╪¬┘è╪¿ ╪º┘ä┘ü╪▒╪▓ ┘ü╪▒┘è╪»┘ï╪º ╪¿┘è┘å ╪º┘ä╪╡┘ü┘ê┘ü ╪º┘ä╪┤┘é┘è┘é╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.duplicatePrefix",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ╪¬┘â┘ê┘å ╪º┘ä╪¿╪º╪»╪ª╪⌐ ┘ü╪▒┘è╪»╪⌐ ╪¿┘è┘å ╪º┘ä╪╡┘ü┘ê┘ü ╪º┘ä╪┤┘é┘è┘é╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.prefixBreaksChildren",
                TranslationValue = "╪│┘è╪ñ╪»┘è ╪¬╪║┘è┘è╪▒ ┘ç╪░┘ç ╪º┘ä╪¿╪º╪»╪ª╪⌐ ╪Ñ┘ä┘ë ╪Ñ╪¿╪╖╪º┘ä ╪¿╪º╪»╪ª╪º╪¬ ╪º┘ä╪╡┘ü┘ê┘ü ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ╪º┘ä╪¡╪º┘ä┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.rowLoadFailed",
                TranslationValue = "╪¬╪╣╪░╪▒ ╪¬╪¡┘à┘è┘ä ╪¬┘â┘ê┘è┘å ╪º┘ä╪╡┘ü┘ê┘ü.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Headers / Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.clearAssignmentsTitle",
                TranslationValue = "╪¼╪╣┘ä ╪º┘ä┘é╪º┘ä╪¿ ╪╣╪º┘à┘ï╪º╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.clearAssignments",
                TranslationValue = "╪│┘è╪¬┘à ┘à╪│╪¡ ╪¼┘à┘è╪╣ ╪¬╪╣┘è┘è┘å╪º╪¬ ╪º┘ä┘à╪│╪¬╪«╪»┘à┘è┘å ({{users}}). ┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪º┘ä┘à╪¬╪º╪¿╪╣╪⌐╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.setDefaultTitle",
                TranslationValue = "╪¬╪╣┘è┘è┘å ┘â╪º┘ü╪¬╪▒╪º╪╢┘è╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.setDefault",
                TranslationValue = "╪│┘è╪ñ╪»┘è ╪¬╪╣┘è┘è┘å ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿ ┘â╪º┘ü╪¬╪▒╪º╪╢┘è ╪Ñ┘ä┘ë ╪Ñ╪▓╪º┘ä╪⌐ ╪╣┘ä╪º┘à╪⌐ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è ╪¬┘ä┘é╪º╪ª┘è┘ï╪º ┘à┘å ╪º┘ä┘é╪º┘ä╪¿ ╪º┘ä╪º┘ü╪¬╪▒╪º╪╢┘è ╪º┘ä╪¡╪º┘ä┘è ┘ä┘å┘ü╪│ ┘å┘ê╪╣ ╪º┘ä┘é╪º┘ä╪¿. ┘ç┘ä ╪¬╪▒┘è╪» ╪º┘ä┘à╪¬╪º╪¿╪╣╪⌐╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.removeUserTitle",
                TranslationValue = "╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä┘à╪│╪¬╪«╪»┘à╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.removeUser",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪Ñ╪▓╪º┘ä╪⌐ ╪¬╪╣┘è┘è┘å ┘ç╪░╪º ╪º┘ä┘à╪│╪¬╪«╪»┘à╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.restoreTitle",
                TranslationValue = "╪º╪│╪¬╪╣╪º╪»╪⌐ ╪º┘ä┘é╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.restore",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪º╪│╪¬╪╣╪º╪»╪⌐ ┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.addNewHeader",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪▒╪ú╪│ ╪¼╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.editHeader",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪╣┘å┘ê╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.editRow",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.addSubCategory",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪ª╪⌐ ┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.copyFromTemplate",
                TranslationValue = "┘å╪│╪« ┘à┘å ┘é╪º┘ä╪¿ ┘à┘ê╪¼┘ê╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.linkGlCodes",
                TranslationValue = "╪▒╪¿╪╖ ╪▒┘à┘ê╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.manageInclusion",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä╪¬╪╢┘à┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.deleteRow",
                TranslationValue = "╪¡╪░┘ü ╪º┘ä╪╡┘ü╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.deleteGl",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í ╪▒╪¿╪╖ ╪▒┘à╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.deleteRow",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪¡╪░┘ü ┘ç╪░╪º ╪º┘ä╪╡┘ü╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.deleteGl",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪Ñ┘ä╪║╪º╪í ╪▒╪¿╪╖ ╪▒┘à╪▓ ╪º┘ä╪ú╪│╪¬╪º╪░ ┘ç╪░╪º╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.allowCrossPeriod",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘à┘â┘å ┘ä┘ç╪░╪º ╪º┘ä┘é╪º┘ä╪¿ ╪│╪¡╪¿ ╪º┘ä╪¿┘è╪º┘å╪º╪¬ ╪╣╪¿╪▒ ╪╣╪»╪⌐ ┘ü╪¬╪▒╪º╪¬ ┘à╪º┘ä┘è╪⌐ ╪¿╪»┘ä╪º┘ï ┘à┘å ┘ü╪¬╪▒╪⌐ ┘ê╪º╪¡╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.maxTotalCodeLength",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╣╪»╪» ╪º┘ä╪ú╪▒┘é╪º┘à ╪º┘ä┘à╪│┘à┘ê╪¡ ╪¿┘ç╪º ┘ü┘è ╪▒┘à╪▓ ╪¡╪│╪º╪¿ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪º┘ä╪╣╪º┘à ╪º┘ä┘â╪º┘à┘ä╪î ╪¿┘à╪º ┘ü┘è ╪░┘ä┘â ╪¼┘à┘è╪╣ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.coaSerialLength",
                TranslationValue = "╪º┘ä╪ú╪▒┘é╪º┘à ╪º┘ä┘à╪¡╪¼┘ê╪▓╪⌐ ┘ä╪▒┘é┘à ╪º┘ä╪¡╪│╪º╪¿ ╪╣┘ä┘ë ┘à╪│╪¬┘ê┘ë ╪º┘ä┘ê╪▒┘é╪⌐. ╪º┘ä╪¡╪» ╪º┘ä╪ú╪»┘å┘ë: 2. ┘è╪¬┘à ╪╖╪▒╪¡┘ç╪º ┘à┘å ╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ┘ä╪╖┘ê┘ä ╪º┘ä╪▒┘à╪▓ ┘ä╪¡╪│╪º╪¿ ╪º┘ä┘à╪│╪¬┘ê┘è╪º╪¬ ╪º┘ä┘à╪¬╪º╪¡╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬┘é┘ê┘è┘à ┘à╪¡╪º╪│╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.cancel",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.saveasdraft",
                TranslationValue = "╪¡┘ü╪╕ ┘â┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.saveandcontinue",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘à╪¬╪º╪¿╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.save",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.skip",
                TranslationValue = "╪¬╪«╪╖┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.share",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.addcompany",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.removecompany",
                TranslationValue = "╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.generateperiods",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ╪º┘ä┘ü╪¬╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.calendarcode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.calendarname",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.numberofperiodsperyear",
                TranslationValue = "╪╣╪»╪» ╪º┘ä┘ü╪¬╪▒╪º╪¬ ┘ü┘è ╪º┘ä╪│┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.fiscalyear",
                TranslationValue = "╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.fiscalyearstartmonth",
                TranslationValue = "╪┤┘ç╪▒ ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.createdby",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.createddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.updatedby",
                TranslationValue = "╪¡┘Å╪»┘æ╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.columnheader.updateddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.calendarcode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.calendarname",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.periodtype",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fiscalyearstartmonth",
                TranslationValue = "╪┤┘ç╪▒ ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fiscalyearendmonth",
                TranslationValue = "╪┤┘ç╪▒ ┘å┘ç╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.numberofperiodsperyear",
                TranslationValue = "╪╣╪»╪» ╪º┘ä┘ü╪¬╪▒╪º╪¬ ┘ü┘è ╪º┘ä╪│┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.startfiscalyear",
                TranslationValue = "╪│┘å╪⌐ ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.endfiscalyear",
                TranslationValue = "╪│┘å╪⌐ ┘å┘ç╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.status",
                TranslationValue = "╪¡╪º┘ä╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.adjustmentperiodsallowed",
                TranslationValue = "╪º┘ä╪│┘à╪º╪¡ ╪¿┘ü╪¬╪▒╪º╪¬ ╪º┘ä╪¬╪│┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.numberofadjustmentperiods",
                TranslationValue = "╪╣╪»╪» ┘ü╪¬╪▒╪º╪¬ ╪º┘ä╪¬╪│┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sequentialcloseenforcement",
                TranslationValue = "┘ü╪▒╪╢ ╪º┘ä╪Ñ╪║┘ä╪º┘é ╪º┘ä┘à╪¬╪│┘ä╪│┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.statusactive",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.statusinactive",
                TranslationValue = "╪║┘è╪▒ ┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.statusdraft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.periodname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.periodnumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.startdate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¿╪»╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.enddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä┘å┘ç╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fiscalyear",
                TranslationValue = "╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.quarter",
                TranslationValue = "╪º┘ä╪▒╪¿╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.defaultstatus",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.regular",
                TranslationValue = "╪╣╪º╪»┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.adjustment",
                TranslationValue = "╪¬╪│┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtype",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.eligiblecompanies",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtypeglobal",
                TranslationValue = "╪╣╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtypeshared",
                TranslationValue = "┘à╪┤╪¬╪▒┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "entity.accountingCalendar",
                TranslationValue = "╪¬┘é┘ê┘è┘à ┘à╪¡╪º╪│╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "entity.accountingPeriod",
                TranslationValue = "┘ü╪¬╪▒╪⌐ ┘à╪¡╪º╪│╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.calendartitle",
                TranslationValue = "╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.summary",
                TranslationValue = "┘à┘ä╪«╪╡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.owner",
                TranslationValue = "╪º┘ä┘à╪º┘ä┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.assignedto",
                TranslationValue = "┘à┘Å╪│┘å╪» ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.viewingcompany",
                TranslationValue = "╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä┘à╪╣╪▒┘ê╪╢╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.selectcompany",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.allfiscalyears",
                TranslationValue = "╪¼┘à┘è╪╣ ╪º┘ä╪│┘å┘ê╪º╪¬ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fiscalyears",
                TranslationValue = "╪º┘ä╪│┘å┘ê╪º╪¬ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fypattern",
                TranslationValue = "┘å┘à╪╖ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.fystart",
                TranslationValue = "╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.totalperiods",
                TranslationValue = "╪Ñ╪¼┘à╪º┘ä┘è ╪º┘ä┘ü╪¬╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.openperiods",
                TranslationValue = "╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪º┘ä┘à┘ü╪¬┘ê╪¡╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.closedlocked",
                TranslationValue = "┘à╪║┘ä┘é / ┘à┘é┘ü┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.closedorpermanentlyclosed",
                TranslationValue = "┘à╪║┘ä┘é ╪ú┘ê ┘à╪║┘ä┘é ┘å┘ç╪º╪ª┘è┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.currentlyopenforposting",
                TranslationValue = "┘à┘ü╪¬┘ê╪¡ ╪¡╪º┘ä┘è┘ï╪º ┘ä┘ä╪¬╪▒╪¡┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.noassignedcompanies",
                TranslationValue = "┘ä╪º ╪¬┘ê╪¼╪» ╪┤╪▒┘â╪º╪¬ ┘à┘Å╪│┘å╪»╪⌐ ╪¿╪╣╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.addcompanyplaceholder",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪┤╪▒┘â╪⌐ / ╪º┘ä┘â┘è╪º┘å ╪º┘ä┘é╪º┘å┘ê┘å┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtypeglobaldescription",
                TranslationValue = "╪│┘è┘â┘ê┘å ╪º┘ä╪│╪¼┘ä ┘à╪¬╪º╪¡┘ï╪º ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬ ╪»┘ê┘å ╪ú┘è ┘é┘è┘ê╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtyperestricted",
                TranslationValue = "┘à┘é┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtyperestricteddescription",
                TranslationValue = "╪│┘è┘é╪¬╪╡╪▒ ╪¬┘ê┘ü╪▒ ╪º┘ä╪│╪¼┘ä ╪╣┘ä┘ë ╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä╪¡╪º┘ä┘è╪⌐ ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharingtypeshareddescription",
                TranslationValue = "╪│┘è┘â┘ê┘å ╪º┘ä╪│╪¼┘ä ┘à╪¬╪º╪¡┘ï╪º ┘ä┘ä╪┤╪▒┘â╪º╪¬ ╪º┘ä┘à┘Å╪│┘å╪»╪⌐ / ╪º┘ä┘à╪¡╪»╪»╪⌐ ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.restrictedinfobanner",
                TranslationValue = "╪│┘è┘é╪¬╪╡╪▒ ╪¬┘ê┘ü╪▒ ╪º┘ä╪│╪¼┘ä ╪╣┘ä┘ë ╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä╪¡╪º┘ä┘è╪⌐ ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.globalinfobanner",
                TranslationValue = "╪│┘è┘â┘ê┘å ┘ç╪░╪º ╪º┘ä╪¬┘é┘ê┘è┘à ┘à╪¬╪º╪¡┘ï╪º ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬ ╪»┘ê┘å ╪ú┘è ┘é┘è┘ê╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sharedinfobanner",
                TranslationValue = "╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è ┘ê╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬ ┘à╪┤╪¬╪▒┘â╪⌐. ╪│┘è╪¬┘à ╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪¿╪┤┘â┘ä ┘à┘å┘ü╪╡┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.changesappliedonsave",
                TranslationValue = "╪│┘è╪¬┘à ╪¬╪╖╪¿┘è┘é ╪º┘ä╪¬╪║┘è┘è╪▒╪º╪¬ ╪╣┘å╪» ╪º┘ä╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.saveheaderfirst",
                TranslationValue = "╪º╪¡┘ü╪╕ ╪▒╪ú╪│ ╪º┘ä╪¬┘é┘ê┘è┘à ╪ú┘ê┘ä╪º┘ï ┘ä╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘ü╪¬╪▒╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.reviewcustomperiods",
                TranslationValue = "╪▒╪º╪¼╪╣ ┘ê╪╣╪»┘æ┘ä ╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪º┘ä┘à┘Å┘å╪┤╪ú╪⌐ ┘é╪¿┘ä ╪º┘ä╪¡┘ü╪╕.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.generatingperiods",
                TranslationValue = "╪¼╪º╪▒┘ì ╪Ñ┘å╪┤╪º╪í ╪º┘ä┘ü╪¬╪▒╪º╪¬...",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.loadingperiods",
                TranslationValue = "╪¼╪º╪▒┘ì ╪¬╪¡┘à┘è┘ä ╪º┘ä┘ü╪¬╪▒╪º╪¬...",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.recommendedmaxadjustmentperiods",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä╪ú┘é╪╡┘ë ╪º┘ä┘à┘ê╪╡┘ë ╪¿┘ç ┘ç┘ê 4 ┘ü╪¬╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.adjustmentperiodsalloweddescription",
                TranslationValue = "╪º┘ä╪│┘à╪º╪¡ ╪¿┘ü╪¬╪▒╪º╪¬ ╪Ñ╪╢╪º┘ü┘è╪⌐ ╪«╪º╪▒╪¼ ╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪º┘ä┘è ╪º┘ä┘à╪╣╪¬╪º╪» ┘ä╪¬╪│┘ê┘è╪º╪¬ ┘å┘ç╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.label.sequentialcloseenforcementdescription",
                TranslationValue = "┘è╪¬╪╖┘ä╪¿ ╪Ñ╪║┘ä╪º┘é ╪º┘ä┘ü╪¬╪▒╪⌐ ╪º┘ä╪│╪º╪¿┘é╪⌐ ┘é╪¿┘ä ╪Ñ┘à┘â╪º┘å┘è╪⌐ ╪Ñ╪║┘ä╪º┘é ╪º┘ä┘ü╪¬╪▒╪⌐ ╪º┘ä╪¬╪º┘ä┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.calendarcode",
                TranslationValue = "╪ú╪»╪«┘ä ╪▒┘à╪▓ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.calendarname",
                TranslationValue = "╪ú╪»╪«┘ä ╪º╪│┘à ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.description",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.periodtype",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.fiscalyearstartmonth",
                TranslationValue = "╪º╪«╪¬╪▒ ╪┤┘ç╪▒ ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.fiscalyearendmonth",
                TranslationValue = "╪º╪«╪¬╪▒ ╪┤┘ç╪▒ ┘å┘ç╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.placeholder.numberofadjustmentperiods",
                TranslationValue = "╪º╪«╪¬╪▒ ╪╣╪»╪» ┘ü╪¬╪▒╪º╪¬ ╪º┘ä╪¬╪│┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.notification.periodsgeneratedsuccess",
                TranslationValue = "╪¬┘à ╪Ñ┘å╪┤╪º╪í ╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è ┘ê╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.notification.periodsgeneratefailed",
                TranslationValue = "┘ü╪┤┘ä ╪Ñ┘å╪┤╪º╪í ╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪º┘ä┘à╪¡╪º╪│╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.notification.sharedsuccess",
                TranslationValue = "╪¬┘à╪¬ ┘à╪┤╪º╪▒┘â╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.notification.sharefailed",
                TranslationValue = "┘ü╪┤┘ä╪¬ ┘à╪┤╪º╪▒┘â╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.notification.deleteblockedbypostedtransactions",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪¡╪░┘ü ┘ç╪░╪º ╪º┘ä╪¬┘é┘ê┘è┘à ┘ä┘ê╪¼┘ê╪» ┘à╪╣╪º┘à┘ä╪º╪¬ ┘à╪▒╪¬╪¿╪╖╪⌐ ╪¿┘ç",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendarheader",
                TranslationValue = "╪▒╪ú╪│ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendarheadersubtitle",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä╪ú╪│╪º╪│┘è╪⌐ ┘ê╪º┘ä┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendaridentity",
                TranslationValue = "┘ç┘ê┘è╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendarperiod",
                TranslationValue = "┘ü╪¬╪▒╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendarperiodsubtitle",
                TranslationValue = "╪Ñ┘å╪┤╪º╪í ╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪º┘ä┘à╪¡╪º╪│╪¿┘è╪⌐ ┘ê╪Ñ╪»╪º╪▒╪¬┘ç╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.calendarsharing",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.sectionheader.periodconfiguration",
                TranslationValue = "╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AC",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Masters List (Grid)
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.commonButtons.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.calendarCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.calendarName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪¬┘é┘ê┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.numberOfPeriodsPerYear",
                TranslationValue = "╪╣╪»╪» ╪º┘ä┘ü╪¬╪▒╪º╪¬ ┘ü┘è ╪º┘ä╪│┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.fiscalYear",
                TranslationValue = "╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.fiscalYearStartMonth",
                TranslationValue = "╪┤┘ç╪▒ ╪¿╪»╪º┘è╪⌐ ╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.createdByName",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.accountingCalendar.columnHeader.updatedByName",
                TranslationValue = "╪¡┘Å╪»┘æ╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.periodname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.startdate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¿╪»╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.enddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä┘å┘ç╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.iscurrent",
                TranslationValue = "╪º┘ä┘ü╪¬╪▒╪⌐ ╪º┘ä╪¡╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.fiscalyear",
                TranslationValue = "╪º┘ä╪│┘å╪⌐ ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.quarter",
                TranslationValue = "╪º┘ä╪▒╪¿╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.postingaccess",
                TranslationValue = "╪╡┘ä╪º╪¡┘è╪⌐ ╪º┘ä╪¬╪▒╪¡┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.columnheader.module",
                TranslationValue = "╪º┘ä┘ê╪¡╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.open",
                TranslationValue = "┘ü╪¬╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.closepending",
                TranslationValue = "╪¿╪º┘å╪¬╪╕╪º╪▒ ╪º┘ä╪Ñ╪║┘ä╪º┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.close",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.openselected",
                TranslationValue = "┘ü╪¬╪¡ ╪º┘ä┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.closependingselected",
                TranslationValue = "╪¿╪º┘å╪¬╪╕╪º╪▒ ╪Ñ╪║┘ä╪º┘é ╪º┘ä┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.closeselected",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é ╪º┘ä┘à╪¡╪»╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.permanentlyclose",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é ┘å┘ç╪º╪ª┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.reopen",
                TranslationValue = "╪Ñ╪╣╪º╪»╪⌐ ┘ü╪¬╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.setcurrent",
                TranslationValue = "╪¬╪╣┘è┘è┘å ┘â┘ü╪¬╪▒╪⌐ ╪¡╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.moreactions",
                TranslationValue = "╪º┘ä┘à╪▓┘è╪» ┘à┘å ╪º┘ä╪Ñ╪¼╪▒╪º╪í╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.sort",
                TranslationValue = "┘ü╪▒╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.clearsort",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í ╪º┘ä┘ü╪▒╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.actionbutton.selectcolumns",
                TranslationValue = "╪¬╪¡╪»┘è╪» ╪º┘ä╪ú╪╣┘à╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.neveropened",
                TranslationValue = "┘ä┘à ┘è╪¬┘à ┘ü╪¬╪¡┘ç╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.menu.edm.accountingCalendar",
                TranslationValue = "╪º┘ä╪¬┘é┘ê┘è┘à ╪º┘ä┘à╪¡╪º╪│╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.current",
                TranslationValue = "╪º┘ä╪¡╪º┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.periodsselected",
                TranslationValue = "╪º┘ä┘ü╪¬╪▒╪º╪¬ ╪º┘ä┘à╪¡╪»╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.changestatus",
                TranslationValue = "╪¬╪║┘è┘è╪▒ ╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.tab.lable.summary",
                TranslationValue = "┘à┘ä╪«╪╡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.legalentities",
                TranslationValue = "╪º┘ä┘â┘è╪º┘å╪º╪¬ ╪º┘ä┘é╪º┘å┘ê┘å┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.label.addcompany",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.validation.actionfailed",
                TranslationValue = "╪¬╪╣╪░╪▒ ╪¬╪¡╪»┘è╪½ ╪¡╪º┘ä╪⌐ ╪º┘ä┘ü╪¬╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.validation.glmustbeopenfirst",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ┘ü╪¬╪¡ ╪º┘ä┘ü╪¬╪▒╪⌐ ╪º┘ä┘à╪¡╪º╪│╪¿┘è╪⌐ ╪¡╪¬┘ë ┘è╪¬┘à ┘ü╪¬╪¡┘ç╪º ┘ü┘è ╪»┘ü╪¬╪▒ ╪º┘ä╪ú╪│╪¬╪º╪░ ╪º┘ä╪╣╪º┘à.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.validation.sequentialcloseviolation",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ╪¬┘â┘ê┘å ╪º┘ä┘ü╪¬╪▒╪⌐ ╪º┘ä┘à╪¡╪º╪│╪¿┘è╪⌐ ╪º┘ä╪│╪º╪¿┘é╪⌐ ┘à╪║┘ä┘é╪⌐ (╪ú┘ê ╪¿╪º┘å╪¬╪╕╪º╪▒ ╪º┘ä╪Ñ╪║┘ä╪º┘é╪î ╪Ñ╪░╪º ╪¬┘à ╪¬┘â┘ê┘è┘å ╪░┘ä┘â) ┘é╪¿┘ä ┘ü╪¬╪¡ ┘ç╪░┘ç ╪º┘ä┘ü╪¬╪▒╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.validation.singlecurrentpermodule",
                TranslationValue = "┘è┘à┘â┘å ╪¬╪¡╪»┘è╪» ┘ü╪¬╪▒╪⌐ ┘à╪¡╪º╪│╪¿┘è╪⌐ ┘ê╪º╪¡╪»╪⌐ ┘ü┘é╪╖ ┘â┘ü╪¬╪▒╪⌐ ╪¡╪º┘ä┘è╪⌐ ┘ä┘â┘ä ┘ê╪¡╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.placeholder.searchperiods",
                TranslationValue = "╪º┘ä╪¿╪¡╪½ ┘ü┘è ╪º┘ä┘ü╪¬╪▒╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Period Management ΓåÆ Period Type
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.periodtype.adjustment",
                TranslationValue = "╪¬╪│┘ê┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingperiodmanagement.periodtype.regular",
                TranslationValue = "╪╣╪º╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-AP",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Authority ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¼┘ç╪⌐ ╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Authority ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "entity.taxAuthority",
                TranslationValue = "╪º┘ä╪¼┘ç╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.breadcrumb.title",
                TranslationValue = "╪º┘ä╪¼┘ç╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.breadcrumb.title.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä╪¼┘ç╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.filingFrequency",
                TranslationValue = "╪¬┘â╪▒╪º╪▒ ╪º┘ä╪¬┘é╪»┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.linkedSupplier",
                TranslationValue = "╪º┘ä┘à┘ê╪▒╪» ╪º┘ä┘à╪▒╪¬╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Authority ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.placeholder.country",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.placeholder.filingFrequency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¬┘â╪▒╪º╪▒ ╪º┘ä╪¬┘é╪»┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.placeholder.linkedSupplier",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à┘ê╪▒╪» ╪º┘ä┘à╪▒╪¬╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Authority ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.detail.generalInformation.sectionHeader.title",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Authority ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.linkedSupplier",
                TranslationValue = "╪º┘ä┘à┘ê╪▒╪» ╪º┘ä┘à╪▒╪¬╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.filingFrequency",
                TranslationValue = "╪¬┘â╪▒╪º╪▒ ╪º┘ä╪¬┘é╪»┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.columnHeader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Jurisdiction ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.actionButton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ê┘ä╪º┘è╪⌐ ╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Jurisdiction ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "entity.taxJurisdiction",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.breadcrumb.title",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.breadcrumb.title.view",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä┘ê┘ä╪º┘è╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.name",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.authority",
                TranslationValue = "╪º┘ä╪¼┘ç╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Jurisdiction ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.placeholder.country",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.placeholder.currency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Jurisdiction ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.detail.generalInformation.sectionHeader.title",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Jurisdiction ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.name",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.jurisdiction",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.authority",
                TranslationValue = "╪º┘ä╪¼┘ç╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.country",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.columnHeader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "entity.currencyMaster",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumb",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbAdd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbEdit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbView",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.generalInformation",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.displayFormatting",
                TranslationValue = "╪º┘ä╪╣╪▒╪╢ / ╪º┘ä╪¬┘å╪│┘è┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.countryAndPeg",
                TranslationValue = "╪º┘ä╪»┘ê┘ä╪⌐ ┘ê╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.lifecycleAndStatus",
                TranslationValue = "╪»┘ê╪▒╪⌐ ╪º┘ä╪¡┘è╪º╪⌐ ┘ê╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyName",
                TranslationValue = "╪º┘ä╪º╪│┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyNameHint",
                TranslationValue = "┘à╪¡╪»╪» ISO 4217╪¢ ┘è┘à┘ä╪ú ╪¡┘é┘ê┘ä ╪º┘ä┘ç┘ê┘è╪⌐ ╪¬┘ä┘é╪º╪ª┘è╪º┘ï.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyCodeHint",
                TranslationValue = "╪¬┘ä┘é╪º╪ª┘è ΓÇö ┘à┘å ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘à╪¡╪»╪»╪⌐ (┘é┘è╪º╪│┘è╪î ┘ä┘ä┘é╪▒╪º╪í╪⌐ ┘ü┘é╪╖).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoCode",
                TranslationValue = "╪▒┘à╪▓ ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoCodeHint",
                TranslationValue = "╪¬┘ä┘é╪º╪ª┘è ΓÇö ┘à┘å ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘à╪¡╪»╪»╪⌐ (┘é┘è╪º╪│┘è╪î ┘ä┘ä┘é╪▒╪º╪í╪⌐ ┘ü┘é╪╖).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoNumeric",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪▒┘é┘à┘è ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoNumericHint",
                TranslationValue = "┘è┘Å╪¡┘à┘æ┘ä ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ┘à┘å ╪╣┘à┘ä╪⌐ ISO 4217 ╪º┘ä┘à╪¡╪»╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.shortCodeHint",
                TranslationValue = "┘è┘Å┘à┘ä╪ú ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ╪¿╪▒┘à╪▓ ISO ΓÇö ┘é╪º╪¿┘ä ┘ä┘ä╪¬╪╣╪»┘è┘ä (╪º╪│┘à ╪»╪º╪«┘ä┘è).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencySymbol",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪▒┘à╪▓┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencySymbolHint",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä╪ú╪╡┘ä┘è ┘à┘å ╪¿┘è╪º┘å╪º╪¬ ISO 4217 (┘ä┘ä┘é╪▒╪º╪í╪⌐ ┘ü┘é╪╖).",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.countryOfIssue",
                TranslationValue = "╪»┘ê┘ä╪⌐ ╪º┘ä╪Ñ╪╡╪»╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isPegged",
                TranslationValue = "┘à╪▒╪¬╪¿╪╖╪⌐ ╪¿╪│╪╣╪▒ ╪½╪º╪¿╪¬╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isPeggedHint",
                TranslationValue = "┘è╪¬╪¡┘â┘à ┘ü┘è ╪¡┘é┘ä┘è ╪º┘ä╪▒╪¿╪╖ ┘ê┘à╪╣╪»┘ä ╪º┘ä╪▒╪¿╪╖ ╪ú╪»┘å╪º┘ç.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedTo",
                TranslationValue = "┘à╪▒╪¬╪¿╪╖╪⌐ ╪¿┘Ç",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedToHint",
                TranslationValue = "╪┤╪▒╪╖┘è ΓÇö ┘à╪╖┘ä┘ê╪¿ ╪Ñ╪░╪º ┘â╪º┘å╪¬ ┘à╪▒╪¬╪¿╪╖╪⌐ = ┘å╪╣┘à.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedRate",
                TranslationValue = "┘à╪╣╪»┘ä ╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedRateHint",
                TranslationValue = "┘à╪╣╪»┘ä ╪½╪º╪¿╪¬╪¢ ┘è╪¬╪¼╪º┘ê╪▓ ╪¬╪║╪░┘è╪⌐ ╪ú╪│╪╣╪º╪▒ ╪º┘ä╪╡╪▒┘ü ╪º┘ä┘è┘ê┘à┘è╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveFrom",
                TranslationValue = "╪│╪º╪▒┘è ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveTo",
                TranslationValue = "╪│╪º╪▒┘è ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveToHint",
                TranslationValue = "┘ü╪º╪▒╪║ = ╪¬╪¿┘é┘ë ╪º┘ä╪╣┘à┘ä╪⌐ ┘å╪┤╪╖╪⌐ ╪Ñ┘ä┘ë ╪ú╪¼┘ä ╪║┘è╪▒ ┘à╪│┘à┘ë.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isTransactional",
                TranslationValue = "┘é╪º╪¿┘ä╪⌐ ┘ä┘ä┘à╪╣╪º┘à┘ä╪º╪¬╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isTransactionalHint",
                TranslationValue = "┘ä╪º = ╪¬┘Å╪│╪¬╪¿╪╣╪» ┘à┘å ┘é┘ê╪º╪ª┘à ╪º╪«╪¬┘è╪º╪▒ ╪╣┘à┘ä╪º╪¬ ╪º┘ä┘à╪╣╪º┘à┘ä╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isReporting",
                TranslationValue = "┘é╪º╪¿┘ä╪⌐ ┘ä┘ä╪¬┘é╪º╪▒┘è╪▒╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isReportingHint",
                TranslationValue = "┘ä╪º = ╪¬┘Å╪│╪¬╪¿╪╣╪» ┘à┘å ╪╣┘ê╪º┘à┘ä ╪¬╪╡┘ü┘è╪⌐ ╪╣┘à┘ä╪º╪¬ ╪º┘ä╪¬┘é╪º╪▒┘è╪▒/╪º┘ä╪¬╪¡┘ä┘è┘ä╪º╪¬.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.yes",
                TranslationValue = "┘å╪╣┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.no",
                TranslationValue = "┘ä╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.inactive",
                TranslationValue = "╪║┘è╪▒ ┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.displayMode",
                TranslationValue = "┘ê╪╢╪╣ ╪º┘ä╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.displayModeHint",
                TranslationValue = "╪º┘ä╪¬╪¿╪»┘è┘ä ╪¿┘è┘å ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪ú╪╡┘ä┘è ┘ê╪º┘ä╪▒┘à╪▓ ╪╣┘ä┘ë ┘à╪│╪¬┘ê┘ë ╪º┘ä┘å╪╕╪º┘à.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.symbolPlacement",
                TranslationValue = "┘à┘ê╪╢╪╣ ╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.symbolSpacing",
                TranslationValue = "╪¬╪¿╪º╪╣╪» ╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.decimalPrecision",
                TranslationValue = "╪º┘ä╪»┘é╪⌐ ╪º┘ä╪╣╪┤╪▒┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.thousandSeparator",
                TranslationValue = "┘ü╪º╪╡┘ä ╪º┘ä╪ó┘ä╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.decimalSeparator",
                TranslationValue = "╪º┘ä┘ü╪º╪╡┘ä ╪º┘ä╪╣╪┤╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.negativeFormat",
                TranslationValue = "╪¬┘å╪│┘è┘é ╪º┘ä╪ú╪▒┘é╪º┘à ╪º┘ä╪│╪º┘ä╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isNegativeRed",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä╪ú╪▒┘é╪º┘à ╪º┘ä╪│╪º┘ä╪¿╪⌐ ╪¿╪º┘ä╪ú╪¡┘à╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.roundingMethod",
                TranslationValue = "╪╖╪▒┘è┘é╪⌐ ╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.roundingPrecision",
                TranslationValue = "╪»┘é╪⌐ ╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreview",
                TranslationValue = "┘à╪╣╪º┘è┘å╪⌐ ┘à╪¿╪º╪┤╪▒╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreviewAmount",
                TranslationValue = "┘à╪╣╪º┘è┘å╪⌐ ┘à╪¿╪º╪┤╪▒╪⌐ ΓÇö ╪º┘ä┘à╪¿┘ä╪║",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreviewNegative",
                TranslationValue = "┘à╪╣╪º┘è┘å╪⌐ ┘à╪¿╪º╪┤╪▒╪⌐ ΓÇö ╪º┘ä╪│╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.displayModeSymbol",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.displayModeIsoCode",
                TranslationValue = "╪▒┘à╪▓ ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.placementPrefix",
                TranslationValue = "╪¿╪º╪»╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.placementSuffix",
                TranslationValue = "┘ä╪º╪¡┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.spacingSpace",
                TranslationValue = "┘à╪│╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.spacingNoSpace",
                TranslationValue = "╪¿╪»┘ê┘å ┘à╪│╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorComma",
                TranslationValue = "┘ü╪º╪╡┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorDot",
                TranslationValue = "┘å┘é╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorSpace",
                TranslationValue = "┘à╪│╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.negativeParentheses",
                TranslationValue = "╪ú┘é┘ê╪º╪│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.negativeMinus",
                TranslationValue = "╪│╪º┘ä╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingBankers",
                TranslationValue = "╪¬┘é╪▒┘è╪¿ ╪º┘ä┘à╪╡╪▒┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingHalfUp",
                TranslationValue = "╪¬┘é╪▒┘è╪¿ ╪º┘ä┘å╪╡┘ü ┘ä╪ú╪╣┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingHalfDown",
                TranslationValue = "╪¬┘é╪▒┘è╪¿ ╪º┘ä┘å╪╡┘ü ┘ä╪ú╪│┘ü┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.currencyCode",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.currencyName",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.shortCode",
                TranslationValue = "╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.symbol",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.decimalPrecision",
                TranslationValue = "╪º┘ä╪»┘é╪⌐ ╪º┘ä╪╣╪┤╪▒┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.createdDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.createdBy",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.updatedDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.updatedBy",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.currency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.autoFilled",
                TranslationValue = "┘è┘Å┘à┘ä╪ú ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ┘à┘å ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.shortCode",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪▒┘à╪▓ ╪º┘ä┘à╪«╪¬╪╡╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.decimalPrecision",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä╪»┘é╪⌐ ╪º┘ä╪╣╪┤╪▒┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.symbolSpacing",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘à╪│╪º┘ü╪⌐ ╪¿╪¼╪º┘å╪¿ ╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.thousandSeparator",
                TranslationValue = "╪º╪«╪¬╪▒ ┘ü╪º╪╡┘ä ╪º┘ä╪ó┘ä╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.decimalSeparator",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä┘ü╪º╪╡┘ä ╪º┘ä╪╣╪┤╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.negativeFormat",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¬┘å╪│┘è┘é ╪º┘ä┘é┘è┘à ╪º┘ä╪│╪º┘ä╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.roundingMethod",
                TranslationValue = "╪º╪«╪¬╪▒ ╪╖╪▒┘è┘é╪⌐ ╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.roundingPrecision",
                TranslationValue = "╪ú╪»╪«┘ä ╪»┘é╪⌐ ╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.countryOfIssue",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¿┘ä╪» ╪º┘ä╪Ñ╪╡╪»╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.peggedTo",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘à╪▒╪¿┘ê╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.peggedRate",
                TranslationValue = "╪ú╪»╪«┘ä ┘à╪╣╪»┘ä ╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.selectOption",
                TranslationValue = "╪º╪«╪¬╪▒ ╪«┘è╪º╪▒╪º┘ï",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.addCurrency",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.share",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.currencyAlreadyExists",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä┘à╪¡╪»╪»╪⌐ ┘à┘ê╪¼┘ê╪»╪⌐ ╪¿╪º┘ä┘ü╪╣┘ä ┘ü┘è ╪º┘ä┘å╪╕╪º┘à.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.isoNumericUnique",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪º┘ä╪▒┘à╪▓ ╪º┘ä╪▒┘é┘à┘è ISO ┘ü╪▒┘è╪»╪º┘ï.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.separatorsSame",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ┘è┘â┘ê┘å ┘ü╪º╪╡┘ä ╪º┘ä╪ó┘ä╪º┘ü ┘ê╪º┘ä┘ü╪º╪╡┘ä ╪º┘ä╪╣╪┤╪▒┘è ┘à╪¬┘à╪º╪½┘ä┘è┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.roundingPrecisionAlign",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ╪¬╪¬┘ê╪º┘ü┘é ╪»┘é╪⌐ ╪º┘ä╪¬┘é╪▒┘è╪¿ ┘à╪╣ ╪º┘ä┘à┘å╪º╪▓┘ä ╪º┘ä╪╣╪┤╪▒┘è╪⌐ ╪º┘ä┘à╪¡╪»╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.peggedToRequired",
                TranslationValue = "╪¡╪»╪» ╪╣┘à┘ä╪⌐ ┘ä┘ä╪▒╪¿╪╖ ╪¿┘ç╪º.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.peggedRateGreaterThanZero",
                TranslationValue = "╪ú╪»╪«┘ä ┘à╪╣╪»┘ä ╪▒╪¿╪╖ ╪╡╪º┘ä╪¡╪º┘ï ╪ú┘â╪¿╪▒ ┘à┘å ╪╡┘ü╪▒.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.peggedToSameCurrency",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪▒╪¿╪╖ ╪º┘ä╪╣┘à┘ä╪⌐ ╪¿┘å┘ü╪│┘ç╪º. ┘è╪▒╪¼┘ë ╪º╪«╪¬┘è╪º╪▒ ╪╣┘à┘ä╪⌐ ┘à╪«╪¬┘ä┘ü╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.effectiveFromRequired",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å ┘à┘å ┘à╪╖┘ä┘ê╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.effectiveDateOrder",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å ┘à┘å ┘ü┘è ╪ú┘ê ┘é╪¿┘ä ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å ╪Ñ┘ä┘ë.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.breadcrumb.label.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪ª╪⌐ ╪╡┘å┘ü ┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.breadcrumb.label.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.breadcrumb.label.view",
                TranslationValue = "╪╣╪▒╪╢ ┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.title",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.restricted",
                TranslationValue = "┘à┘é┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.shared",
                TranslationValue = "┘à╪┤╪¬╪▒┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.global",
                TranslationValue = "╪╣╪º┘ä┘à┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.deleteConfirm",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ╪ú┘å┘â ╪¬╪▒┘è╪» ╪¡╪░┘ü ┘ç╪░┘ç ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.enabled",
                TranslationValue = "┘à┘ü╪╣┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.disabled",
                TranslationValue = "┘à╪╣╪╖┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.identificationTraceability",
                TranslationValue = "╪¬╪¡╪»┘è╪» ╪º┘ä┘ç┘ê┘è╪⌐ ┘ê╪º┘ä╪¬╪¬╪¿╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.serialNumberAssignment",
                TranslationValue = "╪¬╪«╪╡┘è╪╡ ╪º┘ä╪▒┘é┘à ╪º┘ä╪¬╪│┘ä╪│┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.lotBatchNumberAssignment",
                TranslationValue = "╪¬╪«╪╡┘è╪╡ ╪▒┘é┘à ╪º┘ä╪»┘ü╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.expiryBestBeforeDateCapture",
                TranslationValue = "╪¬╪│╪¼┘è┘ä ╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.manufacturingProductionDate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪╡┘å┘è╪╣/╪º┘ä╪Ñ┘å╪¬╪º╪¼",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.barcodeQrCodeRfidScanning",
                TranslationValue = "┘à╪│╪¡ ╪º┘ä╪¿╪º╪▒┘â┘ê╪» / ╪▒┘à╪▓ ╪º┘ä╪º╪│╪¬╪¼╪º╪¿╪⌐ ╪º┘ä╪│╪▒┘è╪╣╪⌐ / RFID",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.supplierBatchLotReference",
                TranslationValue = "┘à╪▒╪¼╪╣ ╪»┘ü╪╣╪⌐ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.qualityAndInspection",
                TranslationValue = "╪º┘ä╪¼┘ê╪»╪⌐ ┘ê╪º┘ä┘ü╪¡╪╡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.inspectionRequired",
                TranslationValue = "╪º┘ä┘ü╪¡╪╡ ┘à╪╖┘ä┘ê╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.certificateOfConformance",
                TranslationValue = "╪┤┘ç╪º╪»╪⌐ ╪º┘ä┘à╪╖╪º╪¿┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.aqlBasedSamplingPlan",
                TranslationValue = "╪«╪╖╪⌐ ╪ú╪«╪░ ╪º┘ä╪╣┘è┘å╪º╪¬ ╪¡╪│╪¿ ┘à╪│╪¬┘ê┘ë ╪º┘ä╪¼┘ê╪»╪⌐ ╪º┘ä┘à┘é╪¿┘ê┘ä (AQL)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.damageDiscrepancyRecording",
                TranslationValue = "╪¬╪│╪¼┘è┘ä ╪º┘ä╪¬┘ä┘ü ┘ê╪º┘ä╪¬╪¿╪º┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.fefoFifoStockRotationFlag",
                TranslationValue = "╪╣┘ä╪º┘à╪⌐ ╪¬╪»┘ê┘è╪▒ ╪º┘ä┘à╪«╪▓┘ê┘å FEFO/FIFO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.shelfLifeMinimumRemainingCheckDays",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä╪ú╪»┘å┘ë ┘ä╪ú┘è╪º┘à ╪º┘ä╪¬╪¡┘é┘é ┘à┘å ┘à╪»╪⌐ ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐ ╪º┘ä┘à╪¬╪¿┘é┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.storageAndLocation",
                TranslationValue = "╪º┘ä╪¬╪«╪▓┘è┘å ┘ê╪º┘ä┘à┘ê┘é╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.warehouseStorageLocationAssignment",
                TranslationValue = "╪¬╪«╪╡┘è╪╡ ┘à┘ê┘é╪╣ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣/╪º┘ä╪¬╪«╪▓┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.subInventorySubLocationTracking",
                TranslationValue = "╪¬╪¬╪¿╪╣ ╪º┘ä┘à╪«╪▓┘ê┘å ╪º┘ä┘ü╪▒╪╣┘è / ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.purchasePriceVariance",
                TranslationValue = "╪¬╪¿╪º┘è┘å ╪│╪╣╪▒ ╪º┘ä╪┤╪▒╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.notificationAndWorkflow",
                TranslationValue = "╪º┘ä╪Ñ╪┤╪╣╪º╪▒╪º╪¬ ┘ê╪│┘è╪▒ ╪º┘ä╪╣┘à┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.automatedReceiptConfirmationNotification",
                TranslationValue = "╪Ñ╪┤╪╣╪º╪▒ ╪¬╪ú┘â┘è╪» ╪º┘ä╪º╪│╪¬┘ä╪º┘à ╪º┘ä╪¬┘ä┘é╪º╪ª┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.expiryDateAlert",
                TranslationValue = "╪¬┘å╪¿┘è┘ç ╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.generalInfo",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.mainCategory",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä╪▒╪ª┘è╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.milestoneDeliverableAcceptance",
                TranslationValue = "┘é╪¿┘ê┘ä ╪º┘ä┘à╪╣┘ä┘à/╪º┘ä╪¬╪│┘ä┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.postToBalanceSheet",
                TranslationValue = "╪º┘ä╪¬╪▒╪¡┘è┘ä ╪Ñ┘ä┘ë ╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.enableSpecification",
                TranslationValue = "╪¬┘ü╪╣┘è┘ä ╪º┘ä┘à┘ê╪º╪╡┘ü╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.quantityTolerance",
                TranslationValue = "┘å╪│╪¿╪⌐ ╪¬╪¡┘à┘ä ╪º┘ä┘â┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.supplierDeliveryNote",
                TranslationValue = "╪Ñ╪┤╪╣╪º╪▒ ╪¬╪│┘ä┘è┘à ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.configurations",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.toggleNavigation",
                TranslationValue = "╪¬╪¿╪»┘è┘ä ╪º┘ä╪¬┘å┘é┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.subCategoriesPrefix",
                TranslationValue = "┘è┘ê╪¼╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.subCategoriesSuffix",
                TranslationValue = "╪╣┘å╪╡╪▒ ┘ü╪▒╪╣┘è ┘à╪¬╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.rowActions",
                TranslationValue = "╪Ñ╪¼╪▒╪º╪í╪º╪¬ ╪º┘ä╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.restrictedDescription",
                TranslationValue = "╪│╪¬┘é╪¬╪╡╪▒ ╪Ñ╪¬╪º╪¡╪⌐ ╪º┘ä╪│╪¼┘ä ╪╣┘ä┘ë ╪º┘ä╪┤╪▒┘â╪⌐ ╪º┘ä╪¡╪º┘ä┘è╪⌐ ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.sharedDescription",
                TranslationValue = "╪│┘è┘â┘ê┘å ╪º┘ä╪│╪¼┘ä ┘à╪¬╪º╪¡┘ï╪º ┘ä┘ä╪┤╪▒┘â╪º╪¬ ╪º┘ä┘à╪╣┘è┘å╪⌐/╪º┘ä┘à╪¡╪»╪»╪⌐ ┘ü┘é╪╖.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.globalDescription",
                TranslationValue = "╪│┘è┘â┘ê┘å ╪º┘ä╪│╪¼┘ä ┘à╪¬╪º╪¡┘ï╪º ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬ ╪»┘ê┘å ╪ú┘è ┘é┘è┘ê╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.assignedTo",
                TranslationValue = "┘à╪╣┘è┘å ╪Ñ┘ä┘ë:",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.restrictedNotice",
                TranslationValue = "╪¬┘à ╪Ñ┘å╪┤╪º╪ñ┘ç ╪¿┘ê╪º╪│╪╖╪⌐ ┘ç╪░┘ç ╪º┘ä╪┤╪▒┘â╪⌐. ┘ä╪º ┘è┘à┘â┘å ┘ä┘ä╪┤╪▒┘â╪º╪¬ ╪º┘ä╪ú╪«╪▒┘ë ╪▒╪ñ┘è╪⌐ ╪ú┘ê ╪º╪│╪¬╪«╪»╪º┘à ┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐ ┘ç╪░┘ç.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.allCompanies",
                TranslationValue = "╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.globalNotice",
                TranslationValue = "┘ü╪ª╪⌐ ╪º┘ä╪╡┘å┘ü ╪º┘ä┘à╪º┘ä┘è╪⌐ ┘ç╪░┘ç ┘à╪▒╪ª┘è╪⌐ ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪┤╪▒┘â╪º╪¬. ┘ê┘ç┘è ╪║┘è╪▒ ┘à┘é┘è╪»╪⌐ ╪¿╪ú┘è ╪┤╪▒┘â╪⌐ ┘à╪¡╪»╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.addCompany",
                TranslationValue = "+ ╪Ñ╪╢╪º┘ü╪⌐ ╪┤╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.owner",
                TranslationValue = "╪º┘ä┘à╪º┘ä┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.changesAppliedOnSave",
                TranslationValue = "╪│┘è╪¬┘à ╪¬╪╖╪¿┘è┘é ╪º┘ä╪¬╪║┘è┘è╪▒╪º╪¬ ╪╣┘å╪» ╪º┘ä╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.milestoneDeliverableAcceptanceDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘â┘ê┘å ┘é╪¿┘ê┘ä ╪º┘ä┘à╪╣┘ä┘à/╪º┘ä╪¬╪│┘ä┘è┘à ┘à╪╖┘ä┘ê╪¿┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.postToBalanceSheetDescription",
                TranslationValue = "┘å╪╣┘à = ┘è╪¬┘à ╪▒╪│┘à┘ä╪⌐ ╪º┘ä╪╡┘å┘ü ┘â╪ú╪╡┘ä╪¢ ┘ä╪º = ┘è╪¬┘à ╪¬╪¡┘à┘è┘ä ╪º┘ä╪╡┘å┘ü ┘â┘à╪╡╪▒┘ê┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.enableSpecificationDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪º┘ä┘à┘ê╪º╪╡┘ü╪º╪¬ ┘ä┘ç╪░╪º ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.supplierDeliveryNoteDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬╪╖┘ä╪¿ ┘ç╪░╪º ╪º┘ä╪╡┘å┘ü ╪Ñ╪┤╪╣╪º╪▒ ╪¬╪│┘ä┘è┘à ┘à┘å ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.serialNumberAssignmentDescription",
                TranslationValue = "╪│┘è╪ñ╪»┘è ┘ç╪░╪º ╪º┘ä╪╡┘å┘ü ╪Ñ┘ä┘ë ╪¬┘ü╪╣┘è┘ä ╪¬╪«╪╡┘è╪╡ ╪º┘ä╪▒┘é┘à ╪º┘ä╪¬╪│┘ä╪│┘ä┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.lotBatchNumberAssignmentDescription",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘à╪╣ ╪¬╪«╪╡┘è╪╡ ╪▒┘é┘à ╪º┘ä╪»┘ü╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.expiryBestBeforeDateCaptureDescription",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘à╪╣ ╪¬╪│╪¼┘è┘ä ╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.manufacturingProductionDateDescription",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘à╪╣ ╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪╡┘å┘è╪╣/╪º┘ä╪Ñ┘å╪¬╪º╪¼",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.barcodeQrCodeRfidScanningDescription",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘à╪╣ ┘à╪│╪¡ ╪º┘ä╪¿╪º╪▒┘â┘ê╪» / ╪▒┘à╪▓ ╪º┘ä╪º╪│╪¬╪¼╪º╪¿╪⌐ ╪º┘ä╪│╪▒┘è╪╣╪⌐ / RFID",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.supplierBatchLotReferenceDescription",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐ ┘à╪╣ ┘à╪▒╪¼╪╣ ╪»┘ü╪╣╪⌐ ╪º┘ä┘à┘ê╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.inspectionRequiredDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ┘è┘â┘ê┘å ╪º┘ä┘ü╪¡╪╡ ┘à╪╖┘ä┘ê╪¿┘ï╪º",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.certificateOfConformanceDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│╪¬┘â┘ê┘å ╪┤┘ç╪º╪»╪⌐ ╪º┘ä┘à╪╖╪º╪¿┘é╪⌐ ┘à╪╖┘ä┘ê╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.damageDiscrepancyRecordingDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪¬╪│╪¼┘è┘ä ╪º┘ä╪¬┘ä┘ü ┘ê╪º┘ä╪¬╪¿╪º┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.fefoFifoStockRotationFlagDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪╣┘ä╪º┘à╪⌐ ╪¬╪»┘ê┘è╪▒ ╪º┘ä┘à╪«╪▓┘ê┘å FEFO/FIFO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.warehouseStorageLocationAssignmentDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪¬╪«╪╡┘è╪╡ ┘à┘ê┘é╪╣ ╪º┘ä┘à╪│╪¬┘ê╪»╪╣/╪º┘ä╪¬╪«╪▓┘è┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.subInventorySubLocationTrackingDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪¬╪¬╪¿╪╣ ╪º┘ä┘à╪«╪▓┘ê┘å ╪º┘ä┘ü╪▒╪╣┘è / ╪º┘ä┘à┘ê┘é╪╣ ╪º┘ä┘ü╪▒╪╣┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.purchasePriceVarianceDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪¬╪¿╪º┘è┘å ╪│╪╣╪▒ ╪º┘ä╪┤╪▒╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.automatedReceiptConfirmationNotificationDescription",
                TranslationValue = "┘è┘é┘ê┘à ┘ç╪░╪º ╪º┘ä╪«┘è╪º╪▒ ╪¿╪ú╪¬┘à╪¬╪⌐ ╪¬╪ú┘â┘è╪»╪º╪¬ ╪º┘ä╪º╪│╪¬┘ä╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.expiryDateAlertDescription",
                TranslationValue = "╪Ñ╪░╪º ╪¬┘à ╪º┘ä╪¬┘ü╪╣┘è┘ä╪î ╪│┘è╪¬┘à ╪¬┘ü╪╣┘è┘ä ╪¬┘å╪¿┘è┘ç ╪¬╪º╪▒┘è╪« ╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.companiesCount",
                TranslationValue = "{{count}} ╪┤╪▒┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.postToBalanceSheetInfo",
                TranslationValue = "┘è┘à┘â┘å ╪¬┘ü╪╣┘è┘ä┘ç ┘ü┘é╪╖ ╪Ñ╪░╪º ┘ä┘à ┘è╪¬┘à ╪º╪«╪¬┘è╪º╪▒ ╪▒┘à╪▓ ╪¡╪│╪º╪¿ ╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐╪î ┘ê┘è┘å╪╖╪¿┘é ┘ü┘é╪╖ ╪╣┘ä┘ë ╪ú╪╡┘å╪º┘ü ╪º┘ä┘à╪«╪▓┘ê┘å ┘ê╪║┘è╪▒ ╪º┘ä┘à╪«╪▓┘ê┘å. ╪╣┘å╪» ╪¬┘ü╪╣┘è┘ä┘ç╪î ╪│┘è┘é┘ê┘à ╪º┘ä┘å╪╕╪º┘à ╪╣┘å╪» ╪º╪│╪¬┘ä╪º┘à ╪º┘ä╪¿╪╢╪º╪╣╪⌐ (GRV) ╪¿╪¬╪▒╪¡┘è┘ä ╪º┘ä┘à╪«╪▓┘ê┘å ┘à╪¿╪º╪┤╪▒╪⌐ ╪Ñ┘ä┘ë ╪º┘ä╪º╪│╪¬┘ç┘ä╪º┘â ╪¿╪»┘ä╪º┘ï ┘à┘å ╪¡╪│╪º╪¿ ╪╢╪¿╪╖ ╪º┘ä┘à╪«╪▓┘ê┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.label.sharing",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐ ┘ü╪ª╪⌐ ╪¬┘à┘ê┘è┘ä ╪º┘ä╪╡┘å┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.notification.saveSuccess",
                TranslationValue = "╪¬┘à ╪º┘ä╪¡┘ü╪╕ ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IFSC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.notification.saveError",
                TranslationValue = "┘ü╪┤┘ä ╪º┘ä╪¡┘ü╪╕. ╪¡╪º┘ê┘ä ┘à╪▒╪⌐ ╪ú╪«╪▒┘ë.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-IFSC",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.enterValue",
                TranslationValue = "╪ú╪»╪«┘ä ╪º┘ä┘é┘è┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.categoryType",
                TranslationValue = "╪º╪«╪¬╪▒ ┘å┘ê╪╣ ╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.balanceSheetGl",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪│╪º╪¿ ╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.consumptionGl",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪│╪º╪¿ ╪º┘ä╪º╪│╪¬┘ç┘ä╪º┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.revenueGl",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪│╪º╪¿ ╪º┘ä╪Ñ┘è╪▒╪º╪»╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.cogsGl",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪│╪º╪¿ ╪¬┘â┘ä┘ü╪⌐ ╪º┘ä╪¿╪╢╪º╪╣╪⌐ ╪º┘ä┘à╪¿╪º╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.placeholder.quantityTolerance",
                TranslationValue = "╪ú╪»╪«┘ä ┘å╪│╪¿╪⌐ ╪¬╪¡┘à┘ä ╪º┘ä┘â┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.subCategoryName",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘ü╪ª╪⌐ ╪º┘ä┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.cogsGl",
                TranslationValue = "╪¡╪│╪º╪¿ ╪¬┘â┘ä┘ü╪⌐ ╪º┘ä╪¿╪╢╪º╪╣╪⌐ ╪º┘ä┘à╪¿╪º╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.revenueGl",
                TranslationValue = "╪¡╪│╪º╪¿ ╪º┘ä╪Ñ┘è╪▒╪º╪»╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.categoryType",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.balanceSheetGl",
                TranslationValue = "╪¡╪│╪º╪¿ ╪º┘ä┘à┘è╪▓╪º┘å┘è╪⌐ ╪º┘ä╪╣┘à┘ê┘à┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.consumptionGl",
                TranslationValue = "╪¡╪│╪º╪¿ ╪º┘ä╪º╪│╪¬┘ç┘ä╪º┘â",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.expiry",
                TranslationValue = "╪º┘å╪¬┘ç╪º╪í ╪º┘ä╪╡┘ä╪º╪¡┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.attributes",
                TranslationValue = "╪º┘ä╪«╪╡╪º╪ª╪╡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.columnHeader.sharedStatus",
                TranslationValue = "╪¡╪º┘ä╪⌐ ╪º┘ä┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Action Buttons 
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.addSubCategory",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪ª╪⌐ ┘ü╪▒╪╣┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.share",
                TranslationValue = "┘à╪┤╪º╪▒┘â╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.history",
                TranslationValue = "╪º┘ä╪│╪¼┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.cancel",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.actionButton.save",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Labels ΓåÆ Breadcrumb
            yield return new SystemTranslation
            {
                KeyName = "entity.currencyConversion",
                TranslationValue = "╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumb",
                TranslationValue = "╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbadd",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬╪¡┘ê┘è┘ä ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbedit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbview",
                TranslationValue = "╪╣╪▒╪╢ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬╪¡┘ê┘è┘ä ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.view",
                TranslationValue = "╪╣╪▒╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.delete",
                TranslationValue = "╪¡╪░┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.cancel",
                TranslationValue = "╪Ñ┘ä╪║╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.draft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.save",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.saveandcontinue",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘à╪¬╪º╪¿╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.override",
                TranslationValue = "╪¬╪¼╪º┘ê╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.addattachment",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.preview",
                TranslationValue = "┘à╪╣╪º┘è┘å╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.code",
                TranslationValue = "╪▒┘à╪▓ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.currencyConversionCode",
                TranslationValue = "╪▒┘à╪▓ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratedate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.effectivefrom",
                TranslationValue = "╪│╪º╪▒┘è ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.effectiveto",
                TranslationValue = "╪│╪º╪▒┘è ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratetype",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.erupdatetype",
                TranslationValue = "┘å┘ê╪╣ ╪¬╪¡╪»┘è╪½ ╪│╪╣╪▒ ╪º┘ä╪╡╪▒┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.source",
                TranslationValue = "╪º┘ä┘à╪╡╪»╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.createddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.createdby",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.fromcurrency",
                TranslationValue = "┘à┘å ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tocurrency",
                TranslationValue = "╪Ñ┘ä┘ë ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.startingcurrency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪º╪¿╪¬╪»╪º╪ª┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.reference",
                TranslationValue = "╪º┘ä┘à╪▒╪¼╪╣ / ╪º┘ä╪│╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.updateddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.updatedby",
                TranslationValue = "╪¡╪»┘æ╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.isactive",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.filename",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ä┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.attachmentname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.type",
                TranslationValue = "╪º┘ä┘å┘ê╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.size",
                TranslationValue = "╪º┘ä╪¡╪¼┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.uploadedby",
                TranslationValue = "╪▒┘ü╪╣ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.uploadedat",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪▒┘ü╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.currency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.iso",
                TranslationValue = "ISO",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.peg",
                TranslationValue = "╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.previous",
                TranslationValue = "╪º┘ä╪│╪º╪¿┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.newrate",
                TranslationValue = "╪º┘ä╪│╪╣╪▒ ╪º┘ä╪¼╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.buying",
                TranslationValue = "╪┤╪▒╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.selling",
                TranslationValue = "╪¿┘è╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.move",
                TranslationValue = "╪º┘ä╪¬╪║┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tolerance",
                TranslationValue = "╪º┘ä╪¬╪¡┘à┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.warning",
                TranslationValue = "╪¬╪¡╪░┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.block",
                TranslationValue = "╪¡╪╕╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.pegtolerance",
                TranslationValue = "╪¬╪¡┘à┘ä ╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.usecase",
                TranslationValue = "╪¡╪º┘ä╪⌐ ╪º┘ä╪º╪│╪¬╪«╪»╪º┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.prevrate",
                TranslationValue = "╪º┘ä┘à╪╣╪»┘ä ╪º┘ä╪│╪º╪¿┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratequote",
                TranslationValue = "╪º┘ä╪│╪╣╪▒ (1{{iso}} = X)",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.crosscheck",
                TranslationValue = "╪º┘ä╪¬╪¡┘é┘é ╪º┘ä┘à╪¬┘é╪º╪╖╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.percentdelta",
                TranslationValue = "% Γû│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tol",
                TranslationValue = "╪¡╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.justification",
                TranslationValue = "╪º┘ä┘à╪¿╪▒╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.code",
                TranslationValue = "╪▒┘à╪▓ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratedate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectivefrom",
                TranslationValue = "╪│╪º╪▒┘è ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectiveto",
                TranslationValue = "╪│╪º╪▒┘è ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectivetohint",
                TranslationValue = "╪╣┘å╪» ╪º┘ä╪¬┘ü╪╣┘è┘ä ╪│┘è╪╕┘ç╪▒ ╪¬╪º╪▒┘è╪« ┘ê┘ê┘é╪¬ ╪º┘ä╪º┘å╪¬┘ç╪º╪í.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratetype",
                TranslationValue = "┘å┘ê╪╣ ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.fromcurrency",
                TranslationValue = "╪▓┘ê╪¼ ╪º┘ä╪╣┘à┘ä╪⌐ ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tocurrency",
                TranslationValue = "╪▓┘ê╪¼ ╪º┘ä╪╣┘à┘ä╪⌐ ╪Ñ┘ä┘ë",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.startingcurrency",
                TranslationValue = "╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪º╪¿╪¬╪»╪º╪ª┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.source",
                TranslationValue = "╪º┘ä┘à╪╡╪»╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.reference",
                TranslationValue = "╪º┘ä┘à╪▒╪¼╪╣ / ╪º┘ä╪│╪▒╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.active",
                TranslationValue = "┘å╪┤╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.open",
                TranslationValue = "┘à┘ü╪¬┘ê╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratevalue",
                TranslationValue = "┘é┘è┘à╪⌐ ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.inverserate",
                TranslationValue = "╪º┘ä╪│╪╣╪▒ ╪º┘ä╪╣┘â╪│┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.movementpercent",
                TranslationValue = "┘å╪│╪¿╪⌐ ╪º┘ä╪¬╪║┘è╪▒ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.buyrate",
                TranslationValue = "╪│╪╣╪▒ ╪º┘ä╪┤╪▒╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.sellrate",
                TranslationValue = "╪│╪╣╪▒ ╪º┘ä╪¿┘è╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.spreadpercent",
                TranslationValue = "╪º┘ä┘ç╪º┘à╪┤ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.previousrate",
                TranslationValue = "╪º┘ä╪│╪╣╪▒ ╪º┘ä╪│╪º╪¿┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.justification",
                TranslationValue = "╪º┘ä┘à╪¿╪▒╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.applymidtobuysell",
                TranslationValue = "╪¬╪╖╪¿┘è┘é ╪º┘ä╪│╪╣╪▒ ╪º┘ä┘ê╪│╪╖┘è ╪╣┘ä┘ë ╪º┘ä╪┤╪▒╪º╪í/╪º┘ä╪¿┘è╪╣ ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪╡┘ü┘ê┘ü╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.activetolerance",
                TranslationValue = "╪º┘ä╪¡╪» ╪º┘ä┘å╪┤╪╖ ┘ä┘Ç {{rateType}}: ╪¬╪¡╪░┘è╪▒ ┬▒{{warn}}% | ╪Ñ┘è┘é╪º┘ü ┬▒{{block}}% | ╪▒╪¿╪╖ ┬▒{{peg}}%",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.movementthreshold",
                TranslationValue = "╪¡╪» ╪º┘ä╪¬╪║┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.lastupdate",
                TranslationValue = "╪ó╪«╪▒ ╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.newrateentry",
                TranslationValue = "╪Ñ╪»╪«╪º┘ä ╪│╪╣╪▒ ╪¼╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.selectbasecurrency",
                TranslationValue = "╪º╪«╪¬╪▒ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.filename",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à┘ä┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.attachmentname",
                TranslationValue = "╪º╪│┘à ╪º┘ä┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.description",
                TranslationValue = "╪º┘ä┘ê╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.uploadattachment",
                TranslationValue = "╪▒┘ü╪╣ ┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.fromcurrencysummary",
                TranslationValue = "┘à┘å ╪╣┘à┘ä╪⌐ :",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tocurrencysummary",
                TranslationValue = "╪Ñ┘ä┘ë ╪╣┘à┘ä╪⌐ :",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tolerancedescription",
                TranslationValue = "╪¬╪¡╪░┘è╪▒ ┬▒2% ┬╖ ╪¡╪╕╪▒ ┬▒10% ┬╖ ╪▒╪¿╪╖ ┬▒0.1% ┬╖ ┘è╪╖╪¿┘æ┘é ╪╣┘ä┘ë ┘â┘ä ╪╡┘ü ╪¡╪│╪¿ ╪º┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐. ╪¬╪║┘è┘è╪▒ ┘å┘ê╪╣ ╪º┘ä╪│╪╣╪▒ ┘ü┘è ╪º┘ä╪¬╪▒┘ê┘è╪│╪⌐ ┘è╪¡╪»┘æ╪½ ╪¼┘à┘è╪╣ ╪¡╪»┘ê╪» ╪º┘ä╪¬╪¡┘à┘ä.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratedetailssubtitle",
                TranslationValue = "╪ú╪»╪«┘ä ┘ê╪▒╪º╪¼╪╣ ╪ú╪│╪╣╪º╪▒ ╪º┘ä╪¬╪¡┘ê┘è┘ä ┘ä┘ä╪╣┘à┘ä╪⌐ ╪º┘ä╪ú╪│╪º╪│┘è╪⌐ ╪º┘ä┘à╪¡╪»╪»╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.on",
                TranslationValue = "┘ü┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.draft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.pending",
                TranslationValue = "┘é┘è╪» ╪º┘ä╪º┘å╪¬╪╕╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.approved",
                TranslationValue = "┘à╪╣╪¬┘à╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.rejected",
                TranslationValue = "┘à╪▒┘ü┘ê╪╢",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatusok",
                TranslationValue = "╪│┘ä┘è┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatuswarn",
                TranslationValue = "╪¬╪¡╪░┘è╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatusblock",
                TranslationValue = "╪¡╪╕╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.pegfixed",
                TranslationValue = "┘à╪½╪¿╪¬ ╪¿╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.viacurrency",
                TranslationValue = "╪╣╪¿╪▒ {{iso}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ersinglesegment",
                TranslationValue = "┘ü╪▒╪»┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.erbulksegment",
                TranslationValue = "┘à╪¼┘à╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.generalinfo",
                TranslationValue = "╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.tolerance",
                TranslationValue = "╪¬╪¡┘à┘ä ╪│╪╣╪▒ ╪º┘ä╪│╪¿┘ê╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.ratecontext",
                TranslationValue = "╪│┘è╪º┘é ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.attachment",
                TranslationValue = "╪º┘ä┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.ratedetails",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪│╪╣╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪¬╪¡┘ê┘è┘ä ╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.edit",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.view",
                TranslationValue = "╪╣╪▒╪╢ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.addattachment",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.editattachment",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ╪º┘ä┘à╪▒┘ü┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.placeholder.keywordsearch",
                TranslationValue = "╪¿╪¡╪½ ╪¿╪º┘ä┘â┘ä┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.placeholder.browsedocument",
                TranslationValue = "╪º╪│╪¬╪╣╪▒╪º╪╢ ╪º┘ä┘à╪│╪¬┘å╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.createdsuccess",
                TranslationValue = "╪¬┘à ╪Ñ┘å╪┤╪º╪í ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐ ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.updatedsuccess",
                TranslationValue = "╪¬┘à ╪¬╪¡╪»┘è╪½ ╪¬╪¡┘ê┘è┘ä ╪º┘ä╪╣┘à┘ä╪⌐ ╪¿┘å╪¼╪º╪¡",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.uploadfailed",
                TranslationValue = "┘ü╪┤┘ä ╪▒┘ü╪╣ ╪º┘ä┘à╪▒┘ü┘é.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.delete",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪º┘ä╪¡╪░┘ü╪ƒ ┘ä╪º ┘è┘à┘â┘å ╪º┘ä╪¬╪▒╪º╪¼╪╣ ╪╣┘å ┘ç╪░╪º ╪º┘ä╪Ñ╪¼╪▒╪º╪í!",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocaltitle",
                TranslationValue = "╪º┘ä╪ú╪│╪╣╪º╪▒ ╪º┘ä╪╣┘â╪│┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalsinglesingle",
                TranslationValue = "┘ç┘ä ╪¬╪▒┘è╪» ╪¬╪╖╪¿┘è┘é ╪ú╪│╪╣╪º╪▒ ╪º┘ä╪┤╪▒╪º╪í/╪º┘ä╪¿┘è╪╣ ╪º┘ä╪╣┘â╪│┘è╪⌐ ┘à┘å {{to}} ╪Ñ┘ä┘ë {{from}}╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalsinglebulk",
                TranslationValue = "┘ç┘ä ╪¬╪▒┘è╪» ╪¬╪╖╪¿┘è┘é ╪ú╪│╪╣╪º╪▒ ╪º┘ä╪┤╪▒╪º╪í/╪º┘ä╪¿┘è╪╣ ╪º┘ä╪╣┘â╪│┘è╪⌐ ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪╣┘à┘ä╪º╪¬ ╪º┘ä╪¿╪º┘ä╪║ ╪╣╪»╪»┘ç╪º {{count}}╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalbulkbulk",
                TranslationValue = "┘ç┘ä ╪¬╪▒┘è╪» ╪¬╪╖╪¿┘è┘é ╪º┘ä╪ú╪│╪╣╪º╪▒ ╪º┘ä╪╣┘â╪│┘è╪⌐ ┘ä╪¼┘à┘è╪╣ ╪º┘ä╪ú╪▓┘ê╪º╪¼ ╪º┘ä╪¿╪º┘ä╪║ ╪╣╪»╪»┘ç╪º {{count}} ┘ü┘è ┘ç╪░┘ç ╪º┘ä╪┤╪¿┘â╪⌐╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.applymidtitle",
                TranslationValue = "╪¬╪╖╪¿┘è┘é ╪º┘ä╪│╪╣╪▒ ╪º┘ä┘ê╪│╪╖┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.applymidcontent",
                TranslationValue = "┘ç┘ä ╪¬╪▒┘è╪» ╪¬╪╖╪¿┘è┘é ┘å┘ü╪│ ╪º┘ä╪│╪╣╪▒ ╪╣┘ä┘ë ╪º┘ä╪┤╪▒╪º╪í ┘ê╪º┘ä╪¿┘è╪╣╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.cfooverridetitle",
                TranslationValue = "╪¬┘à ╪¬╪¼╪º┘ê╪▓ ╪¡╪» ╪º┘ä╪Ñ┘è┘é╪º┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.cfooverridecontent",
                TranslationValue = "┘è╪¬╪¼╪º┘ê╪▓ ┘ç╪░╪º ╪º┘ä╪│╪╣╪▒ ╪¡╪» ╪º┘ä╪Ñ┘è┘é╪º┘ü. ┘ç┘ä ╪¬╪▒┘è╪» ╪¬╪╖╪¿┘è┘é ╪¬╪¼╪º┘ê╪▓ ╪º┘ä┘à╪»┘è╪▒ ╪º┘ä┘à╪º┘ä┘è ┘ê╪º┘ä┘à╪¬╪º╪¿╪╣╪⌐╪ƒ ╪º┘ä┘à╪¿╪▒╪▒ ┘à╪º ╪▓╪º┘ä ┘à╪╖┘ä┘ê╪¿╪º┘ï.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.pegoverridetitle",
                TranslationValue = "╪¬╪¼╪º┘ê╪▓ ╪│╪╣╪▒ ╪º┘ä╪▒╪¿╪╖",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.pegoverridecontent",
                TranslationValue = "┘ç┘ä ╪¬╪▒┘è╪» ╪Ñ┘ä╪║╪º╪í ┘é┘ü┘ä ╪ú╪│╪╣╪º╪▒ ╪º┘ä╪¼╪»┘è╪» ┘ê╪º┘ä╪┤╪▒╪º╪í ┘ê╪º┘ä╪¿┘è╪╣ ┘ä┘ç╪░┘ç ╪º┘ä╪▓┘ê╪¼ ╪º┘ä┘à╪▒╪¬╪¿╪╖ ┘ê╪Ñ╪»╪«╪º┘ä ╪º┘ä╪│╪╣╪▒ ┘è╪»┘ê┘è╪º┘ï╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.ratedatefuture",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪╣╪▒ ╪¿╪╣╪» ╪ú┘â╪½╪▒ ┘à┘å 90 ┘è┘ê┘à╪º┘ï.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.effectivefrombeforeratedate",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å ┘ü┘è ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪╣╪▒ ╪ú┘ê ╪¿╪╣╪»┘ç.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.effectivetomustbeafterfrom",
                TranslationValue = "┘è╪¼╪¿ ╪ú┘å ┘è┘â┘ê┘å ╪¬╪º╪▒┘è╪« ╪º┘ä╪º┘å╪¬┘ç╪º╪í ╪¿╪╣╪» ╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.currenciesmustdiffer",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ╪¬┘â┘ê┘å ╪╣┘à┘ä╪⌐ ╪º┘ä┘à╪╡╪»╪▒ ┘ê╪╣┘à┘ä╪⌐ ╪º┘ä┘ç╪»┘ü ┘à╪¬╪╖╪º╪¿┘é╪¬┘è┘å.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.buyrateexceedssell",
                TranslationValue = "┘ä╪º ┘è┘à┘â┘å ╪ú┘å ┘è╪¬╪¼╪º┘ê╪▓ ╪│╪╣╪▒ ╪º┘ä╪┤╪▒╪º╪í ╪│╪╣╪▒ ╪º┘ä╪¿┘è╪╣.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.movementblocked",
                TranslationValue = "╪¬┘à ╪Ñ┘è┘é╪º┘ü ╪º┘ä╪¡┘ü╪╕ ┘ä╪ú┘å ╪ú╪¡╪» ╪º┘ä╪ú╪│╪╣╪º╪▒ ╪¬╪¼╪º┘ê╪▓ ╪¡╪» ╪º┘ä╪Ñ┘è┘é╪º┘ü.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.justificationrequired",
                TranslationValue = "╪º┘ä┘à╪¿╪▒╪▒ ┘à╪╖┘ä┘ê╪¿ ╪╣┘å╪»┘à╪º ╪¬╪¬╪¼╪º┘ê╪▓ ┘å╪│╪¿╪⌐ ╪º┘ä╪¡╪▒┘â╪⌐ ╪¡╪» ╪º┘ä╪¬╪¡╪░┘è╪▒.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.duplicatepair",
                TranslationValue = "╪▓┘ê╪¼ ╪º┘ä╪╣┘à┘ä╪º╪¬ ┘ç╪░╪º ┘à┘ê╪¼┘ê╪» ╪¿╪º┘ä┘ü╪╣┘ä ┘ü┘è ╪º┘ä╪┤╪¿┘â╪⌐.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.rowactions",
                TranslationValue = "╪Ñ╪¼╪▒╪º╪í╪º╪¬ ╪º┘ä╪╡┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.close",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.removefile",
                TranslationValue = "╪Ñ╪▓╪º┘ä╪⌐ ╪º┘ä┘à┘ä┘ü",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.actionbutton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ╪Ñ╪╣╪»╪º╪» ╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.actionbutton.draft",
                TranslationValue = "┘à╪│┘ê╪»╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.actionbutton.saveandcontinue",
                TranslationValue = "╪¡┘ü╪╕ ┘ê┘à╪¬╪º╪¿╪╣╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.actionbutton.publish",
                TranslationValue = "┘å╪┤╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.actionbutton.save",
                TranslationValue = "╪¡┘ü╪╕",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Confirmation
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.confirmation.publish",
                TranslationValue = "┘ç┘ä ╪ú┘å╪¬ ┘à╪¬╪ú┘â╪» ┘à┘å ╪▒╪║╪¿╪¬┘â ┘ü┘è ┘å╪┤╪▒ ┘ç╪░╪º ╪º┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪╢╪▒┘è╪¿┘è╪ƒ",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "entity.taxCategoryRate",
                TranslationValue = "┘å╪│╪¿╪⌐ ┘ü╪ª╪⌐ ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "entity.taxSetup",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.breadcrumbtitle",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.breadcrumbtitleview",
                TranslationValue = "╪╣╪▒╪╢ ╪º┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.code",
                TranslationValue = "╪▒┘à╪▓ ╪º┘ä╪Ñ╪╣╪»╪º╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.name",
                TranslationValue = "╪º╪│┘à ╪º┘ä╪Ñ╪╣╪»╪º╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.taxtype",
                TranslationValue = "╪º┘ä┘å┘ê╪╣ ╪º┘ä╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.authority",
                TranslationValue = "╪º┘ä╪¼┘ç╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.jurisdiction",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.registrationnumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¬╪│╪¼┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.effective",
                TranslationValue = "╪│╪º╪▒┘è ╪º╪╣╪¬╪¿╪º╪▒╪º┘ï ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.label.filing",
                TranslationValue = "╪»┘ê╪▒┘è╪⌐ ╪º┘ä╪Ñ┘é╪▒╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.taxtype.label.vat",
                TranslationValue = "╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘é┘è┘à╪⌐ ╪º┘ä┘à╪╢╪º┘ü╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.taxtype.label.excise",
                TranslationValue = "╪º┘ä╪╢╪▒┘è╪¿╪⌐ ╪º┘ä╪º┘å╪¬┘é╪º╪ª┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.taxtype.label.withholding",
                TranslationValue = "╪╢╪▒┘è╪¿╪⌐ ╪º┘ä╪º╪│╪¬┘é╪╖╪º╪╣",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.taxtype.label.corporate",
                TranslationValue = "╪╢╪▒┘è╪¿╪⌐ ╪º┘ä╪┤╪▒┘â╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.taxtype.label.contribution",
                TranslationValue = "╪º┘ä┘à╪│╪º┘ç┘à╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.filing.label.monthly",
                TranslationValue = "╪┤┘ç╪▒┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.filing.label.quarterly",
                TranslationValue = "╪▒╪¿╪╣ ╪│┘å┘ê┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.filing.label.biannually",
                TranslationValue = "┘å╪╡┘ü ╪│┘å┘ê┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.filing.label.annually",
                TranslationValue = "╪│┘å┘ê┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.title",
                TranslationValue = "╪Ñ╪╣╪»╪º╪»╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.sectionnotavailable",
                TranslationValue = "┘ç╪░╪º ╪º┘ä┘é╪│┘à ╪║┘è╪▒ ┘à╪¬╪º╪¡ ╪¿╪╣╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.submenu.headerdetails",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪º┘ä╪▒╪ú╪│",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Submenu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.headerdetailsdescription",
                TranslationValue = "╪Ñ╪»╪º╪▒╪⌐ ╪º┘ä┘à╪╣┘ä┘ê┘à╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐ ┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.submenu.taxcategoriesrates",
                TranslationValue = "┘ü╪ª╪º╪¬ ┘ê┘å╪│╪¿ ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Submenu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.taxcategoriesratesdescription",
                TranslationValue = "╪º┘ä┘à╪╣╪º┘ä╪¼╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐ ┘ê╪º┘ä┘å╪│╪¿ ┘ê╪º┘ä┘à┘å╪¬╪¼╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.label.calculationmethod",
                TranslationValue = "╪╖╪▒┘è┘é╪⌐ ╪º┘ä╪º╪¡╪¬╪│╪º╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.label.rounding",
                TranslationValue = "╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.columnheader.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.columnheader.category",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.columnheader.rate",
                TranslationValue = "╪º┘ä┘å╪│╪¿╪⌐ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.columnheader.effectivefrom",
                TranslationValue = "╪│╪º╪▒┘è ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.label.category",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.label.rate",
                TranslationValue = "╪º┘ä┘å╪│╪¿╪⌐ %",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.label.effectivefrom",
                TranslationValue = "╪│╪º╪▒┘è ┘à┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.header.addtitle",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘å╪│╪¿╪⌐ ╪Ñ┘ä┘ë ┘ü╪ª╪⌐ ╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.header.edittitle",
                TranslationValue = "╪¬╪╣╪»┘è┘ä ┘å╪│╪¿╪⌐ ┘ü┘è ┘ü╪ª╪⌐ ╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.header.viewtitle",
                TranslationValue = "╪º┘ä┘ü╪ª╪⌐ ┘ê╪º┘ä┘å╪│╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.categoryrate.actionbutton.add",
                TranslationValue = "╪Ñ╪╢╪º┘ü╪⌐ ┘ü╪ª╪⌐ ┘ê┘å╪│╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.submenu.glconfiguration",
                TranslationValue = "╪Ñ╪╣╪»╪º╪» ╪º┘ä╪¡╪│╪º╪¿╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Submenu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.glconfigurationdescription",
                TranslationValue = "╪Ñ╪╣╪»╪º╪» ┘å╪╕╪▒╪⌐ ╪╣╪º┘à╪⌐ ╪╣┘ä┘ë ╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪º┘ä╪╢╪▒┘è╪¿┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.input",
                TranslationValue = "╪¡╪│╪º╪¿ ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘à╪»╪«┘ä╪º╪¬ {{taxType}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.inputtransfer",
                TranslationValue = "╪¡╪│╪º╪¿ ╪¬╪¡┘ê┘è┘ä ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘à╪»╪«┘ä╪º╪¬ {{taxType}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.output",
                TranslationValue = "╪¡╪│╪º╪¿ ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘à╪«╪▒╪¼╪º╪¬ {{taxType}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.outputtransfer",
                TranslationValue = "╪¡╪│╪º╪¿ ╪¬╪¡┘ê┘è┘ä ╪╢╪▒┘è╪¿╪⌐ ╪º┘ä┘à╪«╪▒╪¼╪º╪¬ {{taxType}}",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.settlement",
                TranslationValue = "╪¡╪│╪º╪¿ ╪¬╪│┘ê┘è╪⌐ ╪º┘ä╪╢╪▒┘è╪¿╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.roundingdifference",
                TranslationValue = "╪¡╪│╪º╪¿ ┘ü╪▒┘ê┘é ╪º┘ä╪¬┘é╪▒┘è╪¿",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.control",
                TranslationValue = "╪¡╪│╪º╪¿ ┘à╪▒╪º┘é╪¿╪⌐ {{taxType}} ╪º┘ä┘à╪╣┘ü╪º╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.expense",
                TranslationValue = "╪¡╪│╪º╪¿ ┘à╪╡╪▒┘ê┘ü {{taxType}} ╪º┘ä┘à╪╣┘ü╪º╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.label.nocategories",
                TranslationValue = "┘ä╪º ╪¬┘ê╪¼╪» ┘ü╪ª╪º╪¬ ┘ä┘ç╪º ┘å╪│╪¿ ╪¿╪╣╪».",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.submenu.supplyrules",
                TranslationValue = "┘é┘ê╪º╪╣╪» ╪º┘ä╪¬┘ê╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Submenu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.supplyrulesdescription",
                TranslationValue = "╪¬┘ü╪º╪╡┘è┘ä ╪¡┘ê┘ä ┘à┘â╪º┘å ┘ê╪▓┘à╪º┘å ╪¬╪│╪¼┘è┘ä ╪º┘ä╪¬┘ê╪▒┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.submenu.determination",
                TranslationValue = "╪º┘ä╪¬╪¡╪»┘è╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Submenu,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.label.determinationdescription",
                TranslationValue = "┘é┘ê╪º╪╣╪» ╪¬╪«╪¬╪º╪▒ ╪º┘ä╪▒┘à┘ê╪▓ ╪¬┘ä┘é╪º╪ª┘è╪º┘ï ╪»┘ê┘å ╪¬╪»╪«┘ä ╪º┘ä┘à╪│╪¬╪«╪»┘à",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.sectionheader.generalinformation",
                TranslationValue = "┘à╪╣┘ä┘ê┘à╪º╪¬ ╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.sectionheader.generalaccounts",
                TranslationValue = "╪º┘ä╪¡╪│╪º╪¿╪º╪¬ ╪º┘ä╪╣╪º┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.sectionheader.categoryaccounts",
                TranslationValue = "╪¡╪│╪º╪¿╪º╪¬ ╪«╪º╪╡╪⌐ ╪¿╪º┘ä┘ü╪ª╪º╪¬",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.code",
                TranslationValue = "╪º┘ä╪▒┘à╪▓",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.setup",
                TranslationValue = "╪º┘ä╪Ñ╪╣╪»╪º╪»",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.taxtype",
                TranslationValue = "╪º┘ä┘å┘ê╪╣ ╪º┘ä╪╢╪▒┘è╪¿┘è",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.authority",
                TranslationValue = "╪º┘ä╪¼┘ç╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.jurisdiction",
                TranslationValue = "╪º┘ä┘ê┘ä╪º┘è╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.registrationnumber",
                TranslationValue = "╪▒┘é┘à ╪º┘ä╪¬╪│╪¼┘è┘ä",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.effective",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪│╪▒┘è╪º┘å",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.filing",
                TranslationValue = "╪º┘ä╪Ñ┘é╪▒╪º╪▒",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.status",
                TranslationValue = "╪º┘ä╪¡╪º┘ä╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.createddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪Ñ┘å╪┤╪º╪í",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.createdby",
                TranslationValue = "╪ú┘å╪┤╪ª ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.updateddate",
                TranslationValue = "╪¬╪º╪▒┘è╪« ╪º┘ä╪¬╪¡╪»┘è╪½",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.updatedby",
                TranslationValue = "╪¡┘Å╪»╪½ ╪¿┘ê╪º╪│╪╖╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.columnheader.approvalstatus",
                TranslationValue = "╪¡╪º┘ä╪⌐ ╪º┘ä┘à┘ê╪º┘ü┘é╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.glconfiguration.placeholder.chooseaccount",
                TranslationValue = "╪º╪«╪¬╪▒ ╪¡╪│╪º╪¿╪º┘ï",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.tooltip.activationneedsapproval",
                TranslationValue = "┘è╪╡╪¿╪¡ ╪º┘ä╪Ñ╪╣╪»╪º╪» ╪º┘ä╪╢╪▒┘è╪¿┘è ┘å╪┤╪╖┘ï╪º ╪¿╪╣╪» ╪º┘â╪¬┘à╪º┘ä ╪º┘ä┘à┘ê╪º┘ü┘é╪⌐ ╪╣┘ä┘è┘ç.",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.tooltip.togglemenu",
                TranslationValue = "╪¬╪¿╪»┘è┘ä ╪º┘ä┘é╪º╪ª┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.navigation.tooltip.closemenu",
                TranslationValue = "╪Ñ╪║┘ä╪º┘é ╪º┘ä┘é╪º╪ª┘à╪⌐",
                CultureName = "ar-OM",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TS",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion
        }
    }
}