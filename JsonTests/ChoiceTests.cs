﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ChoiceTests
    {
        [TestMethod]
        public void ChoiceTest1()
        {
            string input = "-radu";
            var x = new Choice("-");
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "radu");
        }
    }
}
