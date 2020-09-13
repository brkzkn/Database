using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class WorkflowLogs
    {
        public int WorkflowLogId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid WorkflowTemplateId { get; set; }
        public Guid? WorkflowInstanceId { get; set; }
        public DateTime DateTimeUtc { get; set; }
        public string Details { get; set; }
        public int LogLevel { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual WorkflowInstances WorkflowInstance { get; set; }
        public virtual WorkflowTemplates WorkflowTemplate { get; set; }
    }
}
