using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Shipments
    {
        public Shipments()
        {
            PackagingItems = new HashSet<PackagingItems>();
            ShipmentItems = new HashSet<ShipmentItems>();
        }

        public int ShipmentId { get; set; }
        public Guid BillingContactId { get; set; }
        public Guid? ShippingDepartmentId { get; set; }
        public Guid? DeliveryMethodId { get; set; }
        public string LoadingName { get; set; }
        public string LoadingAddress { get; set; }
        public string LoadingPostalCode { get; set; }
        public Guid? LoadingCityId { get; set; }
        public string LoadingCountryCode { get; set; }
        public string LoadingLatitude { get; set; }
        public string LoadingLongitude { get; set; }
        public DateTime? LoadingDateFrom { get; set; }
        public DateTime? LoadingDateTo { get; set; }
        public string LoadingReference { get; set; }
        public string LoadingNotes { get; set; }
        public string UnloadingName { get; set; }
        public string UnloadingAddress { get; set; }
        public string UnloadingPostalCode { get; set; }
        public Guid? UnloadingCityId { get; set; }
        public string UnloadingCountryCode { get; set; }
        public string UnloadingLatitude { get; set; }
        public string UnloadingLongitude { get; set; }
        public DateTime UnloadingDateFrom { get; set; }
        public DateTime UnloadingDateTo { get; set; }
        public string UnloadingReference { get; set; }
        public string UnloadingNotes { get; set; }
        public string ClientReference { get; set; }
        public string ShipmentNotes { get; set; }
        public string TrackingId { get; set; }
        public string ZlegacyTrOrd { get; set; }
        public string ZlegacyRplDel { get; set; }
        public string ZlegacyRplInv { get; set; }
        public string ZlegacyTrafiek { get; set; }
        public string ZlegacyTerms { get; set; }
        public string ZlegacyLCode { get; set; }
        public string ZlegacyLCity { get; set; }
        public string ZlegacyLCountry { get; set; }
        public string ZlegacyDCode { get; set; }
        public string ZlegacyDCity { get; set; }
        public string ZlegacyDCountry { get; set; }
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
        public virtual Contacts BillingContact { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual DeliveryMethods DeliveryMethod { get; set; }
        public virtual Cities LoadingCity { get; set; }
        public virtual Countries LoadingCountryCodeNavigation { get; set; }
        public virtual ShippingPoints LoadingPoint { get; set; }
        public virtual ShippingDepartments ShippingDepartment { get; set; }
        public virtual Cities UnloadingCity { get; set; }
        public virtual Countries UnloadingCountryCodeNavigation { get; set; }
        public virtual ShippingPoints UnloadingPoint { get; set; }
        public virtual ICollection<PackagingItems> PackagingItems { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
    }
}
