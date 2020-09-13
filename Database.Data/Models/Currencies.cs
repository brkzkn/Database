using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Currencies
    {
        public Currencies()
        {
            AdvisorFirms = new HashSet<AdvisorFirms>();
            Contacts = new HashSet<Contacts>();
            Countries = new HashSet<Countries>();
            CurrencyPairsBaseCurrencyCodeNavigation = new HashSet<CurrencyPairs>();
            CurrencyPairsQuoteCurrencyCodeNavigation = new HashSet<CurrencyPairs>();
            DailyPrices = new HashSet<DailyPrices>();
            Plans = new HashSet<Plans>();
            PortfolioLines = new HashSet<PortfolioLines>();
            Portfolios = new HashSet<Portfolios>();
            Securities = new HashSet<Securities>();
            SecurityExchanges = new HashSet<SecurityExchanges>();
            Transactions = new HashSet<Transactions>();
        }

        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }

        public virtual ICollection<AdvisorFirms> AdvisorFirms { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Countries> Countries { get; set; }
        public virtual ICollection<CurrencyPairs> CurrencyPairsBaseCurrencyCodeNavigation { get; set; }
        public virtual ICollection<CurrencyPairs> CurrencyPairsQuoteCurrencyCodeNavigation { get; set; }
        public virtual ICollection<DailyPrices> DailyPrices { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<PortfolioLines> PortfolioLines { get; set; }
        public virtual ICollection<Portfolios> Portfolios { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
        public virtual ICollection<SecurityExchanges> SecurityExchanges { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
