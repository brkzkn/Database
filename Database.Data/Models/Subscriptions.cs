using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Subscriptions
    {
        public Subscriptions()
        {
            SubscriptionEvents = new HashSet<SubscriptionEvents>();
            SubscriptionItems = new HashSet<SubscriptionItems>();
        }

        public Guid SubscriptionId { get; set; }
        public Guid PlanId { get; set; }
        public Guid ContactId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public int SubscriptionStatus { get; set; }
        public int CancelReason { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TrialStartDate { get; set; }
        public DateTime? TrialEndDate { get; set; }
        public DateTime? CurrentTermStartDate { get; set; }
        public DateTime? CurrentTermEndDate { get; set; }
        public DateTime? NextBillingDate { get; set; }
        public int? RemainingBillingCycles { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public DateTime? PausedDate { get; set; }
        public DateTime? ResumeDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public int BillingCycleDay { get; set; }
        public int AutoCollect { get; set; }
        public int? DueInvoicesCount { get; set; }
        public DateTime? DueSince { get; set; }
        public decimal TotalDueAmount { get; set; }
        public int RecordStatus { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual ICollection<SubscriptionEvents> SubscriptionEvents { get; set; }
        public virtual ICollection<SubscriptionItems> SubscriptionItems { get; set; }
    }
}
