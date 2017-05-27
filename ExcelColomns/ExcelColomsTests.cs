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

        string CalculateExcelColomns(int numberOfColomn)
        {
            string colomnIndex = "A";
            return colomnIndex;
        }
    }
}
