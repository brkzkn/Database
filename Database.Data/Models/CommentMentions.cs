using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CommentMentions
    {
        public int CommentMentionId { get; set; }
        public int CommentId { get; set; }
        public string MentionString { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? LeadId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Comments Comment { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Leads Lead { get; set; }
    }
}
