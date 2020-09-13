using System;
using System.Collections.Generic;

namespace Database.Data.Models
{
    public partial class Employees
    {
        public Employees()
        {
            ActivitiesClosedBy = new HashSet<Activities>();
            ActivitiesDelegatedBy = new HashSet<Activities>();
            ActivitiesOwner = new HashSet<Activities>();
            CasesClosedBy = new HashSet<Cases>();
            CasesOwner = new HashSet<Cases>();
            CommentMentions = new HashSet<CommentMentions>();
            Comments = new HashSet<Comments>();
            Contacts = new HashSet<Contacts>();
            FlexData = new HashSet<FlexData>();
            FlexTable001 = new HashSet<FlexTable001>();
            FlexTable002 = new HashSet<FlexTable002>();
            InverseManager = new HashSet<Employees>();
            Leads = new HashSet<Leads>();
            ListViewDefinitions = new HashSet<ListViewDefinitions>();
            MessageAddresses = new HashSet<MessageAddresses>();
            Notifications = new HashSet<Notifications>();
            OpportunitiesClosedBy = new HashSet<Opportunities>();
            OpportunitiesOwner = new HashSet<Opportunities>();
            TaskWatchers = new HashSet<TaskWatchers>();
        }

        public Guid EmployeeId { get; set; }
        public string UserId { get; set; }
        public Guid ProfileId { get; set; }
        public Guid AdvisorFirmId { get; set; }
        public Guid? ManagerId { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNotes { get; set; }
        public string LinkedInPage { get; set; }
        public string FacebookPage { get; set; }
        public Guid? MediaId { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public bool AssignIncomingEmails { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int RowVersion { get; set; }

        public virtual AdvisorFirms AdvisorFirm { get; set; }
        public virtual Employees Manager { get; set; }
        public virtual Media Media { get; set; }
        public virtual UserProfiles Profile { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<Activities> ActivitiesClosedBy { get; set; }
        public virtual ICollection<Activities> ActivitiesDelegatedBy { get; set; }
        public virtual ICollection<Activities> ActivitiesOwner { get; set; }
        public virtual ICollection<Cases> CasesClosedBy { get; set; }
        public virtual ICollection<Cases> CasesOwner { get; set; }
        public virtual ICollection<CommentMentions> CommentMentions { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<FlexData> FlexData { get; set; }
        public virtual ICollection<FlexTable001> FlexTable001 { get; set; }
        public virtual ICollection<FlexTable002> FlexTable002 { get; set; }
        public virtual ICollection<Employees> InverseManager { get; set; }
        public virtual ICollection<Leads> Leads { get; set; }
        public virtual ICollection<ListViewDefinitions> ListViewDefinitions { get; set; }
        public virtual ICollection<MessageAddresses> MessageAddresses { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<Opportunities> OpportunitiesClosedBy { get; set; }
        public virtual ICollection<Opportunities> OpportunitiesOwner { get; set; }
        public virtual ICollection<TaskWatchers> TaskWatchers { get; set; }
    }
}
