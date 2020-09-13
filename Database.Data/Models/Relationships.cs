using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Relationships
    {
        public int RelationshipId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public Guid RelatedContactId { get; set; }
        public bool IsDirect { get; set; }
        public bool IsPrimaryOrganisationContact { get; set; }
        public bool IncludeFinancialsInRollup { get; set; }
        public bool IncludeTasksInRollup { get; set; }
        public Guid RelationshipRoleId { get; set; }
        public string Description { get; set; }
        public Guid? ProfileId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual UserProfiles Profile { get; set; }
        public virtual Contacts RelatedContact { get; set; }
        public virtual RelationshipRoles RelationshipRole { get; set; }
    }
}
