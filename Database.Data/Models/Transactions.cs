using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public Guid PortfolioId { get; set; }
        public int? LiquidAssetId { get; set; }
        public int TransactionType { get; set; }
        public int? SecurityId { get; set; }
        public string IsinCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public string SecuritySymbol { get; set; }
        public decimal UnitPrice { get; set; }
        public int TransactionQuantity { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string TransactionDescription { get; set; }
        public string CurrencyCode { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionSourceId { get; set; }
        public int? BaseTransactionId { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual LiquidAssets LiquidAsset { get; set; }
        public virtual Portfolios Portfolio { get; set; }
        public virtual Securities Security { get; set; }
    }
}
