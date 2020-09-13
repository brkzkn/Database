using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Brokers
    {
        public Brokers()
        {
            Orders = new HashSet<Orders>();
            SecurityExchanges = new HashSet<SecurityExchanges>();
        }

        public string BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public string BrokerWebsite { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<SecurityExchanges> SecurityExchanges { get; set; }
    }
}
