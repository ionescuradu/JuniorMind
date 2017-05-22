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

        [TestMethod]
        public void TestForNumberFifteen()
        {
            Assert.AreEqual("FizzBuzz", CalculateNumberDivision(15));
        }

        string CalculateNumberDivision(decimal givenNumber)
        {
            string[] textes = { "FizzBuzz", "Fizz", "Buzz"};
            string outcome = CalculateNumberMultiple(givenNumber, textes);
            return outcome;
        }

        private static string CalculateNumberMultiple(decimal givenNumber, string[] textes )
        {
            string outcome = "";
            if (givenNumber % 3 == 0)
                if (givenNumber % 5 == 0)
                    return textes[0];
                else return textes[1];
            else if (givenNumber % 5 == 0)
                return textes[2];
            return outcome;
        }
    }
}
