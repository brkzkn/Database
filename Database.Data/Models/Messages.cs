using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Messages
    {
        public Messages()
        {
            Activities = new HashSet<Activities>();
            MessageAddresses = new HashSet<MessageAddresses>();
        }

        public int MessageId { get; set; }
        public bool PublicMessage { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
        public string ToNames { get; set; }
        public string FromGuid { get; set; }
        public string ToGuids { get; set; }
        public string IncomingHeader { get; set; }
        public string ToAddresses { get; set; }
        public string CcAddresses { get; set; }
        public string BccAddresses { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public int MessageSentReceived { get; set; }
        public int MessageStatus { get; set; }
        public bool IsPrivateDraft { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal? SpamScore { get; set; }
        public Guid AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<MessageAddresses> MessageAddresses { get; set; }
    }
}
