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
    }
}
