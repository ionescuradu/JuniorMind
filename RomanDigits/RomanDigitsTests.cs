using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanDigits
{
    [TestClass]
    public class RomanDigitsTests
    {
        [TestMethod]
        public void TestForOneDigitNumber()
        {
            Assert.AreEqual("V", CalculateRomanNumber(5));
        }

        string CalculateRomanNumber(int givenNumber)
        {
            string convertedNumber = "V";
            return convertedNumber;
        }
    }
}
