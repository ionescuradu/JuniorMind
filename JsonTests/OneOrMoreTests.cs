using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class OneOrMoreTests
    {
        [TestMethod]
        public void OneOrMore1()
        {
            var x = new OneOrMore(new Character('r'));
            var (match, remainng) = x.Match("rrradu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "adu");
        }

        [TestMethod]
        public void OneOrMore2()
        {
            var x = new OneOrMore(new Character('r'));
            var (match, remainng) = x.Match("ionescu");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "ionescu");
        }

        [TestMethod]
        public void OneOrMoreRemainingString()
        {
            var x = new OneOrMore(new Character('r'));
            var (match, remainng) = x.Match("ionescu");
            Assert.AreEqual(0, ((NoMatch)match).ErrorPosition);
        }
    }
}
