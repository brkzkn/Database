using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class WeightingSchemes
    {
        public WeightingSchemes()
        {
            Securities = new HashSet<Securities>();
        }

        public string WeightingSchemeId { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
