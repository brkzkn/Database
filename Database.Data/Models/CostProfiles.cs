using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CostProfiles
    {
        public string CostProfileId { get; set; }
        public int EffectiveYear { get; set; }
        public string AssetClassId { get; set; }
        public int SecurityType { get; set; }
        public int TransactionType { get; set; }
        public decimal CostPercent { get; set; }
        public int EndYear { get; set; }
        public decimal EndCostPercent { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
    }
}
