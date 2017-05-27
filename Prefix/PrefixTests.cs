﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTests
    {
        [TestMethod]
        public void OneLetterCommonPrefix()
        {
            Assert.AreEqual("a", CalculateCommonPrefix("aab", "aba"));
        }

        [TestMethod]
        public void TwoLettersCommonPrefix()
        {
            Assert.AreEqual("aa", CalculateCommonPrefix("aad", "aabc"));
        }

        [TestMethod]
        public void ThreeLettersCommonPrefix()
        {
            Assert.AreEqual("aaa", CalculateCommonPrefix("aaabc", "aaacb"));
        }

        string CalculateCommonPrefix (string firstString, string secondString)
        {
            string commonPrefix = "";
            for ( int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i])
                    commonPrefix += firstString[i].ToString();
            }              
            return commonPrefix;
        }
    }
}
