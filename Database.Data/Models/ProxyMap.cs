using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ProxyMap
    {
        public int ProxyMapId { get; set; }
        public int ProxySegmentId { get; set; }
        public int SecurityId { get; set; }
        public string SecuritySymbol { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual ProxySegments ProxySegment { get; set; }
        public virtual Securities Security { get; set; }
    }
}
