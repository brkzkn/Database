using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Leads
    {
        public Leads()
        {
            Activities = new HashSet<Activities>();
            CommentMentions = new HashSet<CommentMentions>();
            Comments = new HashSet<Comments>();
            MessageAddresses = new HashSet<MessageAddresses>();
        }

        public Guid LeadId { get; set; }
        public int LeadIndex { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LeadName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string FullStreetAddress { get; set; }
        public string WebSite { get; set; }
        public int? LeadRating { get; set; }
        public string LeadStatus { get; set; }
        public string LeadSource { get; set; }
        public string MarketingSegment { get; set; }
        public string Industry { get; set; }
        public string Competitors { get; set; }
        public string ProductInterest { get; set; }
        public string PersonalInterests { get; set; }
        public string PreferredCommunicationChannel { get; set; }
        public bool DoNotCall { get; set; }
        public string LeadNotes { get; set; }
        public int? NumberOfEmployees { get; set; }
        public int EmailOption { get; set; }
        public decimal FinancialAssets { get; set; }
        public int LeadType { get; set; }
        public Guid? OpportunityId { get; set; }
        public bool IsConverted { get; set; }
        public DateTime ConvertedDate { get; set; }
        public Guid? ConvertedContactId { get; set; }
        public DateTime LastActivityDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime ClosedDate { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid? OwnerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
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
        public virtual Contacts ConvertedContact { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Opportunities Opportunity { get; set; }
        public virtual Employees Owner { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<CommentMentions> CommentMentions { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<MessageAddresses> MessageAddresses { get; set; }
    }
}
