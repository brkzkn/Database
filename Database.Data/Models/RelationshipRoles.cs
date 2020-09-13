using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class RelationshipRoles
    {
        public RelationshipRoles()
        {
            InverseReverseRole = new HashSet<RelationshipRoles>();
            Relationships = new HashSet<Relationships>();
        }

        public Guid RelationshipRoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public Guid? ReverseRoleId { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsPartner { get; set; }
        public bool IsDependent { get; set; }
        public bool IsGuardian { get; set; }
        public int DisplayOrder { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual RelationshipRoles ReverseRole { get; set; }
        public virtual ICollection<RelationshipRoles> InverseReverseRole { get; set; }
        public virtual ICollection<Relationships> Relationships { get; set; }
    }
}
