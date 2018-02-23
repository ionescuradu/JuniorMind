using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ManyTests
    {
        [TestMethod]
        public void ManyTests1()
        {
            var x = new Many(new Character('r'));
            var (match, remainng) = x.Match("rrradu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "adu");
        }

        [TestMethod]
        public void ManyTests2()
        {
            var x = new Many(new Character('r'));
            var (match, remainng) = x.Match("ionescu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "ionescu");
        }
    }
}
