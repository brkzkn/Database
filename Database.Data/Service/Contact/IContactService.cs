using System;

namespace Database.Data.Service.Contact
{
    public interface IContactService
    {
        public void DuplicateContact(Guid advisorFirmId);
    }
}
