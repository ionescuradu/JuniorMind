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

        [TestMethod]
        public void TestTwoLines1()
        {
            var text = "text \n radu";
            var location = new Location(text, 9);
            Assert.AreEqual(2, location.Line);
            Assert.AreEqual(4, location.Column);
        }

        [TestMethod]
        public void TestThreeLines1()
        {
            var text = "text \n radu \n 5";
            var location = new Location(text, 15);
            Assert.AreEqual(3, location.Line);
            Assert.AreEqual(3, location.Column);
        }

        [TestMethod]
        public void TestThreeLines2()
        {
            var text = "{ \"glossary\":\na{ ";
            var location = new Location(text, 15);
            Assert.AreEqual(2, location.Line);
            Assert.AreEqual(2, location.Column);
        }

        [TestMethod]
        public void TestThreeLines3()
        {
            var text = "{\n\"glossary\":\n\n\na{ ";
            var location = new Location(text, 16);
            Assert.AreEqual(5, location.Line);
            Assert.AreEqual(1, location.Column);
        }

    }
}
