using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Data.Implementations.Classes;

namespace WMTT.Data.Tests.Tests
{
    [TestClass]
    public class PersonCategoryTests
    {
        [TestMethod]
        public void Get()
        {
            ArtistCategoryData getPerson = new ArtistCategoryData();
            Assert.AreEqual(null, getPerson.Get(5, 1).errorMessage);
        }

        [TestMethod]
        public void Post()
        {
            ArtistCategoryData postPerson = new ArtistCategoryData();
            Artists_Categories newPerson = new Artists_Categories()
            {
                IdCategory = 2,
                IdArtist = 6,
                Observation = "Observación de la categoría"
            };
            Assert.AreEqual(true, postPerson.Post(newPerson).succeed);
        }

        [TestMethod]
        public void Update()
        {
            ArtistCategoryData updatePerson = new ArtistCategoryData();
            Artists_Categories newPerson = new Artists_Categories()
            {
                IdCategory = 1,
                IdArtist = 5,
                Observation = "Observación de la categoría actualizada"
            };
            Assert.AreEqual(true, updatePerson.Update(newPerson).succeed);
        }

        [TestMethod]
        public void Delete()
        {
            ArtistCategoryData delCategory = new ArtistCategoryData();
            Assert.AreEqual(true, delCategory.Delete(5, 1).succeed);
        }

        [TestMethod]
        public void GetCatPerPerson()
        {
            ArtistCategoryData getCategories = new ArtistCategoryData();
            Assert.AreEqual(true, getCategories.GetCatPerPerson(5).succeed);
        }

        [TestMethod]
        public void GetPersonPerCat()
        {
            ArtistCategoryData getPeople = new ArtistCategoryData();
            Assert.AreEqual(true, getPeople.GetPersonPerCat(1).succeed);
        }
    }
}
