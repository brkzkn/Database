using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class OrderLines
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public DateTime PlacementDate { get; set; }
        public int? SecurityId { get; set; }
        public string IsinCode { get; set; }
        public string SecuritySymbol { get; set; }
        public int OrderQuantity { get; set; }
        public decimal LimitPrice { get; set; }
        public int OrderStatus { get; set; }
        public int LogId { get; set; }
        public string StatusMessage { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Securities Security { get; set; }
    }
}
