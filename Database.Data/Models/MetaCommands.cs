using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaCommands
    {
        public Guid CommandId { get; set; }
        public Guid? EntityId { get; set; }
        public Guid? AppId { get; set; }
        public string CommandLabel { get; set; }
        public string CommandName { get; set; }
        public int ExectionType { get; set; }
        public string CommandDescription { get; set; }
        public string HelpPage { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaApps App { get; set; }
        public virtual MetaEntities Entity { get; set; }
    }
}
