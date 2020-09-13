using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Institutions
    {
        public Institutions()
        {
            Expenses = new HashSet<Expenses>();
            Incomes = new HashSet<Incomes>();
            LiquidAssets = new HashSet<LiquidAssets>();
        }

        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string AccountAccessMethod { get; set; }
        public string CountryCode { get; set; }
        public bool SavingsAccounts { get; set; }
        public bool CurrentAccounts { get; set; }
        public bool TermDeposits { get; set; }
        public bool InvestmentAccounts { get; set; }
        public bool Mortgages { get; set; }
        public bool PersonalLoans { get; set; }
        public bool Brokerage { get; set; }
        public bool Pension { get; set; }
        public bool Annuity { get; set; }
        public Guid? AdvisorFirmId { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<Expenses> Expenses { get; set; }
        public virtual ICollection<Incomes> Incomes { get; set; }
        public virtual ICollection<LiquidAssets> LiquidAssets { get; set; }
    }
}
