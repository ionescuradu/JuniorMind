using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonthlyRent
{
    [TestClass]
    public class MonthlyRentTests
    {
        [TestMethod]
        public void MonthlyRentForShortPeriod()
        {
            Assert.AreEqual(102, CalculateMonthlyRateDelays(100, 1));
        }

        decimal CalculateMonthlyRateDelays(decimal monthlyRent, int delayedDays)
        {
            decimal shortPeriodPenalities = monthlyRent * delayedDays * 0.02m;
            return monthlyRent + shortPeriodPenalities;
        }
    }
}
