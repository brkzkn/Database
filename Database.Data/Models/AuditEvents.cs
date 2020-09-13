using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AuditEvents
    {
        public int AuditEventId { get; set; }
        public int AuditEventType { get; set; }
        public DateTime AuditEventDate { get; set; }
        public string EntityName { get; set; }
        public string ModelName { get; set; }
        public string KeyValue { get; set; }
        public string KeyType { get; set; }
        public string ItemUrl { get; set; }
        public string AuditEventSubject { get; set; }
        public string AuditEventDescription { get; set; }
        public string ModelDelta { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
