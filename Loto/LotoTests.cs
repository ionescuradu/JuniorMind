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
            Assert.AreEqual(0.0000000715112384201851626194d, CalculateTheOddsOfWinning(49, 6, 6), 0.00000001d);
        }

        [TestMethod]
        public void FiveNumbersWinnings()
        {
            Assert.AreEqual(0.0000184498995124077719558095d, CalculateTheOddsOfWinning(49, 6, 5), 0.00000001d);
        }

        [TestMethod]
        public void FourNumbersWinnings()
        {
            Assert.AreEqual(0.0009686197244014080276799981d, CalculateTheOddsOfWinning(49, 6 ,4), 0.00000001d);
        }

        [TestMethod]
        public void FiveNumbersFromForty()
        {
           Assert.AreEqual(0.00000042906743052111097571649970222d, CalculateTheOddsOfWinning(40, 5, 5), 0.00000001d);
        }

        double CalculateTheOddsOfWinning(double totalNumbers, double numberOfExtractions ,double winningNumbers)
        {
            double combination = CalculateFactorialNumbers(totalNumbers) / CalculateFactorialNumbers(numberOfExtractions) / CalculateFactorialNumbers(totalNumbers - numberOfExtractions);
            double winningNumberCombination = CalculateFactorialNumbers(numberOfExtractions) / CalculateFactorialNumbers(winningNumbers) / CalculateFactorialNumbers(numberOfExtractions - winningNumbers);
            double remainingNumberCombination = CalculateFactorialNumbers(totalNumbers - numberOfExtractions) / CalculateFactorialNumbers(numberOfExtractions - winningNumbers) / CalculateFactorialNumbers(totalNumbers - 2 * numberOfExtractions + winningNumbers);
            double probability = winningNumberCombination * remainingNumberCombination / combination;
            return probability;
        }

        private double CalculateFactorialNumbers(double totalNumbers)
        {
            double factorialNumber = 1;
            for (int i = 1; i <= totalNumbers; i++)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;

        }

    }
}
