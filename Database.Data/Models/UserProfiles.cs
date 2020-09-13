using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class UserProfiles
    {
        public UserProfiles()
        {
            ApiAccessTokens = new HashSet<ApiAccessTokens>();
            Contacts = new HashSet<Contacts>();
            Employees = new HashSet<Employees>();
            MetaAppUserProfileLinks = new HashSet<MetaAppUserProfileLinks>();
            MetaPageUserProfileLinks = new HashSet<MetaPageUserProfileLinks>();
            Relationships = new HashSet<Relationships>();
            Staff = new HashSet<Staff>();
            UserProfileItems = new HashSet<UserProfileItems>();
        }

        public Guid ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string ProfileDescription { get; set; }
        public int UserType { get; set; }
        public bool CanViewAllData { get; set; }
        public bool CanModifyAllData { get; set; }
        public bool IsAdministrator { get; set; }
        public int PrimaryGroupAccess { get; set; }
        public int GroupAccessType { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<ApiAccessTokens> ApiAccessTokens { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<MetaAppUserProfileLinks> MetaAppUserProfileLinks { get; set; }
        public virtual ICollection<MetaPageUserProfileLinks> MetaPageUserProfileLinks { get; set; }
        public virtual ICollection<Relationships> Relationships { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<UserProfileItems> UserProfileItems { get; set; }
    }
}
