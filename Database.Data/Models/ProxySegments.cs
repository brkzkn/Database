using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ProxySegments
    {
        public ProxySegments()
        {
            ProxyMap = new HashSet<ProxyMap>();
        }

        public int ProxySegmentId { get; set; }
        public string ProxySegmentName { get; set; }
        public string AssetClassId { get; set; }
        public string GeographyId { get; set; }
        public string CategoryId { get; set; }
        public string FocusId { get; set; }
        public string NicheId { get; set; }
        public string AdminNotes { get; set; }

        public virtual AssetClasses AssetClass { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Focuses Focus { get; set; }
        public virtual Geographies Geography { get; set; }
        public virtual Niches Niche { get; set; }
        public virtual ICollection<ProxyMap> ProxyMap { get; set; }
    }
}
