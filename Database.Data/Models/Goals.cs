using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Goals
    {
        public int GoalId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public int InvestmentGoal { get; set; }
        public string GoalDescription { get; set; }
        public DateTime? TargetDate { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal RiskAssetsMin { get; set; }
        public decimal RiskAssetsMax { get; set; }
        public int CashOutAssumption { get; set; }
        public int DrawdownYears { get; set; }
        public decimal DesiredMonthlyIncome { get; set; }
        public decimal MinimumMonthlyIncome { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
    }
}
