using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class SecurityEvents
    {
        public int SecurityEventId { get; set; }
        public string UserId { get; set; }
        public string ActionedByUserId { get; set; }
        public int EventType { get; set; }
        public string MoreDetails { get; set; }
        public DateTime EventTimeUtc { get; set; }
        public string AgentDescription { get; set; }
        public string UserAgentString { get; set; }
        public string BrowserName { get; set; }
        public string OsName { get; set; }
        public string Device { get; set; }
        public string IpNumber { get; set; }
        public string IpCountry { get; set; }
        public string IpRegion { get; set; }
        public string IpCity { get; set; }
        public bool HasBeenAnalysed { get; set; }

        public virtual AspNetUsers ActionedByUser { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
