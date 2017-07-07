using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringReversing
{
    [TestClass]
    public class StringReversingTests
    {
        [TestMethod]
        public void ReverseStringFirst()
        {
            Assert.AreEqual("udar", ReverseString("radu"));
        }

        string ReverseString(string givenString)
        {
            if (givenString.Length > 0)
            {
                return givenString[givenString.Length - 1] + ReverseString(givenString.Substring(0, givenString.Length - 1));
            }
            else return givenString;
        }
    }
}
