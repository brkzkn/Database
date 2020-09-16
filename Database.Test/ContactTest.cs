using Database.Data;
using Database.Data.Models;
using Database.Data.Repository;
using Database.Data.Service.Contact;
using Database.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Database.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ContactCount_Should_BeSame_After_DuplicateContact_Execute()
        {
            // Arrange
            var contacts = new List<Contacts>()
            {
                new Contacts() { FirstName = "Burak", LastName = "Ozkan"},
                new Contacts() { FirstName = "Murak", LastName = "Ozkan"},
            };
            var dbSetMock = new Mock<DbSet<Contacts>>();
            dbSetMock.As<IQueryable<Contacts>>().Setup(x => x.Provider).Returns(contacts.AsQueryable().Provider);
            dbSetMock.As<IQueryable<Contacts>>().Setup(x => x.Expression).Returns(contacts.AsQueryable().Expression);
            dbSetMock.As<IQueryable<Contacts>>().Setup(x => x.ElementType).Returns(contacts.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<Contacts>>().Setup(x => x.GetEnumerator()).Returns(contacts.AsQueryable().GetEnumerator());

            var context = new Mock<DbContext>();
            context.Setup(x => x.Set<Contacts>()).Returns(dbSetMock.Object);

            var repository = new Repository<Contacts>(context.Object);

            var unitOfWork = new UnitOfWork(context.Object);

            IContactService service = new ContactService(repository, unitOfWork);

            // Act
            int contactCount = repository.Queryable().Count();
            service.DuplicateContact(Guid.NewGuid());
            int afterServiceExecuteCount = repository.Queryable().Count();


            Assert.AreEqual(contactCount, afterServiceExecuteCount);
        }
    }
}