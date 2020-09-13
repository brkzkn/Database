﻿using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Niches
    {
        public Niches()
        {
            ProxySegments = new HashSet<ProxySegments>();
            Securities = new HashSet<Securities>();
        }

        public string NicheId { get; set; }

        public virtual ICollection<ProxySegments> ProxySegments { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
    }
}
