using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class UserSettings
    {
        public int UserSettingId { get; set; }
        public string UserId { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
    }
}
