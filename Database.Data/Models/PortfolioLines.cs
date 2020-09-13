using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PortfolioLines
    {
        public int PortfolioLineId { get; set; }
        public int PortfolioReportId { get; set; }
        public Guid PortfolioId { get; set; }
        public int? SecurityId { get; set; }
        public string IsinCode { get; set; }
        public string SecuritySymbol { get; set; }
        public string ItemDescription { get; set; }
        public int ReportQuantity { get; set; }
        public decimal SharePrice { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal CurrencyAmount { get; set; }
        public decimal ReportAmount { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Portfolios Portfolio { get; set; }
        public virtual PortfolioReports PortfolioReport { get; set; }
        public virtual Securities Security { get; set; }
    }
}
