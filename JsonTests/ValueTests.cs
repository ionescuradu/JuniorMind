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
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest4()
        {
            var x = new Value();
            var (match, remaining) = x.Match("True");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest5()
        {
            var x = new Value();
            var (match, remaining) = x.Match("-104.575e-1s0");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("-104.575e-1s0", remaining);
        }
    }
}
