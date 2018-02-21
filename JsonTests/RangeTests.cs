using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class RangeTests
    {
        [TestMethod]
        public void RangeTest1()
        {
            var x = new Range('a', 'z');
            var (match, remainng) = x.Match("x");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "");
        }

        [TestMethod]
        public void RangeTest2()
        {
            var x = new Range('a', 'z');
            var (match, remainng) = x.Match("xa");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "a");
        }
    }
}
