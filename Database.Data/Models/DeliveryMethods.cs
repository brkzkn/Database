using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class DeliveryMethods
    {
        public DeliveryMethods()
        {
            Shipments = new HashSet<Shipments>();
        }

        public Guid DeliveryMethodId { get; set; }
        public string DeliveryMethodName { get; set; }
        public string DeliveryMethodDescription { get; set; }
        public string ZlegacyXshipMth { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
        public virtual ICollection<Shipments> Shipments { get; set; }
    }
}
