using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class IndexCriteria
    {
        public IndexCriteria()
        {
            Securities = new HashSet<Securities>();
        }

        public string IndexCriterionId { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
