using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class FlexTable002
    {
        public Guid FlexTableId { get; set; }
        public string FlexField001 { get; set; }
        public string FlexField002 { get; set; }
        public string FlexField003 { get; set; }
        public string FlexField004 { get; set; }
        public string FlexField005 { get; set; }
        public string FlexField006 { get; set; }
        public string FlexField007 { get; set; }
        public string FlexField008 { get; set; }
        public string FlexField009 { get; set; }
        public string FlexField010 { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid? OwnerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees Owner { get; set; }
    }
}
