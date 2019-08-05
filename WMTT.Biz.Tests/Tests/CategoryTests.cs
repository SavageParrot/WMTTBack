using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Biz.Implementations;

namespace WMTT.Biz.Tests.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void GetAll()
        {
            CategoryBiz category = new CategoryBiz();
            Assert.AreEqual(2, category.GetAll().list.Count());
        }
    }
}
