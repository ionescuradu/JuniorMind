using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class WhiteSpaceCharsTests
    {
        [TestMethod]
        public void WhiteSpaceTestSpace()
        {
            var x = new WhiteSpaceChars();
            var (match, remaining) = x.Match("");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
