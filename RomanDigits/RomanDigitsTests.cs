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

        [TestMethod]
        public void TestForOneDigitNumberTestTwo()
        {
            Assert.AreEqual("VIII", CalculateRomanNumber(8));
        }

        [TestMethod]
        public void TestForTwoDigitsNumber()
        {
            Assert.AreEqual("XX", CalculateRomanNumber(20));
        }

        [TestMethod]
        public void TestForTwoDigitsNumberSecondTest()
        {
            Assert.AreEqual("XXVII", CalculateRomanNumber(27));
        }

        [TestMethod]
        public void TestForTwoDigitsNumberThirdTest()
        {
            Assert.AreEqual("XCII", CalculateRomanNumber(92));
        }

        string CalculateRomanNumber(int givenNumber)
        {
            return RomanNumberForTwoDigitNumbers(givenNumber);

        }

        private static string RomanNumberForTwoDigitNumbers(int givenNumber)
        {
            string outcome = "";
            int firstDigit = givenNumber / 10;
            int secondDigit = givenNumber % 10;

            string[] firstDigitString = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            string[] secondDigitString = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            outcome = firstDigitString [firstDigit] + secondDigitString [secondDigit];
            return outcome;
        }
    }
}
