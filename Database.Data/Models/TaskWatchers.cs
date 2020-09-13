using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class TaskWatchers
    {
        public int TaskWatcherId { get; set; }
        public int ActivityId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
