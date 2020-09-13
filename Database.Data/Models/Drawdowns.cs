using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Drawdowns
    {
        public int DrawdownId { get; set; }
        public Guid PortfolioId { get; set; }
        public DateTime DrawdownStart { get; set; }
        public DateTime DrawdownEnd { get; set; }
        public int DrawdownLength { get; set; }
        public DateTime RecoveryBy { get; set; }
        public int RecoveryMonths { get; set; }
        public decimal DrawdownPercent { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Portfolios Portfolio { get; set; }
    }
}
