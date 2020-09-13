using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SubscriptionItems
    {
        public SubscriptionItems()
        {
            PlanItemPriceBrackets = new HashSet<PlanItemPriceBrackets>();
        }

        public int ItemId { get; set; }
        public Guid SubscriptionId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ClaimType { get; set; }
        public int ItemType { get; set; }
        public string UnitName { get; set; }
        public int ChargeType { get; set; }
        public bool RecurringCharge { get; set; }
        public decimal? UnitPrice { get; set; }
        public int PricingScheme { get; set; }
        public int PlanIncludedQuantity { get; set; }
        public int SubscriptionQuantity { get; set; }
        public int PlanMaxQuantity { get; set; }
        public int ConsumedQuantity { get; set; }
        public string ProductCode { get; set; }
        public bool VatIncluded { get; set; }
        public string VatCode { get; set; }
        public int DisplayOrder { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Subscriptions Subscription { get; set; }
        public virtual ICollection<PlanItemPriceBrackets> PlanItemPriceBrackets { get; set; }
    }
}
