using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class AssetClasses
    {
        public AssetClasses()
        {
            ProxySegments = new HashSet<ProxySegments>();
            Securities = new HashSet<Securities>();
        }

        public string AssetClassId { get; set; }

        public virtual ICollection<ProxySegments> ProxySegments { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
    }
}
