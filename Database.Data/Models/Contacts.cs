using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            Activities = new HashSet<Activities>();
            BudgetReports = new HashSet<BudgetReports>();
            BudgetRows = new HashSet<BudgetRows>();
            Cases = new HashSet<Cases>();
            Cities = new HashSet<Cities>();
            CommentMentions = new HashSet<CommentMentions>();
            Comments = new HashSet<Comments>();
            DeliveryMethods = new HashSet<DeliveryMethods>();
            Expenses = new HashSet<Expenses>();
            FixedAssets = new HashSet<FixedAssets>();
            Goals = new HashSet<Goals>();
            Incomes = new HashSet<Incomes>();
            InversePrimaryContact = new HashSet<Contacts>();
            Leads = new HashSet<Leads>();
            Liabilities = new HashSet<Liabilities>();
            LiquidAssets = new HashSet<LiquidAssets>();
            MessageAddresses = new HashSet<MessageAddresses>();
            Opportunities = new HashSet<Opportunities>();
            PackagingItems = new HashSet<PackagingItems>();
            PackagingUnits = new HashSet<PackagingUnits>();
            Portfolios = new HashSet<Portfolios>();
            Products = new HashSet<Products>();
            RelationshipsContact = new HashSet<Relationships>();
            RelationshipsRelatedContact = new HashSet<Relationships>();
            ShipmentItems = new HashSet<ShipmentItems>();
            ShipmentsBillingContact = new HashSet<Shipments>();
            ShipmentsContact = new HashSet<Shipments>();
            ShippingDepartments = new HashSet<ShippingDepartments>();
            ShippingPoints = new HashSet<ShippingPoints>();
            Subscriptions = new HashSet<Subscriptions>();
        }

        public Guid ContactId { get; set; }
        public int ContactType { get; set; }
        public Guid? PrimaryContactId { get; set; }
        public bool IsClient { get; set; }
        public DateTime ClientStartDate { get; set; }
        public DateTime ClientEndDate { get; set; }
        public bool UsePrimaryContactAddress { get; set; }
        public bool IsPrivate { get; set; }
        public Guid? OwnerId { get; set; }
        public string UserId { get; set; }
        public Guid? ProfileId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyDepartment { get; set; }
        public int Gender { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string PreferredName { get; set; }
        public string LastName { get; set; }
        public string ContactName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string FullStreetAddress { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalCity { get; set; }
        public string PostalRegion { get; set; }
        public string PostalPostalCode { get; set; }
        public string PostalCountryCode { get; set; }
        public string FullPostalAddress { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public bool DoNotCall { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string ContactCategory { get; set; }
        public string ContactStatus { get; set; }
        public string ContactSource { get; set; }
        public string MarketingSegment { get; set; }
        public string Industry { get; set; }
        public string Competitors { get; set; }
        public string ProductInterest { get; set; }
        public string PersonalInterests { get; set; }
        public string PreferredCommunicationChannel { get; set; }
        public string LinkedInPage { get; set; }
        public string FacebookPage { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaritalStatus { get; set; }
        public string ContactNotes { get; set; }
        public Guid? MediaId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public int DeRiskYears { get; set; }
        public int FinanciallyIndependentAge { get; set; }
        public int LifeExpectancy { get; set; }
        public string NationalTaxpayerIdentificationNr { get; set; }
        public string ForeignTaxpayerIdentificationNr { get; set; }
        public decimal LiquidAssetsTotal { get; set; }
        public decimal AssetsUnderManagement { get; set; }
        public decimal FixedAssetsTotal { get; set; }
        public decimal LiabilitiesTotal { get; set; }
        public decimal IncomeTotal { get; set; }
        public decimal ExpenseTotal { get; set; }
        public decimal PensionAssetsTotal { get; set; }
        public decimal ExpectedIncomeGrowth { get; set; }
        public decimal AnnualSavingsTotal { get; set; }
        public decimal ConsumptionRatio { get; set; }
        public decimal AverageRetirementTaxRate { get; set; }
        public int BasicRiskPreference { get; set; }
        public string RiskAssessment { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int EmailPreference { get; set; }
        public bool IsActive { get; set; }
        public string ExternalRecordId1 { get; set; }
        public string ExternalRecordId2 { get; set; }
        public Guid? RecordTypeId { get; set; }
        public Guid AdvisorFirmId { get; set; }
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
        public string WebSite { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual Media Media { get; set; }
        public virtual Employees Owner { get; set; }
        public virtual Countries PostalCountryCodeNavigation { get; set; }
        public virtual Contacts PrimaryContact { get; set; }
        public virtual UserProfiles Profile { get; set; }
        public virtual RecordTypes RecordType { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<BudgetReports> BudgetReports { get; set; }
        public virtual ICollection<BudgetRows> BudgetRows { get; set; }
        public virtual ICollection<Cases> Cases { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<CommentMentions> CommentMentions { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual ICollection<Expenses> Expenses { get; set; }
        public virtual ICollection<FixedAssets> FixedAssets { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<Incomes> Incomes { get; set; }
        public virtual ICollection<Contacts> InversePrimaryContact { get; set; }
        public virtual ICollection<Leads> Leads { get; set; }
        public virtual ICollection<Liabilities> Liabilities { get; set; }
        public virtual ICollection<LiquidAssets> LiquidAssets { get; set; }
        public virtual ICollection<MessageAddresses> MessageAddresses { get; set; }
        public virtual ICollection<Opportunities> Opportunities { get; set; }
        public virtual ICollection<PackagingItems> PackagingItems { get; set; }
        public virtual ICollection<PackagingUnits> PackagingUnits { get; set; }
        public virtual ICollection<Portfolios> Portfolios { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Relationships> RelationshipsContact { get; set; }
        public virtual ICollection<Relationships> RelationshipsRelatedContact { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
        public virtual ICollection<Shipments> ShipmentsBillingContact { get; set; }
        public virtual ICollection<Shipments> ShipmentsContact { get; set; }
        public virtual ICollection<ShippingDepartments> ShippingDepartments { get; set; }
        public virtual ICollection<ShippingPoints> ShippingPoints { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}
