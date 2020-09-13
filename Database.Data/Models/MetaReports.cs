using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaReports
    {
        public Guid ReportId { get; set; }
        public Guid EntityId { get; set; }
        public string ReportLabel { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public bool IsCustom { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
    }
}
