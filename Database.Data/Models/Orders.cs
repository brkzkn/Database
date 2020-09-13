using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderLines = new HashSet<OrderLines>();
        }

        public int OrderId { get; set; }
        public Guid AllocationId { get; set; }
        public string BrokerCode { get; set; }
        public string UserName { get; set; }
        public DateTime RebalanceDate { get; set; }
        public DateTime? PlacementDate { get; set; }
        public int OrderType { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Portfolios Allocation { get; set; }
        public virtual Brokers BrokerCodeNavigation { get; set; }
        public virtual ICollection<OrderLines> OrderLines { get; set; }
    }
}
