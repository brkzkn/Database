using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PortfolioSecurities
    {
        public int PortfolioSecurityId { get; set; }
        public Guid PortfolioId { get; set; }
        public int SecurityId { get; set; }
        public string SecuritySymbol { get; set; }
        public decimal BaseWeight { get; set; }
        public decimal TargetWeight { get; set; }
        public int? AccountId { get; set; }
        public int? FixedAssets { get; set; }
        public int BrokerSecurityId { get; set; }
        public decimal CalcResult1 { get; set; }
        public decimal CalcResult2 { get; set; }
        public decimal CalcResult3 { get; set; }
        public decimal CalcResult4 { get; set; }
        public decimal CalcResult5 { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual FixedAssets FixedAssetsNavigation { get; set; }
        public virtual Portfolios Portfolio { get; set; }
        public virtual Securities Security { get; set; }
    }
}
