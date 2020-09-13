using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MessageAddresses
    {
        public int MessageAddressId { get; set; }
        public int MessageId { get; set; }
        public int MessageAddressType { get; set; }
        public string EmailAddress { get; set; }
        public string UserId { get; set; }
        public int UserType { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? LeadId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string PersonName { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Leads Lead { get; set; }
        public virtual Messages Message { get; set; }
    }
}
