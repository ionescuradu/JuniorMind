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
            var (match, remaining) = x.Match("\u0000");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "\u0000");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests2()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\u001f");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "\u001f");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests3()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\u002f");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests4()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\\u0022");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "\\u0022");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests5()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\\u005C");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "\\u005C");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests6()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\\u005D");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void AnyUnicodeCharsTests7()
        {
            var x = new AnyUnicodeChars();
            var (match, remaining) = x.Match("\u005D");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
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
