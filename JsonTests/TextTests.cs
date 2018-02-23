using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class TextTests
    {
        [TestMethod]
        public void TextTest1()
        {
            string input = "raduionescu";
            var x = new Text("rad");
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "uionescu");
        }

        [TestMethod]
        public void TextTest2()
        {
            string input = "raduionescu";
            var x = new Text("rau");
            var (match, remaining) = x.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "raduionescu");
        }
    }
}
