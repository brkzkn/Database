using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class WorkflowTemplates
    {
        public WorkflowTemplates()
        {
            WorkflowInstances = new HashSet<WorkflowInstances>();
            WorkflowLogs = new HashSet<WorkflowLogs>();
        }

        public Guid WorkflowTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid EmployeeId { get; set; }
        public string TriggerType { get; set; }
        public string Trigger { get; set; }
        public string Steps { get; set; }
        public string FirstStep { get; set; }
        public int Status { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<WorkflowInstances> WorkflowInstances { get; set; }
        public virtual ICollection<WorkflowLogs> WorkflowLogs { get; set; }
    }
}
