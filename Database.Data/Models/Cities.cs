using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Cities
    {
        public Cities()
        {
            ShipmentsLoadingCity = new HashSet<Shipments>();
            ShipmentsUnloadingCity = new HashSet<Shipments>();
            ShippingPoints = new HashSet<ShippingPoints>();
        }

        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        public string ZlegacyXcity { get; set; }
        public string ZlegacyCnCode { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<Shipments> ShipmentsLoadingCity { get; set; }
        public virtual ICollection<Shipments> ShipmentsUnloadingCity { get; set; }
        public virtual ICollection<ShippingPoints> ShippingPoints { get; set; }
    }
}
