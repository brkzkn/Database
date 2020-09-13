using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class FixedAssets
    {
        public FixedAssets()
        {
            Incomes = new HashSet<Incomes>();
            PortfolioSecurities = new HashSet<PortfolioSecurities>();
        }

        public int FixedAssetId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public int FixedAssetType { get; set; }
        public string AssetDescription { get; set; }
        public decimal MarketValue { get; set; }
        public decimal ExpectedReturn { get; set; }
        public decimal RegisterValue { get; set; }
        public int AssetOwner { get; set; }
        public bool LinkedExpense { get; set; }
        public decimal LinkedExpenseAmount { get; set; }
        public bool LinkedIncome { get; set; }
        public decimal LinkedIncomeAmount { get; set; }
        public bool LinkedMortgage { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ICollection<Incomes> Incomes { get; set; }
        public virtual ICollection<PortfolioSecurities> PortfolioSecurities { get; set; }
    }
}
