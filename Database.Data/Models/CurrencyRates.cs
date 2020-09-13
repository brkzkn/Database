using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CurrencyRates
    {
        public int CurrencyRateId { get; set; }
        public int CurrencyPairId { get; set; }
        public DateTime RateDate { get; set; }
        public decimal RateValue { get; set; }

        public virtual CurrencyPairs CurrencyPair { get; set; }
    }
}
