using Microsoft.EntityFrameworkCore;
using Database.Data.Models;

namespace Database.Data
{
    public partial class FundMatixTestDatabaseContext : DbContext
    {
        public FundMatixTestDatabaseContext()
        {
        }

        public FundMatixTestDatabaseContext(DbContextOptions<FundMatixTestDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<AdvisorFirms> AdvisorFirms { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AnnualSummaries> AnnualSummaries { get; set; }
        public virtual DbSet<ApiAccessTokens> ApiAccessTokens { get; set; }
        public virtual DbSet<AppEventProcessedStatus> AppEventProcessedStatus { get; set; }
        public virtual DbSet<AppEventSubscribers> AppEventSubscribers { get; set; }
        public virtual DbSet<AppEvents> AppEvents { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AssetClasses> AssetClasses { get; set; }
        public virtual DbSet<AuditEvents> AuditEvents { get; set; }
        public virtual DbSet<Brokers> Brokers { get; set; }
        public virtual DbSet<BudgetReports> BudgetReports { get; set; }
        public virtual DbSet<BudgetRows> BudgetRows { get; set; }
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<CatchHooks> CatchHooks { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CommentMentions> CommentMentions { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<CorporateActionLogs> CorporateActionLogs { get; set; }
        public virtual DbSet<CostProfiles> CostProfiles { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<CurrencyPairs> CurrencyPairs { get; set; }
        public virtual DbSet<CurrencyRates> CurrencyRates { get; set; }
        public virtual DbSet<DailyPrices> DailyPrices { get; set; }
        public virtual DbSet<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Drawdowns> Drawdowns { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Exchanges> Exchanges { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<FirmAddressBookEntries> FirmAddressBookEntries { get; set; }
        public virtual DbSet<FixedAssets> FixedAssets { get; set; }
        public virtual DbSet<FlexData> FlexData { get; set; }
        public virtual DbSet<FlexTable001> FlexTable001 { get; set; }
        public virtual DbSet<FlexTable002> FlexTable002 { get; set; }
        public virtual DbSet<Focuses> Focuses { get; set; }
        public virtual DbSet<Geographies> Geographies { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Incomes> Incomes { get; set; }
        public virtual DbSet<IndexCriteria> IndexCriteria { get; set; }
        public virtual DbSet<Institutions> Institutions { get; set; }
        public virtual DbSet<Issuers> Issuers { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<JobStatuses> JobStatuses { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<Liabilities> Liabilities { get; set; }
        public virtual DbSet<LiquidAssets> LiquidAssets { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<ListViewDefinitions> ListViewDefinitions { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MessageAddresses> MessageAddresses { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MetaAppMetaEntityLinks> MetaAppMetaEntityLinks { get; set; }
        public virtual DbSet<MetaAppUserProfileLinks> MetaAppUserProfileLinks { get; set; }
        public virtual DbSet<MetaApps> MetaApps { get; set; }
        public virtual DbSet<MetaCommands> MetaCommands { get; set; }
        public virtual DbSet<MetaEntities> MetaEntities { get; set; }
        public virtual DbSet<MetaFields> MetaFields { get; set; }
        public virtual DbSet<MetaForms> MetaForms { get; set; }
        public virtual DbSet<MetaLists> MetaLists { get; set; }
        public virtual DbSet<MetaPageTemplates> MetaPageTemplates { get; set; }
        public virtual DbSet<MetaPageUserProfileLinks> MetaPageUserProfileLinks { get; set; }
        public virtual DbSet<MetaPages> MetaPages { get; set; }
        public virtual DbSet<MetaReports> MetaReports { get; set; }
        public virtual DbSet<Niches> Niches { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Opportunities> Opportunities { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PackagingItems> PackagingItems { get; set; }
        public virtual DbSet<PackagingUnits> PackagingUnits { get; set; }
        public virtual DbSet<PendingEmailChanges> PendingEmailChanges { get; set; }
        public virtual DbSet<PicklistItems> PicklistItems { get; set; }
        public virtual DbSet<Picklists> Picklists { get; set; }
        public virtual DbSet<PlanGroups> PlanGroups { get; set; }
        public virtual DbSet<PlanItemPriceBrackets> PlanItemPriceBrackets { get; set; }
        public virtual DbSet<PlanItems> PlanItems { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<PortfolioLines> PortfolioLines { get; set; }
        public virtual DbSet<PortfolioReports> PortfolioReports { get; set; }
        public virtual DbSet<PortfolioSecurities> PortfolioSecurities { get; set; }
        public virtual DbSet<Portfolios> Portfolios { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProxyMap> ProxyMap { get; set; }
        public virtual DbSet<ProxySegments> ProxySegments { get; set; }
        public virtual DbSet<RecordTypes> RecordTypes { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<RelationshipRoles> RelationshipRoles { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Securities> Securities { get; set; }
        public virtual DbSet<SecurityEvents> SecurityEvents { get; set; }
        public virtual DbSet<SecurityExchanges> SecurityExchanges { get; set; }
        public virtual DbSet<SendHookAttempts> SendHookAttempts { get; set; }
        public virtual DbSet<SendHooks> SendHooks { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<ShipmentItems> ShipmentItems { get; set; }
        public virtual DbSet<Shipments> Shipments { get; set; }
        public virtual DbSet<ShippingDepartments> ShippingDepartments { get; set; }
        public virtual DbSet<ShippingPoints> ShippingPoints { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SubscriptionEvents> SubscriptionEvents { get; set; }
        public virtual DbSet<SubscriptionItems> SubscriptionItems { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        public virtual DbSet<TaskWatchers> TaskWatchers { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<UnderlyingIndices> UnderlyingIndices { get; set; }
        public virtual DbSet<UserProfileItems> UserProfileItems { get; set; }
        public virtual DbSet<UserProfiles> UserProfiles { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<ValidationRules> ValidationRules { get; set; }
        public virtual DbSet<WeightingSchemes> WeightingSchemes { get; set; }
        public virtual DbSet<WorkflowInstances> WorkflowInstances { get; set; }
        public virtual DbSet<WorkflowLogs> WorkflowLogs { get; set; }
        public virtual DbSet<WorkflowTemplates> WorkflowTemplates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("Activities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CaseId);

                entity.HasIndex(e => e.ClosedById);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.DelegatedById);

                entity.HasIndex(e => e.LeadId);

                entity.HasIndex(e => e.MessageId);

                entity.HasIndex(e => e.OpportunityId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.ActivitySubject).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.CaseId);

                entity.HasOne(d => d.ClosedBy)
                    .WithMany(p => p.ActivitiesClosedBy)
                    .HasForeignKey(d => d.ClosedById);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.DelegatedBy)
                    .WithMany(p => p.ActivitiesDelegatedBy)
                    .HasForeignKey(d => d.DelegatedById);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.LeadId);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.MessageId);

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.OpportunityId);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ActivitiesOwner)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<AdvisorFirms>(entity =>
            {
                entity.HasKey(e => e.AdvisorFirmId);

                entity.ToTable("AdvisorFirms", "fm");

                entity.HasIndex(e => e.CountryCode);

                entity.HasIndex(e => e.CurrencyCode);

                entity.Property(e => e.AdvisorFirmId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.AdvisorFirms)
                    .HasForeignKey(d => d.CountryCode);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.AdvisorFirms)
                    .HasForeignKey(d => d.CurrencyCode);
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AnnualSummaries>(entity =>
            {
                entity.HasKey(e => e.AnnualSummaryId);

                entity.ToTable("AnnualSummaries", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PortfolioId);

                entity.Property(e => e.AdvisoryFees).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AnnualReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AnnualTurnover).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BrokerageFees).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn01).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn02).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn03).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn04).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn05).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn06).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn07).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn08).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn09).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn10).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn11).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthReturn12).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TradesPerYear).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.YearBeginValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.YearCashInOut).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.YearEndValue).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.AnnualSummaries)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.AnnualSummaries)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ApiAccessTokens>(entity =>
            {
                entity.HasKey(e => e.ApiAccessTokenId);

                entity.ToTable("ApiAccessTokens", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.UserProfileId);

                entity.Property(e => e.ApiAccessTokenId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ApiAccessTokens)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.ApiAccessTokens)
                    .HasForeignKey(d => d.UserProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AppEventProcessedStatus>(entity =>
            {
                entity.ToTable("AppEventProcessedStatus", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => new { e.AppEventId, e.Processor })
                    .IsUnique()
                    .HasFilter("([Processor] IS NOT NULL)");

                entity.Property(e => e.Processor).HasMaxLength(15);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.AppEventProcessedStatus)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AppEvent)
                    .WithMany(p => p.AppEventProcessedStatus)
                    .HasForeignKey(d => d.AppEventId);
            });

            modelBuilder.Entity<AppEventSubscribers>(entity =>
            {
                entity.HasKey(e => e.SubscriberId);

                entity.ToTable("AppEventSubscribers", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.SubscriberId).ValueGeneratedNever();

                entity.Property(e => e.SubscriberName).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.AppEventSubscribers)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AppEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("AppEvents", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EventDate);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.EventTopic)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueIdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.AppEvents)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppEvents)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AssetClasses>(entity =>
            {
                entity.HasKey(e => e.AssetClassId);

                entity.ToTable("AssetClasses", "fm");
            });

            modelBuilder.Entity<AuditEvents>(entity =>
            {
                entity.HasKey(e => e.AuditEventId);

                entity.ToTable("AuditEvents", "fm");

                entity.HasIndex(e => e.AuditEventDate);

                entity.HasIndex(e => e.KeyValue);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.UserName, e.AuditEventDate, e.UserId, e.AdvisorFirmId, e.EntityName, e.KeyValue })
                    .HasName("IX_AuditEvents_AdvisorFirmId_EntityName_KeyValue");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.KeyType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KeyValue)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.Property(e => e.UserName).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.AuditEvents)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Brokers>(entity =>
            {
                entity.HasKey(e => e.BrokerCode);

                entity.ToTable("Brokers", "fm");

                entity.Property(e => e.BrokerCode).HasMaxLength(6);
            });

            modelBuilder.Entity<BudgetReports>(entity =>
            {
                entity.HasKey(e => e.BudgetId);

                entity.ToTable("BudgetReports", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.BudgetReports)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.BudgetReports)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BudgetRows>(entity =>
            {
                entity.HasKey(e => e.BudgetRowId);

                entity.ToTable("BudgetRows", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.BudgetId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.Column01).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column02).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column03).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column04).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column05).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column06).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column07).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column08).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column09).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column10).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column11).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column12).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column13).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column14).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column15).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column16).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column17).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column18).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column19).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column20).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column21).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column22).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column23).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column24).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column25).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column26).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column27).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column28).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column29).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column30).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column31).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column32).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column33).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column34).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column35).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column36).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column37).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column38).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column39).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column40).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column41).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column42).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column43).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column44).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column45).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column46).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column47).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column48).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column49).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column50).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column51).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column52).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column53).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column54).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column55).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column56).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column57).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column58).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column59).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column60).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column61).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column62).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column63).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column64).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column65).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column66).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column67).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column68).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column69).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column70).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column71).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column72).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column73).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column74).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column75).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column76).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column77).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column78).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column79).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column80).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column81).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column82).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column83).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column84).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column85).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column86).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column87).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column88).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column89).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Column90).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.BudgetRows)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.BudgetRows)
                    .HasForeignKey(d => d.BudgetId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.BudgetRows)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Cases>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("Cases", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ClosedById);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.CaseId).ValueGeneratedNever();

                entity.Property(e => e.CaseSubject).HasMaxLength(60);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Cases)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ClosedBy)
                    .WithMany(p => p.CasesClosedBy)
                    .HasForeignKey(d => d.ClosedById);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Cases)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CasesOwner)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<CatchHooks>(entity =>
            {
                entity.HasKey(e => e.WebHookId);

                entity.ToTable("CatchHooks", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.WebHookId).ValueGeneratedNever();

                entity.Property(e => e.WebHookName).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.CatchHooks)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Categories", "fm");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("Cities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.CountryCode);

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName).IsRequired();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ZlegacyCnCode).HasColumnName("ZLegacy_CN_CODE");

                entity.Property(e => e.ZlegacyXcity).HasColumnName("ZLegacy_XCITY");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CommentMentions>(entity =>
            {
                entity.HasKey(e => e.CommentMentionId);

                entity.ToTable("CommentMentions", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.LeadId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.CommentMentions)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentMentions)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CommentMentions)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CommentMentions)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.CommentMentions)
                    .HasForeignKey(d => d.LeadId);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Comments", "fm");

                entity.HasIndex(e => e.ActivityId);

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.LeadId);

                entity.HasIndex(e => e.OpportunityId);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ActivityId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.LeadId);

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.OpportunityId);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("Contacts", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CountryCode);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.MediaId);

                entity.HasIndex(e => e.OwnerId);

                entity.HasIndex(e => e.PostalCountryCode);

                entity.HasIndex(e => e.PrimaryContactId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasIndex(e => e.RecordTypeId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.AnnualSavingsTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssetsUnderManagement).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageRetirementTaxRate).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.ClientEndDate).HasColumnType("date");

                entity.Property(e => e.ClientStartDate).HasColumnType("date");

                entity.Property(e => e.ConsumptionRatio).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ExpectedIncomeGrowth).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ExpenseTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FixedAssetsTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IncomeTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiabilitiesTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiquidAssetsTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PensionAssetsTotal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PostalCountryCode).HasMaxLength(2);

                entity.Property(e => e.RetirementDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.ContactsCountryCodeNavigation)
                    .HasForeignKey(d => d.CountryCode);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.MediaId);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.OwnerId);

                entity.HasOne(d => d.PostalCountryCodeNavigation)
                    .WithMany(p => p.ContactsPostalCountryCodeNavigation)
                    .HasForeignKey(d => d.PostalCountryCode);

                entity.HasOne(d => d.PrimaryContact)
                    .WithMany(p => p.InversePrimaryContact)
                    .HasForeignKey(d => d.PrimaryContactId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ProfileId);

                entity.HasOne(d => d.RecordType)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.RecordTypeId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CorporateActionLogs>(entity =>
            {
                entity.HasKey(e => e.CorporateActionLogId);

                entity.ToTable("CorporateActionLogs", "fm");

                entity.HasIndex(e => e.SecurityId);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.CorporateActionLogs)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CostProfiles>(entity =>
            {
                entity.HasKey(e => e.CostProfileId);

                entity.ToTable("CostProfiles", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.AssetClassId).IsRequired();

                entity.Property(e => e.CostPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EndCostPercent).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.CostProfiles)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("Countries", "fm");

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.Iso3Code)
                    .IsUnique()
                    .HasFilter("([Iso3Code] IS NOT NULL)");

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.CountryName).IsRequired();

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.Iso3Code).HasMaxLength(3);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.CurrencyCode);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode);

                entity.ToTable("Currencies", "fm");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.CurrencyDescription).IsRequired();
            });

            modelBuilder.Entity<CurrencyPairs>(entity =>
            {
                entity.HasKey(e => e.CurrencyPairId);

                entity.ToTable("CurrencyPairs", "fm");

                entity.HasIndex(e => e.BaseCurrencyCode);

                entity.HasIndex(e => e.QuoteCurrencyCode);

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.QuoteCurrencyCode).HasMaxLength(3);

                entity.HasOne(d => d.BaseCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyPairsBaseCurrencyCodeNavigation)
                    .HasForeignKey(d => d.BaseCurrencyCode);

                entity.HasOne(d => d.QuoteCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyPairsQuoteCurrencyCodeNavigation)
                    .HasForeignKey(d => d.QuoteCurrencyCode);
            });

            modelBuilder.Entity<CurrencyRates>(entity =>
            {
                entity.HasKey(e => e.CurrencyRateId);

                entity.ToTable("CurrencyRates", "fm");

                entity.HasIndex(e => new { e.CurrencyPairId, e.RateDate })
                    .HasName("AK_CurrencyRates_CurrencyPairId_RateDate")
                    .IsUnique();

                entity.HasIndex(e => new { e.CurrencyPairId, e.RateDate, e.RateValue });

                entity.Property(e => e.RateDate).HasColumnType("date");

                entity.Property(e => e.RateValue).HasColumnType("decimal(19, 9)");

                entity.HasOne(d => d.CurrencyPair)
                    .WithMany(p => p.CurrencyRates)
                    .HasForeignKey(d => d.CurrencyPairId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DailyPrices>(entity =>
            {
                entity.HasKey(e => e.PriceId);

                entity.ToTable("DailyPrices", "fm");

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => new { e.SecurityId, e.PriceDate });

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DataSource).HasMaxLength(10);

                entity.Property(e => e.DividendPaid).HasColumnType("decimal(19, 9)");

                entity.Property(e => e.PriceAdjustedClose).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceAdjustedHigh).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceAdjustedLow).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceAdjustedOpen).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceClose).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceDate).HasColumnType("date");

                entity.Property(e => e.PriceHigh).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceLow).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceOpen).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.DailyPrices)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.DailyPrices)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DeliveryMethods>(entity =>
            {
                entity.HasKey(e => e.DeliveryMethodId);

                entity.ToTable("DeliveryMethods", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.DeliveryMethodId).ValueGeneratedNever();

                entity.Property(e => e.DeliveryMethodDescription).IsRequired();

                entity.Property(e => e.DeliveryMethodName).IsRequired();

                entity.Property(e => e.ZlegacyXshipMth).HasColumnName("ZLegacy_XSHIP_MTH");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.DeliveryMethods)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DeliveryMethods)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("Documents", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.IssuingCountryCode);

                entity.HasIndex(e => e.MediaId);

                entity.Property(e => e.DocumentId).ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.IssuingCountryCode).HasMaxLength(2);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IssuingCountryCodeNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.IssuingCountryCode);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Drawdowns>(entity =>
            {
                entity.HasKey(e => e.DrawdownId);

                entity.ToTable("Drawdowns", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PortfolioId);

                entity.Property(e => e.DrawdownPercent).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Drawdowns)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.Drawdowns)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Employees", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ManagerId);

                entity.HasIndex(e => e.MediaId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.MediaId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Exchanges>(entity =>
            {
                entity.HasKey(e => e.ExchangeCode);

                entity.ToTable("Exchanges", "fm");

                entity.HasIndex(e => e.CountryCode);

                entity.Property(e => e.ExchangeCode).HasMaxLength(4);

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Exchanges)
                    .HasForeignKey(d => d.CountryCode);
            });

            modelBuilder.Entity<Expenses>(entity =>
            {
                entity.HasKey(e => e.ExpenseId);

                entity.ToTable("Expenses", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.InstitutionId);

                entity.Property(e => e.AnnualExpense).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.MonthlyExpense).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.InstitutionId);
            });

            modelBuilder.Entity<FirmAddressBookEntries>(entity =>
            {
                entity.HasKey(e => e.FirmAddressBookEntryId);

                entity.ToTable("FirmAddressBookEntries", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.FirmAddressBookEntries)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<FixedAssets>(entity =>
            {
                entity.HasKey(e => e.FixedAssetId);

                entity.ToTable("FixedAssets", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.AssetDescription).IsRequired();

                entity.Property(e => e.ExpectedReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LinkedExpenseAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LinkedIncomeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RegisterValue).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.FixedAssets)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.FixedAssets)
                    .HasForeignKey(d => d.ContactId);
            });

            modelBuilder.Entity<FlexData>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("FlexData", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.RowId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.FlexData)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.FlexData)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.FlexData)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<FlexTable001>(entity =>
            {
                entity.HasKey(e => e.FlexTableId);

                entity.ToTable("FlexTable001", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.FlexTableId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.FlexTable001)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.FlexTable001)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<FlexTable002>(entity =>
            {
                entity.HasKey(e => e.FlexTableId);

                entity.ToTable("FlexTable002", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.FlexTableId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.FlexTable002)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.FlexTable002)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<Focuses>(entity =>
            {
                entity.HasKey(e => e.FocusId);

                entity.ToTable("Focuses", "fm");
            });

            modelBuilder.Entity<Geographies>(entity =>
            {
                entity.HasKey(e => e.GeographyId);

                entity.ToTable("Geographies", "fm");
            });

            modelBuilder.Entity<Goals>(entity =>
            {
                entity.HasKey(e => e.GoalId);

                entity.ToTable("Goals", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.DesiredMonthlyIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MinimumMonthlyIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RiskAssetsMax).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RiskAssetsMin).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TargetAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TargetDate).HasColumnType("date");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.ContactId);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Incomes>(entity =>
            {
                entity.HasKey(e => e.IncomeId);

                entity.ToTable("Incomes", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.FixedAssetId);

                entity.HasIndex(e => e.InstitutionId);

                entity.Property(e => e.AnnualDividendIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AnnualIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CarCapitalContribution).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CarExpenseContribution).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CarListPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CarTaxAddBackPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ContributionEndDate).HasColumnType("date");

                entity.Property(e => e.ContributionStartDate).HasColumnType("date");

                entity.Property(e => e.DividendEndDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.MonthlyContribution).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthlyIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OtherEndDate).HasColumnType("date");

                entity.Property(e => e.OtherMonthlyIncome).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PayoutEndDate).HasColumnType("date");

                entity.Property(e => e.PayoutStartDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SurvivorBenefitChild).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SurvivorBenefitPartner).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TerminalValue).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.FixedAsset)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.FixedAssetId);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.InstitutionId);
            });

            modelBuilder.Entity<IndexCriteria>(entity =>
            {
                entity.HasKey(e => e.IndexCriterionId);

                entity.ToTable("IndexCriteria", "fm");
            });

            modelBuilder.Entity<Institutions>(entity =>
            {
                entity.HasKey(e => e.InstitutionId);

                entity.ToTable("Institutions", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CountryCode);

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CountryCode);
            });

            modelBuilder.Entity<Issuers>(entity =>
            {
                entity.HasKey(e => e.IssuerId);

                entity.ToTable("Issuers", "fm");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobStatuses>(entity =>
            {
                entity.HasKey(e => e.JobStatusId);

                entity.ToTable("JobStatuses", "fm");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("Jobs", "fm");

                entity.HasIndex(e => e.JobDescription)
                    .IsUnique();

                entity.Property(e => e.JobDescription).IsRequired();
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.HasKey(e => e.LeadId)
                    .HasName("PK_Lead")
                    .IsClustered(false);

                entity.ToTable("Leads", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ConvertedContactId);

                entity.HasIndex(e => e.CountryCode);

                entity.HasIndex(e => e.LeadIndex)
                    .HasName("IX_Lead")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.LeadName);

                entity.HasIndex(e => e.OpportunityId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.LeadId).ValueGeneratedNever();

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.FinancialAssets).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.JobTitle).HasMaxLength(80);

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.LeadIndex).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ConvertedContact)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.ConvertedContactId);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.CountryCode);

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.OpportunityId);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<Liabilities>(entity =>
            {
                entity.HasKey(e => e.LiabilityId);

                entity.ToTable("Liabilities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InterestRate).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.LiabilityAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiabilityDescription).IsRequired();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Liabilities)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Liabilities)
                    .HasForeignKey(d => d.ContactId);
            });

            modelBuilder.Entity<LiquidAssets>(entity =>
            {
                entity.HasKey(e => e.LiquidAssetId);

                entity.ToTable("LiquidAssets", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.InstitutionId);

                entity.HasIndex(e => e.PortfolioId);

                entity.Property(e => e.AssetDescription).IsRequired();

                entity.Property(e => e.ContributionEndDate).HasColumnType("date");

                entity.Property(e => e.ExpectedReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MonthlyContribution).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TermEndDate).HasColumnType("date");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.LiquidAssets)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.LiquidAssets)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.LiquidAssets)
                    .HasForeignKey(d => d.InstitutionId);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.LiquidAssets)
                    .HasForeignKey(d => d.PortfolioId);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListViewDefinitions>(entity =>
            {
                entity.HasKey(e => e.ListViewDefinitionId);

                entity.ToTable("ListViewDefinitions", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.ListViewDefinitionId).ValueGeneratedNever();

                entity.Property(e => e.ListModel).HasMaxLength(100);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ListViewDefinitions)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ListViewDefinitions)
                    .HasForeignKey(d => d.EntityId);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ListViewDefinitions)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.ToTable("Media", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.MediaId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<MessageAddresses>(entity =>
            {
                entity.HasKey(e => e.MessageAddressId);

                entity.ToTable("MessageAddresses", "fm");

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.LeadId);

                entity.HasIndex(e => e.MessageId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.MessageAddresses)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MessageAddresses)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.MessageAddresses)
                    .HasForeignKey(d => d.LeadId);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageAddresses)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("Messages", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.MessageSubject).HasMaxLength(60);

                entity.Property(e => e.SpamScore).HasColumnType("decimal(16, 8)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MetaAppMetaEntityLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("MetaAppMetaEntityLinks", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.AppId);

                entity.HasIndex(e => e.EntityId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaAppMetaEntityLinks)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.MetaAppMetaEntityLinks)
                    .HasForeignKey(d => d.AppId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaAppMetaEntityLinks)
                    .HasForeignKey(d => d.EntityId);
            });

            modelBuilder.Entity<MetaAppUserProfileLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("MetaAppUserProfileLinks", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.AppId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaAppUserProfileLinks)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.MetaAppUserProfileLinks)
                    .HasForeignKey(d => d.AppId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MetaAppUserProfileLinks)
                    .HasForeignKey(d => d.ProfileId);
            });

            modelBuilder.Entity<MetaApps>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("MetaApps", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppIconColor).HasMaxLength(7);

                entity.Property(e => e.AppLabel).IsRequired();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaApps)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<MetaCommands>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("MetaCommands", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.AppId);

                entity.HasIndex(e => e.EntityId);

                entity.Property(e => e.CommandId).ValueGeneratedNever();

                entity.Property(e => e.CommandLabel).IsRequired();

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaCommands)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.MetaCommands)
                    .HasForeignKey(d => d.AppId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaCommands)
                    .HasForeignKey(d => d.EntityId);
            });

            modelBuilder.Entity<MetaEntities>(entity =>
            {
                entity.HasKey(e => e.EntityId);

                entity.ToTable("MetaEntities", "fm");

                entity.HasIndex(e => e.EntityName);

                entity.HasIndex(e => new { e.AdvisorFirmId, e.EntityName })
                    .IsUnique()
                    .HasFilter("([AdvisorFirmId] IS NOT NULL)");

                entity.Property(e => e.EntityId).ValueGeneratedNever();

                entity.Property(e => e.AllowApiaccess).HasColumnName("AllowAPIAccess");

                entity.Property(e => e.EntityIconColor).HasMaxLength(7);

                entity.Property(e => e.EntityLabel).IsRequired();

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaEntities)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<MetaFields>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("MetaFields", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.HasIndex(e => e.FieldName);

                entity.HasIndex(e => e.LookupEntityId);

                entity.Property(e => e.FieldId).ValueGeneratedNever();

                entity.Property(e => e.FieldLabel).IsRequired();

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaFields)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaFieldsEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LookupEntity)
                    .WithMany(p => p.MetaFieldsLookupEntity)
                    .HasForeignKey(d => d.LookupEntityId);
            });

            modelBuilder.Entity<MetaForms>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("MetaForms", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.Property(e => e.FormId).ValueGeneratedNever();

                entity.Property(e => e.FormLabel).IsRequired();

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaForms)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaForms)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MetaLists>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("MetaLists", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.HasIndex(e => e.FormId);

                entity.Property(e => e.ListId).ValueGeneratedNever();

                entity.Property(e => e.ListLabel).IsRequired();

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaLists)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaLists)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.MetaLists)
                    .HasForeignKey(d => d.FormId);
            });

            modelBuilder.Entity<MetaPageTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("MetaPageTemplates", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.TemplateId).ValueGeneratedNever();

                entity.Property(e => e.TemplateLabel).IsRequired();

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaPageTemplates)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<MetaPageUserProfileLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("MetaPageUserProfileLinks", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PageId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaPageUserProfileLinks)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.MetaPageUserProfileLinks)
                    .HasForeignKey(d => d.PageId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MetaPageUserProfileLinks)
                    .HasForeignKey(d => d.ProfileId);
            });

            modelBuilder.Entity<MetaPages>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("MetaPages", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.HasIndex(e => e.PageType);

                entity.HasIndex(e => e.RecordTypeId);

                entity.Property(e => e.PageId).ValueGeneratedNever();

                entity.Property(e => e.PageIconColor).HasMaxLength(7);

                entity.Property(e => e.PageLabel).IsRequired();

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaPages)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaPages)
                    .HasForeignKey(d => d.EntityId);

                entity.HasOne(d => d.RecordType)
                    .WithMany(p => p.MetaPages)
                    .HasForeignKey(d => d.RecordTypeId);
            });

            modelBuilder.Entity<MetaReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("MetaReports", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.Property(e => e.ReportId).ValueGeneratedNever();

                entity.Property(e => e.ReportLabel).IsRequired();

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.MetaReports)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MetaReports)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Niches>(entity =>
            {
                entity.HasKey(e => e.NicheId);

                entity.ToTable("Niches", "fm");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("Notifications", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Opportunities>(entity =>
            {
                entity.HasKey(e => e.OpportunityId);

                entity.ToTable("Opportunities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ClosedById);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.OpportunityId).ValueGeneratedNever();

                entity.Property(e => e.ExpectedRevenue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FinancialAssets).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OpportunityName).IsRequired();

                entity.Property(e => e.OpportunityType).IsRequired();

                entity.Property(e => e.PlannedClosingDate).HasColumnType("date");

                entity.Property(e => e.PotentialRevenue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Probability).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ClosedBy)
                    .WithMany(p => p.OpportunitiesClosedBy)
                    .HasForeignKey(d => d.ClosedById);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.OpportunitiesOwner)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<OrderLines>(entity =>
            {
                entity.HasKey(e => e.OrderLineId);

                entity.ToTable("OrderLines", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => e.SecurityId);

                entity.Property(e => e.IsinCode).HasMaxLength(12);

                entity.Property(e => e.LimitPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.SecurityId);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Orders", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.AllocationId);

                entity.HasIndex(e => e.BrokerCode);

                entity.Property(e => e.BrokerCode).HasMaxLength(6);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Allocation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AllocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BrokerCode);
            });

            modelBuilder.Entity<PackagingItems>(entity =>
            {
                entity.HasKey(e => e.PackagingItemId);

                entity.ToTable("PackagingItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.LoadingPointId);

                entity.HasIndex(e => e.LoadingUnitId);

                entity.HasIndex(e => e.ShipmentId);

                entity.HasIndex(e => e.UnloadingPointId);

                entity.HasIndex(e => e.UnloadingUnitId);

                entity.Property(e => e.LoadingQuantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnloadingQuantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ZlegacyColTyp1).HasColumnName("ZLegacy_COL_TYP1");

                entity.Property(e => e.ZlegacyColTyp2).HasColumnName("ZLegacy_COL_TYP2");

                entity.Property(e => e.ZlegacyLocation1).HasColumnName("ZLegacy_LOCATION1");

                entity.Property(e => e.ZlegacyLocation2).HasColumnName("ZLegacy_LOCATION2");

                entity.Property(e => e.ZlegacyTrOrd).HasColumnName("ZLegacy_TR_ORD");

                entity.Property(e => e.ZlegacyXnew).HasColumnName("ZLegacy_XNEW");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PackagingItems)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PackagingItems)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LoadingPoint)
                    .WithMany(p => p.PackagingItemsLoadingPoint)
                    .HasForeignKey(d => d.LoadingPointId);

                entity.HasOne(d => d.LoadingUnit)
                    .WithMany(p => p.PackagingItemsLoadingUnit)
                    .HasForeignKey(d => d.LoadingUnitId);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.PackagingItems)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.UnloadingPoint)
                    .WithMany(p => p.PackagingItemsUnloadingPoint)
                    .HasForeignKey(d => d.UnloadingPointId);

                entity.HasOne(d => d.UnloadingUnit)
                    .WithMany(p => p.PackagingItemsUnloadingUnit)
                    .HasForeignKey(d => d.UnloadingUnitId);
            });

            modelBuilder.Entity<PackagingUnits>(entity =>
            {
                entity.HasKey(e => e.PackagingUnitId);

                entity.ToTable("PackagingUnits", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.PackagingUnitId).ValueGeneratedNever();

                entity.Property(e => e.PackagingHeight).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PackagingLength).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PackagingUnitName).IsRequired();

                entity.Property(e => e.PackagingWidth).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ZlegacyXunitCode).HasColumnName("ZLegacy_XUNIT_CODE");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PackagingUnits)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PackagingUnits)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PendingEmailChanges>(entity =>
            {
                entity.HasKey(e => e.PendingEmailChangeId);

                entity.ToTable("PendingEmailChanges", "fm");

                entity.HasIndex(e => e.ChangeToken)
                    .IsUnique()
                    .HasFilter("([ChangeToken] IS NOT NULL)");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PendingEmailChanges)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<PicklistItems>(entity =>
            {
                entity.HasKey(e => e.PicklistItemId);

                entity.ToTable("PicklistItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PicklistId);

                entity.HasIndex(e => e.PicklistName);

                entity.Property(e => e.PicklistItemName).HasMaxLength(100);

                entity.Property(e => e.PicklistName).HasMaxLength(50);

                entity.Property(e => e.Probability).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PicklistItems)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Picklist)
                    .WithMany(p => p.PicklistItems)
                    .HasForeignKey(d => d.PicklistId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Picklists>(entity =>
            {
                entity.HasKey(e => e.PicklistId);

                entity.ToTable("Picklists", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.PicklistName).HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Picklists)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<PlanGroups>(entity =>
            {
                entity.HasKey(e => e.PlanGroupId);

                entity.ToTable("PlanGroups", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.PlanGroupId).ValueGeneratedNever();

                entity.Property(e => e.PlanGroupCode).HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PlanGroups)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PlanItemPriceBrackets>(entity =>
            {
                entity.HasKey(e => e.PriceBracketId);

                entity.ToTable("PlanItemPriceBrackets", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PlanItemId);

                entity.HasIndex(e => e.SubscriptionItemItemId);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PlanItemPriceBrackets)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.PlanItemPriceBrackets)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SubscriptionItemItem)
                    .WithMany(p => p.PlanItemPriceBrackets)
                    .HasForeignKey(d => d.SubscriptionItemItemId);
            });

            modelBuilder.Entity<PlanItems>(entity =>
            {
                entity.HasKey(e => e.PlanItemId);

                entity.ToTable("PlanItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PlanId);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatCode).HasMaxLength(25);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Plans>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("Plans", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.PlanCode)
                    .IsUnique();

                entity.HasIndex(e => e.PlanGroupId);

                entity.Property(e => e.PlanId).ValueGeneratedNever();

                entity.Property(e => e.AccountingCategory1).HasMaxLength(25);

                entity.Property(e => e.AccountingCategory2).HasMaxLength(25);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DiscountedPeriodPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PlanCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlanName).IsRequired();

                entity.Property(e => e.RevenueAccount).HasMaxLength(25);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.PlanGroup)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.PlanGroupId);
            });

            modelBuilder.Entity<PortfolioLines>(entity =>
            {
                entity.HasKey(e => e.PortfolioLineId);

                entity.ToTable("PortfolioLines", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.PortfolioId);

                entity.HasIndex(e => e.PortfolioReportId);

                entity.HasIndex(e => e.SecurityId);

                entity.Property(e => e.CurrencyAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(19, 9)");

                entity.Property(e => e.IsinCode).HasMaxLength(12);

                entity.Property(e => e.ReportAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.Property(e => e.SharePrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PortfolioLines)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.PortfolioLines)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PortfolioLines)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PortfolioReport)
                    .WithMany(p => p.PortfolioLines)
                    .HasForeignKey(d => d.PortfolioReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.PortfolioLines)
                    .HasForeignKey(d => d.SecurityId);
            });

            modelBuilder.Entity<PortfolioReports>(entity =>
            {
                entity.HasKey(e => e.PortfolioReportId);

                entity.ToTable("PortfolioReports", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.PortfolioId);

                entity.Property(e => e.CashInOut).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CumulativeDrawdownPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodBeginValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodBeginValueExCash).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodEndValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodEndValueExCash).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodReturnAmountExCash).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PeriodReturnPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RiskFreeRate).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Rolling12MonthReturn).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PortfolioReports)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PortfolioReports)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PortfolioSecurities>(entity =>
            {
                entity.HasKey(e => e.PortfolioSecurityId);

                entity.ToTable("PortfolioSecurities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.FixedAssets);

                entity.HasIndex(e => e.PortfolioId);

                entity.HasIndex(e => e.SecurityId);

                entity.Property(e => e.BaseWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CalcResult1).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CalcResult2).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CalcResult3).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CalcResult4).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CalcResult5).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.Property(e => e.TargetWeight).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.PortfolioSecurities)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.FixedAssetsNavigation)
                    .WithMany(p => p.PortfolioSecurities)
                    .HasForeignKey(d => d.FixedAssets);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PortfolioSecurities)
                    .HasForeignKey(d => d.PortfolioId);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.PortfolioSecurities)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Portfolios>(entity =>
            {
                entity.HasKey(e => e.PortfolioId);

                entity.ToTable("Portfolios", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.OutOfMarketAssetSecurityId);

                entity.HasIndex(e => e.RiskFreeRateSecurityId);

                entity.Property(e => e.PortfolioId).ValueGeneratedNever();

                entity.Property(e => e.AdvisoryFeePercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AllocationSum).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AnnualTurnoverPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageDaysInTrade).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AverageDrawdownLength).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AverageTradeLoss).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageTradesYear).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AverageTradingCostsYear).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageWiningTrade).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BenchmarkCorrelation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BestMonthReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BestTrade).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BestYearReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BrokerageFeePercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Cagr).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FinalBalance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InitialBalance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaxDrawdown).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MaxDrawdownLength).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PercentWinningMonths).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PercentWinningYears).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PortfolioName).IsRequired();

                entity.Property(e => e.Positive12MonthPeriods).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SharpeRatio).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SlippageCostPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SortinoRatio).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StandardDeviation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TargetVolatility).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TotalReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WinningTradesPercent).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WorstMonthReturn).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WorstTrade).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WorstYearReturn).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Portfolios)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Portfolios)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Portfolios)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.OutOfMarketAssetSecurity)
                    .WithMany(p => p.PortfoliosOutOfMarketAssetSecurity)
                    .HasForeignKey(d => d.OutOfMarketAssetSecurityId);

                entity.HasOne(d => d.RiskFreeRateSecurity)
                    .WithMany(p => p.PortfoliosRiskFreeRateSecurity)
                    .HasForeignKey(d => d.RiskFreeRateSecurityId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Products", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.IsAdrgoods).HasColumnName("IsADRGoods");

                entity.Property(e => e.ProductCode).IsRequired();

                entity.Property(e => e.ProductDescription).IsRequired();

                entity.Property(e => e.ZlegacyXgdsCode).HasColumnName("ZLegacy_XGDS_CODE");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProxyMap>(entity =>
            {
                entity.ToTable("ProxyMap", "fm");

                entity.HasIndex(e => e.ProxySegmentId);

                entity.HasIndex(e => e.SecurityId);

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ProxySegment)
                    .WithMany(p => p.ProxyMap)
                    .HasForeignKey(d => d.ProxySegmentId);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.ProxyMap)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProxySegments>(entity =>
            {
                entity.HasKey(e => e.ProxySegmentId);

                entity.ToTable("ProxySegments", "fm");

                entity.HasIndex(e => e.AssetClassId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.FocusId);

                entity.HasIndex(e => e.GeographyId);

                entity.HasIndex(e => e.NicheId);

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.ProxySegments)
                    .HasForeignKey(d => d.AssetClassId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProxySegments)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Focus)
                    .WithMany(p => p.ProxySegments)
                    .HasForeignKey(d => d.FocusId);

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.ProxySegments)
                    .HasForeignKey(d => d.GeographyId);

                entity.HasOne(d => d.Niche)
                    .WithMany(p => p.ProxySegments)
                    .HasForeignKey(d => d.NicheId);
            });

            modelBuilder.Entity<RecordTypes>(entity =>
            {
                entity.HasKey(e => e.RecordTypeId);

                entity.ToTable("RecordTypes", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.Property(e => e.RecordTypeId).ValueGeneratedNever();

                entity.Property(e => e.RecordTypeLabel).IsRequired();

                entity.Property(e => e.RecordTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.RecordTypes)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.RecordTypes)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("Regions", "fm");
            });

            modelBuilder.Entity<RelationshipRoles>(entity =>
            {
                entity.HasKey(e => e.RelationshipRoleId);

                entity.ToTable("RelationshipRoles", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ReverseRoleId);

                entity.Property(e => e.RelationshipRoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.RelationshipRoles)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ReverseRole)
                    .WithMany(p => p.InverseReverseRole)
                    .HasForeignKey(d => d.ReverseRoleId);
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("Relationships", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasIndex(e => e.RelatedContactId);

                entity.HasIndex(e => e.RelationshipRoleId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.RelationshipsContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.ProfileId);

                entity.HasOne(d => d.RelatedContact)
                    .WithMany(p => p.RelationshipsRelatedContact)
                    .HasForeignKey(d => d.RelatedContactId);

                entity.HasOne(d => d.RelationshipRole)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.RelationshipRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Securities>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("Securities", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.AssetClassId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CountryCode);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.FocusId);

                entity.HasIndex(e => e.GeographyId);

                entity.HasIndex(e => e.IssuerId);

                entity.HasIndex(e => e.NicheId);

                entity.HasIndex(e => e.RegionId);

                entity.HasIndex(e => e.SecuritySymbol);

                entity.HasIndex(e => e.SelectionCriteriaId);

                entity.HasIndex(e => e.UnderlyingIndexId);

                entity.HasIndex(e => e.WeightingSchemeId);

                entity.Property(e => e.AssetsUnderManagement).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageDailyDollarVolume).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AverageSpread).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BondDuration).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CikCode).HasMaxLength(10);

                entity.Property(e => e.CloseDate).HasColumnType("date");

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.CreditQuality).HasMaxLength(4);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.CusipCode).HasMaxLength(10);

                entity.Property(e => e.ExpenseRatio).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InceptionDate).HasColumnType("date");

                entity.Property(e => e.IsinCode).HasMaxLength(12);

                entity.Property(e => e.LeverageFactor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ProxyEndDate).HasColumnType("date");

                entity.Property(e => e.SecurityName).IsRequired();

                entity.Property(e => e.SecuritySymbol)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.AssetClassId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.CountryCode);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.Focus)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.FocusId);

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.GeographyId);

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.IssuerId);

                entity.HasOne(d => d.Niche)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.NicheId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.RegionId);

                entity.HasOne(d => d.SelectionCriteria)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.SelectionCriteriaId);

                entity.HasOne(d => d.UnderlyingIndex)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.UnderlyingIndexId);

                entity.HasOne(d => d.WeightingScheme)
                    .WithMany(p => p.Securities)
                    .HasForeignKey(d => d.WeightingSchemeId);
            });

            modelBuilder.Entity<SecurityEvents>(entity =>
            {
                entity.HasKey(e => e.SecurityEventId);

                entity.ToTable("SecurityEvents", "fm");

                entity.HasIndex(e => e.ActionedByUserId);

                entity.HasIndex(e => e.HasBeenAnalysed)
                    .HasFilter("([HasBeenAnalysed]=(0))");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.ActionedByUserId).HasMaxLength(36);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.ActionedByUser)
                    .WithMany(p => p.SecurityEventsActionedByUser)
                    .HasForeignKey(d => d.ActionedByUserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecurityEventsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<SecurityExchanges>(entity =>
            {
                entity.HasKey(e => e.SecurityExchangeId);

                entity.ToTable("SecurityExchanges", "fm");

                entity.HasIndex(e => e.BrokerCode);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.ExchangeCode);

                entity.HasIndex(e => e.SecurityId);

                entity.Property(e => e.BrokerCode).HasMaxLength(6);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeCode).HasMaxLength(4);

                entity.Property(e => e.IsinCode).HasMaxLength(12);

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.SecurityExchanges)
                    .HasForeignKey(d => d.BrokerCode);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.SecurityExchanges)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.ExchangeCodeNavigation)
                    .WithMany(p => p.SecurityExchanges)
                    .HasForeignKey(d => d.ExchangeCode);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.SecurityExchanges)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SendHookAttempts>(entity =>
            {
                entity.HasKey(e => e.SendHookAttemptId);

                entity.ToTable("SendHookAttempts", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.SendHookId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.SendHookAttempts)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SendHook)
                    .WithMany(p => p.SendHookAttempts)
                    .HasForeignKey(d => d.SendHookId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SendHooks>(entity =>
            {
                entity.HasKey(e => e.SendHookId);

                entity.ToTable("SendHooks", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.SendHooks)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShipmentItems>(entity =>
            {
                entity.HasKey(e => e.ShipmentItemId);

                entity.ToTable("ShipmentItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.PackagingUnitId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ShipmentId);

                entity.Property(e => e.IsAdrgoods).HasColumnName("IsADRGoods");

                entity.Property(e => e.LoadingMeters).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PackagingHeight).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PackagingLength).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PackagingQuantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.PackagingVolume).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.PackagingWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PackagingWidth).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ZlegacyCollitype).HasColumnName("ZLegacy_COLLITYPE");

                entity.Property(e => e.ZlegacyGdsCode).HasColumnName("ZLegacy_GDS_CODE");

                entity.Property(e => e.ZlegacyTrOrd).HasColumnName("ZLegacy_TR_ORD");

                entity.Property(e => e.ZlegacyXnew).HasColumnName("ZLegacy_XNEW");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PackagingUnit)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.PackagingUnitId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId);
            });

            modelBuilder.Entity<Shipments>(entity =>
            {
                entity.HasKey(e => e.ShipmentId);

                entity.ToTable("Shipments", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.BillingContactId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.DeliveryMethodId);

                entity.HasIndex(e => e.LoadingCityId);

                entity.HasIndex(e => e.LoadingCountryCode);

                entity.HasIndex(e => e.LoadingPointId);

                entity.HasIndex(e => e.ShippingDepartmentId);

                entity.HasIndex(e => e.UnloadingCityId);

                entity.HasIndex(e => e.UnloadingCountryCode);

                entity.HasIndex(e => e.UnloadingPointId);

                entity.Property(e => e.LoadingCountryCode).HasMaxLength(2);

                entity.Property(e => e.UnloadingCountryCode).HasMaxLength(2);

                entity.Property(e => e.ZlegacyDCity).HasColumnName("ZLegacy_D_CITY");

                entity.Property(e => e.ZlegacyDCode).HasColumnName("ZLegacy_D_CODE");

                entity.Property(e => e.ZlegacyDCountry).HasColumnName("ZLegacy_D_COUNTRY");

                entity.Property(e => e.ZlegacyLCity).HasColumnName("ZLegacy_L_CITY");

                entity.Property(e => e.ZlegacyLCode).HasColumnName("ZLegacy_L_CODE");

                entity.Property(e => e.ZlegacyLCountry).HasColumnName("ZLegacy_L_COUNTRY");

                entity.Property(e => e.ZlegacyRplDel).HasColumnName("ZLegacy_RPL_DEL");

                entity.Property(e => e.ZlegacyRplInv).HasColumnName("ZLegacy_RPL_INV");

                entity.Property(e => e.ZlegacyTerms).HasColumnName("ZLegacy_TERMS");

                entity.Property(e => e.ZlegacyTrOrd).HasColumnName("ZLegacy_TR_ORD");

                entity.Property(e => e.ZlegacyTrafiek).HasColumnName("ZLegacy_TRAFIEK");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BillingContact)
                    .WithMany(p => p.ShipmentsBillingContact)
                    .HasForeignKey(d => d.BillingContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ShipmentsContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DeliveryMethod)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.DeliveryMethodId);

                entity.HasOne(d => d.LoadingCity)
                    .WithMany(p => p.ShipmentsLoadingCity)
                    .HasForeignKey(d => d.LoadingCityId);

                entity.HasOne(d => d.LoadingCountryCodeNavigation)
                    .WithMany(p => p.ShipmentsLoadingCountryCodeNavigation)
                    .HasForeignKey(d => d.LoadingCountryCode);

                entity.HasOne(d => d.LoadingPoint)
                    .WithMany(p => p.ShipmentsLoadingPoint)
                    .HasForeignKey(d => d.LoadingPointId);

                entity.HasOne(d => d.ShippingDepartment)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ShippingDepartmentId);

                entity.HasOne(d => d.UnloadingCity)
                    .WithMany(p => p.ShipmentsUnloadingCity)
                    .HasForeignKey(d => d.UnloadingCityId);

                entity.HasOne(d => d.UnloadingCountryCodeNavigation)
                    .WithMany(p => p.ShipmentsUnloadingCountryCodeNavigation)
                    .HasForeignKey(d => d.UnloadingCountryCode);

                entity.HasOne(d => d.UnloadingPoint)
                    .WithMany(p => p.ShipmentsUnloadingPoint)
                    .HasForeignKey(d => d.UnloadingPointId);
            });

            modelBuilder.Entity<ShippingDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("ShippingDepartments", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentDescription).IsRequired();

                entity.Property(e => e.DepartmentName).IsRequired();

                entity.Property(e => e.ZlegacyXtrafiek).HasColumnName("ZLegacy_XTRAFIEK");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ShippingDepartments)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ShippingDepartments)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ShippingPoints>(entity =>
            {
                entity.HasKey(e => e.ShippingPointId);

                entity.ToTable("ShippingPoints", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.CountryCode);

                entity.Property(e => e.ShippingPointId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ShippingPoints)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ShippingPoints)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ShippingPoints)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.ShippingPoints)
                    .HasForeignKey(d => d.CountryCode);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff", "fm");

                entity.HasIndex(e => e.MediaId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.StaffId).ValueGeneratedNever();

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.MediaId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<SubscriptionEvents>(entity =>
            {
                entity.HasKey(e => e.SubscriptionEventId);

                entity.ToTable("SubscriptionEvents", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.SubscriptionId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.SubscriptionEvents)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionEvents)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubscriptionEvents)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SubscriptionItems>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("SubscriptionItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.SubscriptionId);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatCode).HasMaxLength(25);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.SubscriptionItems)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionItems)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("Subscriptions", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.PlanId);

                entity.Property(e => e.SubscriptionId).ValueGeneratedNever();

                entity.Property(e => e.TotalDueAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SystemSettings>(entity =>
            {
                entity.HasKey(e => e.KeyName);

                entity.ToTable("SystemSettings", "fm");

                entity.Property(e => e.KeyName).HasMaxLength(256);
            });

            modelBuilder.Entity<TaskWatchers>(entity =>
            {
                entity.HasKey(e => e.TaskWatcherId);

                entity.ToTable("TaskWatchers", "fm");

                entity.HasIndex(e => e.ActivityId);

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TaskWatchers)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.TaskWatchers)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TaskWatchers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Transactions", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.CurrencyCode);

                entity.HasIndex(e => e.LiquidAssetId);

                entity.HasIndex(e => e.SecurityId);

                entity.HasIndex(e => new { e.PortfolioId, e.TransactionDate });

                entity.Property(e => e.CurrencyAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.IsinCode).HasMaxLength(12);

                entity.Property(e => e.SecuritySymbol).HasMaxLength(20);

                entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CurrencyCode);

                entity.HasOne(d => d.LiquidAsset)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.LiquidAssetId);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.SecurityId);
            });

            modelBuilder.Entity<Translations>(entity =>
            {
                entity.HasKey(e => e.TranslationId);

                entity.ToTable("Translations", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.StringId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.Translations)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<UnderlyingIndices>(entity =>
            {
                entity.HasKey(e => e.UnderlyingIndexId);

                entity.ToTable("UnderlyingIndices", "fm");
            });

            modelBuilder.Entity<UserProfileItems>(entity =>
            {
                entity.HasKey(e => e.ProfileItemId);

                entity.ToTable("UserProfileItems", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => new { e.ProfileId, e.PermissionType, e.ScopeId });

                entity.Property(e => e.ProfileItemId).ValueGeneratedNever();

                entity.Property(e => e.ProfileItemName).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.UserProfileItems)
                    .HasForeignKey(d => d.AdvisorFirmId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.UserProfileItems)
                    .HasForeignKey(d => d.ProfileId);
            });

            modelBuilder.Entity<UserProfiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("UserProfiles", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.ProfileId).ValueGeneratedNever();

                entity.Property(e => e.ProfileName).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.AdvisorFirmId);
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.HasKey(e => e.UserSettingId);

                entity.ToTable("UserSettings", "fm");

                entity.HasIndex(e => new { e.UserId, e.KeyName })
                    .IsUnique();

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<ValidationRules>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("ValidationRules", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.EntityId);

                entity.Property(e => e.RuleLabel).IsRequired();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.ValidationRules)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ValidationRules)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WeightingSchemes>(entity =>
            {
                entity.HasKey(e => e.WeightingSchemeId);

                entity.ToTable("WeightingSchemes", "fm");
            });

            modelBuilder.Entity<WorkflowInstances>(entity =>
            {
                entity.HasKey(e => e.WorkflowInstanceId);

                entity.ToTable("WorkflowInstances", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.WorkflowTemplateId);

                entity.Property(e => e.WorkflowInstanceId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.WorkflowInstances)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkflowTemplate)
                    .WithMany(p => p.WorkflowInstances)
                    .HasForeignKey(d => d.WorkflowTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkflowLogs>(entity =>
            {
                entity.HasKey(e => e.WorkflowLogId);

                entity.ToTable("WorkflowLogs", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.HasIndex(e => e.WorkflowInstanceId);

                entity.HasIndex(e => e.WorkflowTemplateId);

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.WorkflowLogs)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkflowInstance)
                    .WithMany(p => p.WorkflowLogs)
                    .HasForeignKey(d => d.WorkflowInstanceId);

                entity.HasOne(d => d.WorkflowTemplate)
                    .WithMany(p => p.WorkflowLogs)
                    .HasForeignKey(d => d.WorkflowTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkflowTemplates>(entity =>
            {
                entity.HasKey(e => e.WorkflowTemplateId);

                entity.ToTable("WorkflowTemplates", "fm");

                entity.HasIndex(e => e.AdvisorFirmId);

                entity.Property(e => e.WorkflowTemplateId).ValueGeneratedNever();

                entity.HasOne(d => d.AdvisorFirm)
                    .WithMany(p => p.WorkflowTemplates)
                    .HasForeignKey(d => d.AdvisorFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
