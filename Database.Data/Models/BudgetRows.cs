using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class BudgetRows
    {
        public int BudgetRowId { get; set; }
        public string Description { get; set; }
        public decimal Column01 { get; set; }
        public decimal Column02 { get; set; }
        public decimal Column03 { get; set; }
        public decimal Column04 { get; set; }
        public decimal Column05 { get; set; }
        public decimal Column06 { get; set; }
        public decimal Column07 { get; set; }
        public decimal Column08 { get; set; }
        public decimal Column09 { get; set; }
        public decimal Column10 { get; set; }
        public decimal Column11 { get; set; }
        public decimal Column12 { get; set; }
        public decimal Column13 { get; set; }
        public decimal Column14 { get; set; }
        public decimal Column15 { get; set; }
        public decimal Column16 { get; set; }
        public decimal Column17 { get; set; }
        public decimal Column18 { get; set; }
        public decimal Column19 { get; set; }
        public decimal Column20 { get; set; }
        public decimal Column21 { get; set; }
        public decimal Column22 { get; set; }
        public decimal Column23 { get; set; }
        public decimal Column24 { get; set; }
        public decimal Column25 { get; set; }
        public decimal Column26 { get; set; }
        public decimal Column27 { get; set; }
        public decimal Column28 { get; set; }
        public decimal Column29 { get; set; }
        public decimal Column30 { get; set; }
        public decimal Column31 { get; set; }
        public decimal Column32 { get; set; }
        public decimal Column33 { get; set; }
        public decimal Column34 { get; set; }
        public decimal Column35 { get; set; }
        public decimal Column36 { get; set; }
        public decimal Column37 { get; set; }
        public decimal Column38 { get; set; }
        public decimal Column39 { get; set; }
        public decimal Column40 { get; set; }
        public decimal Column41 { get; set; }
        public decimal Column42 { get; set; }
        public decimal Column43 { get; set; }
        public decimal Column44 { get; set; }
        public decimal Column45 { get; set; }
        public decimal Column46 { get; set; }
        public decimal Column47 { get; set; }
        public decimal Column48 { get; set; }
        public decimal Column49 { get; set; }
        public decimal Column50 { get; set; }
        public decimal Column51 { get; set; }
        public decimal Column52 { get; set; }
        public decimal Column53 { get; set; }
        public decimal Column54 { get; set; }
        public decimal Column55 { get; set; }
        public decimal Column56 { get; set; }
        public decimal Column57 { get; set; }
        public decimal Column58 { get; set; }
        public decimal Column59 { get; set; }
        public decimal Column60 { get; set; }
        public decimal Column61 { get; set; }
        public decimal Column62 { get; set; }
        public decimal Column63 { get; set; }
        public decimal Column64 { get; set; }
        public decimal Column65 { get; set; }
        public decimal Column66 { get; set; }
        public decimal Column67 { get; set; }
        public decimal Column68 { get; set; }
        public decimal Column69 { get; set; }
        public decimal Column70 { get; set; }
        public decimal Column71 { get; set; }
        public decimal Column72 { get; set; }
        public decimal Column73 { get; set; }
        public decimal Column74 { get; set; }
        public decimal Column75 { get; set; }
        public decimal Column76 { get; set; }
        public decimal Column77 { get; set; }
        public decimal Column78 { get; set; }
        public decimal Column79 { get; set; }
        public decimal Column80 { get; set; }
        public decimal Column81 { get; set; }
        public decimal Column82 { get; set; }
        public decimal Column83 { get; set; }
        public decimal Column84 { get; set; }
        public decimal Column85 { get; set; }
        public decimal Column86 { get; set; }
        public decimal Column87 { get; set; }
        public decimal Column88 { get; set; }
        public decimal Column89 { get; set; }
        public decimal Column90 { get; set; }
        public int BudgetId { get; set; }
        public int SourceId { get; set; }
        public int BudgetGroupType { get; set; }
        public int EnumValue { get; set; }
        public int SortOrder { get; set; }
        public int AssetOwner { get; set; }
        public int RowStyle { get; set; }
        public int IndentLevel { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual BudgetReports Budget { get; set; }
        public virtual Contacts Contact { get; set; }
    }
}
