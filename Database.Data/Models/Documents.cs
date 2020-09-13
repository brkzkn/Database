using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Documents
    {
        public Guid DocumentId { get; set; }
        public Guid MediaId { get; set; }
        public string EntityName { get; set; }
        public Guid? GuidId { get; set; }
        public int? IntId { get; set; }
        public string FieldName { get; set; }
        public int DocumentType { get; set; }
        public string MediaDescription { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string IssuingCountryCode { get; set; }
        public DateTime? CheckedDate { get; set; }
        public Guid? CheckerId { get; set; }
        public string UserId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Countries IssuingCountryCodeNavigation { get; set; }
        public virtual Media Media { get; set; }
    }
}
