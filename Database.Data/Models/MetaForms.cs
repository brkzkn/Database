using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaForms
    {
        public MetaForms()
        {
            MetaLists = new HashSet<MetaLists>();
        }

        public Guid FormId { get; set; }
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public string FormName { get; set; }
        public string FormLabel { get; set; }
        public string FormDescription { get; set; }
        public string HelpText { get; set; }
        public int FormHelpTextPosition { get; set; }
        public string FormLayout { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual ICollection<MetaLists> MetaLists { get; set; }
    }
}
