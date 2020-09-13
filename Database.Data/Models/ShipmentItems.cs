using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ShipmentItems
    {
        public int ShipmentItemId { get; set; }
        public decimal? PackagingQuantity { get; set; }
        public int ShipmentId { get; set; }
        public Guid? PackagingUnitId { get; set; }
        public Guid? ProductId { get; set; }
        public string ProductDescription { get; set; }
        public decimal? PackagingWeight { get; set; }
        public decimal? PackagingVolume { get; set; }
        public decimal? LoadingMeters { get; set; }
        public decimal? PackagingLength { get; set; }
        public decimal? PackagingWidth { get; set; }
        public decimal? PackagingHeight { get; set; }
        public string RequiredTemperature { get; set; }
        public bool IsThermoGoods { get; set; }
        public bool IsAdrgoods { get; set; }
        public string ZlegacyXnew { get; set; }
        public string ZlegacyTrOrd { get; set; }
        public string ZlegacyCollitype { get; set; }
        public string ZlegacyGdsCode { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual PackagingUnits PackagingUnit { get; set; }
        public virtual Products Product { get; set; }
        public virtual Shipments Shipment { get; set; }
    }
}
