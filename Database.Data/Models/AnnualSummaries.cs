using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AnnualSummaries
    {
        public int AnnualSummaryId { get; set; }
        public Guid PortfolioId { get; set; }
        public int ReportYear { get; set; }
        public decimal MonthReturn01 { get; set; }
        public decimal MonthReturn02 { get; set; }
        public decimal MonthReturn03 { get; set; }
        public decimal MonthReturn04 { get; set; }
        public decimal MonthReturn05 { get; set; }
        public decimal MonthReturn06 { get; set; }
        public decimal MonthReturn07 { get; set; }
        public decimal MonthReturn08 { get; set; }
        public decimal MonthReturn09 { get; set; }
        public decimal MonthReturn10 { get; set; }
        public decimal MonthReturn11 { get; set; }
        public decimal MonthReturn12 { get; set; }
        public decimal AnnualReturn { get; set; }
        public decimal YearBeginValue { get; set; }
        public decimal YearCashInOut { get; set; }
        public decimal YearEndValue { get; set; }
        public decimal AdvisoryFees { get; set; }
        public decimal BrokerageFees { get; set; }
        public decimal TradesPerYear { get; set; }
        public decimal AnnualTurnover { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Portfolios Portfolio { get; set; }
    }
}
