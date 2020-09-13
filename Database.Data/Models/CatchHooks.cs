using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CatchHooks
    {
        public Guid WebHookId { get; set; }
        public string WebHookName { get; set; }
        public string EventTopic { get; set; }
        public string EventSubTopic { get; set; }
        public string WebHookDescription { get; set; }
        public string WebHookUrl { get; set; }
        public string FilterCondition { get; set; }
        public Guid WorkflowTemplateId { get; set; }
        public int SecurityEventId { get; set; }
        public bool SaveAppEvent { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
    }
}
