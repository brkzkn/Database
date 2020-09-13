using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SecurityExchanges
    {
        public int SecurityExchangeId { get; set; }
        public int SecurityId { get; set; }
        public string ExchangeCode { get; set; }
        public string IsinCode { get; set; }
        public string SecuritySymbol { get; set; }
        public string CurrencyCode { get; set; }
        public string BrokerCode { get; set; }
        public int? BrokerSecurityId { get; set; }

        public virtual Brokers BrokerCodeNavigation { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Exchanges ExchangeCodeNavigation { get; set; }
        public virtual Securities Security { get; set; }
    }
}
