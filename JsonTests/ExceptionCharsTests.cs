using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ExceptionCharsTests
    {
        [TestMethod]
        public void ExceptionChars1()
        {
            var x = new ExceptionChars();
            var (match, remaining) = x.Match("\\u0000");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ExceptionChars2()
        {
            var x = new ExceptionChars();
            var (match, remaining) = x.Match("\\u001f");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }
    }
}
