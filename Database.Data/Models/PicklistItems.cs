using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PicklistItems
    {
        public int PicklistItemId { get; set; }
        public string PicklistItemName { get; set; }
        public int PicklistId { get; set; }
        public string PicklistName { get; set; }
        public string HelpText { get; set; }
        public bool IsActive { get; set; }
        public string ControllingFieldValues { get; set; }
        public string ItemIcon { get; set; }
        public bool IsClosed { get; set; }
        public bool IsConverted { get; set; }
        public decimal Probability { get; set; }
        public bool IsHighPriority { get; set; }
        public bool CashSecurity { get; set; }
        public int DisplayOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Picklists Picklist { get; set; }
    }
}
