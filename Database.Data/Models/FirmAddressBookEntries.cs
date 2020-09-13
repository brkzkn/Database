using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class FirmAddressBookEntries
    {
        public int FirmAddressBookEntryId { get; set; }
        public Guid PersonId { get; set; }
        public int PersonType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
    }
}
