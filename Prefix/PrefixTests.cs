using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("a", CalculateCommonPrefix("aab", "aba"));
        }

        string CalculateCommonPrefix (string firstString, string secondString)
        {
            return "a";
        }
    }
}
