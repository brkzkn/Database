using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Portfolios
    {
        public Portfolios()
        {
            AnnualSummaries = new HashSet<AnnualSummaries>();
            Drawdowns = new HashSet<Drawdowns>();
            LiquidAssets = new HashSet<LiquidAssets>();
            Orders = new HashSet<Orders>();
            PortfolioLines = new HashSet<PortfolioLines>();
            PortfolioReports = new HashSet<PortfolioReports>();
            PortfolioSecurities = new HashSet<PortfolioSecurities>();
            Transactions = new HashSet<Transactions>();
        }

        public Guid PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public int PortfolioVisibility { get; set; }
        public string TradingStrategy { get; set; }
        public int TradingFrequency { get; set; }
        public int TradingExecution { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal AllocationSum { get; set; }
        public string PortfolioComments { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal FinalBalance { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalReturn { get; set; }
        public decimal Cagr { get; set; }
        public decimal SharpeRatio { get; set; }
        public decimal SortinoRatio { get; set; }
        public decimal StandardDeviation { get; set; }
        public decimal MaxDrawdown { get; set; }
        public decimal MaxDrawdownLength { get; set; }
        public decimal AverageDrawdownLength { get; set; }
        public decimal WinningTradesPercent { get; set; }
        public decimal AverageWiningTrade { get; set; }
        public decimal AverageTradeLoss { get; set; }
        public decimal BestTrade { get; set; }
        public decimal WorstTrade { get; set; }
        public decimal AverageDaysInTrade { get; set; }
        public int TotalTrades { get; set; }
        public decimal AverageTradesYear { get; set; }
        public decimal AnnualTurnoverPercent { get; set; }
        public decimal AverageTradingCostsYear { get; set; }
        public decimal PercentWinningMonths { get; set; }
        public decimal BestMonthReturn { get; set; }
        public decimal WorstMonthReturn { get; set; }
        public decimal PercentWinningYears { get; set; }
        public decimal BestYearReturn { get; set; }
        public decimal WorstYearReturn { get; set; }
        public decimal Positive12MonthPeriods { get; set; }
        public decimal BenchmarkCorrelation { get; set; }
        public decimal AdvisoryFeePercent { get; set; }
        public decimal BrokerageFeePercent { get; set; }
        public decimal SlippageCostPercent { get; set; }
        public int BenchMarkId { get; set; }
        public int BuySignal { get; set; }
        public int MovingAverageType1 { get; set; }
        public int TimingPeriod1 { get; set; }
        public int MovingAverageType2 { get; set; }
        public int TimingPeriod2 { get; set; }
        public int OutOfMarketAssetType { get; set; }
        public int? OutOfMarketAssetSecurityId { get; set; }
        public int? RiskFreeRateSecurityId { get; set; }
        public decimal TargetVolatility { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Securities OutOfMarketAssetSecurity { get; set; }
        public virtual Securities RiskFreeRateSecurity { get; set; }
        public virtual ICollection<AnnualSummaries> AnnualSummaries { get; set; }
        public virtual ICollection<Drawdowns> Drawdowns { get; set; }
        public virtual ICollection<LiquidAssets> LiquidAssets { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<PortfolioLines> PortfolioLines { get; set; }
        public virtual ICollection<PortfolioReports> PortfolioReports { get; set; }
        public virtual ICollection<PortfolioSecurities> PortfolioSecurities { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
