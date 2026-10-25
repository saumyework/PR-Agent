// ----------------------------------------------------------------------
// Copyright (C) 2026, by OSOS. All rights reserved.
// The information and source code contained herein is the exclusive
// property of OSOS and may not be disclosed, examined or reproduced
// in whole or in part without explicit written authorization from OSOS.
// ----------------------------------------------------------------------

namespace Toolbox.CommonServices;

public class RdmLookupValue : IDataFactory
{
    public Dictionary<int, object> GetData()
    {
        Dictionary<int, object> rdmLookupValues = new()
            {
                {
                1,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 1,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Weight",
                        LookupCode = "SYS_UOM_WEIGHT",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "WT",
                        Note = "This is a note for weight unit of measure",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    2,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 2,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Volume",
                        LookupCode = "SYS_UOM_VOLUME",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "VOL",
                        Note = "Unit of measure type: Volume",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    3,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 3,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Length",
                        LookupCode = "SYS_UOM_LENGTH",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LEN",
                        Note = "Unit of measure type: Length",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    4,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 4,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Each",
                        LookupCode = "SYS_UOM_EACH",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EA",
                        Note = "Unit of measure type: Each",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Pack",
                        LookupCode = "SYS_UOM_PACK",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PCK",
                        Note = "Unit of measure type: Pack",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    6,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 6,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Area",
                        LookupCode = "SYS_UOM_AREA",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AR",
                        Note = "Unit of measure type: Area",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    7,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 7,
                        LookupTypeId = 1,
                        LookupType = "SYS_UOM_TYPE",
                        LookupValue = "Time",
                        LookupCode = "SYS_UOM_TIME",
                        LookupLevelValue = "UOM",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TM",
                        Note = "Unit of measure type: Time",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            {
                    8,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 8,
                        LookupTypeId = 2,
                        LookupType = "SYS_FORMULA_TYPE",
                        LookupValue = "Multiply",
                        LookupCode = "SYS_UOM_MULTIPLY",
                        LookupLevelValue = "Conversion",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MUL",
                        Note = "Formula type for UOM conversion: Multiply",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    9,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 9,
                        LookupTypeId = 2,
                        LookupType = "SYS_FORMULA_TYPE",
                        LookupValue = "Divide",
                        LookupCode = "SYS_UOM_DIVIDE",
                        LookupLevelValue = "Conversion",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DIV",
                        Note = "Formula type for UOM conversion: Divide",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

            //SUPPLIER BUSINESS CATEGORY
            #region SUPPLIER BUSINESS CATEGORY
                {
                    10,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 10,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Agriculture & Farming",
                        LookupCode = "SYS_AGRICULTURE_AND_FARMING",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCAF",
                        Note = "Supplier business category: Agriculture & Farming",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    11,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 11,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Crop Production",
                        LookupCode = "SYS_CROP_PRODUCTION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCP",
                        Note = "Supplier business category: Crop Production",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    12,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 12,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Livestock & Poultry",
                        LookupCode = "SYS_LIVESTOCK_AND_POULTRY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCLAP",
                        Note = "Supplier business category: Livestock & Poultry",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    13,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 13,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Aquaculture & Fisheries",
                        LookupCode = "SYS_AQUACULTURE_AND_FISHERIES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAAF",
                        Note = "Supplier business category: Aquaculture & Fisheries",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    14,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 14,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Agricultural Inputs & Supplies",
                        LookupCode = "SYS_AGRICULTURE_INPUTS_AND_SUPPLIES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAIAS",
                        Note = "Supplier business category: Agricultural Inputs & Supplies",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    15,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 15,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Agro-Processing",
                        LookupCode = "SYS_AGRO_PROCESSING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAP",
                        Note = "Supplier business category: Agro-Processing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    16,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 16,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Organic & Specialty Farming",
                        LookupCode = "SYS_ORGANIC_AND_SPECIALTY_FARMING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 10,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCOASF",
                        Note = "Supplier business category: Organic & Specialty Farming",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    17,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 17,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Construction & Infrastructure",
                        LookupCode = "SYS_CONSTRUCTION_AND_INSFRASTRUCTURE",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCCAI",
                        Note = "Supplier business category: Construction & Infrastructure",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    18,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 18,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Civil & Structural Engineering",
                        LookupCode = "SYS_CIVIL_AND_STRUCTURAL_ENGINEERING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCASE",
                        Note = "Supplier business category: Civil & Structural Engineering",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    19,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 19,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Building Materials & Supplies",
                        LookupCode = "SYS_BUILDING_MATERIALS_AND_SUPPLIES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCBMAS",
                        Note = "Supplier business category: Building Materials & Supplies",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    20,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 20,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Electrical & Mechanical Works",
                        LookupCode = "SYS_ELECTRICAL_AND_MECHANICAL_WORKS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEAMW",
                        Note = "Supplier business category: Electrical & Mechanical Works",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    21,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 21,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Plumbing & HVAC",
                        LookupCode = "SYS_PLUMBING_AND_HVAC",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPAH",
                        Note = "Supplier business category: Plumbing & HVAC",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    22,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 22,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Interior Finishing & Fit-Out",
                        LookupCode = "SYS_INTERIOR_FINISHING_AND_FITOUT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCIFAF",
                        Note = "Supplier business category: Interior Finishing & Fit-Out",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    23,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 23,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Roads, Bridges & Highways",
                        LookupCode = "SYS_ROADS_BRIDGES_AND_HIGHWAYS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCRBAH",
                        Note = "Supplier business category: Roads, Bridges & Highways",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    24,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 24,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Project Management & Consultancy",
                        LookupCode = "SYS_PROJECT_MANAGEMENT_AND_CONSULTANCY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 17,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPMAC",
                        Note = "Supplier business category: Project Management & Consultancy",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    25,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 25,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Energy & Utilities",
                        LookupCode = "SYS_ENERGY_AND_UTILITIES",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCEAU",
                        Note = "Supplier business category: Energy & Utilities",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    26,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 26,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Oil & Gas Exploration",
                        LookupCode = "SYS_OIL_AND_GAS_EXPLORATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCOAGE",
                        Note = "Supplier business category: Oil & Gas Exploration",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    27,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 27,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Petroleum Products & Refining",
                        LookupCode = "SYS_PETROLEUM_PRODUCTS_AND_REFINING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPPAR",
                        Note = "Supplier business category: Petroleum Products & Refining",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    28,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 28,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Renewable Energy (Solar, Wind, Hydro)",
                        LookupCode = "SYS_RENEWABLE_ENERGY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCRE",
                        Note = "Supplier business category: Renewable Energy (Solar, Wind, Hydro)",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    29,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 29,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Power Generation & Distribution",
                        LookupCode = "SYS_POWER_GENERATION_AND_DISTRIBUTION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPGAD",
                        Note = "Supplier business category: Power Generation & Distribution",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    30,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 30,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Water & Wastewater Treatment",
                        LookupCode = "SYS_WATER_AND_WASTEWATER_TREATMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCWAWT",
                        Note = "Supplier business category: Water & Wastewater Treatment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    31,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 31,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Energy Efficiency & Conservation",
                        LookupCode = "SYS_ENERGY_EFFICIENCY_AND_CONSERVATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 25,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEEAC",
                        Note = "Supplier business category: Energy Efficiency & Conservation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    32,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 32,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Financial Services",
                        LookupCode = "SYS_FINANCIAL_SERVICES",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCFS",
                        Note = "Supplier business category: Financial Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    33,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 33,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Banking & Credit Facilities",
                        LookupCode = "SYS_BANKING_AND_CREDIT_FACILITIES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCBACF",
                        Note = "Supplier business category: Banking & Credit Facilities",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    34,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 34,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Insurance & Risk Management",
                        LookupCode = "SYS_INSURANCE_AND_RISK_MANAGEMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAIRM",
                        Note = "Supplier business category: Insurance & Risk Management",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    35,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 35,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Investment & Asset Management",
                        LookupCode = "SYS_INVESTMENT_AND_ASSET_MANAGEMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCIAAM",
                        Note = "Supplier business category: Investment & Asset Management",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    36,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 36,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Accounting & Auditing",
                        LookupCode = "SYS_ACCOUNTING_AND_AUDITING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAAA",
                        Note = "Supplier business category: Accounting & Auditing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    37,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 37,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Payment Processing & FinTech",
                        LookupCode = "SYS_PAYMENT_PROCESSING_AND_FINTECH",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPPAF",
                        Note = "Supplier business category: Payment Processing & FinTech",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    38,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 38,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Tax & Advisory Services",
                        LookupCode = "SYS_TAX_AND_ADVISORY_SERVICES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 32,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCTAAS",
                        Note = "Supplier business category: Tax & Advisory Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    39,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 39,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Food & Beverage",
                        LookupCode = "SYS_FOOD_AND_BEVERAGE",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCFAB",
                        Note = "Supplier business category: Food & Beverage",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    40,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 40,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Food Manufacturing & Processing",
                        LookupCode = "SYS_FOOD_MANUFACTURING_AND_PROCESSING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCFMAP",
                        Note = "Supplier business category: Food Manufacturing & Processing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    41,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 41,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Beverages (Alcoholic & Non-Alcoholic)",
                        LookupCode = "SYS_BEVERAGES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCBAN",
                        Note = "Supplier business category: Beverages (Alcoholic & Non-Alcoholic)",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    42,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 42,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Bakery & Confectionery",
                        LookupCode = "SYS_BAKERY_AND_CONFECTIONERY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCBAC",
                        Note = "Supplier business category: Bakery & Confectionery",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    43,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 43,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Dairy Products",
                        LookupCode = "SYS_DAIRY_PRODUCTS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCDP",
                        Note = "Supplier business category: Dairy Products",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    44,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 44,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Frozen & Chilled Foods",
                        LookupCode = "SYS_FROZEN_AND_CHILLED_FOODS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCFACF",
                        Note = "Supplier business category: Frozen & Chilled Foods",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    45,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 45,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Catering & Food Service",
                        LookupCode = "SYS_CATERING_AND_FOOD_SERVICE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCAFS",
                        Note = "Supplier business category: Catering & Food Service",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    46,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 46,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Packaging & Labelling",
                        LookupCode = "SYS_PACKAGING_AND_LABELLING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 39,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPAL",
                        Note = "Supplier business category: Packaging & Labelling",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    47,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 47,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Healthcare & Pharmaceuticals",
                        LookupCode = "SYS_HEALTHCARE_AND_PHARMACEUTICAL",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCHAP",
                        Note = "Supplier business category: Healthcare & Pharmaceuticals",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    48,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 48,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Pharmaceutical Manufacturing",
                        LookupCode = "SYS_PHARMACEUTICAL_MANUFACTURING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 47,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPM",
                        Note = "Supplier business category: Pharmaceutical Manufacturing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    49,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 49,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Medical Devices & Equipment",
                        LookupCode = "SYS_MEDICAL_DEVICES_AND_EQUIPMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 47,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCMDAE",
                        Note = "Supplier business category: Medical Devices & Equipment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    50,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 50,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Hospital & Clinic Services",
                        LookupCode = "SYS_HOSPITAL_AND_CLINIC_SERVICES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 47,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHACS",
                        Note = "Supplier business category: Hospital & Clinic Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    51,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 51,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Health Supplements & Nutraceuticals",
                        LookupCode = "SYS_HEALTH_SUPPLEMENTS_AND_NUTRACEUTICALS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 47,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHSAN",
                        Note = "Supplier business category: Health Supplements & Nutraceuticals",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    52,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 52,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Home Care & Wellness",
                        LookupCode = "SYS_HOME_CARE_AND_WELLNESS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 47,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHCAW",
                        Note = "Supplier business category: Home Care & Wellness",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    53,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 53,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Information Technology",
                        LookupCode = "SYS_INFORMATION_TECHNOLOGY",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCIT",
                        Note = "Supplier business category: Information Technology",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    54,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 54,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Software Development & Licensing",
                        LookupCode = "SYS_SOFTWARE_DEVELOPMENT_AND_LICENSING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCSDAL",
                        Note = "Supplier business category: Software Development & Licensing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    55,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 55,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Hardware & Infrastructure",
                        LookupCode = "SYS_HARDWARE_AND_INFRASTRUCTURE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHAI",
                        Note = "Supplier business category: Hardware & Infrastructure",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    56,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 56,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Cloud Services & Hosting",
                        LookupCode = "SYS_CLOUD_SERVICES_AND_HOSTING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCSAH",
                        Note = "Supplier business category: Cloud Services & Hosting",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    57,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 57,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Cybersecurity",
                        LookupCode = "SYS_CYBERSECURITY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCS",
                        Note = "Supplier business category: Cybersecurity",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    58,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 58,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Data Analytics & AI",
                        LookupCode = "SYS_DATA_ANALYTICS_AND_AI",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCDAAI",
                        Note = "Supplier business category: Data Analytics & AI",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    59,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 59,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "IT Support & Managed Services",
                        LookupCode = "SYS_IT_SUPPORT_AND_MANAGED_SERVICES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCISAMS",
                        Note = "Supplier business category: IT Support & Managed Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    60,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 60,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Telecommunications",
                        LookupCode = "SYS_TELECOMMUNICATIONS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 53,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCT",
                        Note = "Supplier business category: Telecommunications",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    61,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 61,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Logistics & Supply Chain",
                        LookupCode = "SYS_LOGISTICS_AND_SUPPLY_CHAIN",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCLASC",
                        Note = "Supplier business category: Logistics & Supply Chain",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    62,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 62,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Freight & Transportation",
                        LookupCode = "SYS_FREIGHT_AND_TRANSPORTATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCFAT",
                        Note = "Supplier business category: Freight & Transportation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    63,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 63,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Warehousing & Storage",
                        LookupCode = "SYS_WAREHOUSING_AND_STORAGE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCWAS",
                        Note = "Supplier business category: Warehousing & Storage",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    64,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 64,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Customs Brokerage & Compliance",
                        LookupCode = "SYS_CUSTOMS_BROKERAGE_AND_COMPLIANCE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCBAC",
                        Note = "Supplier business category: Customs Brokerage & Compliance",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    65,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 65,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Last-Mile Delivery",
                        LookupCode = "SYS_LAST_MILE_DELIVERY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCLMD",
                        Note = "Supplier business category: Last-Mile Delivery",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    66,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 66,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Supply Chain Consulting",
                        LookupCode = "SYS_SUPPLY_CHAIN_CONSULTING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCSCC",
                        Note = "Supplier business category: Supply Chain Consulting",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    67,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 67,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Cold Chain & Refrigerated Logistics",
                        LookupCode = "SYS_COLD_CHAIN_AND_REFRIGERATED_LOGISTICS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 61,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCARL",
                        Note = "Supplier business category: Cold Chain & Refrigerated Logistics",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    68,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 68,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Manufacturing & Industrial",
                        LookupCode = "SYS_MANUFACTURING_AND_INDUSTRIAL",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCMAI",
                        Note = "Supplier business category: Manufacturing & Industrial",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    69,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 69,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Heavy Machinery & Equipment",
                        LookupCode = "SYS_HEAVY_MACHINERY_AND_EQUIPMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHMAE",
                        Note = "Supplier business category: Heavy Machinery & Equipment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    70,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 70,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Metal Fabrication & Machining",
                        LookupCode = "SYS_METAL_FABRICATION_AND_MACHINING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCMFAM",
                        Note = "Supplier business category: Metal Fabrication & Machining",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    71,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 71,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Plastics & Rubber Products",
                        LookupCode = "SYS_PLASTICS_AND_RUBBER_PRODUCTS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPARP",
                        Note = "Supplier business category: Plastics & Rubber Products",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    72,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 72,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Chemicals & Petrochemicals",
                        LookupCode = "SYS_CHEMICALS_AND_PETROCHEMICALS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCAP",
                        Note = "Supplier business category: Chemicals & Petrochemicals",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    73,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 73,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Electronics & Electrical Components",
                        LookupCode = "SYS_ELECTRONICS_AND_ELECTRICAL_COMPONENTS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEAEC",
                        Note = "Supplier business category: Electronics & Electrical Components",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    74,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 74,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Automotive Parts & Assembly",
                        LookupCode = "SYS_AUTOMOTIVE_PARTS_AND_ASSEMBLY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAPAA",
                        Note = "Supplier business category: Automotive Parts & Assembly",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    75,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 75,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Textile & Garment Manufacturing",
                        LookupCode = "SYS_TEXTILE_AND_GARMENT_MANUFACTURING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 68,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCTAGM",
                        Note = "Supplier business category: Textile & Garment Manufacturing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    76,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 76,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Marketing & Media",
                        LookupCode = "SYS_MARKETING_AND_MEDIA",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCMAM",
                        Note = "Supplier business category: Marketing & Media",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    77,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 77,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Advertising & Creative Services",
                        LookupCode = "SYS_ADVERTISING_AND_CREATIVE_SERVICES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAACS",
                        Note = "Supplier business category: Advertising & Creative Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    78,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 78,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Digital Marketing & SEO",
                        LookupCode = "SYS_DIGITAL_MARKETING_AND_SEO",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCDMASEO",
                        Note = "Supplier business category: Digital Marketing & SEO",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    79,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 79,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Public Relations & Communications",
                        LookupCode = "SYS_PUBLIC_RELATIONS_AND_COMMUNICATIONS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPRAC",
                        Note = "Supplier business category: Public Relations & Communications",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    80,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 80,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Printing & Publishing",
                        LookupCode = "SYS_PRINTING_AND_PUBLISHING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPAP",
                        Note = "Supplier business category: Printing & Publishing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    81,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 81,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Events & Exhibitions",
                        LookupCode = "SYS_EVENTS_AND_EXHIBITIONS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEAE",
                        Note = "Supplier business category: Events & Exhibitions",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    82,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 82,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Market Research & Analytics",
                        LookupCode = "SYS_MARKET_RESEARCH_AND_ANALYTICS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 76,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCMRA",
                        Note = "Supplier business category: Market Research & Analytics",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    83,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 83,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Professional Services",
                        LookupCode = "SYS_PROFESSIONAL_SERVICES",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCPS",
                        Note = "Supplier business category: Professional Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    84,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 84,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Legal & Compliance",
                        LookupCode = "SYS_LEGAL_AND_COMPLIANCE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCLAC",
                        Note = "Supplier business category: Legal & Compliance",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    85,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 85,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Management Consulting",
                        LookupCode = "SYS_MANAGEMENT_CONSULTING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCMC",
                        Note = "Supplier business category: Management Consulting",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    86,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 86,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Human Resources & Recruitment",
                        LookupCode = "SYS_HUMAN_RESOURCES_AND_RECRUITMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHRAR",
                        Note = "Supplier business category: Human Resources & Recruitment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    87,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 87,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Training & Development",
                        LookupCode = "SYS_TRAINING_AND_DEVELOPMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCTAD",
                        Note = "Supplier business category: Training & Development",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    88,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 88,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Facility Management",
                        LookupCode = "SYS_FACILITY_MANAGEMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCFM",
                        Note = "Supplier business category: Facility Management",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    89,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 89,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Translation & Interpretation",
                        LookupCode = "SYS_TRANSLATION_AND_INTERPRETATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 83,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCTAI",
                        Note = "Supplier business category: Translation & Interpretation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    90,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 90,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Real Estate & Property",
                        LookupCode = "SYS_REAL_ESTATE_AND_PROPERTY",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCREAP",
                        Note = "Supplier business category: Real Estate & Property",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    91,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 91,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Commercial Property",
                        LookupCode = "SYS_COMMERCIAL_PROPERTY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 90,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCP",
                        Note = "Supplier business category: Commercial Property",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    92,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 92,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Residential Property",
                        LookupCode = "SYS_RESIDENTIAL_PROPERTY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 90,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCRP",
                        Note = "Supplier business category: Residential Property",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    93,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 93,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Property Management",
                        LookupCode = "SYS_PROPERTY_MANAGEMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 90,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCPM",
                        Note = "Supplier business category: Property Management",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    94,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 94,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Real Estate Valuation",
                        LookupCode = "SYS_REAL_ESTATE_VALUATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 90,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCREV",
                        Note = "Supplier business category: Real Estate Valuation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    95,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 95,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Leasing & Rental",
                        LookupCode = "SYS_LEASING_AND_RENTAL",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 90,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCLAR",
                        Note = "Supplier business category: Leasing & Rental",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    96,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 96,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Retail & Wholesale Trade",
                        LookupCode = "SYS_RETAIL_AND_WHOLESALE_TRADE",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCRAWT",
                        Note = "Supplier business category: Retail & Wholesale Trade",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    97,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 97,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "General Merchandise",
                        LookupCode = "SYS_GENERAL_MERCHANDISE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCGM",
                        Note = "Supplier business category: General Merchandise",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    98,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 98,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Consumer Electronics",
                        LookupCode = "SYS_CONSUMER_ELECTRONICS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCE",
                        Note = "Supplier business category: Consumer Electronics",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    99,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 99,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Apparel & Fashion",
                        LookupCode = "SYS_APPAREL_AND_FASHION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAAF",
                        Note = "Supplier business category: Apparel & Fashion",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    100,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 100,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Home & Living",
                        LookupCode = "SYS_HOME_AND_LIVING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHAL",
                        Note = "Supplier business category: Home & Living",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    101,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 101,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "E-Commerce & Online Retail",
                        LookupCode = "SYS_ECOMMERCE_AND_ONLINE_RETAIL",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEAOR",
                        Note = "Supplier business category: E-Commerce & Online Retail",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    102,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 102,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Import & Export Trading",
                        LookupCode = "SYS_IMPORT_AND_EXPORT_TRADING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 96,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCIAET",
                        Note = "Supplier business category: Import & Export Trading",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    103,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 103,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Travel & Hospitality",
                        LookupCode = "SYS_TRAVEL_AND_HOSPITALITY",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCTAH",
                        Note = "Supplier business category: Travel & Hospitality",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    104,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 104,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Hotels & Accommodation",
                        LookupCode = "SYS_HOTELS_AND_ACCOMMODATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHAA",
                        Note = "Supplier business category: Hotels & Accommodation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    105,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 105,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Travel Agency & Tour Operations",
                        LookupCode = "SYS_TRAVEL_AGENCY_AND_TOUR_OPERATIONS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCTAATO",
                        Note = "Supplier business category: Travel Agency & Tour Operations",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    106,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 106,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Airlines & Aviation",
                        LookupCode = "SYS_AIRLINES_AND_AVIATION",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCAAA",
                        Note = "Supplier business category: Airlines & Aviation",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    107,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 107,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Car Rental & Ground Transport",
                        LookupCode = "SYS_CAR_RENTAL_AND_GROUND_TRANSPORT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCCRAGT",
                        Note = "Supplier business category: Car Rental & Ground Transport",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    108,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 108,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Restaurant & Food Service",
                        LookupCode = "SYS_RESTAURANT_AND_FOOD_SERVICE",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCRAFS",
                        Note = "Supplier business category: Restaurant & Food Service",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    109,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 109,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Event Venue & Conference Facilities",
                        LookupCode = "SYS_EVENT_VENUE_AND_CONFERENCE_FACILITIES",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 103,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEVACF",
                        Note = "Supplier business category: Event Venue & Conference Facilities",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    110,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 110,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Waste Management & Environment",
                        LookupCode = "SYS_WASTE_MANAGEMENT_AND_ENVIRONMENT",
                        LookupLevelValue = "Business Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BCWMAE",
                        Note = "Supplier business category: Waste Management & Environment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    111,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 111,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Solid Waste Collection & Disposal",
                        LookupCode = "SYS_SOLID_WASTE_COLLECTION_AND_DISPOSAL",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 110,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCSWCAD",
                        Note = "Supplier business category: Solid Waste Collection & Disposal",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    112,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 112,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Recycling & Recovery",
                        LookupCode = "SYS_RECYCLING_AND_RECOVERY",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 110,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCRAR",
                        Note = "Supplier business category: Recycling & Recovery",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    113,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 113,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Hazardous Waste Management",
                        LookupCode = "SYS_HAZARDOUS_WASTE_MANAGEMENT",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 110,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCHWM",
                        Note = "Supplier business category: Hazardous Waste Management",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    114,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 114,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Environmental Consulting",
                        LookupCode = "SYS_ENVIRONMENTAL_CONSULTING",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 110,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCEC",
                        Note = "Supplier business category: Environmental Consulting",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    115,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 115,
                        LookupTypeId = 3,
                        LookupType = "RD_SCM_SUPPLIER_BUSINESS_CATEGORY",
                        LookupValue = "Green & Sustainable Solutions",
                        LookupCode = "SYS_GREEN_AND_SUSTAINABLE_SOLUTIONS",
                        LookupLevelValue = "Sub Business Category",
                        Level = 2,
                        ParentId = 110,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SBCGASS",
                        Note = "Supplier business category: Green & Sustainable Solutions",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

            #endregion

            //ICV CATEGORY
            #region ICV CATEGORY
                {
                    116,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 116,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Manufacturing",
                        LookupCode = "SYS_MANUFACTURING",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG",
                        Note = "In-Country Value (ICV) category: Manufacturing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    117,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 117,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Petrochemical Manufacturing",
                        LookupCode = "SYS_PETROCHEMICAL MANUFACTURING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 116,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG-PETRO",
                        Note = "In-Country Value (ICV) category: Petrochemical Manufacturing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    118,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 118,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Metal & Steel Fabrication",
                        LookupCode = "SYS_METAL_AND_STEEL_FABRICATION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 116,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG-METAL",
                        Note = "In-Country Value (ICV) category: Metal & Steel Fabrication",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    119,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 119,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Food & Beverage Manufacturing",
                        LookupCode = "SYS_FOOD_AND_BEVERAGE_MANUFACTURING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 116,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG-FOOD",
                        Note = "In-Country Value (ICV) category: Food & Beverage Manufacturing",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    120,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 120,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Electrical Equipment Mfg",
                        LookupCode = "SYS_ELECTRICAL_EQUIPMENT_MANUFACTURING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 116,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG-ELEC",
                        Note = "In-Country Value (ICV) category: Electrical Equipment Mfg",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    121,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 121,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Chemical & Industrial Products",
                        LookupCode = "SYS_CHEMICAL_AND_INDUSTRIAL_PRODUCTS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 116,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG-CHEM",
                        Note = "In-Country Value (ICV) category: Chemical & Industrial Products",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    122,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 122,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Construction",
                        LookupCode = "SYS_CONSTRUCTION",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST",
                        Note = "In-Country Value (ICV) category: Construction",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    123,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 123,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Civil & Infrastructure Works",
                        LookupCode = "SYS_CIVIL_AND_INFRASTRUCTURE_WORKS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 122,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST-CIV",
                        Note = "In-Country Value (ICV) category: Civil & Infrastructure Works",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    124,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 124,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Building & Architectural Works",
                        LookupCode = "SYS_BUILDING_AND_ARCHITECTURAL_WORKS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 122,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST-BLD",
                        Note = "In-Country Value (ICV) category: Building & Architectural Works",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    125,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 125,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "MEP Works",
                        LookupCode = "SYS_MEP_WORKS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 122,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST-MEP",
                        Note = "In-Country Value (ICV) category: MEP Works",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    126,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 126,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Oil & Gas Construction",
                        LookupCode = "SYS_OIL_AND_GAS_CONSTRUCTION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 122,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST-OIL",
                        Note = "In-Country Value (ICV) category: Oil & Gas Construction",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    127,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 127,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Landscaping & External Works",
                        LookupCode = "SYS_LANDSCAPING_AND_EXTERNAL_WORKS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 122,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CONST-LND",
                        Note = "In-Country Value (ICV) category: Landscaping & External Works",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    128,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 128,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Services",
                        LookupCode = "SYS_SERVICES",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV",
                        Note = "In-Country Value (ICV) category: Services",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    129,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 129,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Maintenance & Repair Services",
                        LookupCode = "SYS_MAINTENANCE_AND_REPAIR_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 128,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV-MNT",
                        Note = "In-Country Value (ICV) category: Maintenance & Repair Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    130,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 130,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Security & Safety Services",
                        LookupCode = "SYS_SECURITY_AND_SAFETY_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 128,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV-SEC",
                        Note = "In-Country Value (ICV) category: Security & Safety Services",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    131,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 131,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Cleaning & Janitorial Services",
                        LookupCode = "SYS_CLEANING_AND_JANITORIAL_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 128,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV-CLN",
                        Note = "In-Country Value (ICV) category: Cleaning & Janitorial Services",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    132,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 132,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Catering & Hospitality",
                        LookupCode = "SYS_CATERING_AND_HOSPITALITY",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 128,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV-CAT",
                        Note = "In-Country Value (ICV) category: Catering & Hospitality",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    133,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 133,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Manpower & Staffing",
                        LookupCode = "SYS_MANPOWER_AND_STAFFING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 128,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SRV-MAN",
                        Note = "In-Country Value (ICV) category: Manpower & Staffing",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    134,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 134,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Technology & IT",
                        LookupCode = "SYS_TECHNOLOGY_AND_IT",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH",
                        Note = "In-Country Value (ICV) category: Technology & IT",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    135,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 135,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Software Development & Solutions",
                        LookupCode = "SYS_SOFTWARE_DEVELOPMENT_AND_SOLUTIONS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 134,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH-SW",
                        Note = "In-Country Value (ICV) category: Software Development & Solutions",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    136,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 136,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "IT Infrastructure & Networking",
                        LookupCode = "SYS_IT_INFRASTRUCTURE_AND_NETWORKING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 134,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH-INF",
                        Note = "In-Country Value (ICV) category: IT Infrastructure & Networking",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    137,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 137,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Cybersecurity Services",
                        LookupCode = "SYS_CYBERSECURITY_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 134,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH-CYB",
                        Note = "In-Country Value (ICV) category: Cybersecurity Services",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    138,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 138,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Telecommunications",
                        LookupCode = "SYS_TELECOMMUNICATIONS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 134,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH-TEL",
                        Note = "In-Country Value (ICV) category: Telecommunications",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    139,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 139,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Digital Transformation",
                        LookupCode = "SYS_DIGITAL_TRANSFORMATION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 134,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TECH-DIG",
                        Note = "In-Country Value (ICV) category: Digital Transformation",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    140,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 140,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Energy & Utilities",
                        LookupCode = "SYS_ENERGY_AND_UTILITIES",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENRG",
                        Note = "In-Country Value (ICV) category: Energy & Utilities",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    141,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 141,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Oil & Gas Exploration/Production",
                        LookupCode = "SYS_OIL_AND_GAS_EXPLORATION_PRODUCTION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 140,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENRG-OIL",
                        Note = "In-Country Value (ICV) category: Oil & Gas Exploration/Production",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    142,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 142,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Power Generation & Distribution",
                        LookupCode = "SYS_POWER_GENERATION_AND_DISTRIBUTION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 140,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENRG-PWR",
                        Note = "In-Country Value (ICV) category: Power Generation & Distribution",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    143,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 143,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Renewable Energy",
                        LookupCode = "SYS_RENEWABLE_ENERGY",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 140,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENRG-REN",
                        Note = "In-Country Value (ICV) category: Renewable Energy",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    144,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 144,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Water & Wastewater",
                        LookupCode = "SYS_WATER_AND_WASTEWATER",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 140,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENRG-WAT",
                        Note = "In-Country Value (ICV) category: Water & Wastewater",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    145,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 145,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Transport & Logistics",
                        LookupCode = "SYS_TRANSPORT_AND_LOGISTICS",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TRNSP",
                        Note = "In-Country Value (ICV) category: Transport & Logistics",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    146,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 146,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Freight & Haulage",
                        LookupCode = "SYS_FREIGHT_AND_HAULAGE",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 145,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TRNSP-FRT",
                        Note = "In-Country Value (ICV) category: Freight & Haulage",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    147,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 147,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Marine & Offshore Transport",
                        LookupCode = "SYS_MARINE_AND_OFFSHORE_TRANSPORT",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 145,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TRNSP-MAR",
                        Note = "In-Country Value (ICV) category: Marine & Offshore Transport",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    148,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 148,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Air Freight & Courier",
                        LookupCode = "SYS_AIR_FREIGHT_AND_COURIER",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 145,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TRNSP-AIR",
                        Note = "In-Country Value (ICV) category: Air Freight & Courier",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    149,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 149,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Warehousing & Storage",
                        LookupCode = "SYS_WAREHOUSING_AND_STORAGE",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 145,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "TRNSP-WHS",
                        Note = "In-Country Value (ICV) category: Warehousing & Storage",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    150,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 150,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Healthcare & Pharmaceuticals",
                        LookupCode = "SYS_HEALTHCARE_AND_PHARMACEUTICALS",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HLTH",
                        Note = "In-Country Value (ICV) category: Healthcare & Pharmaceuticals",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    151,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 151,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Medical Equipment & Devices",
                        LookupCode = "SYS_MEDICAL_eQUIPMENT_AND_DEVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 150,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HLTH-MED",
                        Note = "In-Country Value (ICV) category: Medical Equipment & Devices",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    152,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 152,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Pharmaceuticals & Drugs",
                        LookupCode = "SYS_PHARMACEUTICALS_AND_DRUGS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 150,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HLTH-PHR",
                        Note = "In-Country Value (ICV) category: Pharmaceuticals & Drugs",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    153,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 153,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Healthcare Services",
                        LookupCode = "SYS_HEALTHCARE_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 150,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HLTH-SRV",
                        Note = "In-Country Value (ICV) category: Healthcare Services",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    154,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 154,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Health Supplements & Wellness",
                        LookupCode = "SYS_HEALTH_SUPPLEMENTS_AND_WELLNESS",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 150,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HLTH-WEL",
                        Note = "In-Country Value (ICV) category: Health Supplements & Wellness",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    155,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 155,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Agriculture & Food Processing",
                        LookupCode = "SYS_AGRICULTURE_AND_FOOD_PROCESSING",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "AGRI",
                        Note = "In-Country Value (ICV) category: Agriculture & Food Processing",
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    156,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 156,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Farming & Crop Production",
                        LookupCode = "SYS_FARMING_AND_CROP_PRODUCTION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 155,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "AGRI-FARM",
                        Note = "In-Country Value (ICV) category: Farming & Crop Production",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    157,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 157,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Food Processing & Packaging",
                        LookupCode = "SYS_FOOD_PROCESSING_AND_PACKAGING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 155,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "AGRI-FOOD",
                        Note = "In-Country Value (ICV) category: Food Processing & Packaging",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    158,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 158,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Fisheries & Aquaculture",
                        LookupCode = "SYS_FISHERIES_AND_AQUACULTURE",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 155,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "AGRI-FSHR",
                        Note = "In-Country Value (ICV) category: Fisheries & Aquaculture",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    159,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 159,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Financial Services",
                        LookupCode = "SYS_FINANCIAL_SERVICES",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "FIN",
                        Note = "In-Country Value (ICV) category: Financial Services",
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    160,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 160,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Insurance Services",
                        LookupCode = "SYS_INSURANCE_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 159,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "FIN-INS",
                        Note = "In-Country Value (ICV) category: Insurance Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    161,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 161,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Banking & Finance",
                        LookupCode = "SYS_BANKING_AND_FINANCE",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 159,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "FIN-BNKF",
                        Note = "In-Country Value (ICV) category: Banking & Finance",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    162,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 162,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Investment & Asset Management",
                        LookupCode = "SYS_INVESTMENT_AND_ASSET_MANAGEMENT",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 159,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "FIN-INV",
                        Note = "In-Country Value (ICV) category: Investment & Asset Management",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    163,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 163,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Education & Training",
                        LookupCode = "SYS_EDUCATION_AND_TRAINING",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "EDU",
                        Note = "In-Country Value (ICV) category: Education & Training",
                        SortOrder = 10,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    164,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 164,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Academic Education",
                        LookupCode = "SYS_ACADEMIC_EDUCATION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 163,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "EDU-ACD",
                        Note = "In-Country Value (ICV) category: Academic Education",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    165,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 165,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Vocational & Technical Training",
                        LookupCode = "SYS_VOCATIONAL_AND_TECHNICAL_TRAINING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 163,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "EDU-VOC",
                        Note = "In-Country Value (ICV) category: Vocational & Technical Training",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    166,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 166,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Corporate Training & eLearning",
                        LookupCode = "SYS_CORPORATE_TRAINING_AND_ELEARNING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 163,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "EDU-CORP",
                        Note = "In-Country Value (ICV) category: Corporate Training & eLearning",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    167,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 167,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Environment & Waste Management",
                        LookupCode = "SYS_ENVIRONMENT_AND_WASTE_MANAGEMENT",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENV",
                        Note = "In-Country Value (ICV) category: Environment & Waste Management",
                        SortOrder = 11,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    168,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 168,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Waste Collection & Disposal",
                        LookupCode = "SYS_WASTE_COLLECTION_AND_DISPOSAL",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 167,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENV-WSTE",
                        Note = "In-Country Value (ICV) category: Waste Collection & Disposal",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    169,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 169,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Recycling & Recovery",
                        LookupCode = "SYS_RECYCLING_AND_RECOVERY",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 167,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENV-RECY",
                        Note = "In-Country Value (ICV) category: Recycling & Recovery",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    170,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 170,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Environmental Remediation",
                        LookupCode = "SYS_ENVIRONMENTAL_REMEDIATION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 167,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ENV-REM",
                        Note = "In-Country Value (ICV) category: Environmental Remediation",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    171,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 171,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Media & Creative Industries",
                        LookupCode = "SYS_MEDIA_AND_CREATIVE_INDUSTRIES",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MEDIA",
                        Note = "In-Country Value (ICV) category: Media & Creative Industries",
                        SortOrder = 12,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    172,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 172,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Advertising & Marketing",
                        LookupCode = "SYS_ADVERTISING_AND_MARKETING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 171,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MEDIA-ADV",
                        Note = "In-Country Value (ICV) category: Advertising & Marketing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    173,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 173,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Content & Media Production",
                        LookupCode = "SYS_CONTENT_AND_MEDIA_PRODUCTION",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 171,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MEDIA-PRD",
                        Note = "In-Country Value (ICV) category: Content & Media Production",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    174,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 174,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Real Estate & Facility Mgmt",
                        LookupCode = "SYS_REAL_ESTATE_AND_FACILITY_MGMT",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "REAL",
                        Note = "In-Country Value (ICV) category: Real Estate & Facility Mgmt",
                        SortOrder = 13,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    175,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 175,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Real Estate Development",
                        LookupCode = "SYS_REAL_ESTATE_DEVELOPMENT",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 174,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "REAL-DEV",
                        Note = "In-Country Value (ICV) category: Real Estate Development",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    176,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 176,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Facility Management",
                        LookupCode = "SYS_FACILITY_MANAGEMENT",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 174,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "REAL-FAC",
                        Note = "In-Country Value (ICV) category: Facility Management",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    177,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 177,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Retail & Wholesale Trade",
                        LookupCode = "SYS_RETAIL_AND_WHOLESALE_TRADE",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "RETAIL",
                        Note = "In-Country Value (ICV) category: Retail & Wholesale Trade",
                        SortOrder = 14,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    178,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 178,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "General Merchandise",
                        LookupCode = "SYS_GENERAL_MERCHANDISE",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 177,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "RETAIL-GEN",
                        Note = "In-Country Value (ICV) category: General Merchandise",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    179,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 179,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Specialist Retail",
                        LookupCode = "SYS_SPECIALIST_RETAIL",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 177,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "RETAIL-SPL",
                        Note = "In-Country Value (ICV) category: Specialist Retail",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },

                {
                    180,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 180,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Professional & Consulting Svcs",
                        LookupCode = "SYS_PROFESSIONAL_AND_CONSULTING_SVCS",
                        LookupLevelValue = "ICV Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PROF",
                        Note = "In-Country Value (ICV) category: Professional & Consulting Svcs",
                        SortOrder = 15,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    181,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 181,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Legal Services",
                        LookupCode = "SYS_LEGAL_SERVICES",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 180,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PROF-LEG",
                        Note = "In-Country Value (ICV) category: Legal Services",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    182,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 182,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Audit & Accounting",
                        LookupCode = "SYS_AUDIT_AND_ACCOUNTING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 180,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PROF-AUD",
                        Note = "In-Country Value (ICV) category: Audit & Accounting",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    183,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 183,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Management Consulting",
                        LookupCode = "SYS_MANAGEMENT_CONSULTING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 180,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PROF-MGT",
                        Note = "In-Country Value (ICV) category: Management Consulting",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    184,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 184,
                        LookupTypeId = 4,
                        LookupType = "SYS_ICV_CATEGORY",
                        LookupValue = "Engineering Consulting",
                        LookupCode = "SYS_ENGINEERING_CONSULTING",
                        LookupLevelValue = "Sub ICV Category",
                        Level = 2,
                        ParentId = 180,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PROF-ENG",
                        Note = "In-Country Value (ICV) category: Engineering Consulting",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SUPPLIER TYPES
            #region SUPPLIER TYPES
            {
                    185,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 185,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Supplier",
                        LookupCode = "RD_SCM_SUPPLIER",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-001",
                        Note = "Supplier type classification: Supplier",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    186,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 186,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Freelancers",
                        LookupCode = "RD_SCM_SUPPLIER_FREELANCERS",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-002",
                        Note = "Supplier type classification: Freelancers",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    187,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 187,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Manufacturing",
                        LookupCode = "RD_SCM_SUPPLIER_MANUFACTURING",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-003",
                        Note = "Supplier type classification: Manufacturing",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    188,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 188,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Contractor",
                        LookupCode = "RD_SCM_SUPPLIER_CONTRACTOR",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-004",
                        Note = "Supplier type classification: Contractor",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    189,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 189,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Sub Contractor",
                        LookupCode = "RD_SCM_SUPPLIER_SUB_CONTRACTOR",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-005",
                        Note = "Supplier type classification: Sub Contractor",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    190,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 190,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Construction",
                        LookupCode = "RD_SCM_SUPPLIER_CONSTRUCTION",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-006",
                        Note = "Supplier type classification: Construction",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    191,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 191,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Attorney",
                        LookupCode = "RD_SCM_SUPPLIER_ATTORNEY",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-007",
                        Note = "Supplier type classification: Attorney",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    192,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 192,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Carrier",
                        LookupCode = "RD_SCM_SUPPLIER_CARRIER",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-008",
                        Note = "Supplier type classification: Carrier",
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    193,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 193,
                        LookupTypeId = 5,
                        LookupType = "RD_SCM_SUPPLIER_TYPES",
                        LookupValue = "Insurance Company",
                        LookupCode = "RD_SCM_SUPPLIER_INSURANCE_COMPANY",
                        LookupLevelValue = "Supplier Types",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STYP-009",
                        Note = "Supplier type classification: Insurance Company",
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SUPPLIER GROUPS   
            #region SUPPLIER GROUPS
            {
                    194,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 194,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Low Risk",
                        LookupCode = "RD_SCM_SUPPLIER_LOW_RISK",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-001",
                        Note = "Supplier group classification: Low Risk",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    195,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 195,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Medium Risk",
                        LookupCode = "RD_SCM_SUPPLIER_MEDIUM_RISK",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-002",
                        Note = "Supplier group classification: Medium Risk",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    196,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 196,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "High Risk",
                        LookupCode = "RD_SCM_SUPPLIER_HIGH_RISK",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-003",
                        Note = "Supplier group classification: High Risk",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    197,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 197,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Critical Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_CRITICAL_SUPPLIER",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-004",
                        Note = "Supplier group classification: Critical Supplier",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    198,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 198,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Single Source",
                        LookupCode = "RD_SCM_SUPPLIER_SINGLE_SOURCE",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-005",
                        Note = "Supplier group classification: Single Source",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    199,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 199,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "New Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_NEW_SUPPLIER",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-006",
                        Note = "Supplier group classification: New Supplier",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    200,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 200,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Under Review",
                        LookupCode = "RD_SCM_SUPPLIER_UNDER_REVIEW",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-007",
                        Note = "Supplier group classification: Under Review",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    201,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 201,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Sanctioned",
                        LookupCode = "RD_SCM_SUPPLIER_SANCTIONED",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-008",
                        Note = "Supplier group classification: Sanctioned",
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    202,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 202,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Politically Exposed",
                        LookupCode = "RD_SCM_SUPPLIER_POLITICALLY_EXPOSED",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-009",
                        Note = "Supplier group classification: Politically Exposed",
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    203,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 203,
                        LookupTypeId = 6,
                        LookupType = "RD_SCM_SUPPLIER_GROUP",
                        LookupValue = "Audit Required",
                        LookupCode = "RD_SCM_SUPPLIER_AUDIT_REQUIRED",
                        LookupLevelValue = "Supplier Group",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SGP-010",
                        Note = "Supplier group classification: Audit Required",
                        SortOrder = 10,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SUPPLIER CATEGORIES
            #region SUPPLIER CATEGORIES
            {
                    204,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 204,
                        LookupTypeId = 7,
                        LookupType = "RD_SCM_SUPPLIER_CATEGORY",
                        LookupValue = "Strategic Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_STRATEGIC_SUPPLIER",
                        LookupLevelValue = "Supplier Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SCAT-001",
                        Note = "Supplier category classification: Strategic Supplier",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    205,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 205,
                        LookupTypeId = 7,
                        LookupType = "RD_SCM_SUPPLIER_CATEGORY",
                        LookupValue = "Tactical Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_TACTICAL_SUPPLIER",
                        LookupLevelValue = "Supplier Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SCAT-002",
                        Note = "Supplier category classification: Tactical Supplier",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    206,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 206,
                        LookupTypeId = 7,
                        LookupType = "RD_SCM_SUPPLIER_CATEGORY",
                        LookupValue = "Operational Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_OPERATIONAL_SUPPLIER",
                        LookupLevelValue = "Supplier Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SCAT-003",
                        Note = "Supplier category classification: Operational Supplier",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    207,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 207,
                        LookupTypeId = 7,
                        LookupType = "RD_SCM_SUPPLIER_CATEGORY",
                        LookupValue = "Spot / Ad-hoc Supplier",
                        LookupCode = "RD_SCM_SUPPLIER_SPOT_SUPPLIER",
                        LookupLevelValue = "Supplier Category",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SCAT-004",
                        Note = "Supplier category classification: Spot / Ad-hoc Supplier",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion 

            //GLOBAL REGIONS
            #region GLOBAL REGIONS
            {
                    208,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 208,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô Middle East",
                        LookupCode = "REG-ASIA_MIDDLE_EAST",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "REG-001",
                        Note = "Global region: Asia ΓÇô Middle East",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    209,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 209,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Africa ΓÇô North Africa",
                        LookupCode = "REG-AFRICA_NORTH_AFRICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-002",
                        Note = "Global region: Africa ΓÇô North Africa",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    210,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 210,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Africa ΓÇô West Africa",
                        LookupCode = "REG-AFRICA_WEST_AFRICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-003",
                        Note = "Global region: Africa ΓÇô West Africa",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    211,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 211,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Africa ΓÇô Southern Africa",
                        LookupCode = "REG-AFRICA_SOUTHERN_AFRICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-004",
                        Note = "Global region: Africa ΓÇô Southern Africa",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    212,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 212,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Africa ΓÇô East Africa",
                        LookupCode = "REG-AFRICA_EAST_AFRICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-005",
                        Note = "Global region: Africa ΓÇô East Africa",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    213,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 213,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Africa ΓÇô Central Africa",
                        LookupCode = "REG-AFRICA_CENTRAL_AFRICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-006",
                        Note = "Global region: Africa ΓÇô Central Africa",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    214,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 214,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô South Asia",
                        LookupCode = "REG-ASIA_SOUTH_ASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-007",
                        Note = "Global region: Asia ΓÇô South Asia",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    215,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 215,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô East Asia",
                        LookupCode = "REG-ASIA_EAST_ASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-008",
                        Note = "Global region: Asia ΓÇô East Asia",
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    216,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 216,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô Southeast Asia",
                        LookupCode = "REG-ASIA_SOUTHEAST_ASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-009",
                        Note = "Global region: Asia ΓÇô Southeast Asia",
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    217,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 217,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô Central Asia",
                        LookupCode = "REG-ASIA_CENTRAL_ASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-010",
                        Note = "Global region: Asia ΓÇô Central Asia",
                        SortOrder = 10,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    218,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 218,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Asia ΓÇô Caucasus",
                        LookupCode = "REG-ASIA_CAUCASUS",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-011",
                        Note = "Global region: Asia ΓÇô Caucasus",
                        SortOrder = 11,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    219,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 219,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Europe ΓÇô Western Europe",
                        LookupCode = "REG-EUROPE_WESTERN_EUROPE",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-012",
                        Note = "Global region: Europe ΓÇô Western Europe",
                        SortOrder = 12,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    220,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 220,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Europe ΓÇô Southern Europe",
                        LookupCode = "REG-EUROPE_SOUTHERN_EUROPE",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-013",
                        Note = "Global region: Europe ΓÇô Southern Europe",
                        SortOrder = 13,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    221,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 221,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Europe ΓÇô Northern Europe",
                        LookupCode = "REG-EUROPE_NORTHERN_EUROPE",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-014",
                        Note = "Global region: Europe ΓÇô Northern Europe",
                        SortOrder = 14,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    222,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 222,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Europe ΓÇô Eastern Europe",
                        LookupCode = "REG-EUROPE_EASTERN_EUROPE",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-015",
                        Note = "Global region: Europe ΓÇô Eastern Europe",
                        SortOrder = 15,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    223,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 223,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Europe ΓÇô Western Asia",
                        LookupCode = "REG-EUROPE_WESTERN_ASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-016",
                        Note = "Global region: Europe ΓÇô Western Asia",
                        SortOrder = 16,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    224,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 224,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Americas ΓÇô North America",
                        LookupCode = "REG-AMERICAS_NORTH_AMERICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-017",
                        Note = "Global region: Americas ΓÇô North America",
                        SortOrder = 17,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    225,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 225,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Americas ΓÇô Central America",
                        LookupCode = "REG-AMERICAS_CENTRAL_AMERICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-018",
                        Note = "Global region: Americas ΓÇô Central America",
                        SortOrder = 18,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    226,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 226,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Americas ΓÇô Caribbean",
                        LookupCode = "REG-AMERICAS_CARIBBEAN",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-019",
                        Note = "Global region: Americas ΓÇô Caribbean",
                        SortOrder = 19,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    227,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 227,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Americas ΓÇô South America",
                        LookupCode = "REG-AMERICAS_SOUTH_AMERICA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-020",
                        Note = "Global region: Americas ΓÇô South America",
                        SortOrder = 20,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    228,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 228,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Oceania ΓÇô Australasia",
                        LookupCode = "REG-OCEANIA_AUSTRALASIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-021",
                        Note = "Global region: Oceania ΓÇô Australasia",
                        SortOrder = 21,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    229,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 229,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Oceania ΓÇô Melanesia",
                        LookupCode = "REG-OCEANIA_MELANESIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-022",
                        Note = "Global region: Oceania ΓÇô Melanesia",
                        SortOrder = 22,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    230,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 230,
                        LookupTypeId = 8,
                        LookupType = "RD_GLOB_REGION",
                        LookupValue = "Oceania ΓÇô Polynesia",
                        LookupCode = "REG-OCEANIA_POLYNESIA",
                        LookupLevelValue = "REGION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG-023",
                        Note = "Global region: Oceania ΓÇô Polynesia",
                        SortOrder = 23,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region SERVICE DESK MANAGEMENT (SDM)
                {
                    231,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 231,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "Open",
                        LookupCode = "RS-001",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Initial request status when a ticket is created.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "OPEN",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    232,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 232,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "In Progress",
                        LookupCode = "RS-002",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Indicates the request is actively being worked on.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "IN_PROGRESS",
                        Color = "#F59E0B",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    233,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 233,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "On Hold",
                        LookupCode = "RS-003",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Used when work is paused due to dependency or waiting input.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "ON_HOLD",
                        Color = "#8B5CF6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    234,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 234,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "Resolved",
                        LookupCode = "RS-004",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Indicates the issue has been fixed or fulfilled.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "RESOLVED",
                        Color = "#10B981",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    235,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 235,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "Closed",
                        LookupCode = "RS-005",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Final status after request completion and closure.",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "CLOSED",
                        Color = "#6B7280",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    236,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 236,
                        LookupTypeId = 9,
                        LookupType = "RD_SDM_REQUEST_STATUSES",
                        LookupValue = "Cancelled",
                        LookupCode = "RS-006",
                        LookupLevelValue = "Request Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Used when the request is withdrawn or no longer required.",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "CANCELLED",
                        Color = "#EF4444",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    237,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 237,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Hardware",
                        LookupCode = "RCT-001",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Parent category for hardware-related requests.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    238,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 238,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Laptop Issues",
                        LookupCode = "RSCT-001",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 237,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for laptop faults, setup, and support.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    239,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 239,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Desktop Issues",
                        LookupCode = "RSCT-002",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 237,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for desktop hardware or workstation issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    240,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 240,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Software",
                        LookupCode = "RCT-002",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Parent category for software-related support requests.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    241,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 241,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "OS Installation",
                        LookupCode = "RSCT-003",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 240,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for operating system installation requests.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    242,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 242,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "App Crash",
                        LookupCode = "RSCT-004",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 240,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for application crash or launch failures.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    243,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 243,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Network",
                        LookupCode = "RCT-003",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Parent category for connectivity and network issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    244,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 244,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "VPN Access",
                        LookupCode = "RSCT-005",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 243,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for VPN setup or access problems.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    245,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 245,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Account & Access",
                        LookupCode = "RCT-004",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Parent category for account login and access support.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    246,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 246,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Login Issue",
                        LookupCode = "RSCT-006",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 245,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for failed login or account access issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    247,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 247,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Password Reset",
                        LookupCode = "RSCT-007",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 245,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for password reset or recovery requests.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    248,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 248,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Permission Issue",
                        LookupCode = "RSCT-008",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 245,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for incorrect roles, rights, or permissions.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    249,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 249,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Product Usage",
                        LookupCode = "RCT-005",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Parent category for product guidance and usage support.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    250,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 250,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "How-To Question",
                        LookupCode = "RSCT-009",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 249,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for user guidance on product functionality.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    251,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 251,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Feature Not Working",
                        LookupCode = "RSCT-010",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 249,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for product feature malfunction reports.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    252,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 252,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Configuration Help",
                        LookupCode = "RSCT-011",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 249,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for assistance with product setup or settings.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    253,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 253,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Data & Reporting",
                        LookupCode = "RCT-006",
                        LookupLevelValue = "REQUEST_CATEGORIES",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Parent category for data, report, and dashboard issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    254,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 254,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Data Missing / Incorrect",
                        LookupCode = "RSCT-012",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 253,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Subcategory for missing, incorrect, or outdated data.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    255,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 255,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Report / Dashboard Issue",
                        LookupCode = "RSCT-013",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 253,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for report, dashboard, or analytics issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    256,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 256,
                        LookupTypeId = 10,
                        LookupType = "RD_SDM_REQUEST_CATEGORIES",
                        LookupValue = "Import / Export Issue",
                        LookupCode = "RSCT-014",
                        LookupLevelValue = "REQUEST_SUBCATEGORIES",
                        Level = 2,
                        ParentId = 253,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Subcategory for import, export, upload, or download issues.",
                        SortOrder = 0,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    257,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 257,
                        LookupTypeId = 11,
                        LookupType = "RD_SDM_PRIORITIES",
                        LookupValue = "Critical",
                        LookupCode = "PRI-001",
                        LookupLevelValue = "Priority",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "P1",
                        Note = "Highest priority for severe or business-critical issues.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "CRITICAL",
                        Color = "#DC2626",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    258,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 258,
                        LookupTypeId = 11,
                        LookupType = "RD_SDM_PRIORITIES",
                        LookupValue = "High",
                        LookupCode = "PRI-002",
                        LookupLevelValue = "Priority",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "P2",
                        Note = "High priority for important issues needing quick action.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "HIGH",
                        Color = "#F59E0B",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    259,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 259,
                        LookupTypeId = 11,
                        LookupType = "RD_SDM_PRIORITIES",
                        LookupValue = "Medium",
                        LookupCode = "PRI-003",
                        LookupLevelValue = "Priority",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "P3",
                        Note = "Default priority for standard operational requests.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "MEDIUM",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    260,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 260,
                        LookupTypeId = 11,
                        LookupType = "RD_SDM_PRIORITIES",
                        LookupValue = "Low",
                        LookupCode = "PRI-004",
                        LookupLevelValue = "Priority",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "P4",
                        Note = "Low priority for minor or non-urgent requests.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "LOW",
                        Color = "#10B981",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    261,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 261,
                        LookupTypeId = 12,
                        LookupType = "RD_SDM_URGENCIES",
                        LookupValue = "Critical",
                        LookupCode = "URG-001",
                        LookupLevelValue = "Urgency",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "U1",
                        Note = "Requires immediate attention due to time-sensitive business need.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "CRITICAL",
                        Color = "#DC2626",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    262,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 262,
                        LookupTypeId = 12,
                        LookupType = "RD_SDM_URGENCIES",
                        LookupValue = "High",
                        LookupCode = "URG-002",
                        LookupLevelValue = "Urgency",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "U2",
                        Note = "Requires quick action but is not the highest emergency level.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "HIGH",
                        Color = "#F59E0B",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    263,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 263,
                        LookupTypeId = 12,
                        LookupType = "RD_SDM_URGENCIES",
                        LookupValue = "Medium",
                        LookupCode = "URG-003",
                        LookupLevelValue = "Urgency",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "U3",
                        Note = "Standard urgency for normal operational requests.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "MEDIUM",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    264,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 264,
                        LookupTypeId = 12,
                        LookupType = "RD_SDM_URGENCIES",
                        LookupValue = "Low",
                        LookupCode = "URG-004",
                        LookupLevelValue = "Urgency",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "U4",
                        Note = "Low time sensitivity and can be handled in normal queue order.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "LOW",
                        Color = "#10B981",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    265,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 265,
                        LookupTypeId = 13,
                        LookupType = "RD_SDM_IMPACTS",
                        LookupValue = "Extensive",
                        LookupCode = "IMP-001",
                        LookupLevelValue = "Impact",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "I1",
                        Note = "Critical impact affecting major business operations.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "CRITICAL",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    266,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 266,
                        LookupTypeId = 13,
                        LookupType = "RD_SDM_IMPACTS",
                        LookupValue = "Significant",
                        LookupCode = "IMP-002",
                        LookupLevelValue = "Impact",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "I2",
                        Note = "High impact affecting important users or functions.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "HIGH",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    267,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 267,
                        LookupTypeId = 13,
                        LookupType = "RD_SDM_IMPACTS",
                        LookupValue = "Moderate",
                        LookupCode = "IMP-003",
                        LookupLevelValue = "Impact",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "I3",
                        Note = "Medium impact with limited business disruption.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "MEDIUM",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    268,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 268,
                        LookupTypeId = 13,
                        LookupType = "RD_SDM_IMPACTS",
                        LookupValue = "Minor",
                        LookupCode = "IMP-004",
                        LookupLevelValue = "Impact",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "I4",
                        Note = "Low impact affecting a small scope or single user.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "LOW",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    269,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 269,
                        LookupTypeId = 14,
                        LookupType = "RD_SDM_LEVEL_TIERS",
                        LookupValue = "L1 ΓÇô First Line",
                        LookupCode = "TIER-001",
                        LookupLevelValue = "Level Tier",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "L1",
                        Note = "First-line support for initial triage and basic resolution.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "TIER_1",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    270,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 270,
                        LookupTypeId = 14,
                        LookupType = "RD_SDM_LEVEL_TIERS",
                        LookupValue = "L2 ΓÇô Second Line",
                        LookupCode = "TIER-002",
                        LookupLevelValue = "Level Tier",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "L2",
                        Note = "Second-line support for escalated or specialist issues.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "TIER_2",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    271,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 271,
                        LookupTypeId = 14,
                        LookupType = "RD_SDM_LEVEL_TIERS",
                        LookupValue = "L3 ΓÇô Third Line",
                        LookupCode = "TIER-003",
                        LookupLevelValue = "Level Tier",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "L3",
                        Note = "Third-line expert support for complex technical issues.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "TIER_3",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    272,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 272,
                        LookupTypeId = 15,
                        LookupType = "RD_SDM_MODES",
                        LookupValue = "Email",
                        LookupCode = "MODE-001",
                        LookupLevelValue = "Mode",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "EML",
                        Note = "Request received through email channel.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    273,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 273,
                        LookupTypeId = 15,
                        LookupType = "RD_SDM_MODES",
                        LookupValue = "Portal",
                        LookupCode = "MODE-002",
                        LookupLevelValue = "Mode",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PRTL",
                        Note = "Request submitted through portal or widget.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    274,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 274,
                        LookupTypeId = 15,
                        LookupType = "RD_SDM_MODES",
                        LookupValue = "Call",
                        LookupCode = "MODE-003",
                        LookupLevelValue = "Mode",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CL",
                        Note = "Request created from phone support interaction.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    275,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 275,
                        LookupTypeId = 15,
                        LookupType = "RD_SDM_MODES",
                        LookupValue = "Walk-in",
                        LookupCode = "MODE-004",
                        LookupLevelValue = "Mode",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "WALKIN",
                        Note = "Request created from in-person support interaction.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    276,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 276,
                        LookupTypeId = 16,
                        LookupType = "RD_SDM_REQUEST_TYPES",
                        LookupValue = "Incident",
                        LookupCode = "REQTYPE-001",
                        LookupLevelValue = "Request Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "INC",
                        Note = "Used for unplanned interruption or service degradation.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    277,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 277,
                        LookupTypeId = 16,
                        LookupType = "RD_SDM_REQUEST_TYPES",
                        LookupValue = "Service Request",
                        LookupCode = "REQTYPE-002",
                        LookupLevelValue = "Request Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SVC",
                        Note = "Used for standard service or fulfillment requests.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    278,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 278,
                        LookupTypeId = 16,
                        LookupType = "RD_SDM_REQUEST_TYPES",
                        LookupValue = "Change Request",
                        LookupCode = "REQTYPE-003",
                        LookupLevelValue = "Request Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CHG",
                        Note = "Used for planned change requiring tracking or approval.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    279,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 279,
                        LookupTypeId = 16,
                        LookupType = "RD_SDM_REQUEST_TYPES",
                        LookupValue = "Problem",
                        LookupCode = "REQTYPE-004",
                        LookupLevelValue = "Request Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PRB",
                        Note = "Used for root-cause investigation of recurring issues.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    280,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 280,
                        LookupTypeId = 17,
                        LookupType = "RD_SDM_TASK_TYPES",
                        LookupValue = "Approval Task",
                        LookupCode = "TT-001",
                        LookupLevelValue = "Task Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APPR",
                        Note = "Task used when approval or sign-off is required.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    281,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 281,
                        LookupTypeId = 17,
                        LookupType = "RD_SDM_TASK_TYPES",
                        LookupValue = "Action Task",
                        LookupCode = "TT-002",
                        LookupLevelValue = "Task Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ACTION",
                        Note = "Task used for assignable operational work.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    282,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 282,
                        LookupTypeId = 17,
                        LookupType = "RD_SDM_TASK_TYPES",
                        LookupValue = "Follow-up Task",
                        LookupCode = "TT-003",
                        LookupLevelValue = "Task Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FOLLOW",
                        Note = "Task used for follow-up with requester or team.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    283,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 283,
                        LookupTypeId = 17,
                        LookupType = "RD_SDM_TASK_TYPES",
                        LookupValue = "Review Task",
                        LookupCode = "TT-004",
                        LookupLevelValue = "Task Type",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REVIEW",
                        Note = "Task used for review or validation before completion.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    284,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 284,
                        LookupTypeId = 18,
                        LookupType = "RD_SDM_CLOSURE_CODES",
                        LookupValue = "Resolved",
                        LookupCode = "CC-001",
                        LookupLevelValue = "Closure Code",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "RESOLVED",
                        Note = "Closure reason when the issue has been resolved.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    285,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 285,
                        LookupTypeId = 18,
                        LookupType = "RD_SDM_CLOSURE_CODES",
                        LookupValue = "Duplicate",
                        LookupCode = "CC-002",
                        LookupLevelValue = "Closure Code",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DUPL",
                        Note = "Closure reason when the request duplicates another ticket.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    286,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 286,
                        LookupTypeId = 18,
                        LookupType = "RD_SDM_CLOSURE_CODES",
                        LookupValue = "Cancelled",
                        LookupCode = "CC-003",
                        LookupLevelValue = "Closure Code",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CANCEL",
                        Note = "Closure reason when the request is cancelled.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    287,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 287,
                        LookupTypeId = 18,
                        LookupType = "RD_SDM_CLOSURE_CODES",
                        LookupValue = "Auto-Closed",
                        LookupCode = "CC-004",
                        LookupLevelValue = "Closure Code",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AUTO",
                        Note = "Closure reason when the system closes the request automatically.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    288,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 288,
                        LookupTypeId = 18,
                        LookupType = "RD_SDM_CLOSURE_CODES",
                        LookupValue = "Cannot Reproduce",
                        LookupCode = "CC-005",
                        LookupLevelValue = "Closure Code",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NOREPRO",
                        Note = "Closure reason when the issue cannot be reproduced.",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SUPPLIER PAYMENT
            #region SUPPLIER PAYMENT
                 {
                    289,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 289,
                        LookupTypeId = 19,
                        LookupType = "RD_SCM_PAYMENT_METHOD",
                        LookupValue = "Cheque",
                        LookupCode = "PAY_CHEQUE",
                        LookupLevelValue = "PAYMENT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PAY-001",
                        Note = "Cheque Payment",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                 {
                    290,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 290,
                        LookupTypeId = 19,
                        LookupType = "RD_SCM_PAYMENT_METHOD",
                        LookupValue = "Electronic",
                        LookupCode = "PAY_ELECTRONIC",
                        LookupLevelValue = "PAYMENT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PAY-002",
                        Note = "Electronic Payment",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //GLOBAL ADDRESS TYPE
            #region GLOBAL ADDRESS TYPE
                {
                    291,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 291,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Registered",
                        LookupCode = "ADT-001",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REG",
                        Note = "The legally registered address of the entity as recorded with government or regulatory authorities.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "REGISTERED",
                        Color = "#8B5CF6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    292,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 292,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Physical",
                        LookupCode = "ADT-002",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PHYS",
                        Note = "The actual location where the entity or its operations are physically present.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "PHYSICAL",
                        Color = "#F97316",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    293,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 293,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Mailing",
                        LookupCode = "ADT-003",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MAIL",
                        Note = "The address designated for receiving general correspondence and postal communications.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "MAILING",
                        Color = "#F87171",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    294,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 294,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Shipping",
                        LookupCode = "ADT-004",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SHIP",
                        Note = "The delivery destination for goods and outbound shipments.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "SHIPPING",
                        Color = "#22C55E",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    295,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 295,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Billing",
                        LookupCode = "ADT-005",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BILL",
                        Note = "The address associated with invoicing and financial transaction documents.",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "BILLING",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    296,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 296,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Return",
                        LookupCode = "ADT-006",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RET",
                        Note = "The address to which goods are sent back in case of returns, rejections, or exchanges.",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "RETURN",
                        Color = "#4B5563",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    297,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 297,
                        LookupTypeId = 20,
                        LookupType = "RD_GLOB_ADDRESS_TYPE",
                        LookupValue = "Remitting",
                        LookupCode = "ADT-007",
                        LookupLevelValue = "ADDRESS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REMIT",
                        Note = "The address associated with payment remittance and fund transfer notifications.",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "REMITTING",
                        Color = "#14B8A6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //GLOBAL ENTITY TYPE
            #region GLOBAL ENTITY TYPE
                {
                    298,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 298,
                        LookupTypeId = 21,
                        LookupType = "RD_GLOB_ENTITY_TYPE",
                        LookupValue = "Supplier",
                        LookupCode = "ETR-001",
                        LookupLevelValue = "ENTITY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EDM-SM",
                        Note = "Supplier Address Requirements",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "SUPPLIER",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    299,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 299,
                        LookupTypeId = 21,
                        LookupType = "RD_GLOB_ENTITY_TYPE",
                        LookupValue = "Customer",
                        LookupCode = "ETR-002",
                        LookupLevelValue = "ENTITY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CUS",
                        Note = "Customer Address Requirements",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "CUSTOMER",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    300,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 300,
                        LookupTypeId = 21,
                        LookupType = "RD_GLOB_ENTITY_TYPE",
                        LookupValue = "Employee",
                        LookupCode = "ETR-003",
                        LookupLevelValue = "ENTITY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EMC-EM",
                        Note = "Employee Address Requirements",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "EMPLOYEE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    301,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 301,
                        LookupTypeId = 21,
                        LookupType = "RD_GLOB_ENTITY_TYPE",
                        LookupValue = "Location",
                        LookupCode = "ETR-004",
                        LookupLevelValue = "ENTITY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EDM-LOC",
                        Note = "Location Address Requirements",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "LOCATION",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //GLOBAL ENFORCED AT
            #region GLOBAL ENFORCED AT
                {
                    302,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 302,
                        LookupTypeId = 22,
                        LookupType = "RD_GLOB_ENFORCED_AT",
                        LookupValue = "Save",
                        LookupCode = "EAT-001",
                        LookupLevelValue = "ENFORCED_AT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SAVE",
                        Note = "Enforced when saving the record",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "SAVE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    303,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 303,
                        LookupTypeId = 22,
                        LookupType = "RD_GLOB_ENFORCED_AT",
                        LookupValue = "Activate",
                        LookupCode = "EAT-002",
                        LookupLevelValue = "ENFORCED_AT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ACTIVATE",
                        Note = "Enforced when activating the record",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "ACTIVATE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region Configuration -> Days of Week

                {
                    304,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 304,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Sunday",
                        LookupCode = "DOW-001",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SUN",
                        Note = "Day of week: Sunday",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    305,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 305,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Monday",
                        LookupCode = "DOW-002",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MON",
                        Note = "Day of week: Monday",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    306,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 306,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Tuesday",
                        LookupCode = "DOW-003",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TUE",
                        Note = "Day of week: Tuesday",
                        SortOrder = 3,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    307,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 307,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Wednesday",
                        LookupCode = "DOW-004",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "WED",
                        Note = "Day of week: Wednesday",
                        SortOrder = 4,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    308,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 308,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Thursday",
                        LookupCode = "DOW-005",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "THU",
                        Note = "Day of week: Thursday",
                        SortOrder = 5,
                        Index = 4,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    309,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 309,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Friday",
                        LookupCode = "DOW-006",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FRI",
                        Note = "Day of week: Friday",
                        SortOrder = 6,
                        Index = 5,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    310,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 310,
                        LookupTypeId = 23,
                        LookupType = "SYS_DAYS_OF_WEEK",
                        LookupValue = "Saturday",
                        LookupCode = "DOW-007",
                        LookupLevelValue = "DAY_OF_WEEK",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAT",
                        Note = "Day of week: Saturday",
                        SortOrder = 7,
                        Index = 6,
                        SharedScope = 0,
                        LookupCodeType = "DAY_OF_WEEK",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region SYS_ACCESS_CATEGORY
                {
                    311,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 311,
                        LookupTypeId = 24,
                        LookupType = "SYS_ACCESS_CATEGORY",
                        LookupValue = "Scope",
                        LookupCode = "ACCAT-01",
                        LookupLevelValue = "ACCESS_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SCOPE",
                        Note = "Access category: Scope",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    312,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 312,
                        LookupTypeId = 24,
                        LookupType = "SYS_ACCESS_CATEGORY",
                        LookupValue = "Owned",
                        LookupCode = "ACCAT-02",
                        LookupLevelValue = "ACCESS_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OWNED",
                        Note = "Access category: Owned",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    313,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 313,
                        LookupTypeId = 24,
                        LookupType = "SYS_ACCESS_CATEGORY",
                        LookupValue = "Standard",
                        LookupCode = "ACCAT-03",
                        LookupLevelValue = "ACCESS_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "STD",
                        Note = "Access category: Standard",
                        SortOrder = 3,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    314,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 314,
                        LookupTypeId = 24,
                        LookupType = "SYS_ACCESS_CATEGORY",
                        LookupValue = "Hybrid",
                        LookupCode = "ACCAT-04",
                        LookupLevelValue = "ACCESS_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HYBRID",
                        Note = "Access category: Hybrid",
                        SortOrder = 4,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region SYS_SCOPE
                {
                    315,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 315,
                        LookupTypeId = 25,
                        LookupType = "SYS_SCOPE",
                        LookupValue = "Global",
                        LookupCode = "SCOPE-01",
                        LookupLevelValue = "SCOPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "GLOBAL",
                        Note = "Scope: Global",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "SCOPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    316,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 316,
                        LookupTypeId = 25,
                        LookupType = "SYS_SCOPE",
                        LookupValue = "Restricted",
                        LookupCode = "SCOPE-02",
                        LookupLevelValue = "SCOPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RESTRICTED",
                        Note = "Scope: Restricted",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "SCOPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    317,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 317,
                        LookupTypeId = 25,
                        LookupType = "SYS_SCOPE",
                        LookupValue = "Shared",
                        LookupCode = "SCOPE-03",
                        LookupLevelValue = "SCOPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SHARED",
                        Note = "Scope: Shared",
                        SortOrder = 3,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "SCOPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region SYS_ACCESS_CATEGORY_LEVEL_1
                {
                    318,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 318,
                        LookupTypeId = 26,
                        LookupType = "SYS_ACCESS_CATEGORY_LEVEL_1",
                        LookupValue = "Company",
                        LookupCode = "ACL1-01",
                        LookupLevelValue = "ACCESS_CATEGORY_LEVEL_1",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "COMPANY",
                        Note = "Access category level 1: Company",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY_LEVEL_1",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    319,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 319,
                        LookupTypeId = 26,
                        LookupType = "SYS_ACCESS_CATEGORY_LEVEL_1",
                        LookupValue = "Department",
                        LookupCode = "ACL1-02",
                        LookupLevelValue = "ACCESS_CATEGORY_LEVEL_1",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DEPT",
                        Note = "Access category level 1: Department",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY_LEVEL_1",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region SYS_ACCESS_CATEGORY_LEVEL_2
                {
                    320,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 320,
                        LookupTypeId = 27,
                        LookupType = "SYS_ACCESS_CATEGORY_LEVEL_2",
                        LookupValue = "Company",
                        LookupCode = "ACL2-01",
                        LookupLevelValue = "ACCESS_CATEGORY_LEVEL_2",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "COMPANY",
                        Note = "Access category level 2: Company",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY_LEVEL_2",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    321,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 321,
                        LookupTypeId = 27,
                        LookupType = "SYS_ACCESS_CATEGORY_LEVEL_2",
                        LookupValue = "Department",
                        LookupCode = "ACL2-02",
                        LookupLevelValue = "ACCESS_CATEGORY_LEVEL_2",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DEPT",
                        Note = "Access category level 2: Department",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "ACCESS_CATEGORY_LEVEL_2",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //GLOBAL INDUSTRY TYPE
            #region GLOBAL LE INDUSTRY TYPE
                {
                    322,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 322,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Manufacturing",
                        LookupCode = "LETYPE-01",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MFG",
                        Note = "Legal entity industry type: Manufacturing",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    323,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 323,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Trading / Distribution",
                        LookupCode = "LETYPE-02",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TRD",
                        Note = "Legal entity industry type: Trading / Distribution",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    324,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 324,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Retail",
                        LookupCode = "LETYPE-03",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RTL",
                        Note = "Legal entity industry type: Retail",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    325,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 325,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Construction & Contracting",
                        LookupCode = "LETYPE-04",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CON",
                        Note = "Legal entity industry type: Construction & Contracting",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    326,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 326,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Oil, Gas & Energy",
                        LookupCode = "LETYPE-05",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OIL",
                        Note = "Legal entity industry type: Oil, Gas & Energy",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    327,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 327,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Financial Services",
                        LookupCode = "LETYPE-06",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FIN",
                        Note = "Legal entity industry type: Financial Services",
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    328,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 328,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Healthcare",
                        LookupCode = "LETYPE-07",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HLC",
                        Note = "Legal entity industry type: Healthcare",
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    329,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 329,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Education",
                        LookupCode = "LETYPE-08",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EDU",
                        Note = "Legal entity industry type: Education",
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    330,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 330,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Real Estate",
                        LookupCode = "LETYPE-09",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RES",
                        Note = "Legal entity industry type: Real Estate",
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    331,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 331,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Hospitality & Tourism",
                        LookupCode = "LETYPE-10",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HOS",
                        Note = "Legal entity industry type: Hospitality & Tourism",
                        SortOrder = 10,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    332,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 332,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Logistics & Transportation",
                        LookupCode = "LETYPE-11",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LOG",
                        Note = "Legal entity industry type: Logistics & Transportation",
                        SortOrder = 11,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    333,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 333,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Information Technology & Communications",
                        LookupCode = "LETYPE-12",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ITC",
                        Note = "Legal entity industry type: Information Technology & Communications",
                        SortOrder = 12,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    334,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 334,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Agriculture & Fisheries",
                        LookupCode = "LETYPE-13",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AGR",
                        Note = "Legal entity industry type: Agriculture & Fisheries",
                        SortOrder = 13,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    335,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 335,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Government / Public Sector",
                        LookupCode = "LETYPE-14",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GOV",
                        Note = "Legal entity industry type: Government / Public Sector",
                        SortOrder = 14,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    336,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 336,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Professional Services",
                        LookupCode = "LETYPE-15",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PRO",
                        Note = "Legal entity industry type: Professional Services",
                        SortOrder = 15,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    337,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 337,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Media & Entertainment",
                        LookupCode = "LETYPE-16",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MED",
                        Note = "Legal entity industry type: Media & Entertainment",
                        SortOrder = 16,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    338,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 338,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Utilities",
                        LookupCode = "LETYPE-17",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UTL",
                        Note = "Legal entity industry type: Utilities",
                        SortOrder = 17,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    339,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 339,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Non-Profit / NGO",
                        LookupCode = "LETYPE-18",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NGO",
                        Note = "Legal entity industry type: Non-Profit / NGO",
                        SortOrder = 18,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    340,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 340,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Holding Company",
                        LookupCode = "LETYPE-19",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HLD",
                        Note = "Legal entity industry type: Holding Company",
                        SortOrder = 19,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    341,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 341,
                        LookupTypeId = 28,
                        LookupType = "RD_GLOB_LE_INDUSTRY_TYPE",
                        LookupValue = "Other",
                        LookupCode = "LETYPE-20",
                        LookupLevelValue = "LE_INDUSTRY_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OTH",
                        Note = "Legal entity industry type: Other",
                        SortOrder = 20,
                        SharedScope = 0,
                        LookupCodeType = "LE_INDUSTRY_TYPE",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    342,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 342,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Active",
                        LookupCode = "0",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ACT",
                        Note = "Active Status",
                        SortOrder = 1,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    343,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 343,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Inactive",
                        LookupCode = "1",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "INA",
                        Note = "Inactive Status",
                        SortOrder = 2,
                        Index = 1,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    344,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 344,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Removed",
                        LookupCode = "2",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RMV",
                        Note = "Removed Status",
                        SortOrder = 3,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    345,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 345,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Hide",
                        LookupCode = "3",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HID",
                        Note = "Hide Status",
                        SortOrder = 4,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    346,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 346,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Reject",
                        LookupCode = "4",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REJ",
                        Note = "Reject Status",
                        SortOrder = 5,
                        Index = 4,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    347,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 347,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Ended",
                        LookupCode = "5",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "END",
                        Note = "Ended Status",
                        SortOrder = 6,
                        Index = 5,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    348,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 348,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Deprecated",
                        LookupCode = "6",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DEP",
                        Note = "Deprecated Status",
                        SortOrder = 7,
                        Index = 6,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    349,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 349,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Archived",
                        LookupCode = "7",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ARC",
                        Note = "Archived Status",
                        SortOrder = 8,
                        Index = 7,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    350,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 350,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Purged",
                        LookupCode = "8",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PUR",
                        Note = "Purged Status",
                        SortOrder = 9,
                        Index = 8,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    351,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 351,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Draft",
                        LookupCode = "9",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DRF",
                        Note = "Draft Status",
                        SortOrder = 10,
                        Index = 9,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    352,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 352,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Approved",
                        LookupCode = "10",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APP",
                        Note = "Approved Status",
                        SortOrder = 11,
                        Index = 10,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    353,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 353,
                        LookupTypeId = 29,
                        LookupType = "SYS_STATUS",
                        LookupValue = "Terminated",
                        LookupCode = "11",
                        LookupLevelValue = "Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TRM",
                        Note = "Terminated Status",
                        SortOrder = 12,
                        Index = 11,
                        SharedScope = 0,
                        LookupCodeType = "Status",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //ITEM FINANCE CATEGORY
            #region ITEM FINANCE CATEGORY
                {
                    354,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 354,
                        LookupTypeId = 30,
                        LookupType = "RD_FSC-ITEM_FINANCE_CATEGORY",
                        LookupValue = "Inventory",
                        LookupCode = "IFC-01",
                        LookupLevelValue = "ITEM_FINANCE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "INV",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    355,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 355,
                        LookupTypeId = 30,
                        LookupType = "RD_FSC-ITEM_FINANCE_CATEGORY",
                        LookupValue = "Non-Inventory",
                        LookupCode = "IFC-02",
                        LookupLevelValue = "ITEM_FINANCE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NIN",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    356,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 356,
                        LookupTypeId = 30,
                        LookupType = "RD_FSC-ITEM_FINANCE_CATEGORY",
                        LookupValue = "Service",
                        LookupCode = "IFC-03",
                        LookupLevelValue = "ITEM_FINANCE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SER",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    357,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 357,
                        LookupTypeId = 30,
                        LookupType = "RD_FSC-ITEM_FINANCE_CATEGORY",
                        LookupValue = "Fixed Asset",
                        LookupCode = "IFC-04",
                        LookupLevelValue = "ITEM_FINANCE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FA",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //ITEM TYPE
            #region ITEM TYPE
                {
                    358,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 358,
                        LookupTypeId = 31,
                        LookupType = "RD_FSC_ITEM_TYPE",
                        LookupValue = "Purchase",
                        LookupCode = "ITEMTYPE-01",
                        LookupLevelValue = "ITEM_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PUR",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    359,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 359,
                        LookupTypeId = 31,
                        LookupType = "RD_FSC_ITEM_TYPE",
                        LookupValue = "Sale",
                        LookupCode = "ITEMTYPE-02",
                        LookupLevelValue = "ITEM_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SALE",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //POS TYPE
            #region POS TYPE
                {
                    360,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 360,
                        LookupTypeId = 32,
                        LookupType = "RD_FSC_POS_TYPE",
                        LookupValue = "GPOS",
                        LookupCode = "POSTYPE-01",
                        LookupLevelValue = "POS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GPOS",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    361,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 361,
                        LookupTypeId = 32,
                        LookupType = "RD_FSC_POS_TYPE",
                        LookupValue = "RPOS",
                        LookupCode = "POSTYPE-02",
                        LookupLevelValue = "POS_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RPOS",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //EDM Finance Centre
            #region RD_EDM_FINANCIAL_CENTRE_TYPE
                {
                    362,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 362,
                        LookupTypeId = 33,
                        LookupType = "RD_EDM_FINANCE_CENTRE_TYPE",
                        LookupValue = "Cost Centre",
                        LookupCode = "EDM_FE_FINANCE",
                        LookupLevelValue = "EDM_FE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FE_FC",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    363,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 363,
                        LookupTypeId = 33,
                        LookupType = "RD_EDM_FINANCE_CENTRE_TYPE",
                        LookupValue = "Revenue Centre",
                        LookupCode = "EDM_FE_REVENUE",
                        LookupLevelValue = "EDM_FE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FC_RC",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion
                
            //SUPPLIER SALUTATION
            #region RD_SCM_SALUTATION
                {
                    364,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 364,
                        LookupTypeId = 34,
                        LookupType = "RD_SCM_SALUTATION",
                        LookupValue = "Mr",
                        LookupCode = "SALUTATION_MR",
                        LookupLevelValue = "SALUTATION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SAL-001",
                        Note = "Salutation: Mr",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    365,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 365,
                        LookupTypeId = 34,
                        LookupType = "RD_SCM_SALUTATION",
                        LookupValue = "Mrs",
                        LookupCode = "SALUTATION_MRS",
                        LookupLevelValue = "SALUTATION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAL-002",
                        Note = "Salutation: Mrs",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    366,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 366,
                        LookupTypeId = 34,
                        LookupType = "RD_SCM_SALUTATION",
                        LookupValue = "Ms",
                        LookupCode = "SALUTATION_MS",
                        LookupLevelValue = "SALUTATION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAL-003",
                        Note = "Salutation: Ms",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    367,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 367,
                        LookupTypeId = 34,
                        LookupType = "RD_SCM_SALUTATION",
                        LookupValue = "Dr",
                        LookupCode = "SALUTATION_DR",
                        LookupLevelValue = "SALUTATION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAL-004",
                        Note = "Salutation: Dr",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_TEMPLATE_TYPE
                {
                    368,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 368,
                        LookupTypeId = 35,
                        LookupType = "RD_FSC_TEMPLATE_TYPE",
                        LookupValue = "Balance Sheet",
                        LookupCode = "FSC_TT_BS",
                        LookupLevelValue = "FSC_TEMPLATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BS",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    369,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 369,
                        LookupTypeId = 35,
                        LookupType = "RD_FSC_TEMPLATE_TYPE",
                        LookupValue = "Profit & Loss",
                        LookupCode = "FSC_TT_PL",
                        LookupLevelValue = "FSC_TEMPLATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PL",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    370,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 370,
                        LookupTypeId = 35,
                        LookupType = "RD_FSC_TEMPLATE_TYPE",
                        LookupValue = "Cash Flow",
                        LookupCode = "FSC_TT_CF",
                        LookupLevelValue = "FSC_TEMPLATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CF",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    371,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 371,
                        LookupTypeId = 35,
                        LookupType = "RD_FSC_TEMPLATE_TYPE",
                        LookupValue = "Changes in Equity",
                        LookupCode = "FSC_TT_CE",
                        LookupLevelValue = "FSC_TEMPLATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CE",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_TEMPLATE_GROUP
                {
                    372,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 372,
                        LookupTypeId = 36,
                        LookupType = "RD_FSC_TEMPLATE_GROUP",
                        LookupValue = "Global",
                        LookupCode = "FSC_TG_GLOBAL",
                        LookupLevelValue = "FSC_TEMPLATE_GROUP",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GLOBAL",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    373,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 373,
                        LookupTypeId = 36,
                        LookupType = "RD_FSC_TEMPLATE_GROUP",
                        LookupValue = "Individual",
                        LookupCode = "FSC_TG_INDIVIDUAL",
                        LookupLevelValue = "FSC_TEMPLATE_GROUP",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "INDIVIDUAL",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_TEMPLATE_CATEGORY
                {
                    374,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 374,
                        LookupTypeId = 37,
                        LookupType = "RD_FSC_TEMPLATE_CATEGORY",
                        LookupValue = "Chart of Accounts",
                        LookupCode = "FSC_TC_COA",
                        LookupLevelValue = "FSC_TEMPLATE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COA",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    375,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 375,
                        LookupTypeId = 37,
                        LookupType = "RD_FSC_TEMPLATE_CATEGORY",
                        LookupValue = "Budget",
                        LookupCode = "FSC_TC_BUDGET",
                        LookupLevelValue = "FSC_TEMPLATE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BUDGET",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    376,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 376,
                        LookupTypeId = 37,
                        LookupType = "RD_FSC_TEMPLATE_CATEGORY",
                        LookupValue = "Reporting",
                        LookupCode = "FSC_TC_REPORTING",
                        LookupLevelValue = "FSC_TEMPLATE_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "REPORTING",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_PRIMARY_FILTER
                {
                    377,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 377,
                        LookupTypeId = 38,
                        LookupType = "RD_FSC_PRIMARY_FILTER",
                        LookupValue = "Financial Year/Period",
                        LookupCode = "FSC_PF_FY",
                        LookupLevelValue = "FSC_PRIMARY_FILTER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FY_PERIOD",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    378,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 378,
                        LookupTypeId = 38,
                        LookupType = "RD_FSC_PRIMARY_FILTER",
                        LookupValue = "Date Range",
                        LookupCode = "FSC_PF_DATE",
                        LookupLevelValue = "FSC_PRIMARY_FILTER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DATE_RANGE",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    379,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 379,
                        LookupTypeId = 38,
                        LookupType = "RD_FSC_PRIMARY_FILTER",
                        LookupValue = "Both",
                        LookupCode = "FSC_PF_BOTH",
                        LookupLevelValue = "FSC_PRIMARY_FILTER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BOTH",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_TEMPLATE_ACTION
                {
                    380,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 380,
                        LookupTypeId = 39,
                        LookupType = "RD_FSC_TEMPLATE_ACTION",
                        LookupValue = "Create",
                        LookupCode = "FSC_TA_CREATE",
                        LookupLevelValue = "FSC_TEMPLATE_ACTION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CREATE",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    381,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 381,
                        LookupTypeId = 39,
                        LookupType = "RD_FSC_TEMPLATE_ACTION",
                        LookupValue = "Link",
                        LookupCode = "FSC_TA_LINK",
                        LookupLevelValue = "FSC_TEMPLATE_ACTION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LINK",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    382,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 382,
                        LookupTypeId = 39,
                        LookupType = "RD_FSC_TEMPLATE_ACTION",
                        LookupValue = "Copy",
                        LookupCode = "FSC_TA_COPY",
                        LookupLevelValue = "FSC_TEMPLATE_ACTION",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COPY",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_COPY_MODE
                {
                    383,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 383,
                        LookupTypeId = 40,
                        LookupType = "RD_FSC_COPY_MODE",
                        LookupValue = "Copy Design & GL Codes",
                        LookupCode = "FSC_CM_DESIGN_GL",
                        LookupLevelValue = "FSC_COPY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DESIGN_GL",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    384,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 384,
                        LookupTypeId = 40,
                        LookupType = "RD_FSC_COPY_MODE",
                        LookupValue = "Copy Design Only",
                        LookupCode = "FSC_CM_DESIGN",
                        LookupLevelValue = "FSC_COPY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DESIGN",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    385,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 385,
                        LookupTypeId = 40,
                        LookupType = "RD_FSC_COPY_MODE",
                        LookupValue = "Copy Rows & GL Codes",
                        LookupCode = "FSC_CM_ROWS_GL",
                        LookupLevelValue = "FSC_COPY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ROWS_GL",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    386,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 386,
                        LookupTypeId = 40,
                        LookupType = "RD_FSC_COPY_MODE",
                        LookupValue = "Copy Rows Only",
                        LookupCode = "FSC_CM_ROWS",
                        LookupLevelValue = "FSC_COPY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ROWS",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    387,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 387,
                        LookupTypeId = 40,
                        LookupType = "RD_FSC_COPY_MODE",
                        LookupValue = "Copy Columns Only",
                        LookupCode = "FSC_CM_COLUMNS",
                        LookupLevelValue = "FSC_COPY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COLUMNS",
                        Note = null,
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_SERIAL_LENGTH_MODE
                {
                    388,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 388,
                        LookupTypeId = 41,
                        LookupType = "RD_FSC_SERIAL_LENGTH_MODE",
                        LookupValue = "Fixed Serial Length",
                        LookupCode = "FSC_SL_MODE1",
                        LookupLevelValue = "FSC_SERIAL_LENGTH_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MODE1",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    389,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 389,
                        LookupTypeId = 41,
                        LookupType = "RD_FSC_SERIAL_LENGTH_MODE",
                        LookupValue = "User-Defined Serial Length",
                        LookupCode = "FSC_SL_MODE2",
                        LookupLevelValue = "FSC_SERIAL_LENGTH_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MODE2",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                #endregion

            #region RD_EDM_BANK_ACCOUNT_TYPE
                {
                    390,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 390,
                        LookupTypeId = 42,
                        LookupType = "RD_EDM_BANK_ACCOUNT_TYPE",
                        LookupValue = "Current Account",
                        LookupCode = "CURRENT_ACCOUNT",
                        LookupLevelValue = "BANK_ACCOUNT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CUR-ACC",
                        Note = "Current Account Type",
                        SortOrder = 1,
                        SharedScope = 1,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    391,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 391,
                        LookupTypeId = 42,
                        LookupType = "RD_EDM_BANK_ACCOUNT_TYPE",
                        LookupValue = "Savings Account",
                        LookupCode = "SAVINGS_ACCOUNT",
                        LookupLevelValue = "BANK_ACCOUNT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAV-ACC",
                        Note = "Savings Account Type",
                        SortOrder = 2,
                        SharedScope = 1,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    392,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 392,
                        LookupTypeId = 42,
                        LookupType = "RD_EDM_BANK_ACCOUNT_TYPE",
                        LookupValue = "Credit Card Account",
                        LookupCode = "CREDIT_CARD_ACCOUNT",
                        LookupLevelValue = "BANK_ACCOUNT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CC-ACC",
                        Note = "Credit Card Account Type",
                        SortOrder = 3,
                        SharedScope = 1,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    393,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 393,
                        LookupTypeId = 42,
                        LookupType = "RD_EDM_BANK_ACCOUNT_TYPE",
                        LookupValue = "Cash Account",
                        LookupCode = "CASH_ACCOUNT",
                        LookupLevelValue = "BANK_ACCOUNT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CASH-ACC",
                        Note = "Cash Account Type",
                        SortOrder = 4,
                        SharedScope = 1,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //Accounting calendar
            #region RD_EDM_ACCOUNTING_PERIOD_TYPE
                {
                    394,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 394,

                        LookupTypeId = 43,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_TYPE",
                        LookupValue = "Monthly",
                        LookupCode = "MONTHLY",
                        LookupLevelValue = "ACCOUNTING_PERIOD_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APT-01",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    395,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 395,

                        LookupTypeId = 43,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_TYPE",
                        LookupValue = "Quarterly",
                        LookupCode = "QUARTERLY",
                        LookupLevelValue = "ACCOUNTING_PERIOD_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APT-02",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    396,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 396,

                        LookupTypeId = 43,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_TYPE",
                        LookupValue = "Custom",
                        LookupCode = "CUSTOM",
                        LookupLevelValue = "ACCOUNTING_PERIOD_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APT-03",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_FISCAL_YEAR_START_MONTH
                {
                    397,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 397,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "January",
                        LookupCode = "JANUARY",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "FYSM-01",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    398,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 398,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "February",
                        LookupCode = "FEBRUARY",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-02",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    399,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 399,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "March",
                        LookupCode = "MARCH",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-03",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    400,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 400,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "April",
                        LookupCode = "APRIL",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-04",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    401,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 401,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "May",
                        LookupCode = "MAY",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-05",
                        Note = null,
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    402,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 402,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "June",
                        LookupCode = "JUNE",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-06",
                        Note = null,
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    403,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 403,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "July",
                        LookupCode = "JULY",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-07",
                        Note = null,
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    404,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 404,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "August",
                        LookupCode = "AUGUST",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-08",
                        Note = null,
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    405,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 405,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "September",
                        LookupCode = "SEPTEMBER",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-09",
                        Note = null,
                        SortOrder = 9,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    406,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 406,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "October",
                        LookupCode = "OCTOBER",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-10",
                        Note = null,
                        SortOrder = 10,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    407,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 407,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "November",
                        LookupCode = "NOVEMBER",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-11",
                        Note = null,
                        SortOrder = 11,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    408,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 408,

                        LookupTypeId = 44,
                        LookupType = "RD_EDM_FISCAL_YEAR_START_MONTH",
                        LookupValue = "December",
                        LookupCode = "DECEMBER",
                        LookupLevelValue = "FISCAL_YEAR_START_MONTH",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FYSM-12",
                        Note = null,
                        SortOrder = 12,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_ACCOUNTING_MODULE
                {
                    409,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 409,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "General Ledger",
                        LookupCode = "GL",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "AM-01",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    410,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 410,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Accounts Payable",
                        LookupCode = "AP",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-02",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    411,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 411,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Accounts Receivable",
                        LookupCode = "AR",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-03",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    412,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 412,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Treasury Management",
                        LookupCode = "TM",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-04",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    413,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 413,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Asset Management",
                        LookupCode = "AM",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-05",
                        Note = null,
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    414,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 414,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Inventory",
                        LookupCode = "INV",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-06",
                        Note = null,
                        SortOrder = 6,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    415,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 415,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Sales & Order Processing",
                        LookupCode = "SOP",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-07",
                        Note = null,
                        SortOrder = 7,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    416,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 416,

                        LookupTypeId = 45,
                        LookupType = "RD_EDM_ACCOUNTING_MODULE",
                        LookupValue = "Human Resources Management",
                        LookupCode = "HRM",
                        LookupLevelValue = "ACCOUNTING_MODULE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AM-08",
                        Note = null,
                        SortOrder = 8,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_ACCOUNTING_PERIOD_STATUS
                {
                    417,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 417,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Never Opened",
                        LookupCode = "NEVER_OPENED",
                        LookupLevelValue = "ACCOUNTING_PERIOD_STATUS",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APS-01",
                        Note = "Period not yet opened. No transaction posting permitted.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "#9CA3AF",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    418,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 418,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Open",
                        LookupCode = "OPEN",
                        LookupLevelValue = "ACCOUNTING_PERIOD_STATUS",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-02",
                        Note = "Active Period. Normal transaction posting allowed.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "#22C55E",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    419,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 419,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Close Pending",
                        LookupCode = "CLOSE_PENDING",
                        LookupLevelValue = "ACCOUNTING_PERIOD_STATUS",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-03",
                        Note = "Soft lock in progress. Finance adjustment by finance only.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "#F59E0B",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    420,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 420,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Closed",
                        LookupCode = "CLOSED",
                        LookupLevelValue = "ACCOUNTING_PERIOD_STATUS",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-04",
                        Note = "Period locked. Reopen requires elevated privilege.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    421,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 421,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Permanently Closed",
                        LookupCode = "PERMANENTLY_CLOSED",
                        LookupLevelValue = "ACCOUNTING_PERIOD_STATUS",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-05",
                        Note = "Hard lock. Period is audited and immutable.",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "#EF4444",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    422,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 422,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "No posting permitted",
                        LookupCode = "NO_POSTING_PERMITTED",
                        LookupLevelValue = "POSTING_ACCESS",
                        Level = 2,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APS-01",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    423,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 423,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "All authorized users",
                        LookupCode = "ALL_AUTHORIZED_USERS",
                        LookupLevelValue = "POSTING_ACCESS",
                        Level = 2,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-02",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    424,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 424,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Finance/Controllership only",
                        LookupCode = "FINANCE_CONTROLLERSHIP_ONLY",
                        LookupLevelValue = "POSTING_ACCESS",
                        Level = 2,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-03",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    425,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 425,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "No posting (Approval required to reopen)",
                        LookupCode = "APPROVAL_REQUIRED_TO_REOPEN",
                        LookupLevelValue = "POSTING_ACCESS",
                        Level = 2,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-04",
                        Note = null,
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    426,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 426,

                        LookupTypeId = 46,
                        LookupType = "RD_EDM_ACCOUNTING_PERIOD_STATUS",
                        LookupValue = "Not permitted (Terminal state)",
                        LookupCode = "NOT_PERMITTED_TERMINAL_STATE",
                        LookupLevelValue = "POSTING_ACCESS",
                        Level = 2,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APS-05",
                        Note = null,
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = "",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_PERIOD_TYPE
                {
                    427,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 427,

                        LookupTypeId = 47,
                        LookupType = "RD_EDM_PERIOD_TYPE",
                        LookupValue = "Regular",
                        LookupCode = "REGULAR",
                        LookupLevelValue = "PERIOD_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PT-01",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    428,

                    new Models.EDM.RdmLookupValue
                    {
                        Id = 428,

                        LookupTypeId = 47,
                        LookupType = "RD_EDM_PERIOD_TYPE",
                        LookupValue = "Adjustment",
                        LookupCode = "ADJUSTMENT",
                        LookupLevelValue = "PERIOD_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PT-02",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //RD_FSC_ISO_CURRENCY_SET_1
            #region RD_FSC_ISO_CURRENCY_SET_1
                {
                    429,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 429,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "US Dollar",
                        LookupCode = "840",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "USD",
                        Note = "$",
                        SortOrder = 1,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    430,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 430,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Euro",
                        LookupCode = "978",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EUR",
                        Note = "Γé¼",
                        SortOrder = 2,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    431,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 431,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Pound Sterling",
                        LookupCode = "826",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GBP",
                        Note = "┬ú",
                        SortOrder = 3,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    432,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 432,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Yen",
                        LookupCode = "392",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "JPY",
                        Note = "┬Ñ",
                        SortOrder = 4,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    433,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 433,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "UAE Dirham",
                        LookupCode = "784",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AED",
                        Note = "╪».╪Ñ",
                        SortOrder = 5,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    434,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 434,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Saudi Riyal",
                        LookupCode = "682",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SAR",
                        Note = "╪▒.╪│",
                        SortOrder = 6,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    435,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 435,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Indian Rupee",
                        LookupCode = "356",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "INR",
                        Note = "Γé╣",
                        SortOrder = 7,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    436,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 436,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Australian Dollar",
                        LookupCode = "036",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AUD",
                        Note = "A$",
                        SortOrder = 8,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    437,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 437,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Canadian Dollar",
                        LookupCode = "124",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CAD",
                        Note = "CA$",
                        SortOrder = 9,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    438,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 438,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Swiss Franc",
                        LookupCode = "756",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CHF",
                        Note = "CHF",
                        SortOrder = 10,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    439,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 439,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Yuan Renminbi",
                        LookupCode = "156",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CNY",
                        Note = "┬Ñ",
                        SortOrder = 11,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    440,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 440,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Singapore Dollar",
                        LookupCode = "702",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SGD",
                        Note = "S$",
                        SortOrder = 12,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    441,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 441,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Hong Kong Dollar",
                        LookupCode = "344",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HKD",
                        Note = "HK$",
                        SortOrder = 13,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    442,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 442,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Malaysian Ringgit",
                        LookupCode = "458",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MYR",
                        Note = "RM",
                        SortOrder = 14,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    443,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 443,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Qatari Riyl",
                        LookupCode = "634",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "QAR",
                        Note = "╪▒.┘é",
                        SortOrder = 15,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    444,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 444,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Kuwaiti Dinar",
                        LookupCode = "414",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KWD",
                        Note = "╪».┘â",
                        SortOrder = 16,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    445,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 445,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Bahraini Dinar",
                        LookupCode = "048",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BHD",
                        Note = ".╪».╪¿",
                        SortOrder = 17,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    446,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 446,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Rial Omani",
                        LookupCode = "512",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OMR",
                        Note = "╪▒.╪╣.",
                        SortOrder = 18,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    447,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 447,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Egyptian Pound",
                        LookupCode = "818",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EGP",
                        Note = "╪¼.┘à",
                        SortOrder = 19,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    448,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 448,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Turkish Lira",
                        LookupCode = "949",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TRY",
                        Note = "Γé║",
                        SortOrder = 20,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    449,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 449,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Rand",
                        LookupCode = "710",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ZAR",
                        Note = "R",
                        SortOrder = 21,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    450,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 450,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Naira",
                        LookupCode = "566",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NGN",
                        Note = "Γéª",
                        SortOrder = 22,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    451,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 451,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Kenyan Shilling",
                        LookupCode = "404",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KES",
                        Note = "KSh",
                        SortOrder = 23,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    452,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 452,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Pakistan Rupee",
                        LookupCode = "586",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PKR",
                        Note = "Γé¿",
                        SortOrder = 24,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    453,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 453,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Taka",
                        LookupCode = "050",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BDT",
                        Note = "αº│",
                        SortOrder = 25,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    454,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 454,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Sri Lanka Rupee",
                        LookupCode = "144",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LKR",
                        Note = "Rs",
                        SortOrder = 26,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    455,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 455,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Rupiah",
                        LookupCode = "360",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "IDR",
                        Note = "Rp",
                        SortOrder = 27,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    456,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 456,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Baht",
                        LookupCode = "764",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "THB",
                        Note = "α╕┐",
                        SortOrder = 28,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    457,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 457,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Philippine Peso",
                        LookupCode = "608",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PHP",
                        Note = "Γé▒",
                        SortOrder = 29,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    458,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 458,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Dong",
                        LookupCode = "704",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "VND",
                        Note = "Γé½",
                        SortOrder = 30,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    459,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 459,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Mexican Peso",
                        LookupCode = "484",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MXN",
                        Note = "MX$",
                        SortOrder = 31,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    460,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 460,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Brazilian Real",
                        LookupCode = "986",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BRL",
                        Note = "R$",
                        SortOrder = 32,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    461,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 461,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Russian Ruble",
                        LookupCode = "643",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RUB",
                        Note = "Γé╜",
                        SortOrder = 33,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    462,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 462,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Norwegian Krone",
                        LookupCode = "578",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NOK",
                        Note = "kr",
                        SortOrder = 34,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    463,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 463,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Swedish Krona",
                        LookupCode = "752",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SEK",
                        Note = "kr",
                        SortOrder = 35,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    464,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 464,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Danish Krone",
                        LookupCode = "208",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DKK",
                        Note = "kr",
                        SortOrder = 36,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    465,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 465,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "New Zealand Dollar",
                        LookupCode = "554",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NZD",
                        Note = "NZ$",
                        SortOrder = 37,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    466,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 466,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Forint",
                        LookupCode = "348",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HUF",
                        Note = "Ft",
                        SortOrder = 38,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    467,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 467,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Czech Koruna",
                        LookupCode = "203",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CZK",
                        Note = "K─ì",
                        SortOrder = 39,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    468,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 468,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Zloty",
                        LookupCode = "985",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PLN",
                        Note = "z┼é",
                        SortOrder = 40,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_DISPLAY_MODE
                {
                    469,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 469,
                        LookupTypeId = 49,
                        LookupType = "RD_GLOB_DISPLAY_MODE",
                        LookupValue = "Symbol",
                        LookupCode = "GLOB_CDM_SYMBOL",
                        LookupLevelValue = "DISPLAY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SYMBOL",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    470,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 470,
                        LookupTypeId = 49,
                        LookupType = "RD_GLOB_DISPLAY_MODE",
                        LookupValue = "ISO Code",
                        LookupCode = "GLOB_CDM_ISO",
                        LookupLevelValue = "DISPLAY_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "ISO_CODE",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_SYMBOL_PLACEMENT
                {
                    471,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 471,
                        LookupTypeId = 50,
                        LookupType = "RD_GLOB_SYMBOL_PLACEMENT",
                        LookupValue = "Prefix",
                        LookupCode = "GLOB_CSP_PREFIX",
                        LookupLevelValue = "SYMBOL_PLACEMENT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PREFIX",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    472,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 472,
                        LookupTypeId = 50,
                        LookupType = "RD_GLOB_SYMBOL_PLACEMENT",
                        LookupValue = "Suffix",
                        LookupCode = "GLOB_CSP_SUFFIX",
                        LookupLevelValue = "SYMBOL_PLACEMENT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SUFFIX",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_SYMBOL_SPACING
                {
                    473,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 473,
                        LookupTypeId = 51,
                        LookupType = "RD_GLOB_SYMBOL_SPACING",
                        LookupValue = "Space",
                        LookupCode = "GLOB_CSS_SPACE",
                        LookupLevelValue = "SYMBOL_SPACING",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SPACE",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    474,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 474,
                        LookupTypeId = 51,
                        LookupType = "RD_GLOB_SYMBOL_SPACING",
                        LookupValue = "No space",
                        LookupCode = "GLOB_CSS_NO_SPACE",
                        LookupLevelValue = "SYMBOL_SPACING",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NO_SPACE",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_THOUSAND_SEPARATOR
                {
                    475,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 475,
                        LookupTypeId = 52,
                        LookupType = "RD_GLOB_THOUSAND_SEPARATOR",
                        LookupValue = "Comma",
                        LookupCode = "GLOB_CTS_COMMA",
                        LookupLevelValue = "THOUSAND_SEPARATOR",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "COMMA",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    476,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 476,
                        LookupTypeId = 52,
                        LookupType = "RD_GLOB_THOUSAND_SEPARATOR",
                        LookupValue = "Dot",
                        LookupCode = "GLOB_CTS_DOT",
                        LookupLevelValue = "THOUSAND_SEPARATOR",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DOT",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    477,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 477,
                        LookupTypeId = 52,
                        LookupType = "RD_GLOB_THOUSAND_SEPARATOR",
                        LookupValue = "Space",
                        LookupCode = "GLOB_CTS_SPACE",
                        LookupLevelValue = "THOUSAND_SEPARATOR",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SPACE",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_DECIMAL_SEPARATOR
                {
                    478,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 478,
                        LookupTypeId = 53,
                        LookupType = "RD_GLOB_DECIMAL_SEPARATOR",
                        LookupValue = "Dot",
                        LookupCode = "GLOB_CDS_DOT",
                        LookupLevelValue = "DECIMAL_SEPARATOR",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "DOT",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    479,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 479,
                        LookupTypeId = 53,
                        LookupType = "RD_GLOB_DECIMAL_SEPARATOR",
                        LookupValue = "Comma",
                        LookupCode = "GLOB_CDS_COMMA",
                        LookupLevelValue = "DECIMAL_SEPARATOR",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COMMA",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_NEGATIVE_FORMAT
                {
                    480,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 480,
                        LookupTypeId = 54,
                        LookupType = "RD_GLOB_NEGATIVE_FORMAT",
                        LookupValue = "Parentheses",
                        LookupCode = "GLOB_CNF_PARENTHESES",
                        LookupLevelValue = "NEGATIVE_FORMAT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "PARENTHESES",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    481,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 481,
                        LookupTypeId = 54,
                        LookupType = "RD_GLOB_NEGATIVE_FORMAT",
                        LookupValue = "Minus",
                        LookupCode = "GLOB_CNF_MINUS",
                        LookupLevelValue = "NEGATIVE_FORMAT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MINUS",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_GLOB_ROUNDING_METHOD
                {
                    482,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 482,
                        LookupTypeId = 55,
                        LookupType = "RD_GLOB_ROUNDING_METHOD",
                        LookupValue = "Banker's",
                        LookupCode = "GLOB_CRM_BANKERS",
                        LookupLevelValue = "ROUNDING_METHOD",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "BANKERS",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    483,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 483,
                        LookupTypeId = 55,
                        LookupType = "RD_GLOB_ROUNDING_METHOD",
                        LookupValue = "Round half up",
                        LookupCode = "GLOB_CRM_HALF_UP",
                        LookupLevelValue = "ROUNDING_METHOD",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ROUND_HALF_UP",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    484,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 484,
                        LookupTypeId = 55,
                        LookupType = "RD_GLOB_ROUNDING_METHOD",
                        LookupValue = "Round half down",
                        LookupCode = "GLOB_CRM_HALF_DOWN",
                        LookupLevelValue = "ROUNDING_METHOD",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ROUND_HALF_DOWN",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_CURRENCY_RATE_TYPE
                {
                    485,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 485,
                        LookupTypeId = 56,
                        LookupType = "RD_EDM_CURRENCY_RATE_TYPE",
                        LookupValue = "Spot Rate",
                        LookupCode = "RD_EDM_CRT_SPOT",
                        LookupLevelValue = "CURRENCY_RATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "SPOT",
                        Note = "Daily spot conversion rate",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    486,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 486,
                        LookupTypeId = 56,
                        LookupType = "RD_EDM_CURRENCY_RATE_TYPE",
                        LookupValue = "Closing Rate",
                        LookupCode = "RD_EDM_CRT_CLOSING",
                        LookupLevelValue = "CURRENCY_RATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CLOSING",
                        Note = "Period-end closing conversion rate",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    487,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 487,
                        LookupTypeId = 56,
                        LookupType = "RD_EDM_CURRENCY_RATE_TYPE",
                        LookupValue = "Average Rate",
                        LookupCode = "RD_EDM_CRT_AVERAGE",
                        LookupLevelValue = "CURRENCY_RATE_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AVERAGE",
                        Note = "Period average conversion rate",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_CURRENCY_RATE_SOURCE
                {
                    488,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 488,
                        LookupTypeId = 57,
                        LookupType = "RD_EDM_CURRENCY_RATE_SOURCE",
                        LookupValue = "Manual",
                        LookupCode = "RD_EDM_CRS_MANUAL",
                        LookupLevelValue = "CURRENCY_RATE_SOURCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MANUAL",
                        Note = "Manually entered conversion rate",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    489,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 489,
                        LookupTypeId = 57,
                        LookupType = "RD_EDM_CURRENCY_RATE_SOURCE",
                        LookupValue = "Central Bank",
                        LookupCode = "RD_EDM_CRS_CENTRAL_BANK",
                        LookupLevelValue = "CURRENCY_RATE_SOURCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CB",
                        Note = "Rate sourced from the central bank",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    490,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 490,
                        LookupTypeId = 57,
                        LookupType = "RD_EDM_CURRENCY_RATE_SOURCE",
                        LookupValue = "Bank Feed",
                        LookupCode = "RD_EDM_CRS_BANK_FEED",
                        LookupLevelValue = "CURRENCY_RATE_SOURCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FEED",
                        Note = "Rate sourced from a bank feed",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //EDM Tax Setup
            #region RD_EDM_TAX_TYPE
                {
                    491,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 491,
                        LookupTypeId = 58,
                        LookupType = "RD_EDM_TAX_TYPE",
                        LookupValue = "VAT",
                        LookupCode = "RD_EDM_TT_VAT",
                        LookupLevelValue = "TAX_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "VAT",
                        Note = "Value added tax",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    492,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 492,
                        LookupTypeId = 58,
                        LookupType = "RD_EDM_TAX_TYPE",
                        LookupValue = "WHT",
                        LookupCode = "RD_EDM_TT_WHT",
                        LookupLevelValue = "TAX_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "WHT",
                        Note = "Withholding tax",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    493,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 493,
                        LookupTypeId = 58,
                        LookupType = "RD_EDM_TAX_TYPE",
                        LookupValue = "Excise Tax",
                        LookupCode = "RD_EDM_TT_EXCISE",
                        LookupLevelValue = "TAX_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EXCISE",
                        Note = "Excise tax",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    494,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 494,
                        LookupTypeId = 58,
                        LookupType = "RD_EDM_TAX_TYPE",
                        LookupValue = "Corporate Tax",
                        LookupCode = "RD_EDM_TT_CORPORATE",
                        LookupLevelValue = "TAX_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CORP",
                        Note = "Corporate tax",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    495,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 495,
                        LookupTypeId = 58,
                        LookupType = "RD_EDM_TAX_TYPE",
                        LookupValue = "Contribution",
                        LookupCode = "RD_EDM_TT_CONTRIBUTION",
                        LookupLevelValue = "TAX_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CONTRIB",
                        Note = "Contribution",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_TAX_FILING_CADENCE
                {
                    496,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 496,
                        LookupTypeId = 59,
                        LookupType = "RD_EDM_TAX_FILING_CADENCE",
                        LookupValue = "Monthly",
                        LookupCode = "RD_EDM_TFC_MONTHLY",
                        LookupLevelValue = "TAX_FILING_CADENCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "MONTHLY",
                        Note = "Returns filed every month",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    497,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 497,
                        LookupTypeId = 59,
                        LookupType = "RD_EDM_TAX_FILING_CADENCE",
                        LookupValue = "Quarterly",
                        LookupCode = "RD_EDM_TFC_QUARTERLY",
                        LookupLevelValue = "TAX_FILING_CADENCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "QUARTERLY",
                        Note = "Returns filed every quarter",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    498,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 498,
                        LookupTypeId = 59,
                        LookupType = "RD_EDM_TAX_FILING_CADENCE",
                        LookupValue = "Bi-Annually",
                        LookupCode = "RD_EDM_TFC_BI_ANNUALLY",
                        LookupLevelValue = "TAX_FILING_CADENCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BIANNUAL",
                        Note = "Returns filed twice a year",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    499,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 499,
                        LookupTypeId = 59,
                        LookupType = "RD_EDM_TAX_FILING_CADENCE",
                        LookupValue = "Annually",
                        LookupCode = "RD_EDM_TFC_ANNUALLY",
                        LookupLevelValue = "TAX_FILING_CADENCE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ANNUAL",
                        Note = "Returns filed once a year",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SDM TASK STATUSES
            #region RD_SDM_TASK_STATUSES

                {
                    500,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 500,
                        LookupTypeId = 60,
                        LookupType = "RD_SDM_TASK_STATUSES",
                        LookupValue = "Open",
                        LookupCode = "TS-001",
                        LookupLevelValue = "Task Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = null,
                        Note = "Initial task status when a task is created.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "OPEN",
                        Color = "#3B82F6",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    501,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 501,
                        LookupTypeId = 60,
                        LookupType = "RD_SDM_TASK_STATUSES",
                        LookupValue = "In Progress",
                        LookupCode = "TS-002",
                        LookupLevelValue = "Task Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Indicates the task is actively being worked on.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "IN_PROGRESS",
                        Color = "#F59E0B",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    502,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 502,
                        LookupTypeId = 60,
                        LookupType = "RD_SDM_TASK_STATUSES",
                        LookupValue = "Completed",
                        LookupCode = "TS-003",
                        LookupLevelValue = "Task Status",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = null,
                        Note = "Indicates the task has been finished.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "COMPLETED",
                        Color = "#10B981",
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //SUPPLIER CONTACT TYPE
            #region RD_SCM_CONTACT_TYPE
                {
                    503,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 503,
                        LookupTypeId = 61,
                        LookupType = "RD_SCM_CONTACT_TYPE",
                        LookupValue = "Primary Contact",
                        LookupCode = "CT-001",
                        LookupLevelValue = "CONTACT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "CT-001",
                        Note = "Contact Type: Primary Contact",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    504,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 504,
                        LookupTypeId = 61,
                        LookupType = "RD_SCM_CONTACT_TYPE",
                        LookupValue = "Billing Contact",
                        LookupCode = "CT-002",
                        LookupLevelValue = "CONTACT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CT-002",
                        Note = "Contact Type: Billing Contact",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    505,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 505,
                        LookupTypeId = 61,
                        LookupType = "RD_SCM_CONTACT_TYPE",
                        LookupValue = "Technical Contact",
                        LookupCode = "CT-003",
                        LookupLevelValue = "CONTACT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CT-003",
                        Note = "Contact Type: Technical Contact",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    506,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 506,
                        LookupTypeId = 61,
                        LookupType = "RD_SCM_CONTACT_TYPE",
                        LookupValue = "Sales Contact",
                        LookupCode = "CT-004",
                        LookupLevelValue = "CONTACT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CT-004",
                        Note = "Contact Type: Sales Contact",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    507,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 507,
                        LookupTypeId = 61,
                        LookupType = "RD_SCM_CONTACT_TYPE",
                        LookupValue = "Procurement Contact",
                        LookupCode = "CT-005",
                        LookupLevelValue = "CONTACT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CT-005",
                        Note = "Contact Type: Procurement Contact",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //EDM Tax Categories & Rates
            #region RD_EDM_TAX_CATEGORY
                {
                    508,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 508,
                        LookupTypeId = 62,
                        LookupType = "RD_EDM_TAX_CATEGORY",
                        LookupValue = "Standard-rated",
                        LookupCode = "RD_EDM_TC_STD",
                        LookupLevelValue = "TAX_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "STD",
                        Note = "Standard-rated",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    509,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 509,
                        LookupTypeId = 62,
                        LookupType = "RD_EDM_TAX_CATEGORY",
                        LookupValue = "Zero-rated",
                        LookupCode = "RD_EDM_TC_ZR",
                        LookupLevelValue = "TAX_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ZR",
                        Note = "Zero-rated",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    510,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 510,
                        LookupTypeId = 62,
                        LookupType = "RD_EDM_TAX_CATEGORY",
                        LookupValue = "Exempt",
                        LookupCode = "RD_EDM_TC_EX",
                        LookupLevelValue = "TAX_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EX",
                        Note = "Exempt",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    511,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 511,
                        LookupTypeId = 62,
                        LookupType = "RD_EDM_TAX_CATEGORY",
                        LookupValue = "Out of scope",
                        LookupCode = "RD_EDM_TC_OOS",
                        LookupLevelValue = "TAX_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OOS",
                        Note = "Out of scope",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    512,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 512,
                        LookupTypeId = 62,
                        LookupType = "RD_EDM_TAX_CATEGORY",
                        LookupValue = "Reverse-charge",
                        LookupCode = "RD_EDM_TC_RCM",
                        LookupLevelValue = "TAX_CATEGORY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RCM",
                        Note = "Reverse-charge",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_COA_ROW_TYPE
                {
                    513,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 513,
                        LookupTypeId = 63,
                        LookupType = "RD_FSC_COA_ROW_TYPE",
                        LookupValue = "Header",
                        LookupCode = "FSC_CRT_HEADER",
                        LookupLevelValue = "FSC_COA_ROW_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "HEADER",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    514,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 514,
                        LookupTypeId = 63,
                        LookupType = "RD_FSC_COA_ROW_TYPE",
                        LookupValue = "Sub Category",
                        LookupCode = "FSC_CRT_SUB_CATEGORY",
                        LookupLevelValue = "FSC_COA_ROW_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SUB_CATEGORY",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    515,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 515,
                        LookupTypeId = 63,
                        LookupType = "RD_FSC_COA_ROW_TYPE",
                        LookupValue = "Group Total",
                        LookupCode = "FSC_CRT_GROUP_TOTAL",
                        LookupLevelValue = "FSC_COA_ROW_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GROUP_TOTAL",
                        Note = null,
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_CONTROL_ACCOUNT
                {
                    516,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 516,
                        LookupTypeId = 64,
                        LookupType = "RD_FSC_CONTROL_ACCOUNT",
                        LookupValue = "Income",
                        LookupCode = "FSC_CA_INCOME",
                        LookupLevelValue = "FSC_CONTROL_ACCOUNT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "INCOME",
                        Note = null,
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    517,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 517,
                        LookupTypeId = 64,
                        LookupType = "RD_FSC_CONTROL_ACCOUNT",
                        LookupValue = "Expense",
                        LookupCode = "FSC_CA_EXPENSE",
                        LookupLevelValue = "FSC_CONTROL_ACCOUNT",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EXPENSE",
                        Note = null,
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_FSC_COA_SEED_HEADER
                {
                    518,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 518,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Assets",
                        LookupCode = "FSC_SH_BS_ASSETS",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ASSETS",
                        Note = "BS",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    519,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 519,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Liabilities",
                        LookupCode = "FSC_SH_BS_LIABILITIES",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LIABILITIES",
                        Note = "BS",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    520,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 520,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Equity",
                        LookupCode = "FSC_SH_BS_EQUITY",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EQUITY",
                        Note = "BS",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    521,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 521,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Revenue",
                        LookupCode = "FSC_SH_PL_REVENUE",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "REVENUE",
                        Note = "PL",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    522,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 522,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Expenses",
                        LookupCode = "FSC_SH_PL_EXPENSES",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "EXPENSES",
                        Note = "PL",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    523,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 523,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Operating Activities",
                        LookupCode = "FSC_SH_CF_OPERATING",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OPERATING",
                        Note = "CF",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    524,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 524,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Investing Activities",
                        LookupCode = "FSC_SH_CF_INVESTING",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "INVESTING",
                        Note = "CF",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    525,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 525,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Financing Activities",
                        LookupCode = "FSC_SH_CF_FINANCING",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FINANCING",
                        Note = "CF",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    526,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 526,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Opening Balance",
                        LookupCode = "FSC_SH_CE_OPENING",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "OPENING",
                        Note = "CE",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    527,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 527,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Movements",
                        LookupCode = "FSC_SH_CE_MOVEMENTS",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MOVEMENTS",
                        Note = "CE",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    528,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 528,
                        LookupTypeId = 65,
                        LookupType = "RD_FSC_COA_SEED_HEADER",
                        LookupValue = "Closing Balance",
                        LookupCode = "FSC_SH_CE_CLOSING",
                        LookupLevelValue = "FSC_COA_SEED_HEADER",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CLOSING",
                        Note = "CE",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_SDM_MODULES

                {
                    529,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 529,
                        LookupTypeId = 66,
                        LookupType = "RD_SDM_MODULES",
                        LookupValue = "ERP",
                        LookupCode = "MOD-001",
                        LookupLevelValue = "Module",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ERP",
                        Note = "ERP module reference used within SDM.",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    530,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 530,
                        LookupTypeId = 66,
                        LookupType = "RD_SDM_MODULES",
                        LookupValue = "HRMS",
                        LookupCode = "MOD-002",
                        LookupLevelValue = "Module",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HRMS",
                        Note = "HRMS module reference used within SDM.",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    531,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 531,
                        LookupTypeId = 66,
                        LookupType = "RD_SDM_MODULES",
                        LookupValue = "PropRP",
                        LookupCode = "MOD-003",
                        LookupLevelValue = "Module",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PROPRP",
                        Note = "PropRP module reference used within SDM.",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    532,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 532,
                        LookupTypeId = 66,
                        LookupType = "RD_SDM_MODULES",
                        LookupValue = "QHSE",
                        LookupCode = "MOD-004",
                        LookupLevelValue = "Module",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "QHSE",
                        Note = "QHSE module reference used within SDM.",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    533,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 533,
                        LookupTypeId = 66,
                        LookupType = "RD_SDM_MODULES",
                        LookupValue = "PMO",
                        LookupCode = "MOD-005",
                        LookupLevelValue = "Module",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PMO",
                        Note = "PMO module reference used within SDM.",
                        SortOrder = 5,
                        SharedScope = 0,
                        LookupCodeType = null,
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_TAX_CALCULATION_METHOD
                {
                    534,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 534,
                        LookupTypeId = 67,
                        LookupType = "RD_EDM_TAX_CALCULATION_METHOD",
                        LookupValue = "Net amount",
                        LookupCode = "RD_EDM_TCM_NET_AMOUNT",
                        LookupLevelValue = "TAX_CALCULATION_METHOD",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "NET_AMOUNT",
                        Note = "Rate applied to the line value net of tax",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    535,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 535,
                        LookupTypeId = 67,
                        LookupType = "RD_EDM_TAX_CALCULATION_METHOD",
                        LookupValue = "Gross Amount",
                        LookupCode = "RD_EDM_TCM_GROSS_AMOUNT",
                        LookupLevelValue = "TAX_CALCULATION_METHOD",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GROSS_AMOUNT",
                        Note = "Rate applied to the line gross value",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_EDM_TAX_ROUNDING
                {
                    536,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 536,
                        LookupTypeId = 68,
                        LookupType = "RD_EDM_TAX_ROUNDING",
                        LookupValue = "No Rounding",
                        LookupCode = "RD_EDM_TR_NO_ROUNDING",
                        LookupLevelValue = "TAX_ROUNDING",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "NO_ROUNDING",
                        Note = "No Rounding",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    537,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 537,
                        LookupTypeId = 68,
                        LookupType = "RD_EDM_TAX_ROUNDING",
                        LookupValue = "Half Up, Perline",
                        LookupCode = "RD_EDM_TR_HALF_UP_PERLINE",
                        LookupLevelValue = "TAX_ROUNDING",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HALF_UP_PERLINE",
                        Note = "Half Up, Perline",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    538,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 538,
                        LookupTypeId = 68,
                        LookupType = "RD_EDM_TAX_ROUNDING",
                        LookupValue = "Half Down, Perline",
                        LookupCode = "RD_EDM_TR_HALF_DOWN_PERLINE",
                        LookupLevelValue = "TAX_ROUNDING",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HALF_DOWN_PERLINE",
                        Note = "Half Down, Perline",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            #region RD_PRM_PO_TYPE
                {
                    539,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 539,
                        LookupTypeId = 69,
                        LookupType = "RD_PRM_PO_TYPE",
                        LookupValue = "Direct PO",
                        LookupCode = "RD_PRM_PO_TYPE_DIRECT",
                        LookupLevelValue = "PO_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "DIRECT",
                        Note = "Direct PO",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    540,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 540,
                        LookupTypeId = 69,
                        LookupType = "RD_PRM_PO_TYPE",
                        LookupValue = "From Request PO",
                        LookupCode = "RD_PRM_PO_TYPE_FROM_REQUEST",
                        LookupLevelValue = "PO_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FROM_REQUEST",
                        Note = "From Request PO",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //ACCOUNTS PAYABLE - PAYMENT TYPE
            #region ACCOUNTS PAYABLE PAYMENT TYPE
                {
                    541,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 541,
                        LookupTypeId = 70,
                        LookupType = "RD_APY_PAYMENT_TYPE",
                        LookupValue = "Supplier Direct Invoice",
                        LookupCode = "APY_PT_SUPPLIER_DIRECT_INVOICE",
                        LookupLevelValue = "PAYMENT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APY-PT-001",
                        Note = "Supplier Direct Invoice",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    542,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 542,
                        LookupTypeId = 70,
                        LookupType = "RD_APY_PAYMENT_TYPE",
                        LookupValue = "Supplier PO Invoice",
                        LookupCode = "APY_PT_SUPPLIER_PO_INVOICE",
                        LookupLevelValue = "PAYMENT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PT-002",
                        Note = "Supplier PO Invoice",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    543,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 543,
                        LookupTypeId = 70,
                        LookupType = "RD_APY_PAYMENT_TYPE",
                        LookupValue = "Direct GRV Invoice",
                        LookupCode = "APY_PT_DIRECT_GRV_INVOICE",
                        LookupLevelValue = "PAYMENT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PT-003",
                        Note = "Direct GRV Invoice",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    544,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 544,
                        LookupTypeId = 70,
                        LookupType = "RD_APY_PAYMENT_TYPE",
                        LookupValue = "Employee Direct Invoice",
                        LookupCode = "APY_PT_EMPLOYEE_DIRECT_INVOICE",
                        LookupLevelValue = "PAYMENT_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PT-004",
                        Note = "Employee Direct Invoice",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //ACCOUNTS PAYABLE - PAYMENT MODE
            #region ACCOUNTS PAYABLE PAYMENT MODE
                {
                    545,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 545,
                        LookupTypeId = 71,
                        LookupType = "RD_APY_PAYMENT_MODE",
                        LookupValue = "Cash",
                        LookupCode = "APY_PM_CASH",
                        LookupLevelValue = "PAYMENT_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "APY-PM-001",
                        Note = "Cash",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    546,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 546,
                        LookupTypeId = 71,
                        LookupType = "RD_APY_PAYMENT_MODE",
                        LookupValue = "Cheque",
                        LookupCode = "APY_PM_CHEQUE",
                        LookupLevelValue = "PAYMENT_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PM-002",
                        Note = "Cheque",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    547,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 547,
                        LookupTypeId = 71,
                        LookupType = "RD_APY_PAYMENT_MODE",
                        LookupValue = "Bank Transfer",
                        LookupCode = "APY_PM_BANK_TRANSFER",
                        LookupLevelValue = "PAYMENT_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PM-003",
                        Note = "Bank Transfer",
                        SortOrder = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    548,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 548,
                        LookupTypeId = 71,
                        LookupType = "RD_APY_PAYMENT_MODE",
                        LookupValue = "Online",
                        LookupCode = "APY_PM_ONLINE",
                        LookupLevelValue = "PAYMENT_MODE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "APY-PM-004",
                        Note = "Online",
                        SortOrder = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion

            //Inventory Management Goods Receipt Voucher
            #region RD_IVM_GOODS_RECEIPT_VOUCHER_TYPE
                {
                    549,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 549,
                        LookupTypeId = 72,
                        LookupType = "RD_IVM_GOODS_RECEIPT_VOUCHER_TYPE",
                        LookupValue = "Direct GRV",
                        LookupCode = "RD_IVM_GRV_TYPE_DIRECT",
                        LookupLevelValue = "GOODS_RECEIPT_VOUCHER_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = true,
                        ShortCode = "DIRECT",
                        Note = "Direct Goods Receipt Voucher, created without a Purchase Order",
                        SortOrder = 1,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    550,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 550,
                        LookupTypeId = 72,
                        LookupType = "RD_IVM_GOODS_RECEIPT_VOUCHER_TYPE",
                        LookupValue = "PO GRV",
                        LookupCode = "RD_IVM_GRV_TYPE_PO",
                        LookupLevelValue = "GOODS_RECEIPT_VOUCHER_TYPE",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PO",
                        Note = "Goods Receipt Voucher created against a Purchase Order",
                        SortOrder = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion
            
            //RD_FSC_ISO_CURRENCY_SET_2
            #region RD_FSC_ISO_CURRENCY_SET_2
            {
                    5001,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5001,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Afghani",
                        LookupCode = "971",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AFN",
                        Note = "╪ï",
                        SortOrder = 41,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5002,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5002,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lek",
                        LookupCode = "008",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ALL",
                        Note = "L",
                        SortOrder = 42,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5003,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5003,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Armenian Dram",
                        LookupCode = "051",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AMD",
                        Note = "╓Å",
                        SortOrder = 43,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5004,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5004,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Kwanza",
                        LookupCode = "973",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AOA",
                        Note = "AOA",
                        SortOrder = 44,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5005,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5005,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Argentine Peso",
                        LookupCode = "032",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ARS",
                        Note = "ARS",
                        SortOrder = 45,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5006,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5006,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Aruban Florin",
                        LookupCode = "533",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AWG",
                        Note = "╞Æ",
                        SortOrder = 46,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5007,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5007,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Azerbaijan Manat",
                        LookupCode = "944",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "AZN",
                        Note = "Γé╝",
                        SortOrder = 47,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5008,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5008,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Convertible Mark",
                        LookupCode = "977",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BAM",
                        Note = "BAM",
                        SortOrder = 48,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5009,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5009,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Barbados Dollar",
                        LookupCode = "052",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BBD",
                        Note = "BBD",
                        SortOrder = 49,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5010,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5010,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Burundi Franc",
                        LookupCode = "108",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BIF",
                        Note = "BIF",
                        SortOrder = 50,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5011,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5011,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Bermudian Dollar",
                        LookupCode = "060",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BMD",
                        Note = "BMD",
                        SortOrder = 51,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5012,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5012,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Brunei Dollar",
                        LookupCode = "096",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BND",
                        Note = "BND",
                        SortOrder = 52,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5013,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5013,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Boliviano",
                        LookupCode = "068",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BOB",
                        Note = "Bs",
                        SortOrder = 53,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5014,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5014,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Mvdol",
                        LookupCode = "984",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BOV",
                        Note = "BOV",
                        SortOrder = 54,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5015,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5015,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Bahamian Dollar",
                        LookupCode = "044",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BSD",
                        Note = "BSD",
                        SortOrder = 55,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5016,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5016,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Ngultrum",
                        LookupCode = "064",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BTN",
                        Note = "BTN",
                        SortOrder = 56,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5017,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5017,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Pula",
                        LookupCode = "072",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BWP",
                        Note = "P",
                        SortOrder = 57,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5018,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5018,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Belarusian Ruble",
                        LookupCode = "933",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BYN",
                        Note = "BYN",
                        SortOrder = 58,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5019,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5019,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Belize Dollar",
                        LookupCode = "084",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "BZD",
                        Note = "BZ$",
                        SortOrder = 59,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5020,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5020,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Congolese Franc",
                        LookupCode = "976",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CDF",
                        Note = "CDF",
                        SortOrder = 60,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5021,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5021,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "WIR Euro",
                        LookupCode = "947",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CHE",
                        Note = "CHE",
                        SortOrder = 61,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5022,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5022,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "WIR Franc",
                        LookupCode = "948",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CHW",
                        Note = "CHW",
                        SortOrder = 62,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5023,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5023,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Unidad de Fomento",
                        LookupCode = "990",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CLF",
                        Note = "CLF",
                        SortOrder = 63,
                        Index = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5024,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5024,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Chilean Peso",
                        LookupCode = "152",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CLP",
                        Note = "CLP",
                        SortOrder = 64,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5025,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5025,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Colombian Peso",
                        LookupCode = "170",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COP",
                        Note = "COP",
                        SortOrder = 65,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5026,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5026,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Unidad de Valor Real",
                        LookupCode = "970",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "COU",
                        Note = "COU",
                        SortOrder = 66,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5027,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5027,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Costa Rican Colon",
                        LookupCode = "188",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CRC",
                        Note = "Γéí",
                        SortOrder = 67,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5028,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5028,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Cuban Peso",
                        LookupCode = "192",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CUP",
                        Note = "CUP",
                        SortOrder = 68,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5029,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5029,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Cabo Verde Escudo",
                        LookupCode = "132",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "CVE",
                        Note = "CVE",
                        SortOrder = 69,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5030,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5030,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Djibouti Franc",
                        LookupCode = "262",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DJF",
                        Note = "DJF",
                        SortOrder = 70,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5031,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5031,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Dominican Peso",
                        LookupCode = "214",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DOP",
                        Note = "RD$",
                        SortOrder = 71,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5032,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5032,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Algerian Dinar",
                        LookupCode = "012",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "DZD",
                        Note = "╪».╪¼",
                        SortOrder = 72,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5033,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5033,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Nakfa",
                        LookupCode = "232",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ERN",
                        Note = "ERN",
                        SortOrder = 73,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5034,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5034,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Ethiopian Birr",
                        LookupCode = "230",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ETB",
                        Note = "Br",
                        SortOrder = 74,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5035,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5035,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Fiji Dollar",
                        LookupCode = "242",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FJD",
                        Note = "FJ$",
                        SortOrder = 75,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5036,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5036,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Falkland Islands Pound",
                        LookupCode = "238",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "FKP",
                        Note = "FKP",
                        SortOrder = 76,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5037,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5037,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lari",
                        LookupCode = "981",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GEL",
                        Note = "Γé╛",
                        SortOrder = 77,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5038,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5038,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Ghana Cedi",
                        LookupCode = "936",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GHS",
                        Note = "Γé╡",
                        SortOrder = 78,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5039,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5039,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Gibraltar Pound",
                        LookupCode = "292",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GIP",
                        Note = "GIP",
                        SortOrder = 79,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5040,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5040,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Dalasi",
                        LookupCode = "270",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GMD",
                        Note = "GMD",
                        SortOrder = 80,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5041,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5041,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Guinean Franc",
                        LookupCode = "324",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GNF",
                        Note = "GNF",
                        SortOrder = 81,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5042,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5042,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Quetzal",
                        LookupCode = "320",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GTQ",
                        Note = "Q",
                        SortOrder = 82,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5043,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5043,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Guyana Dollar",
                        LookupCode = "328",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "GYD",
                        Note = "GYD",
                        SortOrder = 83,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5044,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5044,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lempira",
                        LookupCode = "340",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HNL",
                        Note = "L",
                        SortOrder = 84,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5045,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5045,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Gourde",
                        LookupCode = "332",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "HTG",
                        Note = "HTG",
                        SortOrder = 85,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5046,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5046,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "New Israeli Sheqel",
                        LookupCode = "376",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ILS",
                        Note = "Γé¬",
                        SortOrder = 86,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5047,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5047,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Iraqi Dinar",
                        LookupCode = "368",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "IQD",
                        Note = "╪╣.╪»",
                        SortOrder = 87,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5048,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5048,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Iranian Rial",
                        LookupCode = "364",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "IRR",
                        Note = "∩╖╝",
                        SortOrder = 88,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5049,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5049,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Iceland Krona",
                        LookupCode = "352",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ISK",
                        Note = "kr",
                        SortOrder = 89,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5050,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5050,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Jamaican Dollar",
                        LookupCode = "388",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "JMD",
                        Note = "J$",
                        SortOrder = 90,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5051,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5051,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Jordanian Dinar",
                        LookupCode = "400",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "JOD",
                        Note = "╪».╪º",
                        SortOrder = 91,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5052,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5052,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Som",
                        LookupCode = "417",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KGS",
                        Note = "KGS",
                        SortOrder = 92,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5053,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5053,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Riel",
                        LookupCode = "116",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KHR",
                        Note = "ßƒ¢",
                        SortOrder = 93,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5054,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5054,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Comorian Franc",
                        LookupCode = "174",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KMF",
                        Note = "KMF",
                        SortOrder = 94,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5055,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5055,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "North Korean Won",
                        LookupCode = "408",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KPW",
                        Note = "KPW",
                        SortOrder = 95,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5056,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5056,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Won",
                        LookupCode = "410",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KRW",
                        Note = "Γé⌐",
                        SortOrder = 96,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5057,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5057,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Cayman Islands Dollar",
                        LookupCode = "136",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KYD",
                        Note = "KYD",
                        SortOrder = 97,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5058,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5058,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Tenge",
                        LookupCode = "398",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "KZT",
                        Note = "Γé╕",
                        SortOrder = 98,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5059,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5059,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lao Kip",
                        LookupCode = "418",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LAK",
                        Note = "Γé¡",
                        SortOrder = 99,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5060,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5060,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lebanese Pound",
                        LookupCode = "422",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LBP",
                        Note = "┘ä.┘ä",
                        SortOrder = 100,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5061,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5061,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Liberian Dollar",
                        LookupCode = "430",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LRD",
                        Note = "LRD",
                        SortOrder = 101,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5062,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5062,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Loti",
                        LookupCode = "426",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LSL",
                        Note = "LSL",
                        SortOrder = 102,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5063,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5063,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Libyan Dinar",
                        LookupCode = "434",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "LYD",
                        Note = "┘ä.╪»",
                        SortOrder = 103,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5064,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5064,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Moroccan Dirham",
                        LookupCode = "504",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MAD",
                        Note = "╪».┘à.",
                        SortOrder = 104,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5065,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5065,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Moldovan Leu",
                        LookupCode = "498",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MDL",
                        Note = "MDL",
                        SortOrder = 105,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5066,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5066,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Malagasy Ariary",
                        LookupCode = "969",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MGA",
                        Note = "MGA",
                        SortOrder = 106,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5067,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5067,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Denar",
                        LookupCode = "807",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MKD",
                        Note = "╨┤╨╡╨╜",
                        SortOrder = 107,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5068,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5068,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Kyat",
                        LookupCode = "104",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MMK",
                        Note = "MMK",
                        SortOrder = 108,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5069,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5069,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Tugrik",
                        LookupCode = "496",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MNT",
                        Note = "Γé«",
                        SortOrder = 109,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5070,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5070,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Pataca",
                        LookupCode = "446",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MOP",
                        Note = "MOP",
                        SortOrder = 110,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5071,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5071,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Ouguiya",
                        LookupCode = "929",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MRU",
                        Note = "MRU",
                        SortOrder = 111,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5072,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5072,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Mauritius Rupee",
                        LookupCode = "480",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MUR",
                        Note = "Γé¿",
                        SortOrder = 112,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5073,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5073,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Rufiyaa",
                        LookupCode = "462",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MVR",
                        Note = "MVR",
                        SortOrder = 113,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5074,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5074,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Malawi Kwacha",
                        LookupCode = "454",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MWK",
                        Note = "MK",
                        SortOrder = 114,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5075,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5075,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Mexican Unidad de Inversion (UDI)",
                        LookupCode = "979",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MXV",
                        Note = "MXV",
                        SortOrder = 115,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5076,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5076,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Mozambique Metical",
                        LookupCode = "943",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "MZN",
                        Note = "MT",
                        SortOrder = 116,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5077,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5077,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Namibia Dollar",
                        LookupCode = "516",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NAD",
                        Note = "N$",
                        SortOrder = 117,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5078,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5078,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Cordoba Oro",
                        LookupCode = "558",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NIO",
                        Note = "C$",
                        SortOrder = 118,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5079,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5079,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Nepalese Rupee",
                        LookupCode = "524",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "NPR",
                        Note = "Rs",
                        SortOrder = 119,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5080,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5080,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Balboa",
                        LookupCode = "590",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PAB",
                        Note = "B/.",
                        SortOrder = 120,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5081,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5081,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Sol",
                        LookupCode = "604",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PEN",
                        Note = "S/",
                        SortOrder = 121,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5082,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5082,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Kina",
                        LookupCode = "598",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PGK",
                        Note = "K",
                        SortOrder = 122,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5083,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5083,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Guarani",
                        LookupCode = "600",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "PYG",
                        Note = "Γé▓",
                        SortOrder = 123,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5084,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5084,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Romanian Leu",
                        LookupCode = "946",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RON",
                        Note = "lei",
                        SortOrder = 124,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5085,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5085,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Serbian Dinar",
                        LookupCode = "941",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RSD",
                        Note = "╨┤╨╕╨╜.",
                        SortOrder = 125,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5086,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5086,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Rwanda Franc",
                        LookupCode = "646",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "RWF",
                        Note = "RWF",
                        SortOrder = 126,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5087,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5087,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Solomon Islands Dollar",
                        LookupCode = "090",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SBD",
                        Note = "SI$",
                        SortOrder = 127,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5088,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5088,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Seychelles Rupee",
                        LookupCode = "690",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SCR",
                        Note = "SCR",
                        SortOrder = 128,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5089,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5089,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Sudanese Pound",
                        LookupCode = "938",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SDG",
                        Note = "╪¼.╪│",
                        SortOrder = 129,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5090,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5090,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Saint Helena Pound",
                        LookupCode = "654",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SHP",
                        Note = "SHP",
                        SortOrder = 130,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5091,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5091,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Leone",
                        LookupCode = "925",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SLE",
                        Note = "SLE",
                        SortOrder = 131,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5092,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5092,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Somali Shilling",
                        LookupCode = "706",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SOS",
                        Note = "SOS",
                        SortOrder = 132,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5093,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5093,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Surinam Dollar",
                        LookupCode = "968",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SRD",
                        Note = "SRD",
                        SortOrder = 133,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5094,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5094,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "South Sudanese Pound",
                        LookupCode = "728",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SSP",
                        Note = "SSP",
                        SortOrder = 134,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5095,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5095,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Dobra",
                        LookupCode = "930",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "STN",
                        Note = "STN",
                        SortOrder = 135,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5096,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5096,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "El Salvador Colon",
                        LookupCode = "222",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SVC",
                        Note = "SVC",
                        SortOrder = 136,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5097,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5097,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Syrian Pound",
                        LookupCode = "760",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SYP",
                        Note = "┘ä.╪│",
                        SortOrder = 137,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5098,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5098,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Lilangeni",
                        LookupCode = "748",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "SZL",
                        Note = "SZL",
                        SortOrder = 138,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5099,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5099,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Somoni",
                        LookupCode = "972",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TJS",
                        Note = "TJS",
                        SortOrder = 139,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5100,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5100,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Turkmenistan New Manat",
                        LookupCode = "934",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TMT",
                        Note = "TMT",
                        SortOrder = 140,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5101,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5101,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Tunisian Dinar",
                        LookupCode = "788",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TND",
                        Note = "╪».╪¬",
                        SortOrder = 141,
                        Index = 3,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5102,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5102,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "PaΓÇÖanga",
                        LookupCode = "776",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TOP",
                        Note = "T$",
                        SortOrder = 142,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5103,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5103,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Trinidad and Tobago Dollar",
                        LookupCode = "780",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TTD",
                        Note = "TT$",
                        SortOrder = 143,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5104,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5104,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "New Taiwan Dollar",
                        LookupCode = "901",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TWD",
                        Note = "NT$",
                        SortOrder = 144,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5105,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5105,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Tanzanian Shilling",
                        LookupCode = "834",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "TZS",
                        Note = "TSh",
                        SortOrder = 145,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5106,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5106,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Hryvnia",
                        LookupCode = "980",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UAH",
                        Note = "Γé┤",
                        SortOrder = 146,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5107,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5107,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Uganda Shilling",
                        LookupCode = "800",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UGX",
                        Note = "USh",
                        SortOrder = 147,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5108,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5108,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "US Dollar (Next day)",
                        LookupCode = "997",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "USN",
                        Note = "USN",
                        SortOrder = 148,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5109,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5109,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Uruguay Peso en Unidades Indexadas (UI)",
                        LookupCode = "940",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UYI",
                        Note = "UYI",
                        SortOrder = 149,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5110,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5110,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Peso Uruguayo",
                        LookupCode = "858",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UYU",
                        Note = "$U",
                        SortOrder = 150,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5111,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5111,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Unidad Previsional",
                        LookupCode = "927",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UYW",
                        Note = "UYW",
                        SortOrder = 151,
                        Index = 4,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5112,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5112,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Uzbekistan Sum",
                        LookupCode = "860",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "UZS",
                        Note = "UZS",
                        SortOrder = 152,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5113,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5113,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Bol├¡var Soberano",
                        LookupCode = "926",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "VED",
                        Note = "VED",
                        SortOrder = 153,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5114,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5114,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Bol├¡var Soberano",
                        LookupCode = "928",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "VES",
                        Note = "Bs.",
                        SortOrder = 154,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5115,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5115,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Vatu",
                        LookupCode = "548",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "VUV",
                        Note = "VT",
                        SortOrder = 155,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5116,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5116,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Tala",
                        LookupCode = "882",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "WST",
                        Note = "WS$",
                        SortOrder = 156,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5117,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5117,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Arab Accounting Dinar",
                        LookupCode = "396",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XAD",
                        Note = "XAD",
                        SortOrder = 157,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5118,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5118,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "CFA Franc BEAC",
                        LookupCode = "950",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XAF",
                        Note = "FCFA",
                        SortOrder = 158,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5119,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5119,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "East Caribbean Dollar",
                        LookupCode = "951",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XCD",
                        Note = "EC$",
                        SortOrder = 159,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5120,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5120,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Caribbean Guilder",
                        LookupCode = "532",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XCG",
                        Note = "Cg.",
                        SortOrder = 160,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5121,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5121,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "CFA Franc BCEAO",
                        LookupCode = "952",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XOF",
                        Note = "F CFA",
                        SortOrder = 161,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5122,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5122,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "CFP Franc",
                        LookupCode = "953",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "XPF",
                        Note = "Γéú",
                        SortOrder = 162,
                        Index = 0,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5123,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5123,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Yemeni Rial",
                        LookupCode = "886",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "YER",
                        Note = "∩╖╝",
                        SortOrder = 163,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5124,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5124,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Zambian Kwacha",
                        LookupCode = "967",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ZMW",
                        Note = "ZK",
                        SortOrder = 164,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
                {
                    5125,
                    new Models.EDM.RdmLookupValue
                    {
                        Id = 5125,
                        LookupTypeId = 48,
                        LookupType = "RD_FSC_ISO_CURRENCY",
                        LookupValue = "Zimbabwe Gold",
                        LookupCode = "924",
                        LookupLevelValue = "ISO_CURRENCY",
                        Level = 1,
                        ParentId = null,
                        ValidFrom = DateOnly.FromDateTime(DateTime.Now),
                        ValidTo = null,
                        IsDefault = false,
                        ShortCode = "ZWG",
                        Note = "ZWG",
                        SortOrder = 165,
                        Index = 2,
                        SharedScope = 0,
                        LookupCodeType = "Done",
                        Color = null,
                        IsSystem = true,
                        IsActive = true,
                        IsDeleted = false
                    }
                },
            #endregion
        };

        return rdmLookupValues;
    }
}