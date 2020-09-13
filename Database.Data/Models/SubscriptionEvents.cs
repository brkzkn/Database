using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SubscriptionEvents
    {
        public int SubscriptionEventId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime? EventDate { get; set; }
        public int SubscriptionEventType { get; set; }
        public int SubscriptionEventSource { get; set; }
        public string UserId { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Subscriptions Subscription { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
