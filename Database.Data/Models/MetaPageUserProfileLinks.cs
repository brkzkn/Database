using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaPageUserProfileLinks
    {
        public int LinkId { get; set; }
        public Guid PageId { get; set; }
        public Guid ProfileId { get; set; }
        public bool IsDefaultForProfile { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaPages Page { get; set; }
        public virtual UserProfiles Profile { get; set; }
    }
}
