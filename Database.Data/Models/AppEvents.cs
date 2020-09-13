using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AppEvents
    {
        public AppEvents()
        {
            AppEventProcessedStatus = new HashSet<AppEventProcessedStatus>();
        }

        public int EventId { get; set; }
        public string EventTopic { get; set; }
        public string SubTopic { get; set; }
        public string EventSummary { get; set; }
        public string EventPayload { get; set; }
        public string EventDescription { get; set; }
        public string UserId { get; set; }
        public string SchemaName { get; set; }
        public string UniqueId { get; set; }
        public string UniqueIdType { get; set; }
        public DateTime EventDate { get; set; }
        public string UserName { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<AppEventProcessedStatus> AppEventProcessedStatus { get; set; }
    }
}
