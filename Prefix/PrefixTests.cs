using System;
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
            Assert.AreEqual("aa", CalculateCommonPrefix("aab", "aabc"));
        }

        string CalculateCommonPrefix (string firstString, string secondString)
        {
            string commonPrefix = "a";
            return commonPrefix;
        }
    }
}
