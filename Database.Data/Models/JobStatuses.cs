using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class JobStatuses
    {
        public int JobStatusId { get; set; }
        public string JobName { get; set; }
        public string JobMessages { get; set; }
        public int JobState { get; set; }
        public int PercentComplete { get; set; }
        public string SubJobDescription { get; set; }
        public int ElapsedTime { get; set; }
        public string HangfireJobId { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}
