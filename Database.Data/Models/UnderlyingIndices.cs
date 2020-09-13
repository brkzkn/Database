using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class UnderlyingIndices
    {
        public UnderlyingIndices()
        {
            Securities = new HashSet<Securities>();
        }

        public string UnderlyingIndexId { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
