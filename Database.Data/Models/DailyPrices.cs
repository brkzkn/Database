using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class DailyPrices
    {
        public int PriceId { get; set; }
        public string DataSource { get; set; }
        public DateTime PriceDate { get; set; }
        public int SecurityId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? PriceOpen { get; set; }
        public decimal? PriceHigh { get; set; }
        public decimal? PriceLow { get; set; }
        public decimal? PriceClose { get; set; }
        public long? DailyVolume { get; set; }
        public decimal? DividendPaid { get; set; }
        public int? Split { get; set; }
        public decimal? PriceAdjustedOpen { get; set; }
        public decimal? PriceAdjustedHigh { get; set; }
        public decimal? PriceAdjustedLow { get; set; }
        public decimal? PriceAdjustedClose { get; set; }
        public long? AdjustedDailyVolume { get; set; }

        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Securities Security { get; set; }
    }
}
