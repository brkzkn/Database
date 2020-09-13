using Bogus;
using Database.Data.Repository;
using Database.Data.UnitOfWork;
using System;
using System.Linq;
using ContractsDb = Database.Data.Models.Contacts;

namespace Database.Data.Service.Contact
{
    public class ContactService : Service<ContractsDb>, IContactService
    {
        private readonly IRepository<ContractsDb> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ContactService(IRepository<ContractsDb> repository, IUnitOfWork unitOfWork)
            : base(repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void DuplicateContact(Guid advisorFirmId)
        {
            //Get contract list by firmID
            var contractListByFirm = _repository.Queryable().Where(x => x.AdvisorFirmId == advisorFirmId).ToList();

            //Create faker instance to generate mock data
            var faker = new Faker("en");

            foreach (var item in contractListByFirm)
            {
                item.LastName = "Clone: " + item.LastName;
                item.ContactName = faker.Name.FullName();
                item.CompanyName = faker.Company.CompanyName();
                item.AddressLine1 = faker.Address.StreetAddress().ToString();
                item.AddressLine2 = faker.Address.StreetName().ToString();

                _repository.Update(item);
            }

            // EfBulkExtension might be an option to handle big volume data.
            int affectedRow = _unitOfWork.SaveChanges();
        }
    }
}
