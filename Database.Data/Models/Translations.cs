using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Translations
    {
        public int TranslationId { get; set; }
        public string StringId { get; set; }
        public string StringEnGb { get; set; }
        public bool StringEnGbVerified { get; set; }
        public string StringNlNl { get; set; }
        public bool StringNlNlVerified { get; set; }
        public string StringDeDe { get; set; }
        public bool StringDeDeVerified { get; set; }
        public string StringFrFr { get; set; }
        public bool StringFrFrVerified { get; set; }
        public bool OrphanString { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
    }
}
