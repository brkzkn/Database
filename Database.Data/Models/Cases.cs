using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Cases
    {
        public Cases()
        {
            Activities = new HashSet<Activities>();
        }

        public Guid CaseId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? ContactId { get; set; }
        public string CaseSubject { get; set; }
        public string CaseDescription { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReminderDate { get; set; }
        public int CaseStatus { get; set; }
        public bool IsVisibleInSelfService { get; set; }
        public int CaseOrigin { get; set; }
        public int CasePriority { get; set; }
        public bool IsClosed { get; set; }
        public DateTime ClosedDate { get; set; }
        public Guid? ClosedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees ClosedBy { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Employees Owner { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
    }
}
