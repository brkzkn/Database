using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ApiAccessTokens
    {
        public Guid ApiAccessTokenId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public string Name { get; set; }
        public DateTime GeneratedDate { get; set; }
        public Guid UserProfileId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual UserProfiles UserProfile { get; set; }
    }
}
