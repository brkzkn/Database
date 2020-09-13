using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ShippingPoints
    {
        public ShippingPoints()
        {
            PackagingItemsLoadingPoint = new HashSet<PackagingItems>();
            PackagingItemsUnloadingPoint = new HashSet<PackagingItems>();
            ShipmentsLoadingPoint = new HashSet<Shipments>();
            ShipmentsUnloadingPoint = new HashSet<Shipments>();
        }

        public Guid ShippingPointId { get; set; }
        public string SearchCode { get; set; }
        public Guid? CityId { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string FullStreetAddress { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string WebSite { get; set; }
        public string ShippingPointNotes { get; set; }
        public bool IsActive { get; set; }
        public string ExternalRecordId1 { get; set; }
        public string ExternalRecordId2 { get; set; }
        public Guid ContactId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public string CityName { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Cities City { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<PackagingItems> PackagingItemsLoadingPoint { get; set; }
        public virtual ICollection<PackagingItems> PackagingItemsUnloadingPoint { get; set; }
        public virtual ICollection<Shipments> ShipmentsLoadingPoint { get; set; }
        public virtual ICollection<Shipments> ShipmentsUnloadingPoint { get; set; }
    }
}
