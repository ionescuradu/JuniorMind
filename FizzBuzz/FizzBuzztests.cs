using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzztests
    {
        [TestMethod]
        public void TestForNumberThree()
        {
            Assert.AreEqual("FIZZ", CalculateNumberDivision(3));
        }

        string CalculateNumberDivision(decimal givenNumber)
        {
            string outcome = "FIZZ";
            return outcome;
        }
    }
}
