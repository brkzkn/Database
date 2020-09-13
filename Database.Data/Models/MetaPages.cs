using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaPages
    {
        public MetaPages()
        {
            MetaPageUserProfileLinks = new HashSet<MetaPageUserProfileLinks>();
        }

        public Guid PageId { get; set; }
        public Guid EntityId { get; set; }
        public string PageLabel { get; set; }
        public string PageName { get; set; }
        public string PageDescription { get; set; }
        public string HelpText { get; set; }
        public int PageHelpTextPosition { get; set; }
        public int PageType { get; set; }
        public int PageStyle { get; set; }
        public string PageLayout { get; set; }
        public string FeatureKeys { get; set; }
        public string PageIconName { get; set; }
        public string PageIconColor { get; set; }
        public string ModelName { get; set; }
        public bool IsCustom { get; set; }
        public int DefaultUserFlags { get; set; }
        public bool IsDefaultClient { get; set; }
        public bool IsDefaultEmployee { get; set; }
        public bool IsDefaultStaff { get; set; }
        public Guid? RecordTypeId { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual RecordTypes RecordType { get; set; }
        public virtual ICollection<MetaPageUserProfileLinks> MetaPageUserProfileLinks { get; set; }
    }
}
