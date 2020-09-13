using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Exchanges
    {
        public Exchanges()
        {
            SecurityExchanges = new HashSet<SecurityExchanges>();
        }

        public string ExchangeCode { get; set; }
        public string ExchangeDescription { get; set; }
        public string CountryCode { get; set; }
        public string ExchangeWebsite { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<SecurityExchanges> SecurityExchanges { get; set; }
    }
}
