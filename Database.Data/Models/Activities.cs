using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Activities
    {
        public Activities()
        {
            Comments = new HashSet<Comments>();
            TaskWatchers = new HashSet<TaskWatchers>();
        }

        public int ActivityId { get; set; }
        public string ActivitySubject { get; set; }
        public string ActivityDescription { get; set; }
        public int ActivityType { get; set; }
        public int TaskType { get; set; }
        public int TaskPriority { get; set; }
        public bool IsHighPriority { get; set; }
        public int TaskStatus { get; set; }
        public int? WorkFlowId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? DelegatedById { get; set; }
        public int RelatedToWho { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? LeadId { get; set; }
        public int RelatedToWhat { get; set; }
        public Guid? OpportunityId { get; set; }
        public Guid? CaseId { get; set; }
        public int? MessageId { get; set; }
        public int RelatedToDisplay { get; set; }
        public int? SourceImageId { get; set; }
        public string SourceProcess { get; set; }
        public DateTime? DueDate { get; set; }
        public int ReminderPeriod { get; set; }
        public int? CustomReminderPeriod { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Location { get; set; }
        public bool IsClosed { get; set; }
        public Guid? ClosedById { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int RowVersion { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Cases Case { get; set; }
        public virtual Employees ClosedBy { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Employees DelegatedBy { get; set; }
        public virtual Leads Lead { get; set; }
        public virtual Messages Message { get; set; }
        public virtual Opportunities Opportunity { get; set; }
        public virtual Employees Owner { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<TaskWatchers> TaskWatchers { get; set; }
    }
}
