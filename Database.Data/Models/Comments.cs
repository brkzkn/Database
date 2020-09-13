using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Comments
    {
        public Comments()
        {
            CommentMentions = new HashSet<CommentMentions>();
        }

        public int CommentId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid? ContactId { get; set; }
        public int? ActivityId { get; set; }
        public Guid? OpportunityId { get; set; }
        public Guid? LeadId { get; set; }
        public string CommentBody { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Leads Lead { get; set; }
        public virtual Opportunities Opportunity { get; set; }
        public virtual ICollection<CommentMentions> CommentMentions { get; set; }
    }
}
