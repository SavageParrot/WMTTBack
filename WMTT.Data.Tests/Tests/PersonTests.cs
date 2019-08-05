using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Data.Implementations.Classes;

namespace WMTT.Data.Tests.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Delete()
        {
            PersonData delPerson = new PersonData();
            Assert.AreEqual(true, delPerson.Delete(7).succeed);

        }

        [TestMethod]
        public void Get()
        {
            PersonData getPerson = new PersonData();
            Assert.AreEqual(null, getPerson.Get(2).errorMessage);
        }

        [TestMethod]
        public void Post()
        {
            PersonData postPerson = new PersonData();
            Person newPerson = new Person()
            {
                FullName = "Juan Castelblanco",
                BirthDate = Convert.ToDateTime("1991-06-11"),
                StartDate = Convert.ToDateTime("2014-04-24"),
                PhoneNumber = "31787101069",
                Address = "Diag 123",
                Email = "juancastelblancoh@gmail.com"
            };
            Assert.AreEqual(5.GetType(), postPerson.Post(newPerson).idElement.GetType());
        }

        [TestMethod]
        public void Update()
        {
            PersonData updatePerson = new PersonData();
            Person newPerson = new Person()
            {
                IdPerson = 5,
                FullName = "Juan"
            };
            Assert.AreEqual(true, updatePerson.Update(newPerson).succeed);
        }

        [TestMethod]
        public void GetAll()
        {
            PersonData getAllPeople = new PersonData();
            Assert.AreEqual(5, getAllPeople.GetAll().list.Count());
        }
    }
}
