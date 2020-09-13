using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Liabilities
    {
        public int LiabilityId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid ContactId { get; set; }
        public string LiabilityDescription { get; set; }
        public int LiabilityType { get; set; }
        public int RepaymentType { get; set; }
        public int LoanType { get; set; }
        public decimal LiabilityAmount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int InterestDeductionEndYear { get; set; }
        public string LendingInstitution { get; set; }
        public int? FixedAssetId { get; set; }
        public int LiabilityOwner { get; set; }
        public bool MoreInfoRequired { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Contacts Contact { get; set; }
    }
}
