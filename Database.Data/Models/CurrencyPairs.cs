using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CurrencyPairs
    {
        public CurrencyPairs()
        {
            CurrencyRates = new HashSet<CurrencyRates>();
        }

        public int CurrencyPairId { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string QuoteCurrencyCode { get; set; }
        public string DataSource { get; set; }
        public string DataSet { get; set; }

        public virtual Currencies BaseCurrencyCodeNavigation { get; set; }
        public virtual Currencies QuoteCurrencyCodeNavigation { get; set; }
        public virtual ICollection<CurrencyRates> CurrencyRates { get; set; }
    }
}
