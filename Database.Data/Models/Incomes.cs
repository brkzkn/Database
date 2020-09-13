using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Incomes
    {
        public int IncomeId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public int IncomeType { get; set; }
        public int IncomeOwner { get; set; }
        public string IncomeDescription { get; set; }
        public int StartDateType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal MonthlyIncome { get; set; }
        public bool ThirteenthMonth { get; set; }
        public bool VacationPay { get; set; }
        public decimal AnnualDividendIncome { get; set; }
        public DateTime? DividendEndDate { get; set; }
        public decimal OtherMonthlyIncome { get; set; }
        public DateTime? OtherEndDate { get; set; }
        public string CarBrandType { get; set; }
        public string CarRegistrationNr { get; set; }
        public bool CarPrivateUseTax { get; set; }
        public decimal CarListPrice { get; set; }
        public decimal CarCapitalContribution { get; set; }
        public decimal CarExpenseContribution { get; set; }
        public decimal CarTaxAddBackPercent { get; set; }
        public int? InstitutionId { get; set; }
        public decimal SurvivorBenefitPartner { get; set; }
        public decimal SurvivorBenefitChild { get; set; }
        public int UniformPensionYear { get; set; }
        public decimal TerminalValue { get; set; }
        public decimal MonthlyContribution { get; set; }
        public DateTime? ContributionStartDate { get; set; }
        public DateTime? ContributionEndDate { get; set; }
        public int FundPayoutType { get; set; }
        public DateTime? PayoutStartDate { get; set; }
        public DateTime? PayoutEndDate { get; set; }
        public int? FixedAssetId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual FixedAssets FixedAsset { get; set; }
        public virtual Institutions Institution { get; set; }
    }
}
