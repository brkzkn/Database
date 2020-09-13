using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ValidationRules
    {
        public int RuleId { get; set; }
        public Guid EntityId { get; set; }
        public string RuleLabel { get; set; }
        public string RuleName { get; set; }
        public string RuleDescription { get; set; }
        public string RuleScript { get; set; }
        public string HelpPage { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
    }
}
