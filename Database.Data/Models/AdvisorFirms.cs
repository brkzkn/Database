using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AdvisorFirms
    {
        public AdvisorFirms()
        {
            Activities = new HashSet<Activities>();
            AnnualSummaries = new HashSet<AnnualSummaries>();
            ApiAccessTokens = new HashSet<ApiAccessTokens>();
            AppEventProcessedStatus = new HashSet<AppEventProcessedStatus>();
            AppEventSubscribers = new HashSet<AppEventSubscribers>();
            AppEvents = new HashSet<AppEvents>();
            AuditEvents = new HashSet<AuditEvents>();
            BudgetReports = new HashSet<BudgetReports>();
            BudgetRows = new HashSet<BudgetRows>();
            Cases = new HashSet<Cases>();
            CatchHooks = new HashSet<CatchHooks>();
            Cities = new HashSet<Cities>();
            CommentMentions = new HashSet<CommentMentions>();
            Comments = new HashSet<Comments>();
            Contacts = new HashSet<Contacts>();
            CostProfiles = new HashSet<CostProfiles>();
            DeliveryMethods = new HashSet<DeliveryMethods>();
            Documents = new HashSet<Documents>();
            Drawdowns = new HashSet<Drawdowns>();
            Employees = new HashSet<Employees>();
            Expenses = new HashSet<Expenses>();
            FirmAddressBookEntries = new HashSet<FirmAddressBookEntries>();
            FixedAssets = new HashSet<FixedAssets>();
            FlexData = new HashSet<FlexData>();
            FlexTable001 = new HashSet<FlexTable001>();
            FlexTable002 = new HashSet<FlexTable002>();
            Goals = new HashSet<Goals>();
            Incomes = new HashSet<Incomes>();
            Institutions = new HashSet<Institutions>();
            Leads = new HashSet<Leads>();
            Liabilities = new HashSet<Liabilities>();
            LiquidAssets = new HashSet<LiquidAssets>();
            ListViewDefinitions = new HashSet<ListViewDefinitions>();
            Media = new HashSet<Media>();
            Messages = new HashSet<Messages>();
            MetaAppMetaEntityLinks = new HashSet<MetaAppMetaEntityLinks>();
            MetaAppUserProfileLinks = new HashSet<MetaAppUserProfileLinks>();
            MetaApps = new HashSet<MetaApps>();
            MetaCommands = new HashSet<MetaCommands>();
            MetaEntities = new HashSet<MetaEntities>();
            MetaFields = new HashSet<MetaFields>();
            MetaForms = new HashSet<MetaForms>();
            MetaLists = new HashSet<MetaLists>();
            MetaPageTemplates = new HashSet<MetaPageTemplates>();
            MetaPageUserProfileLinks = new HashSet<MetaPageUserProfileLinks>();
            MetaPages = new HashSet<MetaPages>();
            MetaReports = new HashSet<MetaReports>();
            Notifications = new HashSet<Notifications>();
            Opportunities = new HashSet<Opportunities>();
            OrderLines = new HashSet<OrderLines>();
            Orders = new HashSet<Orders>();
            PackagingItems = new HashSet<PackagingItems>();
            PackagingUnits = new HashSet<PackagingUnits>();
            PicklistItems = new HashSet<PicklistItems>();
            Picklists = new HashSet<Picklists>();
            PlanGroups = new HashSet<PlanGroups>();
            PlanItemPriceBrackets = new HashSet<PlanItemPriceBrackets>();
            PlanItems = new HashSet<PlanItems>();
            Plans = new HashSet<Plans>();
            PortfolioLines = new HashSet<PortfolioLines>();
            PortfolioReports = new HashSet<PortfolioReports>();
            PortfolioSecurities = new HashSet<PortfolioSecurities>();
            Portfolios = new HashSet<Portfolios>();
            Products = new HashSet<Products>();
            RecordTypes = new HashSet<RecordTypes>();
            RelationshipRoles = new HashSet<RelationshipRoles>();
            Relationships = new HashSet<Relationships>();
            Securities = new HashSet<Securities>();
            SendHookAttempts = new HashSet<SendHookAttempts>();
            SendHooks = new HashSet<SendHooks>();
            ShipmentItems = new HashSet<ShipmentItems>();
            Shipments = new HashSet<Shipments>();
            ShippingDepartments = new HashSet<ShippingDepartments>();
            ShippingPoints = new HashSet<ShippingPoints>();
            SubscriptionEvents = new HashSet<SubscriptionEvents>();
            SubscriptionItems = new HashSet<SubscriptionItems>();
            Subscriptions = new HashSet<Subscriptions>();
            TaskWatchers = new HashSet<TaskWatchers>();
            Transactions = new HashSet<Transactions>();
            Translations = new HashSet<Translations>();
            UserProfileItems = new HashSet<UserProfileItems>();
            UserProfiles = new HashSet<UserProfiles>();
            ValidationRules = new HashSet<ValidationRules>();
            WorkflowInstances = new HashSet<WorkflowInstances>();
            WorkflowLogs = new HashSet<WorkflowLogs>();
            WorkflowTemplates = new HashSet<WorkflowTemplates>();
        }

        public Guid AdvisorFirmId { get; set; }
        public string CompanyName { get; set; }
        public int Salutation { get; set; }
        public string BillingEmployeeName { get; set; }
        public string BillingEmployeeEmail { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string FullStreetAddress { get; set; }
        public string WebSite { get; set; }
        public string CompanyRegistry { get; set; }
        public string VatNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string AdvisorFirmNotes { get; set; }
        public int AllocationTargetTolerance { get; set; }
        public string TeamEmailAddress { get; set; }
        public int UnidentifiedEmailToHandling { get; set; }
        public bool AutoCreateTaskFromContactMessage { get; set; }
        public bool AutoNotifyDelegatingEmployee { get; set; }
        public bool AutoNotifyManager { get; set; }
        public bool NotifyEmployeeOnTaskAssignment { get; set; }
        public bool NotifyEmployeeOnNewMessageAboutTask { get; set; }
        public bool NotifyReviewerWhenTaskPendingReview { get; set; }
        public bool NotifyTaskOwnerWhenCommentAdded { get; set; }
        public bool NotifyTaskOwnerWhenCommentEdited { get; set; }
        public bool NotifyTaskOwnerWhenCommentDeleted { get; set; }
        public bool NotifyTaskOwnerWhenTaskCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public string ExternalAccountId { get; set; }
        public Guid? DefaultClientId { get; set; }
        public Guid? DefaultBillingId { get; set; }
        public int DefaultLoadingDateOffset { get; set; }
        public int DefaultUnloadingDateOffset { get; set; }
        public Guid? DepartmentId { get; set; }
        public string DefaultBillingClientContactName { get; set; }
        public string DefaultClientContactName { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<AnnualSummaries> AnnualSummaries { get; set; }
        public virtual ICollection<ApiAccessTokens> ApiAccessTokens { get; set; }
        public virtual ICollection<AppEventProcessedStatus> AppEventProcessedStatus { get; set; }
        public virtual ICollection<AppEventSubscribers> AppEventSubscribers { get; set; }
        public virtual ICollection<AppEvents> AppEvents { get; set; }
        public virtual ICollection<AuditEvents> AuditEvents { get; set; }
        public virtual ICollection<BudgetReports> BudgetReports { get; set; }
        public virtual ICollection<BudgetRows> BudgetRows { get; set; }
        public virtual ICollection<Cases> Cases { get; set; }
        public virtual ICollection<CatchHooks> CatchHooks { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<CommentMentions> CommentMentions { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<CostProfiles> CostProfiles { get; set; }
        public virtual ICollection<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<Drawdowns> Drawdowns { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Expenses> Expenses { get; set; }
        public virtual ICollection<FirmAddressBookEntries> FirmAddressBookEntries { get; set; }
        public virtual ICollection<FixedAssets> FixedAssets { get; set; }
        public virtual ICollection<FlexData> FlexData { get; set; }
        public virtual ICollection<FlexTable001> FlexTable001 { get; set; }
        public virtual ICollection<FlexTable002> FlexTable002 { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<Incomes> Incomes { get; set; }
        public virtual ICollection<Institutions> Institutions { get; set; }
        public virtual ICollection<Leads> Leads { get; set; }
        public virtual ICollection<Liabilities> Liabilities { get; set; }
        public virtual ICollection<LiquidAssets> LiquidAssets { get; set; }
        public virtual ICollection<ListViewDefinitions> ListViewDefinitions { get; set; }
        public virtual ICollection<Media> Media { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<MetaAppMetaEntityLinks> MetaAppMetaEntityLinks { get; set; }
        public virtual ICollection<MetaAppUserProfileLinks> MetaAppUserProfileLinks { get; set; }
        public virtual ICollection<MetaApps> MetaApps { get; set; }
        public virtual ICollection<MetaCommands> MetaCommands { get; set; }
        public virtual ICollection<MetaEntities> MetaEntities { get; set; }
        public virtual ICollection<MetaFields> MetaFields { get; set; }
        public virtual ICollection<MetaForms> MetaForms { get; set; }
        public virtual ICollection<MetaLists> MetaLists { get; set; }
        public virtual ICollection<MetaPageTemplates> MetaPageTemplates { get; set; }
        public virtual ICollection<MetaPageUserProfileLinks> MetaPageUserProfileLinks { get; set; }
        public virtual ICollection<MetaPages> MetaPages { get; set; }
        public virtual ICollection<MetaReports> MetaReports { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<Opportunities> Opportunities { get; set; }
        public virtual ICollection<OrderLines> OrderLines { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<PackagingItems> PackagingItems { get; set; }
        public virtual ICollection<PackagingUnits> PackagingUnits { get; set; }
        public virtual ICollection<PicklistItems> PicklistItems { get; set; }
        public virtual ICollection<Picklists> Picklists { get; set; }
        public virtual ICollection<PlanGroups> PlanGroups { get; set; }
        public virtual ICollection<PlanItemPriceBrackets> PlanItemPriceBrackets { get; set; }
        public virtual ICollection<PlanItems> PlanItems { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<PortfolioLines> PortfolioLines { get; set; }
        public virtual ICollection<PortfolioReports> PortfolioReports { get; set; }
        public virtual ICollection<PortfolioSecurities> PortfolioSecurities { get; set; }
        public virtual ICollection<Portfolios> Portfolios { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<RecordTypes> RecordTypes { get; set; }
        public virtual ICollection<RelationshipRoles> RelationshipRoles { get; set; }
        public virtual ICollection<Relationships> Relationships { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
        public virtual ICollection<SendHookAttempts> SendHookAttempts { get; set; }
        public virtual ICollection<SendHooks> SendHooks { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
        public virtual ICollection<Shipments> Shipments { get; set; }
        public virtual ICollection<ShippingDepartments> ShippingDepartments { get; set; }
        public virtual ICollection<ShippingPoints> ShippingPoints { get; set; }
        public virtual ICollection<SubscriptionEvents> SubscriptionEvents { get; set; }
        public virtual ICollection<SubscriptionItems> SubscriptionItems { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
        public virtual ICollection<TaskWatchers> TaskWatchers { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
        public virtual ICollection<Translations> Translations { get; set; }
        public virtual ICollection<UserProfileItems> UserProfileItems { get; set; }
        public virtual ICollection<UserProfiles> UserProfiles { get; set; }
        public virtual ICollection<ValidationRules> ValidationRules { get; set; }
        public virtual ICollection<WorkflowInstances> WorkflowInstances { get; set; }
        public virtual ICollection<WorkflowLogs> WorkflowLogs { get; set; }
        public virtual ICollection<WorkflowTemplates> WorkflowTemplates { get; set; }
    }
}
