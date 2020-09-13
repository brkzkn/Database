using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Securities
    {
        public Securities()
        {
            CorporateActionLogs = new HashSet<CorporateActionLogs>();
            DailyPrices = new HashSet<DailyPrices>();
            OrderLines = new HashSet<OrderLines>();
            PortfolioLines = new HashSet<PortfolioLines>();
            PortfolioSecurities = new HashSet<PortfolioSecurities>();
            PortfoliosOutOfMarketAssetSecurity = new HashSet<Portfolios>();
            PortfoliosRiskFreeRateSecurity = new HashSet<Portfolios>();
            ProxyMap = new HashSet<ProxyMap>();
            SecurityExchanges = new HashSet<SecurityExchanges>();
            Transactions = new HashSet<Transactions>();
        }

        public int SecurityId { get; set; }
        public string SecurityName { get; set; }
        public string SecurityProfile { get; set; }
        public string MoreInfo { get; set; }
        public string AdminNotes { get; set; }
        public string IsinCode { get; set; }
        public string SecuritySymbol { get; set; }
        public int SecurityType { get; set; }
        public string Segment { get; set; }
        public string AssetClassId { get; set; }
        public string RegionId { get; set; }
        public string CategoryId { get; set; }
        public string GeographyId { get; set; }
        public string IssuerId { get; set; }
        public string IssuerHomePage { get; set; }
        public string FocusId { get; set; }
        public string NicheId { get; set; }
        public string UnderlyingIndexId { get; set; }
        public string IndexHomePage { get; set; }
        public string SelectionCriteriaId { get; set; }
        public string WeightingSchemeId { get; set; }
        public string CountryCode { get; set; }
        public int? TradingStatus { get; set; }
        public string CusipCode { get; set; }
        public string CikCode { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? ProxyEndDate { get; set; }
        public bool LeveragedEtf { get; set; }
        public bool InverseEtf { get; set; }
        public decimal LeverageFactor { get; set; }
        public bool SecuritiesLending { get; set; }
        public decimal BondDuration { get; set; }
        public string CreditQuality { get; set; }
        public decimal AssetsUnderManagement { get; set; }
        public decimal AverageDailyDollarVolume { get; set; }
        public int AverageDailyShareVolume { get; set; }
        public decimal ExpenseRatio { get; set; }
        public decimal AverageSpread { get; set; }
        public int LegalStructure { get; set; }
        public string DataSource { get; set; }
        public string DataSourceId { get; set; }
        public string CurrencyCode { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual AssetClasses AssetClass { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Focuses Focus { get; set; }
        public virtual Geographies Geography { get; set; }
        public virtual Issuers Issuer { get; set; }
        public virtual Niches Niche { get; set; }
        public virtual Regions Region { get; set; }
        public virtual IndexCriteria SelectionCriteria { get; set; }
        public virtual UnderlyingIndices UnderlyingIndex { get; set; }
        public virtual WeightingSchemes WeightingScheme { get; set; }
        public virtual ICollection<CorporateActionLogs> CorporateActionLogs { get; set; }
        public virtual ICollection<DailyPrices> DailyPrices { get; set; }
        public virtual ICollection<OrderLines> OrderLines { get; set; }
        public virtual ICollection<PortfolioLines> PortfolioLines { get; set; }
        public virtual ICollection<PortfolioSecurities> PortfolioSecurities { get; set; }
        public virtual ICollection<Portfolios> PortfoliosOutOfMarketAssetSecurity { get; set; }
        public virtual ICollection<Portfolios> PortfoliosRiskFreeRateSecurity { get; set; }
        public virtual ICollection<ProxyMap> ProxyMap { get; set; }
        public virtual ICollection<SecurityExchanges> SecurityExchanges { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
