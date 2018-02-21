using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class AnyTests
    {
        [TestMethod]
        public void AnyTest1()
        {
            var x = new Any("radu");
            var (match, remainng) = x.Match("axy");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "xy");
        }

        [TestMethod]
        public void AnyTest2()
        {
            var x = new Any("radu");
            var (match, remainng) = x.Match("dxy");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "xy");
        }

        [TestMethod]
        public void AnyTest3()
        {
            var x = new Any("radu");
            var (match, remainng) = x.Match("ixy");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "ixy");
        }
    }
}
