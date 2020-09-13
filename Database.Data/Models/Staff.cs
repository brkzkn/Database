using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Staff
    {
        public Guid StaffId { get; set; }
        public string UserId { get; set; }
        public Guid ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffName { get; set; }
        public string StaffNotes { get; set; }
        public Guid? MediaId { get; set; }
        public string LinkedInPage { get; set; }
        public string FacebookPage { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual Media Media { get; set; }
        public virtual UserProfiles Profile { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
