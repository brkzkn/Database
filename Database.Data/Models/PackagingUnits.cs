using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class PackagingUnits
    {
        public PackagingUnits()
        {
            PackagingItemsLoadingUnit = new HashSet<PackagingItems>();
            PackagingItemsUnloadingUnit = new HashSet<PackagingItems>();
            ShipmentItems = new HashSet<ShipmentItems>();
        }

        public Guid PackagingUnitId { get; set; }
        public string PackagingUnitName { get; set; }
        public string PackagingUnitDescription { get; set; }
        public decimal? PackagingLength { get; set; }
        public decimal? PackagingWidth { get; set; }
        public decimal? PackagingHeight { get; set; }
        public bool IsPackagingRegistration { get; set; }
        public string ZlegacyXunitCode { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ICollection<PackagingItems> PackagingItemsLoadingUnit { get; set; }
        public virtual ICollection<PackagingItems> PackagingItemsUnloadingUnit { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
    }
}
