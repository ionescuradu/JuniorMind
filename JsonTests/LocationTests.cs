using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var text = "text";
            var location = new Location(text, 1);
            Assert.AreEqual(1, location.Line);
            Assert.AreEqual(2, location.Column);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var text = "text";
            var location = new Location(text, 3);
            Assert.AreEqual(1, location.Line);
            Assert.AreEqual(4, location.Column);
        }

    }
}
