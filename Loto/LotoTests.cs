﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoTests
    {
        [TestMethod]
        public void SixNumbersWinnings()
        {
            Assert.AreEqual(1 / 13983816, CalculateTheOddsOfWinning(6));
        }

        [TestMethod]
        public void FiveNumbersWinnings()
        {
            Assert.AreEqual(43 / 2330636, CalculateTheOddsOfWinning(5));
        }

        decimal CalculateTheOddsOfWinning(decimal winningNumbers)
        {
            decimal combination = 13983816;
            decimal probability = 1 / combination;
            return probability;
        }

    }
}
