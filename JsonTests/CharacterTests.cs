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

        [TestMethod]
        public void CharacterTests2()
        {
            var x = new Character('x');
            var (match, remainng) = x.Match("xa");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "a");
        }

        [TestMethod]
        public void CharacterTests3()
        {
            var x = new Character('x');
            var (match, remainng) = x.Match("ax");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "ax");
        }

        [TestMethod]
        public void CharacterTests4()
        {
            var x = new Character('x');
            var (match, remainng) = x.Match("");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "");
        }

        [TestMethod]
        public void CharacterTestsWhiteSpace()
        {
            var x = new Character('\t');
            var (match, remainng) = x.Match("\t");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "");
        }

        [TestMethod]
        public void CharacterTestsWhiteSpace2()
        {
            var x = new Character('\n');
            var (match, remainng) = x.Match("\n");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "");
        }

        [TestMethod]
        public void CharacterRemainingString()
        {
            var x = new Character('a');
            var (match, remainng) = x.Match("abc");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "bc");
        }

        [TestMethod]
        public void CharacterErrorReporting()
        {
            var x = new Character('a');
            var (match, remainng) = x.Match("b");
            var noMatch = (NoMatch)match;
            Assert.AreEqual(0, noMatch.ErrorPosition);
        }
    }
}
