using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Opportunities
    {
        public Opportunities()
        {
            Activities = new HashSet<Activities>();
            Comments = new HashSet<Comments>();
            Leads = new HashSet<Leads>();
        }

        public Guid OpportunityId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityDescription { get; set; }
        public Guid ContactId { get; set; }
        public Guid? OwnerId { get; set; }
        public string OpportunityStage { get; set; }
        public decimal PotentialRevenue { get; set; }
        public decimal Probability { get; set; }
        public decimal ExpectedRevenue { get; set; }
        public string OpportunityType { get; set; }
        public decimal FinancialAssets { get; set; }
        public string ProductInterest { get; set; }
        public string Competitors { get; set; }
        public string PreferredCommunicationChannel { get; set; }
        public bool DoNotCall { get; set; }
        public int? NumberOfEmployees { get; set; }
        public int EmailOption { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? PlannedClosingDate { get; set; }
        public bool IsClosed { get; set; }
        public int? ClosedType { get; set; }
        public string ClosedLostReason { get; set; }
        public Guid? ClosedById { get; set; }
        public string FlexField001 { get; set; }
        public string FlexField002 { get; set; }
        public string FlexField003 { get; set; }
        public string FlexField004 { get; set; }
        public string FlexField005 { get; set; }
        public string FlexField006 { get; set; }
        public string FlexField007 { get; set; }
        public string FlexField008 { get; set; }
        public string FlexField009 { get; set; }
        public string FlexField010 { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees ClosedBy { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Employees Owner { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Leads> Leads { get; set; }
    }
}
