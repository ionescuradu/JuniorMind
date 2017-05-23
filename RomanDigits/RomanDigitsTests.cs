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

        string CalculateRomanNumber(int givenNumber)
        {
            return RomanNumberForTwoDigitNumbers(givenNumber);

        }

        private static string RomanNumberForTwoDigitNumbers(int givenNumber)
        {
            string convertedFirstNumber = "";
            string convertedSecondNumber = "";
            string outcome = "";
            decimal firstDigit = givenNumber / 10;
            decimal secondDigit = givenNumber % 10;

            switch (firstDigit)
            {
                case 1:
                    convertedFirstNumber = "X";
                    break;
                case 2:
                    convertedFirstNumber = "XX";
                    break;
                case 3:
                    convertedFirstNumber = "XXX";
                    break;
                case 4:
                    convertedFirstNumber = "XL";
                    break;
                case 5:
                    convertedFirstNumber = "L";
                    break;
                case 6:
                    convertedFirstNumber = "LX";
                    break;
                case 7:
                    convertedFirstNumber = "LXX";
                    break;
                case 8:
                    convertedFirstNumber = "LXXX";
                    break;
                case 9:
                    convertedFirstNumber = "XC";
                    break;
                case 10:
                    convertedFirstNumber = "C";
                    break;
            }

            switch (secondDigit)
            {
                case 1:
                    convertedSecondNumber = "I";
                    break;
                case 2:
                    convertedSecondNumber = "II";
                    break;
                case 3:
                    convertedSecondNumber = "III";
                    break;
                case 4:
                    convertedSecondNumber = "IV";
                    break;
                case 5:
                    convertedSecondNumber = "V";
                    break;
                case 6:
                    convertedSecondNumber = "VI";
                    break;
                case 7:
                    convertedSecondNumber = "VII";
                    break;
                case 8:
                    convertedSecondNumber = "VIII";
                    break;
                case 9:
                    convertedSecondNumber = "IX";
                    break;
            }
            outcome = convertedFirstNumber + convertedSecondNumber;
            return outcome;
        }
    }
}
