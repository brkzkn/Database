using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class RecordTypes
    {
        public RecordTypes()
        {
            Contacts = new HashSet<Contacts>();
            MetaPages = new HashSet<MetaPages>();
        }

        public Guid RecordTypeId { get; set; }
        public string RecordTypeName { get; set; }
        public string RecordTypeLabel { get; set; }
        public string RecordTypeDescription { get; set; }
        public Guid EntityId { get; set; }
        public bool IsActive { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<MetaPages> MetaPages { get; set; }
    }
}
