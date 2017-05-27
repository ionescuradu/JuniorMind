using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColomns
{
    [TestClass]
    public class ExcelColomsTests
    {
        [TestMethod]
        public void ColomnATest()
        {
            Assert.AreEqual("A", CalculateExcelColomns(1));
        }

        [TestMethod]
        public void ColomnMtest()
        {
            Assert.AreEqual("M", CalculateExcelColomns(13));
        }

        [TestMethod]
        public void ColomnXTest()
        {
            Assert.AreEqual("X", CalculateExcelColomns(24));
        }

        [TestMethod]
        public void ColomnABTests()
        {
            Assert.AreEqual("AA", CalculateExcelColomns(27));
        }

        [TestMethod]
        public void ColomnZTest()
        {
            Assert.AreEqual("Z", CalculateExcelColomns(26));
        }

        [TestMethod]
        public void ColomnAYTest()
        {
            Assert.AreEqual("AY", CalculateExcelColomns(51));
        }

        [TestMethod]
        public void ColomnAZTest()
        {
            Assert.AreEqual("BZ", CalculateExcelColomns(78));
        }

        [TestMethod]
        public void ColomnAAATest()
        {
            Assert.AreEqual("AAA", CalculateExcelColomns(677));
        }

        [TestMethod]
        public void ColomnABATest()
        {
            Assert.AreEqual("ACB", CalculateExcelColomns(730));
        }


        string CalculateExcelColomns(int numberOfColomn)
        {
            string colomnIndex = "";
            string alphabetLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (numberOfColomn < 27)
                colomnIndex = alphabetLetters[numberOfColomn - 1].ToString();
            else
            {
                decimal n = numberOfColomn / 26;
                int remainingLetters = numberOfColomn;
                int total = 0;
                while ( n >= 26)
                {
                    total += 1;
                    n = n / 26;
                    remainingLetters = numberOfColomn / 26 + 1;
                }
                if (total != 0)
                    colomnIndex = alphabetLetters[total - 1].ToString();
                if (remainingLetters % 26 == 0)
                    colomnIndex = alphabetLetters[remainingLetters / 26 - 2].ToString() + alphabetLetters[25].ToString();
                else
                    if (remainingLetters != numberOfColomn)
                        colomnIndex = colomnIndex + alphabetLetters[remainingLetters - 27].ToString() + alphabetLetters[numberOfColomn - (numberOfColomn / 26) * 26 -1].ToString();
                    else colomnIndex = colomnIndex + alphabetLetters[numberOfColomn / 26 - 1].ToString() + alphabetLetters[numberOfColomn % 26 - 1].ToString();
            }
            return colomnIndex;
        }
    }
}
