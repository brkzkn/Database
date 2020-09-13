using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SendHooks
    {
        public SendHooks()
        {
            SendHookAttempts = new HashSet<SendHookAttempts>();
        }

        public int SendHookId { get; set; }
        public string SendHookUrl { get; set; }
        public string SendHookPayload { get; set; }
        public int PayloadType { get; set; }
        public int HttpVerb { get; set; }
        public DateTime RequestDate { get; set; }
        public string HttpMessages { get; set; }
        public int? SendHookStatus { get; set; }
        public int? HttpResponse { get; set; }
        public string SendHookSourceId { get; set; }
        public int SendHookSourceType { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public string Signature { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<SendHookAttempts> SendHookAttempts { get; set; }
    }
}
