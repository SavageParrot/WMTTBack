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
            ArtistData delPerson = new ArtistData();
            Assert.AreEqual(true, delPerson.Delete(7).succeed);

        }

        [TestMethod]
        public void Get()
        {
            ArtistData getPerson = new ArtistData();
            Assert.AreEqual(null, getPerson.Get(2).errorMessage);
        }

        [TestMethod]
        public void Post()
        {
            ArtistData postPerson = new ArtistData();
            Artist newPerson = new Artist()
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
            ArtistData updatePerson = new ArtistData();
            Artist newPerson = new Artist()
            {
                IdArtist = 5,
                FullName = "Juan"
            };
            Assert.AreEqual(true, updatePerson.Update(newPerson).succeed);
        }

        [TestMethod]
        public void GetAll()
        {
            ArtistData getAllPeople = new ArtistData();
            Assert.AreEqual(5, getAllPeople.GetAll().list.Count());
        }
    }
}
