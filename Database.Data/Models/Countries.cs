using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Countries
    {
        public Countries()
        {
            AdvisorFirms = new HashSet<AdvisorFirms>();
            Cities = new HashSet<Cities>();
            ContactsCountryCodeNavigation = new HashSet<Contacts>();
            ContactsPostalCountryCodeNavigation = new HashSet<Contacts>();
            Documents = new HashSet<Documents>();
            Exchanges = new HashSet<Exchanges>();
            Institutions = new HashSet<Institutions>();
            Leads = new HashSet<Leads>();
            Securities = new HashSet<Securities>();
            ShipmentsLoadingCountryCodeNavigation = new HashSet<Shipments>();
            ShipmentsUnloadingCountryCodeNavigation = new HashSet<Shipments>();
            ShippingPoints = new HashSet<ShippingPoints>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Iso3Code { get; set; }
        public string CurrencyCode { get; set; }
        public string AddressTemplate { get; set; }
        public bool BaseList { get; set; }

        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual ICollection<AdvisorFirms> AdvisorFirms { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<Contacts> ContactsCountryCodeNavigation { get; set; }
        public virtual ICollection<Contacts> ContactsPostalCountryCodeNavigation { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<Exchanges> Exchanges { get; set; }
        public virtual ICollection<Institutions> Institutions { get; set; }
        public virtual ICollection<Leads> Leads { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
        public virtual ICollection<Shipments> ShipmentsLoadingCountryCodeNavigation { get; set; }
        public virtual ICollection<Shipments> ShipmentsUnloadingCountryCodeNavigation { get; set; }
        public virtual ICollection<ShippingPoints> ShippingPoints { get; set; }
    }
}
