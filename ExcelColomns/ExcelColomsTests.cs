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

        string CalculateExcelColomns(int numberOfColomn)
        {
            string colomnIndex;
            string alphabetLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (numberOfColomn < 27)
                colomnIndex = alphabetLetters[numberOfColomn % 26 - 1].ToString();
            else colomnIndex = alphabetLetters[numberOfColomn / 26 - 1].ToString() + alphabetLetters[numberOfColomn % 26 - 1].ToString(); 
            return colomnIndex;
        }
    }
}
