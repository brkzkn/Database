using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class BudgetReports
    {
        public BudgetReports()
        {
            BudgetRows = new HashSet<BudgetRows>();
        }

        public int BudgetId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public DateTime LastGenerated { get; set; }
        public int FirstYear { get; set; }
        public int LastYear { get; set; }
        public bool HasPartner { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ICollection<BudgetRows> BudgetRows { get; set; }
    }
}
