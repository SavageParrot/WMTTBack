using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTT.Biz.Implementations;
using WMTT.Common;
using WMTT.Data;
using WMTT.Data.Implementations.Classes;
using WMTT.Data.Interfaces;

namespace WMTT.Biz.Tests.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GetAll()
        {
            IArtistData _artist = new ArtistData();
            ArtistBiz person = new ArtistBiz(_artist);
            Assert.AreEqual(5, person.GetAll().list.Count());
        }

        [TestMethod]
        public void Get()
        {
            IArtistData _artist = new ArtistData();
            ArtistBiz person = new ArtistBiz(_artist);
            Assert.AreEqual(true, person.Get(2).succeed);
        }
    }
}
