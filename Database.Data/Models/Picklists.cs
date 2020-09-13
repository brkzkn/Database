using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Picklists
    {
        public Picklists()
        {
            PicklistItems = new HashSet<PicklistItems>();
        }

        public int PicklistId { get; set; }
        public string PicklistName { get; set; }
        public string PicklistLabel { get; set; }
        public int PicklistScope { get; set; }
        public string PicklistDescription { get; set; }
        public bool Restricted { get; set; }
        public bool AutoSort { get; set; }
        public int ColorSource { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<PicklistItems> PicklistItems { get; set; }
    }
}
