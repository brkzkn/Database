using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SendHookAttempts
    {
        public int SendHookAttemptId { get; set; }
        public int SendHookId { get; set; }
        public DateTime RequestDate { get; set; }
        public int? HttpResponse { get; set; }
        public string HttpMessages { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual SendHooks SendHook { get; set; }
    }
}
