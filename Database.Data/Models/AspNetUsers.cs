using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AppEvents = new HashSet<AppEvents>();
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            AuditEvents = new HashSet<AuditEvents>();
            Contacts = new HashSet<Contacts>();
            Employees = new HashSet<Employees>();
            Notifications = new HashSet<Notifications>();
            PendingEmailChanges = new HashSet<PendingEmailChanges>();
            SecurityEventsActionedByUser = new HashSet<SecurityEvents>();
            SecurityEventsUser = new HashSet<SecurityEvents>();
            Staff = new HashSet<Staff>();
            SubscriptionEvents = new HashSet<SubscriptionEvents>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AppEvents> AppEvents { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<AuditEvents> AuditEvents { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<PendingEmailChanges> PendingEmailChanges { get; set; }
        public virtual ICollection<SecurityEvents> SecurityEventsActionedByUser { get; set; }
        public virtual ICollection<SecurityEvents> SecurityEventsUser { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<SubscriptionEvents> SubscriptionEvents { get; set; }
    }
}
