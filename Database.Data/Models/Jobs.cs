using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Jobs
    {
        public int JobId { get; set; }
        public string HangfireJobId { get; set; }
        public bool HangfireJobActive { get; set; }
        public string JobDescription { get; set; }
        public string JobMethodCall { get; set; }
        public int ScheduleType { get; set; }
        public string ScheduleDescription { get; set; }
        public int MinuteInterval { get; set; }
        public int HourInterval { get; set; }
        public int MinuteOffset { get; set; }
        public int DayInterval { get; set; }
        public int DayOfWeek { get; set; }
        public int DayOfMonth { get; set; }
        public DateTime StartTime { get; set; }
        public string CronExpression { get; set; }
    }
}
