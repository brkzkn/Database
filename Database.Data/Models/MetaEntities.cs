using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaEntities
    {
        public MetaEntities()
        {
            FlexData = new HashSet<FlexData>();
            ListViewDefinitions = new HashSet<ListViewDefinitions>();
            MetaAppMetaEntityLinks = new HashSet<MetaAppMetaEntityLinks>();
            MetaCommands = new HashSet<MetaCommands>();
            MetaFieldsEntity = new HashSet<MetaFields>();
            MetaFieldsLookupEntity = new HashSet<MetaFields>();
            MetaForms = new HashSet<MetaForms>();
            MetaLists = new HashSet<MetaLists>();
            MetaPages = new HashSet<MetaPages>();
            MetaReports = new HashSet<MetaReports>();
            RecordTypes = new HashSet<RecordTypes>();
            ValidationRules = new HashSet<ValidationRules>();
        }

        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public string SqlEntityName { get; set; }
        public string EntityLabel { get; set; }
        public string EntityLabelPlural { get; set; }
        public string EntityIconName { get; set; }
        public string EntityIconColor { get; set; }
        public string EntityDescription { get; set; }
        public bool IsCustom { get; set; }
        public bool IsVirtual { get; set; }
        public int VirtualPageType { get; set; }
        public bool HideInLauncher { get; set; }
        public string EntityUrl { get; set; }
        public bool OpenInNewBrowserWindow { get; set; }
        public string SecurityScopes { get; set; }
        public string SecurityParent { get; set; }
        public int EntityFlags { get; set; }
        public int EntityOwnerType { get; set; }
        public string FeatureKeys { get; set; }
        public bool AllowReports { get; set; }
        public bool AllowApiaccess { get; set; }
        public string HelpText { get; set; }
        public int FieldHelpTextPosition { get; set; }
        public string EntityNotes { get; set; }
        public string ExternalTableName01 { get; set; }
        public string ExternalTableName02 { get; set; }
        public int EntityDeleteBehavior { get; set; }
        public int RequiredUserType { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public string EntityBaseName { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<FlexData> FlexData { get; set; }
        public virtual ICollection<ListViewDefinitions> ListViewDefinitions { get; set; }
        public virtual ICollection<MetaAppMetaEntityLinks> MetaAppMetaEntityLinks { get; set; }
        public virtual ICollection<MetaCommands> MetaCommands { get; set; }
        public virtual ICollection<MetaFields> MetaFieldsEntity { get; set; }
        public virtual ICollection<MetaFields> MetaFieldsLookupEntity { get; set; }
        public virtual ICollection<MetaForms> MetaForms { get; set; }
        public virtual ICollection<MetaLists> MetaLists { get; set; }
        public virtual ICollection<MetaPages> MetaPages { get; set; }
        public virtual ICollection<MetaReports> MetaReports { get; set; }
        public virtual ICollection<RecordTypes> RecordTypes { get; set; }
        public virtual ICollection<ValidationRules> ValidationRules { get; set; }
    }
}
