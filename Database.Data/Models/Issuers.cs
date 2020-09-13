using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Issuers
    {
        public Issuers()
        {
            Securities = new HashSet<Securities>();
        }

        public string IssuerId { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
