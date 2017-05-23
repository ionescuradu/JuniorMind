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

        string CalculateRomanNumber(int givenNumber)
        {
            string convertedNumber = "";
            switch (givenNumber)
            {
                case 1:
                    convertedNumber = "I";
                    break;
                case 2:
                    convertedNumber = "II";
                    break;
                case 3:
                    convertedNumber = "III";
                    break;
                case 4:
                    convertedNumber = "IV";
                    break;
                case 5:
                    convertedNumber = "V";
                    break;
                case 6:
                    convertedNumber = "VI";
                    break;
                case 7:
                    convertedNumber = "VII";
                    break;
                case 8:
                    convertedNumber = "VIII";
                    break;
                case 9:
                    convertedNumber = "IX";
                    break;
            }
            return convertedNumber;
        }
    }
}
