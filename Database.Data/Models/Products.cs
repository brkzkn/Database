using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Products
    {
        public Products()
        {
            ShipmentItems = new HashSet<ShipmentItems>();
        }

        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public bool IsThermoGoods { get; set; }
        public string RequiredTemperature { get; set; }
        public bool IsAdrgoods { get; set; }
        public string ZlegacyXgdsCode { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
    }
}
