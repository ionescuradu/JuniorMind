﻿using System;
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
            var (match, remaining) = x.Match("\\u1234");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void SpecialCharsTest2()
        {
            var x = new SpecialChars();
            var (match, remaining) = x.Match("\\t");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void SpecialCharsTest3()
        {
            var x = new SpecialChars();
            var (match, remaining) = x.Match("radu");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void SpecialCharsTest4()
        {
            var x = new SpecialChars();
            var (match, remaining) = x.Match("\u1234");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "\u1234");
        }

        [TestMethod]
        public void SpecialCharsTest5()
        {
            var x = new SpecialChars();
            var (match, remaining) = x.Match("\\n");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }
    }
}
