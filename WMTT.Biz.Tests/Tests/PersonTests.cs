using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Biz.Implementations;
using WMTT.Common;
using WMTT.Data;

namespace WMTT.Biz.Tests.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GetAll()
        {
            ArtistBiz person = new ArtistBiz();
            Assert.AreEqual(5, person.GetAll().list.Count());
        }

        [TestMethod]
        public void Get()
        {
            ArtistBiz person = new ArtistBiz();
            Assert.AreEqual(true, person.Get(2).succeed);
        }
    }
}
