using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PortfolioReports
    {
        public PortfolioReports()
        {
            PortfolioLines = new HashSet<PortfolioLines>();
        }

        public int PortfolioReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal PeriodBeginValue { get; set; }
        public decimal CashInOut { get; set; }
        public decimal PeriodEndValue { get; set; }
        public decimal PeriodReturnAmountExCash { get; set; }
        public decimal PeriodReturnPercent { get; set; }
        public decimal RiskFreeRate { get; set; }
        public DateTime PreviousReportDate { get; set; }
        public decimal PeriodBeginValueExCash { get; set; }
        public decimal PeriodEndValueExCash { get; set; }
        public decimal Rolling12MonthReturn { get; set; }
        public decimal CumulativeDrawdownPercent { get; set; }
        public Guid PortfolioId { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Portfolios Portfolio { get; set; }
        public virtual ICollection<PortfolioLines> PortfolioLines { get; set; }
    }
}
