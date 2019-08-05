using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Data.Implementations.Classes;
using WMTT.Data;
using System.Linq;

namespace WMTT.Data.Tests.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void Delete()
        {
            CategoryData delCategory = new CategoryData();
            Assert.AreEqual(true, delCategory.Delete(3).succeed);
        }

        [TestMethod]
        public void Get()
        {
            CategoryData getCategory = new CategoryData();
            Assert.AreEqual(true, getCategory.Get(1).succeed);
        }

        [TestMethod]
        public void Post()
        {
            CategoryData postCategory = new CategoryData();
            Category newCategory = new Category()
            {
                CategoryName = "Acuarela",
                Details = "Finos detalles"

            };
            Assert.AreEqual(true, postCategory.Post(newCategory).succeed);
        }

        [TestMethod]
        public void Update()
        {
            CategoryData updateCategory = new CategoryData();
            Category newCategory = new Category()
            {
                IdCategory = 2,
                Details = "Trazos degradados"
            };
            Assert.AreEqual(true, updateCategory.Update(newCategory).succeed);
        }

        [TestMethod]
        public void GetAll()
        {
            CategoryData getAllCategories = new CategoryData();
            Assert.AreEqual(2, getAllCategories.GetAll().list.Count());
        }
    }
}
