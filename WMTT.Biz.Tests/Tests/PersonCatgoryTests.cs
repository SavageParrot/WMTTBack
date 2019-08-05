using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Biz.Implementations;

namespace WMTT.Biz.Tests.Tests
{
    [TestClass]
    public class PersonCatgoryTests
    {
        [TestMethod]
        public void GetCatPerPerson()
        {
            PersonCategoryBiz getCategories = new PersonCategoryBiz();
            Assert.AreEqual(2, getCategories.GetCatPerPerson(6).list.Count());
        }

        [TestMethod]
        public void GetPersonPerCat()
        {
            PersonCategoryBiz getPeople = new PersonCategoryBiz();
            Assert.AreEqual(2, getPeople.GetPersonPerCat(2).list.Count());
        }
    }
}
