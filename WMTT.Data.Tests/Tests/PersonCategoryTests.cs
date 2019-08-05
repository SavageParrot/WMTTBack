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
            PersonCategoryData getPerson = new PersonCategoryData();
            Assert.AreEqual(null, getPerson.Get(5, 1).errorMessage);
        }

        [TestMethod]
        public void Post()
        {
            PersonCategoryData postPerson = new PersonCategoryData();
            Persons_Categories newPerson = new Persons_Categories()
            {
                IdCategory = 2,
                Idperson = 6,
                Obsevation = "Observación de la categoría"
            };
            Assert.AreEqual(true, postPerson.Post(newPerson).succeed);
        }

        [TestMethod]
        public void Update()
        {
            PersonCategoryData updatePerson = new PersonCategoryData();
            Persons_Categories newPerson = new Persons_Categories()
            {
                IdCategory = 1,
                Idperson = 5,
                Obsevation = "Observación de la categoría actualizada"
            };
            Assert.AreEqual(true, updatePerson.Update(newPerson).succeed);
        }

        [TestMethod]
        public void Delete()
        {
            PersonCategoryData delCategory = new PersonCategoryData();
            Assert.AreEqual(true, delCategory.Delete(5, 1).succeed);
        }

        [TestMethod]
        public void GetCatPerPerson()
        {
            PersonCategoryData getCategories = new PersonCategoryData();
            Assert.AreEqual(true, getCategories.GetCatPerPerson(5).succeed);
        }

        [TestMethod]
        public void GetPersonPerCat()
        {
            PersonCategoryData getPeople = new PersonCategoryData();
            Assert.AreEqual(true, getPeople.GetPersonPerCat(1).succeed);
        }
    }
}
