using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Regions
    {
        public Regions()
        {
            Securities = new HashSet<Securities>();
        }

        public string RegionId { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
