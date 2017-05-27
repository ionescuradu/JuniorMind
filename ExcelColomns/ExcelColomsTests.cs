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

        string CalculateExcelColomns(int numberOfColomn)
        {
            string alphabetLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string colomnIndex = alphabetLetters[numberOfColomn % 26 - 1].ToString();
            return colomnIndex;
        }
    }
}
