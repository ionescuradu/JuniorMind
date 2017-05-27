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
            string commonPrefix = "";
            if (firstString[0] == secondString[0])
            {
                if (firstString[1] == secondString[1])
                {
                    commonPrefix = firstString[0].ToString() + firstString[1].ToString();
                }
                else commonPrefix = firstString[0].ToString();
            }
            return commonPrefix;
        }
    }
}
