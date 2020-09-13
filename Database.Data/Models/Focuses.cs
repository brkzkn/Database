using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Focuses
    {
        public Focuses()
        {
            ProxySegments = new HashSet<ProxySegments>();
            Securities = new HashSet<Securities>();
        }

        public string FocusId { get; set; }

        public virtual ICollection<ProxySegments> ProxySegments { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
    }
}
