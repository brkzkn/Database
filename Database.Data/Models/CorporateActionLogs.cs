using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class CorporateActionLogs
    {
        public int CorporateActionLogId { get; set; }
        public int SecurityId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string Details { get; set; }

        public virtual Securities Security { get; set; }
    }
}
