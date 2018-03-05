using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class AnyUnicodeCharsTests
    {
        [TestMethod]
        public void AnyUnicodeCharsTests1()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\\u0000");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests2()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\\u001fradu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests8()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests9()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("radu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "adu");
        }
    }
}
