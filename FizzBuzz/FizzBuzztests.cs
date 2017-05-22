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
            Assert.AreEqual("Fizz", CalculateNumberDivision(3));
        }

        [TestMethod]
        public void TestForNumberFive()
        {
            Assert.AreEqual("Buzz",CalculateNumberDivision(5));
        }

        string CalculateNumberDivision(decimal givenNumber)
        {
            string outcome = "";
            if (givenNumber % 3 == 0)
                if (givenNumber % 5 == 0)
                    outcome = "FizzBuzz";
                else outcome = "Fizz";
            else if (givenNumber % 5 == 0)
                outcome = "Buzz";
            return outcome;
        }
    }
}
