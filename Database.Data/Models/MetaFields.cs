using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaFields
    {
        public Guid FieldId { get; set; }
        public string FieldName { get; set; }
        public string SqlFieldName { get; set; }
        public string FieldLabel { get; set; }
        public string FieldLabelShort { get; set; }
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public int DataType { get; set; }
        public int FieldType { get; set; }
        public bool IsKey { get; set; }
        public bool IsNameField { get; set; }
        public string Placeholder { get; set; }
        public string Tooltip { get; set; }
        public string HelpText { get; set; }
        public int FieldHelpTextPosition { get; set; }
        public string FieldNotes { get; set; }
        public string HtmlTemplate { get; set; }
        public int DisplayOrder { get; set; }
        public int DisplayRows { get; set; }
        public int? DisplayDigits { get; set; }
        public int? DisplayDecimals { get; set; }
        public int? DisplayWidth { get; set; }
        public bool DisplayHumanizedNumber { get; set; }
        public bool DisplayHumanizedDate { get; set; }
        public int FormVisibility { get; set; }
        public int MinimumViewport { get; set; }
        public string VisibleWhenFieldName { get; set; }
        public int VisibleWhenOperator { get; set; }
        public string VisibleWhenComparand { get; set; }
        public string SecurityScopes { get; set; }
        public bool IsRequired { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsReadOnlyAfterInsert { get; set; }
        public string ReadOnlyWhenFieldName { get; set; }
        public int ReadOnlyWhenOperator { get; set; }
        public string ReadOnlyWhenComparand { get; set; }
        public bool IsUnique { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public string RegexPattern { get; set; }
        public bool ForceUpperCase { get; set; }
        public bool IsNullable { get; set; }
        public string DefaultValue { get; set; }
        public Guid? LookupEntityId { get; set; }
        public string LookupEntityName { get; set; }
        public string LookupFieldName { get; set; }
        public string LookupEntityRelationshipName { get; set; }
        public string DetailEntityName { get; set; }
        public string EntityToAggregate { get; set; }
        public string FieldToAggregate { get; set; }
        public int AggregateType { get; set; }
        public string AggregateFilter { get; set; }
        public string PicklistName { get; set; }
        public bool IsMultiSelect { get; set; }
        public string ValueList { get; set; }
        public bool DisplayListValuesAlphabetically { get; set; }
        public bool UseFirstValueAsDefault { get; set; }
        public bool RestrictInputToValueList { get; set; }
        public bool IsSearchable { get; set; }
        public bool? DisableContainsSearch { get; set; }
        public bool IsSortable { get; set; }
        public int? DefaultSort { get; set; }
        public bool HideInDiff { get; set; }
        public string ComplianceGroup { get; set; }
        public int AnonymisationType { get; set; }
        public string DisplayFormat { get; set; }
        public int StartingNumber { get; set; }
        public string ExternalFieldName01 { get; set; }
        public string ExternalFieldName02 { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual MetaEntities LookupEntity { get; set; }
    }
}
