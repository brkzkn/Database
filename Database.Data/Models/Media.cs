using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Media
    {
        public Media()
        {
            Contacts = new HashSet<Contacts>();
            Documents = new HashSet<Documents>();
            Employees = new HashSet<Employees>();
            Staff = new HashSet<Staff>();
        }

        public Guid MediaId { get; set; }
        public string BlobName { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public long FileSize { get; set; }
        public DateTime UploadDate { get; set; }
        public int FileAccessSecurity { get; set; }
        public string UserId { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public bool IsPermanent { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
