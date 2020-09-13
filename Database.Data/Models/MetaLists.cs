using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaLists
    {
        public Guid ListId { get; set; }
        public Guid EntityId { get; set; }
        public string ListName { get; set; }
        public string ListLabel { get; set; }
        public string ListDescription { get; set; }
        public int ListType { get; set; }
        public string MetaListItems { get; set; }
        public Guid? FormId { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual MetaForms Form { get; set; }
    }
}
