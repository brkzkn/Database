using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AppEventProcessedStatus
    {
        public int AppEventProcessedStatusId { get; set; }
        public int AppEventId { get; set; }
        public string Processor { get; set; }
        public DateTime DateTime { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual AppEvents AppEvent { get; set; }
    }
}
