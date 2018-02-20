using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterTests1()
        {
            var x = new Character('x');
            var (match, remainng) = x.Match("x");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "");
        }
    }
}
