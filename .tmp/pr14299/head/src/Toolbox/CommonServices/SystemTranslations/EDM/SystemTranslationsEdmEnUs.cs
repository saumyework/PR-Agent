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
        private static IEnumerable<SystemTranslation> GetEdmEnUs()
        {
            // EDM ΓåÆ English (United States)
            #region EDM ΓåÆ Country Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.country.commonButtons.add",
                TranslationValue = "Add Country",
                CultureName = "en-US",
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
                TranslationValue = "Edit Country",
                CultureName = "en-US",
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
                TranslationValue = "View",
                CultureName = "en-US",
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
                TranslationValue = "Edit",
                CultureName = "en-US",
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
                TranslationValue = "Delete",
                CultureName = "en-US",
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
                KeyName = "translate.edm.businessUnit.columnHeader.updatedDate",
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Inactive",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "ISO 3 Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "ISO Numeric Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Region",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Nationality Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Upload a flag icon",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Browse the Document",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Default Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "VAT Applicable",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enable VAT applicable for country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Default Language",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Time Zone",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Geographical Structure",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Localization Settings",
                CultureName = "en-US",
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
                TranslationValue = "Financial & Tax Configuration",
                CultureName = "en-US",
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
                TranslationValue = "Address Template",
                CultureName = "en-US",
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
                TranslationValue = "Geographical Structure",
                CultureName = "en-US",
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
                TranslationValue = "ISO Code",
                CultureName = "en-US",
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
                TranslationValue = "Country Name",
                CultureName = "en-US",
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
                TranslationValue = "Flag",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Select Level",
                CultureName = "en-US",
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
                TranslationValue = "Enter Country Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter ISO 3 Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter ISO Numeric Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Nationality Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Level Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Display Label",
                CultureName = "en-US",
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
                TranslationValue = "Select Language",
                CultureName = "en-US",
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
                TranslationValue = "Select Time Zone",
                CultureName = "en-US",
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
                TranslationValue = "Select Currency",
                CultureName = "en-US",
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
                TranslationValue = "Field Key",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Display Label",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Visibility",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Line 1",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Line 2",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Line 3",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Geolocation",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Postal Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "PO Box",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Area/District",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Way/Street",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Building/House Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "City",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Postal Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "P.O. Box",
                CultureName = "en-US",
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
                TranslationValue = "Must be exactly 3 letters.",
                CultureName = "en-US",
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
                TranslationValue = "Levels",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Levels",
                CultureName = "en-US",
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
                TranslationValue = "Level Name",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Country Code",
                CultureName = "en-US",
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
                TranslationValue = "Geo-Location Code",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Edit",
                CultureName = "en-US",
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
                TranslationValue = "Add Child Level",
                CultureName = "en-US",
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
                TranslationValue = "Delete",
                CultureName = "en-US",
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
                TranslationValue = "View",
                CultureName = "en-US",
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
                TranslationValue = "Create Structure",
                CultureName = "en-US",
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
                TranslationValue = "Manage Child Level",
                CultureName = "en-US",
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
                TranslationValue = "Edit Main Level",
                CultureName = "en-US",
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
                TranslationValue = "Edit Values",
                CultureName = "en-US",
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
                TranslationValue = "Value",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Parent Level",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Selected Level",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "New Level Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country ISO 3 code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Inactive",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Enter description",
                CultureName = "en-US",
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
                TranslationValue = "Enter level name",
                CultureName = "en-US",
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
                TranslationValue = "Select country",
                CultureName = "en-US",
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
                TranslationValue = "Auto-filled from country",
                CultureName = "en-US",
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
                TranslationValue = "New level name is required",
                CultureName = "en-US",
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
                TranslationValue = "Level name cannot be left blank.",
                CultureName = "en-US",
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
                TranslationValue = "Address template already in use; structure cannot be edited.",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location structure saved successfully",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location structure updated successfully",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location structure deleted successfully",
                CultureName = "en-US",
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
                TranslationValue = "Geolocation level updated successfully.",
                CultureName = "en-US",
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
                TranslationValue = "Failed to load countries",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to delete this level and all its sub-levels? This action cannot be undone!",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to delete this? This action cannot be undone!",
                CultureName = "en-US",
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
                TranslationValue = "Geo Location Structure",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Create Geo Location Structure",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Edit Geo Location Structure",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "View Geo Location Structure",
                CultureName = "en-US",
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
                TranslationValue = "State/Province/Governorate",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "District/County",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Wilayah/Municipality",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "City/Area",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Geo Location Hierarchy Levels",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Read only mode",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Parent Level",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Values",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Geo Location Hierarchy",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Add Geo Location Hierarchy",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Edit Geo Location Hierarchy",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "View Geo Location Hierarchy",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Are you sure you want to delete this? This action cannot be undone!",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Geo-Location Hierarchy ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.geolocationhierarchy.actionbutton.view",
                TranslationValue = "View",
                CultureName = "en-US",
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
                TranslationValue = "Edit",
                CultureName = "en-US",
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
                TranslationValue = "Delete",
                CultureName = "en-US",
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
                TranslationValue = "Reset",
                CultureName = "en-US",
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
                TranslationValue = "Save",
                CultureName = "en-US",
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
                TranslationValue = "Close",
                CultureName = "en-US",
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
                TranslationValue = "Add Child Values",
                CultureName = "en-US",
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
                TranslationValue = "Add Value",
                CultureName = "en-US",
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
                TranslationValue = "Add Hierarchy",
                CultureName = "en-US",
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
                TranslationValue = "Country Code",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Levels",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Level Name",
                CultureName = "en-US",
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
                TranslationValue = "Values Count",
                CultureName = "en-US",
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
                TranslationValue = "No. of Values",
                CultureName = "en-US",
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
                TranslationValue = "Manage Values",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location structure is not set up for the selected country.",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location hierarchy saved successfully",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location hierarchy updated successfully",
                CultureName = "en-US",
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
                TranslationValue = "Geo-location hierarchy deleted successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to save geo-location hierarchy",
                CultureName = "en-US",
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
                TranslationValue = "Enter Value Name",
                CultureName = "en-US",
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
                TranslationValue = "Select country",
                CultureName = "en-US",
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
                TranslationValue = "Auto-filled from country",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Supplier Master ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.supplier.actionButton.add",
                TranslationValue = "Add Supplier",
                CultureName = "en-US",
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
                TranslationValue = "Edit Supplier",
                CultureName = "en-US",
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
                TranslationValue = "View Supplier",
                CultureName = "en-US",
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
                TranslationValue = "Save as Draft",
                CultureName = "en-US",
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
                TranslationValue = "Save",
                CultureName = "en-US",
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
                TranslationValue = "Save and Publish",
                CultureName = "en-US",
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
                TranslationValue = "Publish",
                CultureName = "en-US",
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
                TranslationValue = "Add Certification",
                CultureName = "en-US",
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
                TranslationValue = "Add Share Holders",
                CultureName = "en-US",
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
                TranslationValue = "Add Customer Reference",
                CultureName = "en-US",
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
                TranslationValue = "Add Site",
                CultureName = "en-US",
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
                TranslationValue = "Edit Address",
                CultureName = "en-US",
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
                TranslationValue = "Add Contact",
                CultureName = "en-US",
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
                TranslationValue = "Edit Supplier Contact",
                CultureName = "en-US",
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
                TranslationValue = "Add Currency",
                CultureName = "en-US",
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
                TranslationValue = "Add Bank Details",
                CultureName = "en-US",
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
                TranslationValue = "Edit Bank Details",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to publish this Supplier?",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Business Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub Business Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Group",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Short Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Commercial Registration Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Primary Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Lead Time (Days)",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "ICV Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "ICV Sub Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Year Established",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Website",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Product and Service Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Credit Period (Days)",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Days",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Source System",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "SME",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Direct Supplier Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Registration",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Certification Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Certification Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Expiry Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Share Holder Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Share %",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Customer Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Customer Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Address Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Address",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Province",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "District",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "DS area",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Postal Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Phone Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Address Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Is Primary",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this address will be the primary location",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Linked Contacts",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Make Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this record will be active",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Site Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Tax Land Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Contact Person Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Contact Person Salutation",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Contact Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "First Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Middle Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Last Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Land Phone",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Mobile",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this contact will be the primary contact",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Default Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Default",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Payment Method",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Credit Limit",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Name on the Cheque",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Retention %",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Payment Terms",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Bank Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Account Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Account Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "SWIFT Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "IBAN Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this bank account will be the primary account",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Corporate Details",
                CultureName = "en-US",
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
                TranslationValue = "Address & Contacts",
                CultureName = "en-US",
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
                TranslationValue = "Contact",
                CultureName = "en-US",
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
                TranslationValue = "Finance Details",
                CultureName = "en-US",
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
                TranslationValue = "Basic Information",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Certification",
                CultureName = "en-US",
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
                TranslationValue = "Share Holders",
                CultureName = "en-US",
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
                TranslationValue = "Customer Reference",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Sites",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Contacts",
                CultureName = "en-US",
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
                TranslationValue = "Payment",
                CultureName = "en-US",
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
                TranslationValue = "Bank Details",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Code",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Name",
                CultureName = "en-US",
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
                TranslationValue = "Supplier Type",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
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
                TranslationValue = "Credit Period",
                CultureName = "en-US",
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
                TranslationValue = "Source System",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Certifications, share holders, and customer references.",
                CultureName = "en-US",
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
                TranslationValue = "Payment, bank, tax, and GL account sections.",
                CultureName = "en-US",
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
                TranslationValue = "Supplier addresses and contacts.",
                CultureName = "en-US",
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
                TranslationValue = "Enter certification name",
                CultureName = "en-US",
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
                TranslationValue = "Enter certification code",
                CultureName = "en-US",
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
                TranslationValue = "Enter share holder name",
                CultureName = "en-US",
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
                TranslationValue = "Enter share percentage",
                CultureName = "en-US",
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
                TranslationValue = "Enter customer name",
                CultureName = "en-US",
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
                TranslationValue = "Enter customer email",
                CultureName = "en-US",
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
                TranslationValue = "Enter site name",
                CultureName = "en-US",
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
                TranslationValue = "Enter address name",
                CultureName = "en-US",
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
                TranslationValue = "Enter country",
                CultureName = "en-US",
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
                TranslationValue = "Enter address details",
                CultureName = "en-US",
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
                TranslationValue = "Enter province",
                CultureName = "en-US",
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
                TranslationValue = "Enter district",
                CultureName = "en-US",
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
                TranslationValue = "Enter DS area",
                CultureName = "en-US",
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
                TranslationValue = "Enter postal code",
                CultureName = "en-US",
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
                TranslationValue = "Enter phone number",
                CultureName = "en-US",
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
                TranslationValue = "Enter email address",
                CultureName = "en-US",
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
                TranslationValue = "Enter address type",
                CultureName = "en-US",
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
                TranslationValue = "Enter contact type",
                CultureName = "en-US",
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
                TranslationValue = "Enter first name",
                CultureName = "en-US",
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
                TranslationValue = "Enter middle name",
                CultureName = "en-US",
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
                TranslationValue = "Enter last name",
                CultureName = "en-US",
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
                TranslationValue = "Enter land phone",
                CultureName = "en-US",
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
                TranslationValue = "Enter mobile number",
                CultureName = "en-US",
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
                TranslationValue = "Enter bank name",
                CultureName = "en-US",
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
                TranslationValue = "Enter branch name",
                CultureName = "en-US",
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
                TranslationValue = "Enter account name",
                CultureName = "en-US",
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
                TranslationValue = "Enter account number",
                CultureName = "en-US",
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
                TranslationValue = "Enter SWIFT code",
                CultureName = "en-US",
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
                TranslationValue = "Enter IBAN number",
                CultureName = "en-US",
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
                TranslationValue = "Select tax land type",
                CultureName = "en-US",
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
                TranslationValue = "Select site(s)",
                CultureName = "en-US",
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
                TranslationValue = "Select salutation",
                CultureName = "en-US",
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
                TranslationValue = "Enter credit limit",
                CultureName = "en-US",
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
                TranslationValue = "Select default currency",
                CultureName = "en-US",
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
                TranslationValue = "Select payment method",
                CultureName = "en-US",
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
                TranslationValue = "Enter retention percentage",
                CultureName = "en-US",
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
                TranslationValue = "Enter supplier name on the cheque",
                CultureName = "en-US",
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
                TranslationValue = "Enter commercial registration number",
                CultureName = "en-US",
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
                TranslationValue = "Enter credit period",
                CultureName = "en-US",
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
                TranslationValue = "Enter lead time in days",
                CultureName = "en-US",
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
                TranslationValue = "Enter product and service description",
                CultureName = "en-US",
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
                TranslationValue = "Select SME status",
                CultureName = "en-US",
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
                TranslationValue = "Select source system",
                CultureName = "en-US",
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
                TranslationValue = "Enter supplier name",
                CultureName = "en-US",
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
                TranslationValue = "Enter supplier short name",
                CultureName = "en-US",
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
                TranslationValue = "Enter supplier website",
                CultureName = "en-US",
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
                TranslationValue = "Enter year established",
                CultureName = "en-US",
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
                TranslationValue = "A bank detail with the same Bank Name and Account Number already exists",
                CultureName = "en-US",
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
                TranslationValue = "Supplier draft is saved Successfully",
                CultureName = "en-US",
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
                TranslationValue = "This entry already exists",
                CultureName = "en-US",
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
                TranslationValue = "Add Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Edit Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "View Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Publish",
                CultureName = "en-US",
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
                TranslationValue = "Id",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Phone Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Location",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Time Zone",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Default Language",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Department",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Legal Entity",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Finance Center",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Legal Entities",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Available Legal Entities",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Departments",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Available Departments",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Select a Legal Entity first",
                CultureName = "en-US",
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
                TranslationValue = "Enter Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Phone Number",
                CultureName = "en-US",
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
                TranslationValue = "Enter Email",
                CultureName = "en-US",
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
                TranslationValue = "Enter Description",
                CultureName = "en-US",
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
                TranslationValue = "Search Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Search Department",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Id",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Email",
                CultureName = "en-US",
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
                TranslationValue = "Linked Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Contact Information",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to publish this Business Unit?",
                CultureName = "en-US",
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
                TranslationValue = "Organizational Assignments",
                CultureName = "en-US",
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
                TranslationValue = "Add Branch",
                CultureName = "en-US",
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
                KeyName = "translate.edm.branchMaster.actionButton.edit",
                TranslationValue = "Edit Branch",
                CultureName = "en-US",
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
                KeyName = "translate.edm.branchMaster.actionButton.view",
                TranslationValue = "View Branch",
                CultureName = "en-US",
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
                TranslationValue = "Branch Master",
                CultureName = "en-US",
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
                TranslationValue = "Add Branch",
                CultureName = "en-US",
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
                TranslationValue = "Edit Branch",
                CultureName = "en-US",
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
                TranslationValue = "View Branch",
                CultureName = "en-US",
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
                TranslationValue = "Basic Details",
                CultureName = "en-US",
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
                TranslationValue = "Add Location",
                CultureName = "en-US",
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
                TranslationValue = "Branch Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Short Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Business Unit",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Finance Centre",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Location",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Manager / Contact Person",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Contact Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Effective Start Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Effective End Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Country",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Enter Branch Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Branch Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Branch Email",
                CultureName = "en-US",
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
                TranslationValue = "Enter Branch Contact Number",
                CultureName = "en-US",
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
                TranslationValue = "Branch Code",
                CultureName = "en-US",
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
                TranslationValue = "Branch Name",
                CultureName = "en-US",
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
                TranslationValue = "Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Branch Manager/Contact Person",
                CultureName = "en-US",
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
                TranslationValue = "Location",
                CultureName = "en-US",
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
                TranslationValue = "Email",
                CultureName = "en-US",
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
                TranslationValue = "Contact Number",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address ΓåÆ Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.address.breadcrumb.title",
                TranslationValue = "Address",
                CultureName = "en-US",
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
                TranslationValue = "Address Type Rules",
                CultureName = "en-US",
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
                TranslationValue = "Address Requirements",
                CultureName = "en-US",
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
                TranslationValue = "Address Types ({{count}})",
                CultureName = "en-US",
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
                TranslationValue = "Entity Types ({{count}})",
                CultureName = "en-US",
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
                TranslationValue = "Manage Address Types",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address ΓåÆ Section Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.purpose.title",
                TranslationValue = "Purpose",
                CultureName = "en-US",
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
                TranslationValue = "Address Requirements",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-ARQ",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Address Type Rules ΓåÆ Column Header
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.addressTypeRules.columns.fieldKey",
                TranslationValue = "Field Key",
                CultureName = "en-US",
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
                TranslationValue = "Display Label",
                CultureName = "en-US",
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
                TranslationValue = "Visible",
                CultureName = "en-US",
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
                TranslationValue = "Required",
                CultureName = "en-US",
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
                TranslationValue = "Address Type",
                CultureName = "en-US",
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
                TranslationValue = "Purpose",
                CultureName = "en-US",
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
                TranslationValue = "Mandatory",
                CultureName = "en-US",
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
                TranslationValue = "Enforced At",
                CultureName = "en-US",
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
                TranslationValue = "Add Address Types",
                CultureName = "en-US",
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
                TranslationValue = "No address types configured. Click \"Add Address Types\" to begin.",
                CultureName = "en-US",
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
                TranslationValue = "All address types have been added.",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to remove this address type? This action cannot be undone!",
                CultureName = "en-US",
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
                TranslationValue = "Mandatory address types cannot be removed.",
                CultureName = "en-US",
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
                TranslationValue = "Toggle Menu",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Add Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "View Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Edit Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Finance Details",
                CultureName = "en-US",
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
                TranslationValue = "Contact & Location Details",
                CultureName = "en-US",
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
                TranslationValue = "Configuration",
                CultureName = "en-US",
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
                TranslationValue = "Linked Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Company Registration No.",
                CultureName = "en-US",
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
                TranslationValue = "Location",
                CultureName = "en-US",
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
                TranslationValue = "Add Location",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.label.generalInformation.description",
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Phone Number",
                CultureName = "en-US",
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
                TranslationValue = "Email",
                CultureName = "en-US",
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
                TranslationValue = "Default Language",
                CultureName = "en-US",
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
                TranslationValue = "Time Zone",
                CultureName = "en-US",
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
                TranslationValue = "Industry Type",
                CultureName = "en-US",
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
                TranslationValue = "Website URL",
                CultureName = "en-US",
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
                TranslationValue = "Logo",
                CultureName = "en-US",
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
                TranslationValue = "Browse Logo",
                CultureName = "en-US",
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
                TranslationValue = "Add Logo",
                CultureName = "en-US",
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
                TranslationValue = "Group of Legal Entities",
                CultureName = "en-US",
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
                TranslationValue = "Create this legal entity as a group of legal entities",
                CultureName = "en-US",
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
                TranslationValue = "Share Master Across Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Set this as a master across the legal entities",
                CultureName = "en-US",
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
                TranslationValue = "Parent Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Functional Currency",
                CultureName = "en-US",
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
                TranslationValue = "Reporting Currency",
                CultureName = "en-US",
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
                TranslationValue = "Consolidation Currency",
                CultureName = "en-US",
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
                TranslationValue = "VAT Registered",
                CultureName = "en-US",
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
                TranslationValue = "If enable, confirms you are VAT registered",
                CultureName = "en-US",
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
                TranslationValue = "VAT Registration No.",
                CultureName = "en-US",
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
                TranslationValue = "Tax Card No.",
                CultureName = "en-US",
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
                TranslationValue = "Default Payment Term",
                CultureName = "en-US",
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
                TranslationValue = "Default Selling Term",
                CultureName = "en-US",
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
                TranslationValue = "Location",
                CultureName = "en-US",
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
                TranslationValue = "Phone Number",
                CultureName = "en-US",
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
                TranslationValue = "Email",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "City",
                CultureName = "en-US",
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
                TranslationValue = "Area",
                CultureName = "en-US",
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
                TranslationValue = "Way",
                CultureName = "en-US",
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
                TranslationValue = "Building",
                CultureName = "en-US",
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
                TranslationValue = "Postal Code",
                CultureName = "en-US",
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
                TranslationValue = "P.O. Box",
                CultureName = "en-US",
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
                TranslationValue = "Time Zone",
                CultureName = "en-US",
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
                TranslationValue = "Default Language",
                CultureName = "en-US",
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
                TranslationValue = "Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Business Units",
                CultureName = "en-US",
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
                TranslationValue = "Search Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Available Business Units",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Toggle Menu",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Basic Information of the Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Finance Details",
                CultureName = "en-US",
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
                TranslationValue = "Financial Details of the Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Contact & Address Details",
                CultureName = "en-US",
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
                TranslationValue = "Contact & Location Details of the Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Configurations",
                CultureName = "en-US",
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
                TranslationValue = "Default Configurations of the Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Linked Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Linked Business Units of the Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Company",
                CultureName = "en-US",
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
                TranslationValue = "Add Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "CR Number",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entity Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.legalEntityName",
                TranslationValue = "Legal Entity Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.crNumber",
                TranslationValue = "CR Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.email",
                TranslationValue = "Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.status",
                TranslationValue = "Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.createdDate",
                TranslationValue = "Created Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.createdBy",
                TranslationValue = "Created By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.updatedDate",
                TranslationValue = "Updated Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.tableHeaders.columnheader.updatedBy",
                TranslationValue = "Updated By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Legal Entity ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.actionbutton.draft",
                TranslationValue = "Draft",
                CultureName = "en-US",
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
                TranslationValue = "Save & Continue",
                CultureName = "en-US",
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
                TranslationValue = "Auto Generated Field",
                CultureName = "en-US",
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
                TranslationValue = "Enter Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Company Registration No.",
                CultureName = "en-US",
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
                TranslationValue = "Select Location",
                CultureName = "en-US",
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
                TranslationValue = "Enter Description",
                CultureName = "en-US",
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
                TranslationValue = "Enter Phone Number",
                CultureName = "en-US",
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
                TranslationValue = "Enter Email",
                CultureName = "en-US",
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
                TranslationValue = "Select Default Language",
                CultureName = "en-US",
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
                TranslationValue = "Select Time Zone",
                CultureName = "en-US",
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
                TranslationValue = "Select Industry Type",
                CultureName = "en-US",
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
                TranslationValue = "Enter Website URL",
                CultureName = "en-US",
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
                TranslationValue = "Select Functional Currency",
                CultureName = "en-US",
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
                TranslationValue = "Select Reporting Currency",
                CultureName = "en-US",
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
                TranslationValue = "Select Consolidation Currency",
                CultureName = "en-US",
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
                TranslationValue = "Enter VAT Registration No.",
                CultureName = "en-US",
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
                TranslationValue = "Enter Tax Card No.",
                CultureName = "en-US",
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
                TranslationValue = "Select Default Payment Term",
                CultureName = "en-US",
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
                TranslationValue = "Select Default Selling Term",
                CultureName = "en-US",
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
                TranslationValue = "Select Location",
                CultureName = "en-US",
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
                TranslationValue = "Enter Phone Number",
                CultureName = "en-US",
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
                TranslationValue = "Enter Email",
                CultureName = "en-US",
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
                TranslationValue = "Select Country",
                CultureName = "en-US",
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
                TranslationValue = "Enter City",
                CultureName = "en-US",
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
                TranslationValue = "Enter Area",
                CultureName = "en-US",
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
                TranslationValue = "Enter Way",
                CultureName = "en-US",
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
                TranslationValue = "Enter Building",
                CultureName = "en-US",
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
                TranslationValue = "Enter Postal Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter P.O. Box",
                CultureName = "en-US",
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
                TranslationValue = "Select Time Zone",
                CultureName = "en-US",
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
                TranslationValue = "Select Default Language",
                CultureName = "en-US",
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
                TranslationValue = "Select Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Logo uploaded successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to upload logo",
                CultureName = "en-US",
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
                TranslationValue = "Failed to remove logo",
                CultureName = "en-US",
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
                TranslationValue = "Failed to create location",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-LE",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.legalEntity.notification.businessUnitAssignFail",
                TranslationValue = "Failed to update business unit assignment",
                CultureName = "en-US",
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
                TranslationValue = "Failed to load legal entity",
                CultureName = "en-US",
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
                TranslationValue = "Legal entity saved successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to save legal entity",
                CultureName = "en-US",
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
                TranslationValue = "Legal entity created successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to create legal entity",
                CultureName = "en-US",
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
                TranslationValue = "Please fix the validation before saving",
                CultureName = "en-US",
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
                TranslationValue = "Add Item",
                CultureName = "en-US",
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
                TranslationValue = "Item Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Company Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Short Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Finance Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Finance Subcategory",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Primary UOM",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Alternative UOM",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Is Sub-item",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this item is set as a sub-item of another item",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "POS System Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "VAT Subcategory",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Upload a document",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Audit Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Main Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub Category 01",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub Category 02",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub Category 03",
                CultureName = "en-US",
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
                TranslationValue = "Enter item code",
                CultureName = "en-US",
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
                TranslationValue = "Enter item name",
                CultureName = "en-US",
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
                TranslationValue = "Enter item short description",
                CultureName = "en-US",
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
                TranslationValue = "Select item finance category",
                CultureName = "en-US",
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
                TranslationValue = "Select finance subcategory",
                CultureName = "en-US",
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
                TranslationValue = "Select audit category",
                CultureName = "en-US",
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
                TranslationValue = "Select item type",
                CultureName = "en-US",
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
                TranslationValue = "Select main category",
                CultureName = "en-US",
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
                TranslationValue = "Select sub category 01",
                CultureName = "en-US",
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
                TranslationValue = "Select sub category 02",
                CultureName = "en-US",
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
                TranslationValue = "Select sub category 03",
                CultureName = "en-US",
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
                TranslationValue = "Select primary UOM",
                CultureName = "en-US",
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
                TranslationValue = "Select alternative UOM",
                CultureName = "en-US",
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
                TranslationValue = "Select POS system type",
                CultureName = "en-US",
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
                TranslationValue = "Select VAT subcategory",
                CultureName = "en-US",
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
                TranslationValue = "Remove attachment",
                CultureName = "en-US",
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
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.ariaDropzone",
                TranslationValue = "Drop file to upload",
                CultureName = "en-US",
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
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.browseDocument",
                TranslationValue = "Browse or drop document here",
                CultureName = "en-US",
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
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.uploadFailed",
                TranslationValue = "Failed to upload document",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.attachment.removeFailed",
                TranslationValue = "Failed to remove document",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "edm.enterpriseStructure.itemMaster.detail.generalInformation.title",
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Item Code",
                CultureName = "en-US",
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
                TranslationValue = "Item Type",
                CultureName = "en-US",
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
                TranslationValue = "Part Number / Reference Number",
                CultureName = "en-US",
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
                TranslationValue = "Item Description",
                CultureName = "en-US",
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
                TranslationValue = "UOM",
                CultureName = "en-US",
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
                TranslationValue = "Item Finance Category",
                CultureName = "en-US",
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
                TranslationValue = "Finance Subcategory",
                CultureName = "en-US",
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
                TranslationValue = "Primary Company",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Item Master",
                CultureName = "en-US",
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
                TranslationValue = "Add Item",
                CultureName = "en-US",
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
                TranslationValue = "Edit Item",
                CultureName = "en-US",
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
                TranslationValue = "View Item",
                CultureName = "en-US",
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
                TranslationValue = "Location",
                CultureName = "en-US",
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
                TranslationValue = "Add Location",
                CultureName = "en-US",
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
                TranslationValue = "Edit Location",
                CultureName = "en-US",
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
                TranslationValue = "View Location",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Company Name",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Primary Address",
                CultureName = "en-US",
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
                TranslationValue = "If enabled, this location will be set as the primary address.",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Location Type",
                CultureName = "en-US",
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
                TranslationValue = "Enter Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Name",
                CultureName = "en-US",
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
                TranslationValue = "Enter Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Select Country",
                CultureName = "en-US",
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
                TranslationValue = "Select Location Type",
                CultureName = "en-US",
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
                TranslationValue = "╪º╪»╪«┘ä ┘ç┘å╪º",
                CultureName = "ar-OM",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Address",
                CultureName = "en-US",
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
                TranslationValue = "Add Location",
                CultureName = "en-US",
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
                TranslationValue = "Location Code",
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
                KeyName = "translate.edm.masters.location.columnHeaders.shortCode",
                TranslationValue = "Short Code",
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
                KeyName = "translate.edm.masters.location.columnHeaders.isPrimary",
                TranslationValue = "Primary",
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
                TranslationValue = "Location Name",
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
                KeyName = "translate.edm.masters.location.columnHeaders.createdDate",
                TranslationValue = "Created Date",
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
                KeyName = "translate.edm.masters.location.columnHeaders.createdBy",
                TranslationValue = "Created By",
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
                KeyName = "translate.edm.masters.location.columnHeaders.updatedDate",
                TranslationValue = "Updated Date",
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
                KeyName = "translate.edm.masters.location.columnHeaders.updatedBy",
                TranslationValue = "Updated By",
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
                KeyName = "translate.edm.masters.location.columnHeaders.status",
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Failed to the save data",
                CultureName = "en-US",
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
                TranslationValue = "Failed to update the data",
                CultureName = "en-US",
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
                TranslationValue = "Financial Centre",
                CultureName = "en-US",
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
                TranslationValue = "Edit Financial Centre",
                CultureName = "en-US",
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
                TranslationValue = "View Financial Centre",
                CultureName = "en-US",
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
                TranslationValue = "Add Financial Centre",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Type",
                CultureName = "en-US",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Type",
                CultureName = "en-US",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Cannot Delete",
                CultureName = "en-US",
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
                TranslationValue = "This financial centre is in use and cannot be deleted.",
                CultureName = "en-US",
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
                TranslationValue = "Warehouse",
                CultureName = "en-US",
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
                TranslationValue = "Edit Warehouse",
                CultureName = "en-US",
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
                TranslationValue = "View Warehouse",
                CultureName = "en-US",
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
                TranslationValue = "Add Warehouse",
                CultureName = "en-US",
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
                TranslationValue = "Auto Generated Field",
                CultureName = "en-US",
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
                TranslationValue = "Enter Warehouse Name",
                CultureName = "en-US",
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
                TranslationValue = "Identity",
                CultureName = "en-US",
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
                TranslationValue = "Warehouse Allocation",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Type",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entity",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Business Unit",
                CultureName = "en-US",
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
                TranslationValue = "Branch",
                CultureName = "en-US",
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
                TranslationValue = "Location",
                CultureName = "en-US",
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
                TranslationValue = "Is Default",
                CultureName = "en-US",
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
                TranslationValue = "If enabled, this warehouse becomes the default.",
                CultureName = "en-US",
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
                TranslationValue = "Address Line",
                CultureName = "en-US",
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
                TranslationValue = "Enter address",
                CultureName = "en-US",
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
                TranslationValue = "Physical",
                CultureName = "en-US",
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
                TranslationValue = "Logical",
                CultureName = "en-US",
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
                TranslationValue = "In-Transit",
                CultureName = "en-US",
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
                TranslationValue = "Storage Hierarchy",
                CultureName = "en-US",
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
                TranslationValue = "Hierarchy depth",
                CultureName = "en-US",
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
                TranslationValue = "Flat (No Bins)",
                CultureName = "en-US",
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
                TranslationValue = "Warehouse ΓåÆ Bin",
                CultureName = "en-US",
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
                TranslationValue = "Warehouse ΓåÆ Zone ΓåÆ Bin",
                CultureName = "en-US",
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
                TranslationValue = "Items",
                CultureName = "en-US",
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
                TranslationValue = "Assign",
                CultureName = "en-US",
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
                TranslationValue = "Add Bin",
                CultureName = "en-US",
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
                TranslationValue = "Add Zone",
                CultureName = "en-US",
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
                TranslationValue = "Delete",
                CultureName = "en-US",
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
                TranslationValue = "Save the warehouse first to configure its storage hierarchy.",
                CultureName = "en-US",
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
                TranslationValue = "Assign Items",
                CultureName = "en-US",
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
                TranslationValue = "Assigning to {{node}} ┬╖ showing active & approved items only",
                CultureName = "en-US",
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
                TranslationValue = "Search",
                CultureName = "en-US",
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
                TranslationValue = "All Category",
                CultureName = "en-US",
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
                TranslationValue = "Sub Category",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Item",
                CultureName = "en-US",
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
                TranslationValue = "Category",
                CultureName = "en-US",
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
                TranslationValue = "Sub category",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Type",
                CultureName = "en-US",
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
                TranslationValue = "Entity / Branch",
                CultureName = "en-US",
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
                TranslationValue = "Storage",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Default",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Add Bank Account",
                CultureName = "en-US",
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
                TranslationValue = "Bank Details",
                CultureName = "en-US",
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
                TranslationValue = "Branch Details",
                CultureName = "en-US",
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
                TranslationValue = "Account Details",
                CultureName = "en-US",
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
                TranslationValue = "Other Details",
                CultureName = "en-US",
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
                TranslationValue = "Bank",
                CultureName = "en-US",
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
                TranslationValue = "Branch",
                CultureName = "en-US",
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
                TranslationValue = "Account Name",
                CultureName = "en-US",
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
                TranslationValue = "Account Number",
                CultureName = "en-US",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
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
                TranslationValue = "IBAN Number",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Bank Account",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Bank Account",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Bank Account",
                CultureName = "en-US",
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
                TranslationValue = "Bank Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Bank Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "SWIFT Code",
                CultureName = "en-US",
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
                TranslationValue = "Branch",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Contact Person",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Code",
                CultureName = "en-US",
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
                KeyName = "translate.edm.masters.bankAccount.label.telephone",
                TranslationValue = "Telephone",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Email",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Branch Address",
                CultureName = "en-US",
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
                TranslationValue = "Account Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Account Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Account Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "IBAN Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Account Created Date",
                CultureName = "en-US",
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
                TranslationValue = "GL Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Cheque Printed Starting Number",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Salary Bank",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "When enabled, selectable in HRMS during salary payment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Temporary Account",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this will be a temporary account",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Temporary Start Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Temporary End Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Note",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = false,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Bank Account ΓåÆ Placeholder
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.bankAccount.detail.bankDetails.placeholder.bankName",
                TranslationValue = "Select bank name",
                CultureName = "en-US",
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
                TranslationValue = "Select branch name",
                CultureName = "en-US",
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
                TranslationValue = "Enter contact person name",
                CultureName = "en-US",
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
                TranslationValue = "Enter telephone number",
                CultureName = "en-US",
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
                TranslationValue = "Enter email address",
                CultureName = "en-US",
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
                TranslationValue = "Enter branch address",
                CultureName = "en-US",
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
                TranslationValue = "Select account type",
                CultureName = "en-US",
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
                TranslationValue = "Enter account number",
                CultureName = "en-US",
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
                TranslationValue = "Enter account name",
                CultureName = "en-US",
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
                TranslationValue = "Select currency",
                CultureName = "en-US",
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
                TranslationValue = "Enter iban number",
                CultureName = "en-US",
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
                TranslationValue = "Select GL code",
                CultureName = "en-US",
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
                TranslationValue = "Enter number",
                CultureName = "en-US",
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
                TranslationValue = "Add a note",
                CultureName = "en-US",
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
                TranslationValue = "Account number must contain digits only",
                CultureName = "en-US",
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
                TranslationValue = "Temporary Start Date cannot be before Account Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Temporary End Date cannot be before Temporary Start Date",
                CultureName = "en-US",
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
                TranslationValue = "Financial Template",
                CultureName = "en-US",
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
                TranslationValue = "Financial Template",
                CultureName = "en-US",
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
                TranslationValue = "Create Financial Template",
                CultureName = "en-US",
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
                TranslationValue = "Edit Financial Template",
                CultureName = "en-US",
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
                TranslationValue = "View Financial Template",
                CultureName = "en-US",
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
                TranslationValue = "Configure Chart Of Account Template",
                CultureName = "en-US",
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
                TranslationValue = "Add Financial Template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.draft",
                TranslationValue = "Draft",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.saveAndContinue",
                TranslationValue = "Save & Continue",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.assignUsers",
                TranslationValue = "Assign Users",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.removeUser",
                TranslationValue = "Remove User",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.configure",
                TranslationValue = "Configure",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.restore",
                TranslationValue = "Restore",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addNewHeader",
                TranslationValue = "Add New Header",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.copyFromTemplate",
                TranslationValue = "Copy from Existing Template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.applyNow",
                TranslationValue = "Apply Now",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addRow",
                TranslationValue = "Add Row",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.addSubCategory",
                TranslationValue = "Add Sub Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.manageInclusion",
                TranslationValue = "Manage Inclusion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.unlinkGl",
                TranslationValue = "Unlink GL",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.buttons.actionbutton.linkGlCodes",
                TranslationValue = "Link GL Codes",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.yes",
                TranslationValue = "Yes",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.no",
                TranslationValue = "No",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.noAssignedUsers",
                TranslationValue = "No users have been assigned yet.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.active",
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.inactive",
                TranslationValue = "Inactive",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.companies",
                TranslationValue = "Companies",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.companiesWarning",
                TranslationValue = "This template will be auto-assigned to all selected companies in Inactive state. Each company must activate it before use.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isPublic",
                TranslationValue = "Visible in Reports",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isPublicDesc",
                TranslationValue = "If enabled, this template appears in the reports list",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isDefault",
                TranslationValue = "Default Template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.isDefaultDesc",
                TranslationValue = "If enabled, this is the default template for the selected type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.templateAction",
                TranslationValue = "Template Action",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.sourceTemplate",
                TranslationValue = "Link To",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.linkEquals",
                TranslationValue = "Link =",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyMode",
                TranslationValue = "Copy Mode",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintIndividual",
                TranslationValue = "Individual template ΓÇö belongs to this company only",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintGlobalTitle",
                TranslationValue = "Global template ΓÇö choose how to create it",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.copyModeHintGlobalBody",
                TranslationValue = "Linking adopts the selected template fully. This company will share the same Chart of Accounts codes and sequence as the originating company. No new codes can be generated independently.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.primaryFilter",
                TranslationValue = "Primary Filter",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.allowCrossPeriod",
                TranslationValue = "Allow Cross Period",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.allowCrossPeriodDesc",
                TranslationValue = "If enabled, this template can pull data across multiple financial periods.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.consolidationDesc",
                TranslationValue = "If enabled, template will be a consolidation template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.codeConfigInfo",
                TranslationValue = "These settings control how account codes are generated under this template. They are locked once the first GL account is created. Configure carefully before activating.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.maxTotalCodeLength",
                TranslationValue = "Maximum Total Code Length",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.coaSerialLength",
                TranslationValue = "COA Serial Length",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.maxNumberOfLevels",
                TranslationValue = "Maximum Levels",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.uniformLengthPadding",
                TranslationValue = "Pad All Leaf Codes with Trailing Zeros",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.uniformLengthPaddingDesc",
                TranslationValue = "Ensures all GL Codes reach maximum length",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialLengthMode",
                TranslationValue = "Mode",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialLength",
                TranslationValue = "Fixed Serial Length (Per Level)",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.level",
                TranslationValue = "Level",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelLabel",
                TranslationValue = "Level {{level}}",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScope0",
                TranslationValue = "Asset / Liability / Equity / Income / Expense",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeBs0",
                TranslationValue = "Asset / Liability / Equity",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopePl0",
                TranslationValue = "Income / Expense",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeCf0",
                TranslationValue = "Operating / Investing / Financing",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeCe0",
                TranslationValue = "Share Capital / Reserves / Retained Earnings",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.levelScopeSubCategory",
                TranslationValue = "Sub category {{index}}",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.categoryScope",
                TranslationValue = "Category Scope",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.serialDigits",
                TranslationValue = "Serial Digits",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.computedPrefixLength",
                TranslationValue = "Computed Prefix Length",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.computedPrefixLengthValue",
                TranslationValue = "{{count}} digit(s) total prefix",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.fixed",
                TranslationValue = "Fixed",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.previewLabel",
                TranslationValue = "Sample GL Account Code Based on Current Setting",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.previewExample",
                TranslationValue = "Example Path : Assets (L1) ΓåÆ Current Asset (L2) ΓåÆ Cash at Bank (GL)",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.noRecords",
                TranslationValue = "No records found",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.columnComingSoon",
                TranslationValue = "Column configuration will be available soon.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.selectedCount",
                TranslationValue = "{{count}} selected",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.unmappedGlCodes",
                TranslationValue = "Unmapped GL Codes: {{count}}",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.label.selectedGlCount",
                TranslationValue = "{{count}} selected",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.searchGlCodes",
                TranslationValue = "Search",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.prefixLengthHint",
                TranslationValue = "Alphanumeric and must end with a digit. Length must be less than the serial length ({{serialLength}}).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.childLengthHint",
                TranslationValue = "Child length is parent ({{parent}}) length plus 1 and must stay less than serial length ({{serialLength}}).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.inclusionHint",
                TranslationValue = "Toggle child rows to include or exclude them from this parent.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.prefixHint",
                TranslationValue = "Prefix is generated automatically from the parent prefix.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.lengthHint",
                TranslationValue = "Length is calculated from the prefix.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.unmappedGlCodes",
                TranslationValue = "{{count}} Unmapped GL Codes",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.startWithZero",
                TranslationValue = "Start with 0",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.filterAndSearch",
                TranslationValue = "Filter And Search",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.chartOfAccounts",
                TranslationValue = "Chart of Accounts",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.balanceSheet",
                TranslationValue = "Balance Sheet",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.pnl",
                TranslationValue = "PNL",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.fields.label.scope",
                TranslationValue = "Scope",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.code",
                TranslationValue = "Template Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.templateType",
                TranslationValue = "Template Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.name",
                TranslationValue = "Template Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.templateGroup",
                TranslationValue = "Template Group",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.category",
                TranslationValue = "Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.consolidation",
                TranslationValue = "Consolidation",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.public",
                TranslationValue = "Public",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.default",
                TranslationValue = "Default",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.createdDate",
                TranslationValue = "Created Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.createdBy",
                TranslationValue = "Created By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.status",
                TranslationValue = "Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.description",
                TranslationValue = "Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.updatedBy",
                TranslationValue = "Updated By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.updatedDate",
                TranslationValue = "Updated Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.prefix",
                TranslationValue = "Prefix",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.type",
                TranslationValue = "Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.length",
                TranslationValue = "Length",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.sortOrder",
                TranslationValue = "Sort Order",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.hide",
                TranslationValue = "Hide",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.controlAccount",
                TranslationValue = "Control AC",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.mappedTo",
                TranslationValue = "Mapped To",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.accountType",
                TranslationValue = "Account Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tableHeaders.columnheader.glCode",
                TranslationValue = "GL Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.templateHeader",
                TranslationValue = "Template Header",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.codeConfiguration",
                TranslationValue = "Code Configuration",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.flagsVisibility",
                TranslationValue = "Flags & Visibility",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.generalInformation",
                TranslationValue = "General Information",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.templateGroupAction",
                TranslationValue = "Template Group & Action",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.reportingFiltering",
                TranslationValue = "Reporting & Filtering",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.companiesApplicable",
                TranslationValue = "Companies Applicable",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.flagsVisibility",
                TranslationValue = "Flags & Visibility",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.assignedUsers",
                TranslationValue = "Assigned Users",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.codeConfiguration",
                TranslationValue = "Code Length Setting",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.serialLengthPerLevel",
                TranslationValue = "Serial Length Per Level",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.liveCodePreview",
                TranslationValue = "Live Code Preview",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.rowConfiguration",
                TranslationValue = "Row Configuration",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tabs.sectionheader.columnConfiguration",
                TranslationValue = "Column Configuration",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.sections.sectionheader.criteriaItems",
                TranslationValue = "Criteria Items",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.invalidCategoryForTypeTitle",
                TranslationValue = "Invalid template category",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.invalidCategoryForType",
                TranslationValue = "Budget and Chart of Accounts are only valid for Balance Sheet or Profit & Loss.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.activeDefaultCoaExistsTitle",
                TranslationValue = "Chart of Accounts not available",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.activeDefaultCoaExists",
                TranslationValue = "There is already an Active & Default Chart of Account Template for {{templateType}} - {{reportName}}",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeleteActive",
                TranslationValue = "Active templates cannot be deleted.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateTitle",
                TranslationValue = "Cannot deactivate template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateWithGlCodes",
                TranslationValue = "Cannot deactivate: GL codes exist under this template.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeactivateWithBudget",
                TranslationValue = "Cannot deactivate: a Budget has been defined using this template.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotClearDefaultTitle",
                TranslationValue = "Cannot clear default",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotClearDefault",
                TranslationValue = "Cannot set Is Default to No while GL codes exist under this Chart of Accounts template.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2Title",
                TranslationValue = "Alert",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2Body",
                TranslationValue = "Level 1 is restricted to 1 digit (covers Asset, Liability, Equity, Income, Expense ΓÇö max 5 values). Configure levels 2 onwards. Sum of all level digits must not exceed Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyBs",
                TranslationValue = "Level 1 is restricted to 1 digit (covers Asset, Liability, Equity ΓÇö max 3 values). Configure levels 2 onwards. Sum of all level digits must not exceed Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyPl",
                TranslationValue = "Level 1 is restricted to 1 digit (covers Income, Expense ΓÇö max 2 values). Configure levels 2 onwards. Sum of all level digits must not exceed Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyCf",
                TranslationValue = "Level 1 is restricted to 1 digit (covers Operating, Investing, Financing ΓÇö max 3 values). Configure levels 2 onwards. Sum of all level digits must not exceed Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.alerts.notification.mode2BodyCe",
                TranslationValue = "Level 1 is restricted to 1 digit (covers Share Capital, Reserves, Retained Earnings ΓÇö max 3 values). Configure levels 2 onwards. Sum of all level digits must not exceed Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.hierarchyLengthMismatch",
                TranslationValue = "When uniform length padding is off, the sum of all level digits must equal Max Code Length minus COA Serial Length.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.noAssignableUsers",
                TranslationValue = "No assignable users are available for this template.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.usersAssigned",
                TranslationValue = "Users assigned successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.userRemoved",
                TranslationValue = "User assignment removed successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.configureComingSoon",
                TranslationValue = "Template configuration will be available soon.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.restored",
                TranslationValue = "Template restored successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.glUnlinked",
                TranslationValue = "GL code unlinked successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowHidden",
                TranslationValue = "Row visibility updated successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.headerSaved",
                TranslationValue = "Header saved successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.subCategoriesSaved",
                TranslationValue = "Sub-categories saved successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowsCopied",
                TranslationValue = "Rows copied successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.glLinked",
                TranslationValue = "GL codes linked successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.rowDeleted",
                TranslationValue = "Row deleted successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.notifications.notification.inclusionSaved",
                TranslationValue = "Inclusion updated successfully.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.cannotDeleteWithChildren",
                TranslationValue = "This row cannot be deleted because it has child rows.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.duplicateSortOrder",
                TranslationValue = "Sort order must be unique among sibling rows.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.duplicatePrefix",
                TranslationValue = "Prefix must be unique among sibling rows.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.prefixBreaksChildren",
                TranslationValue = "This prefix change would invalidate existing child prefixes.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.errors.notification.rowLoadFailed",
                TranslationValue = "Could not load row configuration.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Headers / Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.clearAssignmentsTitle",
                TranslationValue = "Make template public?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.clearAssignments",
                TranslationValue = "All User Assignments ({{users}}) will be cleared. Are you sure you want to proceed?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.setDefaultTitle",
                TranslationValue = "Set as default?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.setDefault",
                TranslationValue = "Setting this template as Default will automatically remove the Default flag from the existing default template of the same Template Type. Do you want to continue?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.removeUserTitle",
                TranslationValue = "Remove user?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.removeUser",
                TranslationValue = "Are you sure you want to remove this user assignment?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.header.restoreTitle",
                TranslationValue = "Restore template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.restore",
                TranslationValue = "Are you sure you want to restore this template?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.addNewHeader",
                TranslationValue = "Add New Header",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.editHeader",
                TranslationValue = "Edit Header",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.editRow",
                TranslationValue = "Edit Row",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.addSubCategory",
                TranslationValue = "Add Sub Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.copyFromTemplate",
                TranslationValue = "Copy from Existing Template",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.linkGlCodes",
                TranslationValue = "Link GL Codes",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.manageInclusion",
                TranslationValue = "Manage Inclusion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.deleteRow",
                TranslationValue = "Delete row?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.headers.header.deleteGl",
                TranslationValue = "Unlink GL code?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.deleteRow",
                TranslationValue = "Are you sure you want to delete this row?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.confirmation.deleteGl",
                TranslationValue = "Are you sure you want to unlink this GL code?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Financial Template ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.allowCrossPeriod",
                TranslationValue = "If enabled, this template can pull data across multiple financial periods instead of a single period.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.maxTotalCodeLength",
                TranslationValue = "The maximum number of digits allowed in the full GL account code, including all levels.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.financialTemplate.tooltips.tooltip.coaSerialLength",
                TranslationValue = "Digits reserved for the leaf-level account number. Min: 2. This is subtracted from Max Code Length to calculate the available levels.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-FT",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Accounting Calendar ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.accountingcalendar.actionbutton.add",
                TranslationValue = "Add Accounting Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Cancel",
                CultureName = "en-US",
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
                TranslationValue = "Save as Draft",
                CultureName = "en-US",
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
                TranslationValue = "Save and Continue",
                CultureName = "en-US",
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
                TranslationValue = "Save",
                CultureName = "en-US",
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
                TranslationValue = "Skip",
                CultureName = "en-US",
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
                TranslationValue = "Share",
                CultureName = "en-US",
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
                TranslationValue = "Add Company",
                CultureName = "en-US",
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
                TranslationValue = "Remove Company",
                CultureName = "en-US",
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
                TranslationValue = "Generate Periods",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Code",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Name",
                CultureName = "en-US",
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
                TranslationValue = "Number of Periods per Year",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year Start Month",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Code",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Name",
                CultureName = "en-US",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Period Type",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year Start Month",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year End Month",
                CultureName = "en-US",
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
                TranslationValue = "Number of Periods per Year",
                CultureName = "en-US",
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
                TranslationValue = "Start Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "End Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Status",
                CultureName = "en-US",
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
                TranslationValue = "Adjustment Periods Allowed",
                CultureName = "en-US",
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
                TranslationValue = "Number of Adjustment Periods",
                CultureName = "en-US",
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
                TranslationValue = "Sequential Close Enforcement",
                CultureName = "en-US",
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
                TranslationValue = "Active",
                CultureName = "en-US",
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
                TranslationValue = "Inactive",
                CultureName = "en-US",
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
                TranslationValue = "Draft",
                CultureName = "en-US",
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
                TranslationValue = "Period Name",
                CultureName = "en-US",
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
                TranslationValue = "Period Number",
                CultureName = "en-US",
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
                TranslationValue = "Start Date",
                CultureName = "en-US",
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
                TranslationValue = "End Date",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "Quarter",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Regular",
                CultureName = "en-US",
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
                TranslationValue = "Adjustment",
                CultureName = "en-US",
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
                TranslationValue = "Sharing Type",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entities",
                CultureName = "en-US",
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
                TranslationValue = "Global",
                CultureName = "en-US",
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
                TranslationValue = "Shared",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Period",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Summary",
                CultureName = "en-US",
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
                TranslationValue = "Owner",
                CultureName = "en-US",
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
                TranslationValue = "Assigned To",
                CultureName = "en-US",
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
                TranslationValue = "Viewing Company",
                CultureName = "en-US",
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
                TranslationValue = "Select Company",
                CultureName = "en-US",
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
                TranslationValue = "All Fiscal Years",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Years",
                CultureName = "en-US",
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
                TranslationValue = "FY Pattern",
                CultureName = "en-US",
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
                TranslationValue = "FY Start",
                CultureName = "en-US",
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
                TranslationValue = "Total Periods",
                CultureName = "en-US",
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
                TranslationValue = "Open Periods",
                CultureName = "en-US",
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
                TranslationValue = "Closed / Locked",
                CultureName = "en-US",
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
                TranslationValue = "Closed or Permanently Closed",
                CultureName = "en-US",
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
                TranslationValue = "Currently open for posting",
                CultureName = "en-US",
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
                TranslationValue = "No companies assigned yet",
                CultureName = "en-US",
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
                TranslationValue = "Select company/legal entity",
                CultureName = "en-US",
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
                TranslationValue = "Record will be available for all the companies without any restrictions.",
                CultureName = "en-US",
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
                TranslationValue = "Restricted",
                CultureName = "en-US",
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
                TranslationValue = "Record availability will be restricted only for the current Company.",
                CultureName = "en-US",
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
                TranslationValue = "Record will be available for the assigned/selected companies only.",
                CultureName = "en-US",
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
                TranslationValue = "Record availability will be restricted only for the current company.",
                CultureName = "en-US",
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
                TranslationValue = "This calendar will be available to all companies without any restrictions.",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar & Configurations are shared. Period Management will be managed individually.",
                CultureName = "en-US",
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
                TranslationValue = "Changes will be applied upon save",
                CultureName = "en-US",
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
                TranslationValue = "Save the calendar header first to manage periods.",
                CultureName = "en-US",
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
                TranslationValue = "Review and adjust the generated periods before saving.",
                CultureName = "en-US",
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
                TranslationValue = "Generating periods...",
                CultureName = "en-US",
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
                TranslationValue = "Loading periods...",
                CultureName = "en-US",
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
                TranslationValue = "Recommended maximum is 4 periods",
                CultureName = "en-US",
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
                TranslationValue = "Allow additional periods outside the regular fiscal calendar for year-end adjustments.",
                CultureName = "en-US",
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
                TranslationValue = "Require the previous period to be closed before the next one can be closed.",
                CultureName = "en-US",
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
                TranslationValue = "Enter calendar code",
                CultureName = "en-US",
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
                TranslationValue = "Enter calendar name",
                CultureName = "en-US",
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
                TranslationValue = "Enter description",
                CultureName = "en-US",
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
                TranslationValue = "Select period type",
                CultureName = "en-US",
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
                TranslationValue = "Select fiscal year start month",
                CultureName = "en-US",
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
                TranslationValue = "Select fiscal year end month",
                CultureName = "en-US",
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
                TranslationValue = "Select number of adjustment periods",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar and Periods generated successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to generate Accounting Periods",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar shared successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to share Accounting Calendar",
                CultureName = "en-US",
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
                TranslationValue = "This calendar cannot be deleted as transactions exist against it",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Header",
                CultureName = "en-US",
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
                TranslationValue = "Basic calendar details and sharing",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Identity",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Period",
                CultureName = "en-US",
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
                TranslationValue = "Generate and manage accounting periods",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Sharing",
                CultureName = "en-US",
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
                TranslationValue = "Period Configuration",
                CultureName = "en-US",
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
                TranslationValue = "Add Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Code",
                CultureName = "en-US",
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
                TranslationValue = "Calendar Name",
                CultureName = "en-US",
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
                TranslationValue = "Number Of Periods Per Year",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year Start Month",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Description",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Period Name",
                CultureName = "en-US",
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
                TranslationValue = "Active",
                CultureName = "en-US",
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
                TranslationValue = "Start Date",
                CultureName = "en-US",
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
                TranslationValue = "End Date",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Current",
                CultureName = "en-US",
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
                TranslationValue = "Fiscal Year",
                CultureName = "en-US",
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
                TranslationValue = "Quarter",
                CultureName = "en-US",
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
                TranslationValue = "Type",
                CultureName = "en-US",
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
                TranslationValue = "Posting Access",
                CultureName = "en-US",
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
                TranslationValue = "Module",
                CultureName = "en-US",
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
                TranslationValue = "Open",
                CultureName = "en-US",
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
                TranslationValue = "Close Pending",
                CultureName = "en-US",
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
                TranslationValue = "Close",
                CultureName = "en-US",
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
                TranslationValue = "Open Selected",
                CultureName = "en-US",
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
                TranslationValue = "Close Pending Selected",
                CultureName = "en-US",
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
                TranslationValue = "Close Selected",
                CultureName = "en-US",
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
                TranslationValue = "Permanently Close",
                CultureName = "en-US",
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
                TranslationValue = "Reopen",
                CultureName = "en-US",
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
                TranslationValue = "Set Current",
                CultureName = "en-US",
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
                TranslationValue = "More actions",
                CultureName = "en-US",
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
                TranslationValue = "Sort",
                CultureName = "en-US",
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
                TranslationValue = "Clear Sort",
                CultureName = "en-US",
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
                TranslationValue = "Select Columns",
                CultureName = "en-US",
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
                TranslationValue = "Never Opened",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Calendar",
                CultureName = "en-US",
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
                TranslationValue = "Current",
                CultureName = "en-US",
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
                TranslationValue = "Periods Selected",
                CultureName = "en-US",
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
                TranslationValue = "Change Status",
                CultureName = "en-US",
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
                TranslationValue = "Summary",
                CultureName = "en-US",
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
                TranslationValue = "Legal Entities",
                CultureName = "en-US",
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
                TranslationValue = "Add Company",
                CultureName = "en-US",
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
                TranslationValue = "Unable to update the period status",
                CultureName = "en-US",
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
                TranslationValue = "Accounting Period cannot be opened until it is open for General Ledger.",
                CultureName = "en-US",
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
                TranslationValue = "The previous accounting period must be Closed (or Close Pending, if configured) before this period can be opened.",
                CultureName = "en-US",
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
                TranslationValue = "Only one Accounting Period can be marked as Current per module.",
                CultureName = "en-US",
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
                TranslationValue = "Search periods",
                CultureName = "en-US",
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
                TranslationValue = "Adjustment",
                CultureName = "en-US",
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
                TranslationValue = "Regular",
                CultureName = "en-US",
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
                TranslationValue = "Add Tax Authority",
                CultureName = "en-US",
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
                TranslationValue = "Tax Authority",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TA",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxAuthority.label.breadcrumb.title",
                TranslationValue = "Tax Authorities",
                CultureName = "en-US",
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
                TranslationValue = "View Tax Authority",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Filing Frequency",
                CultureName = "en-US",
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
                TranslationValue = "Linked Supplier",
                CultureName = "en-US",
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
                TranslationValue = "Select Country",
                CultureName = "en-US",
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
                TranslationValue = "Select Filing Frequency",
                CultureName = "en-US",
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
                TranslationValue = "Select Linked Supplier",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Linked Supplier",
                CultureName = "en-US",
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
                TranslationValue = "Filing Frequency",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Add Tax Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Tax Jurisdiction",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-TJ",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.masters.taxJurisdiction.label.breadcrumb.title",
                TranslationValue = "Tax Jurisdictions",
                CultureName = "en-US",
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
                TranslationValue = "View Tax Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Name",
                CultureName = "en-US",
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
                TranslationValue = "Tax Authority",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
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
                TranslationValue = "Select Country",
                CultureName = "en-US",
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
                TranslationValue = "Select Currency",
                CultureName = "en-US",
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
                TranslationValue = "General Information",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Tax Authority",
                CultureName = "en-US",
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
                TranslationValue = "Country",
                CultureName = "en-US",
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
                TranslationValue = "Currency",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Currency Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumb",
                TranslationValue = "Currency Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbAdd",
                TranslationValue = "Add Currency Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbEdit",
                TranslationValue = "Edit Currency Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.labels.breadcrumbView",
                TranslationValue = "View Currency Master",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.generalInformation",
                TranslationValue = "General Information",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.displayFormatting",
                TranslationValue = "Display / Formatting",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.countryAndPeg",
                TranslationValue = "Country & Peg",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.sections.sectionheader.lifecycleAndStatus",
                TranslationValue = "Lifecycle & Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyName",
                TranslationValue = "Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyNameHint",
                TranslationValue = "Changed ΓÇö ISO 4217 picker; drives auto-fill of all identity fields.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyCode",
                TranslationValue = "Currency Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencyCodeHint",
                TranslationValue = "Auto ΓÇö from selected currency (canonical, read-only).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoCode",
                TranslationValue = "ISO Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoCodeHint",
                TranslationValue = "Auto ΓÇö from selected currency (canonical, read-only).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoNumeric",
                TranslationValue = "ISO Numeric",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isoNumericHint",
                TranslationValue = "New ΓÇö SWIFT / ISO 20022 - auto-loads.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.shortCode",
                TranslationValue = "Short Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.shortCodeHint",
                TranslationValue = "Auto-fills to ISO code ΓÇö editable (internal alias).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencySymbol",
                TranslationValue = "Currency Symbol",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.currencySymbolHint",
                TranslationValue = "Native glyph from ISO 4217 data (read-only).",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.countryOfIssue",
                TranslationValue = "Country of issue",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isPegged",
                TranslationValue = "Is pegged?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isPeggedHint",
                TranslationValue = "Drives Pegged to / Pegged rate below.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedTo",
                TranslationValue = "Pegged to",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedToHint",
                TranslationValue = "Conditional ΓÇö required if Is pegged = Yes.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedRate",
                TranslationValue = "Pegged rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.peggedRateHint",
                TranslationValue = "Fixed rate; bypasses daily FX rate feed.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.status",
                TranslationValue = "Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveFrom",
                TranslationValue = "Effective from",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveTo",
                TranslationValue = "Effective to",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.effectiveToHint",
                TranslationValue = "Blank = currency remains active indefinitely.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isTransactional",
                TranslationValue = "Is transactional?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isTransactionalHint",
                TranslationValue = "No = excluded from transaction currency pickers.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isReporting",
                TranslationValue = "Is reporting?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isReportingHint",
                TranslationValue = "No = excluded from reporting/analytics currency filters.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.yes",
                TranslationValue = "Yes",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.no",
                TranslationValue = "No",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.active",
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.inactive",
                TranslationValue = "Inactive",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.displayMode",
                TranslationValue = "Display Mode",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.displayModeHint",
                TranslationValue = "Toggle between native symbol and code system-wide.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.symbolPlacement",
                TranslationValue = "Symbol Placement",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.symbolSpacing",
                TranslationValue = "Symbol Spacing",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.decimalPrecision",
                TranslationValue = "Decimal Precision",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.thousandSeparator",
                TranslationValue = "Thousand Separator",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.decimalSeparator",
                TranslationValue = "Decimal Separator",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.negativeFormat",
                TranslationValue = "Negative Format",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.isNegativeRed",
                TranslationValue = "Show negatives in red",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.roundingMethod",
                TranslationValue = "Rounding Method",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.roundingPrecision",
                TranslationValue = "Rounding Precision",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreview",
                TranslationValue = "Live Preview",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreviewAmount",
                TranslationValue = "Live Preview ΓÇö Amount",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.fields.label.livePreviewNegative",
                TranslationValue = "Live Preview ΓÇö Negative",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.displayModeSymbol",
                TranslationValue = "Symbol",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.displayModeIsoCode",
                TranslationValue = "ISO Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.placementPrefix",
                TranslationValue = "Prefix",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.placementSuffix",
                TranslationValue = "Suffix",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.spacingSpace",
                TranslationValue = "Space",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.spacingNoSpace",
                TranslationValue = "No space",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorComma",
                TranslationValue = "Comma",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorDot",
                TranslationValue = "Dot",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.separatorSpace",
                TranslationValue = "Space",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.negativeParentheses",
                TranslationValue = "Parentheses",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.negativeMinus",
                TranslationValue = "Minus",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingBankers",
                TranslationValue = "Banker's",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingHalfUp",
                TranslationValue = "Round half up",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.options.label.roundingHalfDown",
                TranslationValue = "Round half down",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.currencyCode",
                TranslationValue = "Currency Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.currencyName",
                TranslationValue = "Currency Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.shortCode",
                TranslationValue = "Short Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.symbol",
                TranslationValue = "Symbol",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.decimalPrecision",
                TranslationValue = "Decimal Precision",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.createdDate",
                TranslationValue = "Created Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.createdBy",
                TranslationValue = "Created By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.status",
                TranslationValue = "Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.updatedDate",
                TranslationValue = "Updated Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.tableHeaders.columnheader.updatedBy",
                TranslationValue = "Updated By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.placeholders.currency",
                TranslationValue = "Select Currency",
                CultureName = "en-US",
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
                TranslationValue = "Auto-filled from currency",
                CultureName = "en-US",
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
                TranslationValue = "Enter Short Code",
                CultureName = "en-US",
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
                TranslationValue = "Enter Decimal Precision",
                CultureName = "en-US",
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
                TranslationValue = "Select Symbol Spacing",
                CultureName = "en-US",
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
                TranslationValue = "Select Thousand Separator",
                CultureName = "en-US",
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
                TranslationValue = "Select Decimal Separator",
                CultureName = "en-US",
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
                TranslationValue = "Select Negative Format",
                CultureName = "en-US",
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
                TranslationValue = "Select Rounding Method",
                CultureName = "en-US",
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
                TranslationValue = "Enter Rounding Precision",
                CultureName = "en-US",
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
                TranslationValue = "Select Country of Issue",
                CultureName = "en-US",
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
                TranslationValue = "Select Pegged Currency",
                CultureName = "en-US",
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
                TranslationValue = "Enter Pegged Rate",
                CultureName = "en-US",
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
                TranslationValue = "Select Option",
                CultureName = "en-US",
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
                TranslationValue = "Add Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.view",
                TranslationValue = "View",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.edit",
                TranslationValue = "Edit",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.share",
                TranslationValue = "Share",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.commonButtons.actionbutton.delete",
                TranslationValue = "Delete",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Master ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.currencyMaster.validation.currencyAlreadyExists",
                TranslationValue = "The selected currency already exists in the system.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.isoNumericUnique",
                TranslationValue = "ISO numeric code must be unique.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.separatorsSame",
                TranslationValue = "Thousand separator and decimal separator cannot be the same.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.roundingPrecisionAlign",
                TranslationValue = "Rounding precision must align with the selected decimal places.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.peggedToRequired",
                TranslationValue = "Select a currency to peg to.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.peggedRateGreaterThanZero",
                TranslationValue = "Enter a valid pegged rate greater than zero.",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.peggedToSameCurrency",
                TranslationValue = "A currency cannot be pegged to itself. Select a different currency.",
                CultureName = "en-US",
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
                TranslationValue = "Effective From is required",
                CultureName = "en-US",
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
                KeyName = "translate.edm.currencyMaster.validation.effectiveDateOrder",
                TranslationValue = "Effective To date cannot be before Effective From date.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CM",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Item Finance Category ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.itemFinanceCategory.breadcrumb.label.add",
                TranslationValue = "Add Item Finance Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Edit Item Finance Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "View Item Finance Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Finance Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Restricted",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Shared",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Global",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Are you sure you want to delete this subcategory?",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Enable",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Disable",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Identification & Traceability",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Serial Number Assignment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Lot/Batch Number Assignment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Expiry/Best Before Date Capture",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Manufacturing/Production Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Barcode/QR Code/RFID Scanning",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Batch/Lot Reference",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Quality and Inspection",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Inspection Required",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Certificate of Conformance (COC)",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "AQL Based Sampling Plan (Acceptable Quality Level)",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Damage & Discrepancy Recording",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "FEFO/FIFO Stock Rotation Flag",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Shelf-Life Minimum Remaining Check (Days)",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Storage and Location",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Warehouse/Storage Location Assignment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-Inventory/Sub-Location Tracking",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Purchase Price Variance",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Notification and Workflow",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Automated Receipt Confirmation Notification",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Expiry Date Alert",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "General Info",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Main Category",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Milestone/Deliverable Acceptance",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Post to Balance Sheet?",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Enable Specification",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Quantity Tolerance",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Supplier Delivery Note",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Configurations",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Toggle navigation",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "There are",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "available sub-items",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Row actions",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Record availability will be restricted only for the current Company.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Record will be available for the assigned/selected Companies only.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Record will be available for all the companies without any restrictions.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Assigned To:",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Created by this company. Other companies cannot see or use this item finance category.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "All Companies",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "This item finance category is visible to all companies. It is not restricted to any specific company.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "+ Add Company",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Owner",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Changes will be applied upon save",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, milestone/deliverable acceptance is required",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Yes = item is capitalized as asset; No = item is expensed",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this item will enable specification",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, this item will require a supplier delivery note",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "This item will enable serial number assignment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-category with lot/batch number assignment",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-category with expiry/best before date capture",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-category with manufacturing/production date",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-category with barcode / QR code / RFID scanning",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Sub-category with supplier batch/lot reference",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, inspection is required",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, certificate of conformance (COC) will be required",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, damage & discrepancy recording will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, FEFO/FIFO stock rotation flag will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, warehouse/storage location assignment will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, sub-inventory/sub-location tracking will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, purchase price variance will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "This option automates receipt confirmations",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "If enabled, expiry date alert will be enabled",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "{{count}} Companies",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Can be checked only if BS GL code is not selected and applicable only for Inventory and Non-Inventory items. If this is checked, when doing GRV for the item, the system will post the inventory directly to consumption instead of the inventory control account.",
                CultureName = "en-US",
                ModuleCode = "EDM",
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
                TranslationValue = "Item Finance Category Sharing",
                CultureName = "en-US",
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
                TranslationValue = "Saved successfully",
                CultureName = "en-US",
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
                TranslationValue = "Failed to save. Please try again.",
                CultureName = "en-US",
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
                TranslationValue = "Enter value",
                CultureName = "en-US",
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
                TranslationValue = "Select category type",
                CultureName = "en-US",
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
                TranslationValue = "Select balance sheet GL",
                CultureName = "en-US",
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
                TranslationValue = "Select consumption GL",
                CultureName = "en-US",
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
                TranslationValue = "Select revenue GL",
                CultureName = "en-US",
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
                TranslationValue = "Select COGS GL",
                CultureName = "en-US",
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
                TranslationValue = "Enter quantity tolerance",
                CultureName = "en-US",
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
                TranslationValue = "Subcategory Name",
                CultureName = "en-US",
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
                TranslationValue = "COGS GL",
                CultureName = "en-US",
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
                TranslationValue = "Revenue GL",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Category Type",
                CultureName = "en-US",
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
                TranslationValue = "Balance Sheet GL",
                CultureName = "en-US",
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
                TranslationValue = "Consumption GL",
                CultureName = "en-US",
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
                TranslationValue = "Expiry",
                CultureName = "en-US",
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
                TranslationValue = "Attributes",
                CultureName = "en-US",
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
                TranslationValue = "Shared Status",
                CultureName = "en-US",
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
                TranslationValue = "View",
                CultureName = "en-US",
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
                TranslationValue = "Edit",
                CultureName = "en-US",
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
                TranslationValue = "Add Subcategory",
                CultureName = "en-US",
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
                TranslationValue = "Share",
                CultureName = "en-US",
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
                TranslationValue = "Delete",
                CultureName = "en-US",
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
                TranslationValue = "History",
                CultureName = "en-US",
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
                TranslationValue = "Cancel",
                CultureName = "en-US",
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
                TranslationValue = "Save",
                CultureName = "en-US",
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
                TranslationValue = "Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumb",
                TranslationValue = "Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbadd",
                TranslationValue = "Add Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbedit",
                TranslationValue = "Edit Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.breadcrumbview",
                TranslationValue = "View Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.add",
                TranslationValue = "Add Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.view",
                TranslationValue = "View",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.edit",
                TranslationValue = "Edit",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.delete",
                TranslationValue = "Delete",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.cancel",
                TranslationValue = "Cancel",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.draft",
                TranslationValue = "Draft",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.save",
                TranslationValue = "Save",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.saveandcontinue",
                TranslationValue = "Save & Continue",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.override",
                TranslationValue = "Override",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.addattachment",
                TranslationValue = "Add Attachment",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.actionbutton.preview",
                TranslationValue = "Preview",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ActionButton,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Column Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.code",
                TranslationValue = "Currency Conversion Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.currencyConversionCode",
                TranslationValue = "Currency Conversion Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratedate",
                TranslationValue = "Rate Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.effectivefrom",
                TranslationValue = "Effective From",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.effectiveto",
                TranslationValue = "Effective To",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratetype",
                TranslationValue = "Rate Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.erupdatetype",
                TranslationValue = "ER Update Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.source",
                TranslationValue = "Source",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.createddate",
                TranslationValue = "Created Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.createdby",
                TranslationValue = "Created by",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.status",
                TranslationValue = "Status",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.fromcurrency",
                TranslationValue = "From Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tocurrency",
                TranslationValue = "To Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.startingcurrency",
                TranslationValue = "Starting Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.reference",
                TranslationValue = "Reference / Narration",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.updateddate",
                TranslationValue = "Updated Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.updatedby",
                TranslationValue = "Updated by",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.isactive",
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.filename",
                TranslationValue = "File Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.attachmentname",
                TranslationValue = "Attachment Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.type",
                TranslationValue = "Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.size",
                TranslationValue = "Size",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.uploadedby",
                TranslationValue = "Uploaded By",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.uploadedat",
                TranslationValue = "Uploaded At",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.description",
                TranslationValue = "Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.currency",
                TranslationValue = "Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.iso",
                TranslationValue = "ISO",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.peg",
                TranslationValue = "Peg",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.previous",
                TranslationValue = "Previous",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.newrate",
                TranslationValue = "New Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.buying",
                TranslationValue = "Buying",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.selling",
                TranslationValue = "Selling",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.move",
                TranslationValue = "Move",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tolerance",
                TranslationValue = "Tol",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.warning",
                TranslationValue = "Warning",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.block",
                TranslationValue = "Block",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.pegtolerance",
                TranslationValue = "Peg Tolerance",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.usecase",
                TranslationValue = "Use Case",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.prevrate",
                TranslationValue = "Prev Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.ratequote",
                TranslationValue = "Rate (1{{iso}} = X)",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.crosscheck",
                TranslationValue = "Cross Check",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.percentdelta",
                TranslationValue = "% Γû│",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.tol",
                TranslationValue = "Tol",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.columnheader.justification",
                TranslationValue = "Justification",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.ColumnHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Labels
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.code",
                TranslationValue = "Currency Conversion Code",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratedate",
                TranslationValue = "Rate Date",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectivefrom",
                TranslationValue = "Effective From",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectiveto",
                TranslationValue = "Effective To",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.effectivetohint",
                TranslationValue = "If enable, Effective to Date and Time will visible.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratetype",
                TranslationValue = "Rate Type",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.fromcurrency",
                TranslationValue = "Currency Pair From",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tocurrency",
                TranslationValue = "Currency Pair To",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.startingcurrency",
                TranslationValue = "Starting Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.source",
                TranslationValue = "Source",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.reference",
                TranslationValue = "Reference / Narration",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.active",
                TranslationValue = "Active",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.open",
                TranslationValue = "Open",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratevalue",
                TranslationValue = "Rate Value",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.inverserate",
                TranslationValue = "Inverse Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.movementpercent",
                TranslationValue = "Movement %",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.buyrate",
                TranslationValue = "Buy Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.sellrate",
                TranslationValue = "Sell Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.spreadpercent",
                TranslationValue = "Spread %",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.previousrate",
                TranslationValue = "Previous Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.justification",
                TranslationValue = "Justification",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.applymidtobuysell",
                TranslationValue = "Apply Mid Rate to Buy/Sell for all rows?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.activetolerance",
                TranslationValue = "Active Tolerance for {{rateType}}: Warn ┬▒{{warn}}% | Block ┬▒{{block}}% | Peg ┬▒{{peg}}%",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.movementthreshold",
                TranslationValue = "Movement Threshold",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.lastupdate",
                TranslationValue = "Last Update",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.newrateentry",
                TranslationValue = "New Rate Entry",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.selectbasecurrency",
                TranslationValue = "Select the Base Currency",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.filename",
                TranslationValue = "File Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.attachmentname",
                TranslationValue = "Attachment Name",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.description",
                TranslationValue = "Description",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.uploadattachment",
                TranslationValue = "Upload a Attachment",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.fromcurrencysummary",
                TranslationValue = "From Currency :",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tocurrencysummary",
                TranslationValue = "To Currency :",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.tolerancedescription",
                TranslationValue = "Warning ┬▒2% ┬╖ Block ┬▒10% ┬╖ Peg ┬▒0.1% ┬╖ Applied to every row per base currency. Changing Rate Type in header updates all tolerances.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ratedetailssubtitle",
                TranslationValue = "Enter and review conversion rates for the selected base currency.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.on",
                TranslationValue = "on",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.draft",
                TranslationValue = "Draft",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.pending",
                TranslationValue = "Pending",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.approved",
                TranslationValue = "Approved",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.rejected",
                TranslationValue = "Rejected",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatusok",
                TranslationValue = "OK",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatuswarn",
                TranslationValue = "Warn",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.linestatusblock",
                TranslationValue = "Block",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.pegfixed",
                TranslationValue = "Peg Fixed",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.viacurrency",
                TranslationValue = "Via {{iso}}",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.ersinglesegment",
                TranslationValue = "Single",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.label.erbulksegment",
                TranslationValue = "Bulk",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Label,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Section Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.generalinfo",
                TranslationValue = "General Info",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.tolerance",
                TranslationValue = "Tolerance for SPOT rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.ratecontext",
                TranslationValue = "Rate Context",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.attachment",
                TranslationValue = "Attachment",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.sectionheader.ratedetails",
                TranslationValue = "Rate Details",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.SectionHeader,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Headers
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.add",
                TranslationValue = "Add Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.edit",
                TranslationValue = "Edit Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.view",
                TranslationValue = "View Currency Conversion",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.addattachment",
                TranslationValue = "Add Attachment",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.header.editattachment",
                TranslationValue = "Edit Attachment",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Header,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Placeholders
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.placeholder.keywordsearch",
                TranslationValue = "Keyword Search",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.placeholder.browsedocument",
                TranslationValue = "Browse the Document",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.PlaceHolder,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.createdsuccess",
                TranslationValue = "Currency conversion created successfully",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.updatedsuccess",
                TranslationValue = "Currency conversion updated successfully",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Confirmations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.delete",
                TranslationValue = "Are you sure you want to delete this? This action cannot be undone!",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocaltitle",
                TranslationValue = "Reciprocal Rates",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalsinglesingle",
                TranslationValue = "Apply reciprocal Buy/Sell rates to {{to}} ΓåÆ {{from}}?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalsinglebulk",
                TranslationValue = "Do you want to apply reciprocal Buy/Sell rates for all {{count}} currencies?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.reciprocalbulkbulk",
                TranslationValue = "Do you want to apply the reciprocal rates for all {{count}} pairs defined in this grid?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.applymidtitle",
                TranslationValue = "Apply Mid Rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.applymidcontent",
                TranslationValue = "Apply the same rate to Buy and Sell?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.cfooverridetitle",
                TranslationValue = "Block threshold exceeded",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.cfooverridecontent",
                TranslationValue = "This rate exceeds the block threshold. Apply CFO override and continue? Justification is still required.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.pegoverridetitle",
                TranslationValue = "Override pegged rate",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.confirmation.pegoverridecontent",
                TranslationValue = "Unlock New, Buy, and Sell for this pegged pair and enter the rate manually?",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Confirmation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Validations
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.ratedatefuture",
                TranslationValue = "Rate Date cannot be more than 90 days in the future.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.effectivefrombeforeratedate",
                TranslationValue = "Effective From must be on or after Rate Date.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.effectivetomustbeafterfrom",
                TranslationValue = "Effective To must be after Effective From.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.currenciesmustdiffer",
                TranslationValue = "From Currency and To Currency cannot be the same.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.buyrateexceedssell",
                TranslationValue = "Buy rate cannot exceed sell rate.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.movementblocked",
                TranslationValue = "Save is blocked because a rate exceeds the block threshold.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.justificationrequired",
                TranslationValue = "Justification is required when movement exceeds the warning threshold.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.validation.duplicatepair",
                TranslationValue = "This currency pair already exists in the grid.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Validation,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Tooltips
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.rowactions",
                TranslationValue = "Row actions",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.close",
                TranslationValue = "Close",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.tooltip.removefile",
                TranslationValue = "Remove file",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Tooltip,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Currency Conversion ΓåÆ Notifications
            yield return new SystemTranslation
            {
                KeyName = "translation.edm.currencyconversion.notification.uploadfailed",
                TranslationValue = "Attachment upload failed.",
                CultureName = "en-US",
                ModuleCode = "EDM",
                DocumentTypeCode = "EDM-CCV",
                SystemTranslationElementType = SystemTranslationElementType.Notification,
                IsCommon = false,
                CommonKey = "",
                IsOriginal = true,
                CommonKeyExist = false
            };
            #endregion

            #region EDM ΓåÆ Tax Setup ΓåÆ Action Buttons
            yield return new SystemTranslation
            {
                KeyName = "translate.edm.taxsetup.actionbutton.add",
                TranslationValue = "Add Tax Setup",
                CultureName = "en-US",
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
                TranslationValue = "Draft",
                CultureName = "en-US",
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
                TranslationValue = "Save & Continue",
                CultureName = "en-US",
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
                TranslationValue = "Publish",
                CultureName = "en-US",
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
                TranslationValue = "Save",
                CultureName = "en-US",
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
                TranslationValue = "Are you sure you want to publish this Tax Setup?",
                CultureName = "en-US",
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
                TranslationValue = "Tax Category Rate",
                CultureName = "en-US",
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
                TranslationValue = "Tax Setup",
                CultureName = "en-US",
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
                TranslationValue = "Tax Setups",
                CultureName = "en-US",
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
                TranslationValue = "View Tax Setup",
                CultureName = "en-US",
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
                TranslationValue = "Setup code",
                CultureName = "en-US",
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
                TranslationValue = "Setup name",
                CultureName = "en-US",
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
                TranslationValue = "Tax Type",
                CultureName = "en-US",
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
                TranslationValue = "Tax authority",
                CultureName = "en-US",
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
                TranslationValue = "Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Registration number",
                CultureName = "en-US",
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
                TranslationValue = "Effective from",
                CultureName = "en-US",
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
                TranslationValue = "Filing cadence",
                CultureName = "en-US",
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
                TranslationValue = "VAT",
                CultureName = "en-US",
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
                TranslationValue = "Excise Tax",
                CultureName = "en-US",
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
                TranslationValue = "Withholding Tax",
                CultureName = "en-US",
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
                TranslationValue = "Corporate Tax",
                CultureName = "en-US",
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
                TranslationValue = "Contribution",
                CultureName = "en-US",
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
                TranslationValue = "Monthly",
                CultureName = "en-US",
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
                TranslationValue = "Quarterly",
                CultureName = "en-US",
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
                TranslationValue = "Bi-Annually",
                CultureName = "en-US",
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
                TranslationValue = "Annually",
                CultureName = "en-US",
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
                TranslationValue = "Tax Configuration",
                CultureName = "en-US",
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
                TranslationValue = "This section is not available yet.",
                CultureName = "en-US",
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
                TranslationValue = "Header details",
                CultureName = "en-US",
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
                TranslationValue = "Manage general information on tax setup",
                CultureName = "en-US",
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
                TranslationValue = "Tax Categories & Rates",
                CultureName = "en-US",
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
                TranslationValue = "Tax treatments, rates, and products",
                CultureName = "en-US",
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
                TranslationValue = "Calculation method",
                CultureName = "en-US",
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
                TranslationValue = "Rounding",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Category",
                CultureName = "en-US",
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
                TranslationValue = "Rate %",
                CultureName = "en-US",
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
                TranslationValue = "Effective From",
                CultureName = "en-US",
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
                TranslationValue = "Category",
                CultureName = "en-US",
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
                TranslationValue = "Rate %",
                CultureName = "en-US",
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
                TranslationValue = "Effective From",
                CultureName = "en-US",
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
                TranslationValue = "Add a rate to a tax category",
                CultureName = "en-US",
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
                TranslationValue = "Edit a rate to a tax category",
                CultureName = "en-US",
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
                TranslationValue = "Category & Rate",
                CultureName = "en-US",
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
                TranslationValue = "Add Category & Rate",
                CultureName = "en-US",
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
                TranslationValue = "GL Configuration",
                CultureName = "en-US",
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
                TranslationValue = "Setup for tax accounts overview",
                CultureName = "en-US",
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
                TranslationValue = "Input {{taxType}} GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Input {{taxType}} Transfer GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Output {{taxType}} GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Output {{taxType}} Transfer GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Tax Settlement GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Rounding Difference GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Exempt {{taxType}} Control GL Account",
                CultureName = "en-US",
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
                TranslationValue = "Exempt {{taxType}} Expense GL Account",
                CultureName = "en-US",
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
                TranslationValue = "No categories with rates yet.",
                CultureName = "en-US",
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
                TranslationValue = "Supply Rules",
                CultureName = "en-US",
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
                TranslationValue = "Details on where and when a supply is recorded",
                CultureName = "en-US",
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
                TranslationValue = "Determination",
                CultureName = "en-US",
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
                TranslationValue = "Rules that automatically select codes without user input",
                CultureName = "en-US",
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
                TranslationValue = "General Info",
                CultureName = "en-US",
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
                TranslationValue = "General accounts",
                CultureName = "en-US",
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
                TranslationValue = "Category-specific accounts",
                CultureName = "en-US",
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
                TranslationValue = "Code",
                CultureName = "en-US",
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
                TranslationValue = "Setup",
                CultureName = "en-US",
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
                TranslationValue = "Tax Type",
                CultureName = "en-US",
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
                TranslationValue = "Authority",
                CultureName = "en-US",
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
                TranslationValue = "Jurisdiction",
                CultureName = "en-US",
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
                TranslationValue = "Registration Number",
                CultureName = "en-US",
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
                TranslationValue = "Effective",
                CultureName = "en-US",
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
                TranslationValue = "Filing",
                CultureName = "en-US",
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
                TranslationValue = "Status",
                CultureName = "en-US",
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
                TranslationValue = "Created Date",
                CultureName = "en-US",
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
                TranslationValue = "Created By",
                CultureName = "en-US",
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
                TranslationValue = "Updated Date",
                CultureName = "en-US",
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
                TranslationValue = "Updated By",
                CultureName = "en-US",
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
                TranslationValue = "Approval Status",
                CultureName = "en-US",
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
                TranslationValue = "Choose an Account",
                CultureName = "en-US",
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
                TranslationValue = "The tax setup becomes active once its approval is completed.",
                CultureName = "en-US",
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
                TranslationValue = "Toggle menu",
                CultureName = "en-US",
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
                TranslationValue = "Close menu",
                CultureName = "en-US",
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