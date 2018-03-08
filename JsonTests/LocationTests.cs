using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class LocationTests
    {
        [TestMethod]
        public void TestOneLine1()
        {
            var text = "text";
            var location = new Location(text, 1);
            Assert.AreEqual(1, location.Line);
            Assert.AreEqual(2, location.Column);
        }

        [TestMethod]
        public void TestOneLine2()
        {
            var text = "text";
            var location = new Location(text, 3);
            Assert.AreEqual(1, location.Line);
            Assert.AreEqual(4, location.Column);
        }

    }
}
