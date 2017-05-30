using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoTests
    {
        [TestMethod]
        public void SixNumbersWinnings()
        {
            Assert.AreEqual(0.0000000715112384201851626194m, CalculateTheOddsOfWinning(6));
        }

        [TestMethod]
        public void FiveNumbersWinnings()
        {
            Assert.AreEqual(0.0000184498995124077719558095m, CalculateTheOddsOfWinning(5));
        }

        [TestMethod]
        public void FourNumbersWinnings()
        {
            Assert.AreEqual(0.0009686197244014080276799981m, CalculateTheOddsOfWinning(4));
        }

        decimal CalculateTheOddsOfWinning(decimal winningNumbers)
        {
            decimal combination = CalculaterRemainingFactorialNumbers(43) / CalculateFactorialWinningNumbers(6) ;
            decimal probability = CalculateFactorialForFirstDenominator(winningNumbers) * CalculateFactorialForSecondDenominator(winningNumbers) / combination / CalculateFactorialWinningNumbers(6 - winningNumbers) / CalculateFactorialWinningNumbers(6 - winningNumbers);
            return probability;
        }
        
        private decimal CalculateFactorialWinningNumbers(decimal winningNumbers)
        {
            decimal factorialNumber = 1;
            for (int i = 1; i <= winningNumbers; i++)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;

        }
        
        private decimal CalculateFactorialForFirstDenominator(decimal winningNumbers)
        {
            decimal factorialNumber = 1;
            for (int i = 6; i > winningNumbers ; i--)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;
        }

        private decimal CalculateFactorialForSecondDenominator(decimal winningNumbers)
        {
            decimal factorialNumber = 1;
            for (int i = 43; i > (43 - 6 + winningNumbers); i--)
            {
                factorialNumber = factorialNumber * i;
            }
           return factorialNumber;
        }

        private static decimal CalculaterRemainingFactorialNumbers(decimal givingNumber)
        {
            decimal factorialNumber = 1;
            for (int i = 49; i > givingNumber; i--)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;
        }
    }
}
