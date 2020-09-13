using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AppEventSubscribers
    {
        public Guid SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberDescription { get; set; }
        public string SendHookUrl { get; set; }
        public int HttpVerb { get; set; }
        public int PayloadType { get; set; }
        public string TransFormPayload { get; set; }
        public string ClientSecret { get; set; }
        public string EventTopics { get; set; }
        public string EventSubTopics { get; set; }
        public bool WaitForWebhook { get; set; }
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
