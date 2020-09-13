using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaApps
    {
        public MetaApps()
        {
            MetaAppMetaEntityLinks = new HashSet<MetaAppMetaEntityLinks>();
            MetaAppUserProfileLinks = new HashSet<MetaAppUserProfileLinks>();
            MetaCommands = new HashSet<MetaCommands>();
        }

        public Guid AppId { get; set; }
        public string AppLabel { get; set; }
        public string AppName { get; set; }
        public string AppDescription { get; set; }
        public string AppIconName { get; set; }
        public string AppIconColor { get; set; }
        public string HelpText { get; set; }
        public string FeatureKeys { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<MetaAppMetaEntityLinks> MetaAppMetaEntityLinks { get; set; }
        public virtual ICollection<MetaAppUserProfileLinks> MetaAppUserProfileLinks { get; set; }
        public virtual ICollection<MetaCommands> MetaCommands { get; set; }
    }
}
