using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PlanItemPriceBrackets
    {
        public int PriceBracketId { get; set; }
        public int PlanItemId { get; set; }
        public int StartingQuantity { get; set; }
        public int EndingQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public int? SubscriptionItemItemId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual PlanItems PlanItem { get; set; }
        public virtual SubscriptionItems SubscriptionItemItem { get; set; }
    }
}
