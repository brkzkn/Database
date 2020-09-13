using Database.Data.Service.Contact;
using System;

namespace Database.Code
{
    public class App
    {
        private readonly IContactService _contactService;
        public App(IContactService contactService)
        {
            _contactService = contactService;
        }
        public void Run()
        {
            var guid = new Guid("9E242E51-DE8E-4D39-EAC8-08D5D05B2628");
            _contactService.DuplicateContact(guid);

            Console.WriteLine("Contact updated");
        }
    }
}
