using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class UserProfileItems
    {
        public Guid ProfileItemId { get; set; }
        public Guid ProfileId { get; set; }
        public string ProfileItemName { get; set; }
        public string ProfileItemDescription { get; set; }
        public string ScopeId { get; set; }
        public int PermissionType { get; set; }
        public int EntityOwnerType { get; set; }
        public bool IsRecordOwnerEntity { get; set; }
        public bool IsSelfContext { get; set; }
        public bool CreateEnabled { get; set; }
        public bool ReadEnabled { get; set; }
        public bool UpdateEnabled { get; set; }
        public bool DeleteEnabled { get; set; }
        public bool AssignEnabled { get; set; }
        public int EntityAccess { get; set; }
        public int SelfAccess { get; set; }
        public bool ActionEnabled { get; set; }
        public string ItemIconName { get; set; }
        public string ItemIconColor { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual UserProfiles Profile { get; set; }
    }
}
