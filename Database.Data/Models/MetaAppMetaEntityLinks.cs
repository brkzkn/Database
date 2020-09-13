using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class MetaAppMetaEntityLinks
    {
        public int LinkId { get; set; }
        public Guid AppId { get; set; }
        public Guid EntityId { get; set; }
        public bool DisplayInMenu { get; set; }
        public bool DisplayInLauncher { get; set; }
        public bool IsCustom { get; set; }
        public int DisplayOrder { get; set; }
        public Guid? AdvisorFirmId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaApps App { get; set; }
        public virtual MetaEntities Entity { get; set; }
    }
}
