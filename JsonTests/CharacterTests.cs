﻿using System;
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
    }
}