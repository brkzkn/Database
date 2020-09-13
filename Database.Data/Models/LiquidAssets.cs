using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class LiquidAssets
    {
        public LiquidAssets()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int LiquidAssetId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public Guid? PortfolioId { get; set; }
        public int LiquidAssetType { get; set; }
        public string AssetDescription { get; set; }
        public int? InstitutionId { get; set; }
        public decimal MarketValue { get; set; }
        public decimal ExpectedReturn { get; set; }
        public decimal MonthlyContribution { get; set; }
        public DateTime? ContributionEndDate { get; set; }
        public DateTime? TermEndDate { get; set; }
        public int AssetOwner { get; set; }
        public int AccountAccess { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Institutions Institution { get; set; }
        public virtual Portfolios Portfolio { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
