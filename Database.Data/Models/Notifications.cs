using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Notifications
    {
        public int NotificationId { get; set; }
        public int SystemNotificationId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string UserId { get; set; }
        public DateTime NotificationDate { get; set; }
        public string NotificationText { get; set; }
        public int NotificationPriority { get; set; }
        public DateTime UserActionDate { get; set; }
        public int UserAction { get; set; }
        public int SnoozeDuration { get; set; }
        public bool PreviewShown { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
