using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PackagingItems
    {
        public int PackagingItemId { get; set; }
        public int? ShipmentId { get; set; }
        public decimal? UnloadingQuantity { get; set; }
        public Guid? UnloadingUnitId { get; set; }
        public decimal? LoadingQuantity { get; set; }
        public Guid? LoadingUnitId { get; set; }
        public string ZlegacyXnew { get; set; }
        public string ZlegacyTrOrd { get; set; }
        public string ZlegacyLocation1 { get; set; }
        public string ZlegacyColTyp1 { get; set; }
        public string ZlegacyLocation2 { get; set; }
        public string ZlegacyColTyp2 { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }
        public Guid? LoadingPointId { get; set; }
        public Guid? UnloadingPointId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ShippingPoints LoadingPoint { get; set; }
        public virtual PackagingUnits LoadingUnit { get; set; }
        public virtual Shipments Shipment { get; set; }
        public virtual ShippingPoints UnloadingPoint { get; set; }
        public virtual PackagingUnits UnloadingUnit { get; set; }
    }
}
