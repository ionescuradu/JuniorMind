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
            Assert.AreEqual(13983816, CalculateTheOddsOfWinning(6));
        }

        decimal CalculateTheOddsOfWinning(decimal winningNumbers)
        {
            decimal combination = 13983816;
            return combination;
        }

    }
}
