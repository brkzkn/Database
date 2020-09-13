using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PlanGroups
    {
        public PlanGroups()
        {
            Plans = new HashSet<Plans>();
        }

        public Guid PlanGroupId { get; set; }
        public string PlanGroupCode { get; set; }
        public string PlanGroupName { get; set; }
        public string PlanGroupDescription { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
    }
}
