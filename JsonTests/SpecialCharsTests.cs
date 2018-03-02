using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class SpecialCharsTests
    {
        [TestMethod]
        public void SpecialCharsTest1()
        {
            var x = new SpecialChars();
            var (match, remaining) = x.Match("\u1234");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }
    }
}
