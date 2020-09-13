using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Plans
    {
        public Plans()
        {
            PlanItems = new HashSet<PlanItems>();
            Subscriptions = new HashSet<Subscriptions>();
        }

        public Guid PlanId { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
        public string PlanDescription { get; set; }
        public Guid? PlanGroupId { get; set; }
        public decimal? PeriodPrice { get; set; }
        public int BillingPeriod { get; set; }
        public int BillingFrequency { get; set; }
        public int TrialPeriodLength { get; set; }
        public int TrialPeriodUnit { get; set; }
        public int DiscountedPeriodLength { get; set; }
        public decimal? DiscountedPeriodPrice { get; set; }
        public bool VatIncluded { get; set; }
        public string VatCode { get; set; }
        public string CurrencyCode { get; set; }
        public string RevenueAccount { get; set; }
        public string AccountingCategory1 { get; set; }
        public string AccountingCategory2 { get; set; }
        public int RecordStatus { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual PlanGroups PlanGroup { get; set; }
        public virtual ICollection<PlanItems> PlanItems { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}
