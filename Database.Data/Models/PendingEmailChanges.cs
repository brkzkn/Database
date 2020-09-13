using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PendingEmailChanges
    {
        public int PendingEmailChangeId { get; set; }
        public string UserId { get; set; }
        public string CurrentEmail { get; set; }
        public string NewEmail { get; set; }
        public DateTime RequestedTime { get; set; }
        public DateTime? ConfirmedTime { get; set; }
        public string ChangeToken { get; set; }
        public Guid EntityId { get; set; }
        public string EntityType { get; set; }
        public string InitiatingIp { get; set; }
        public string ConfirmingIp { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
