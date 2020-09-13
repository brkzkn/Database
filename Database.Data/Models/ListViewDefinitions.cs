using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class ListViewDefinitions
    {
        public Guid ListViewDefinitionId { get; set; }
        public Guid? EntityId { get; set; }
        public string ListModel { get; set; }
        public string ViewName { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid? OwnerId { get; set; }
        public int ListType { get; set; }
        public string ListItems { get; set; }
        public string FilterExpression { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual MetaEntities Entity { get; set; }
        public virtual Employees Owner { get; set; }
    }
}
