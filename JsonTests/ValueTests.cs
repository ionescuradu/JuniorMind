using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ValueTests
    {
        [TestMethod]
        public void ValueTest1()
        {
            var x = new Value();
            var (match, remaining) = x.Match("");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest2()
        {
            var x = new Value();
            var (match, remaining) = x.Match("\"\"");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest3()
        {
            var x = new Value();
            var (match, remaining) = x.Match("-104.575e-10");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
