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
            var (match, remaining) = x.Match("\\u1234");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "");
        }
    }
}
