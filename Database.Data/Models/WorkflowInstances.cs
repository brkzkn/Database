using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class WorkflowInstances
    {
        public WorkflowInstances()
        {
            WorkflowLogs = new HashSet<WorkflowLogs>();
        }

        public Guid WorkflowInstanceId { get; set; }
        public Guid WorkflowTemplateId { get; set; }
        public int WorkflowStatus { get; set; }
        public string CurrentStepId { get; set; }
        public string CurrentStepType { get; set; }
        public int StepsCompleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ErrorMessages { get; set; }
        public string SuccessMessages { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid EmployeeId { get; set; }
        public string State { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual WorkflowTemplates WorkflowTemplate { get; set; }
        public virtual ICollection<WorkflowLogs> WorkflowLogs { get; set; }
    }
}
