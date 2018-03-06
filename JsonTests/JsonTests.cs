using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class JsonTests
    {
        [TestMethod]
        public void ValueTest1()
        {
            var x = new Json();
            var (match, remaining) = x.Match("");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest2()
        {
            var x = new Json();
            var (match, remaining) = x.Match("\"\"");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest3()
        {
            var x = new Json();
            var (match, remaining) = x.Match("-104.575e-10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest4()
        {
            var x = new Json();
            var (match, remaining) = x.Match("true");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest5()
        {
            var x = new Json();
            var (match, remaining) = x.Match("-104.575e-1s0");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("s0", remaining);
        }

        [TestMethod]
        public void ValueTestArray()
        {
            var x = new Json();
            var (match, remaining) = x.Match("[true,null,false,1234.7,\"radu\"]");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
