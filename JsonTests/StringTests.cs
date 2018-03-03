using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void StringTest1()
        {
            var x = new String();
            var (match, remaining) = x.Match("");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void StringTest2()
        {
            var x = new String();
            var (match, remaining) = x.Match("\u0041lin");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void StringTest3()
        {
            var x = new String();
            var (match, remaining) = x.Match("\\n\u0041lin");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
