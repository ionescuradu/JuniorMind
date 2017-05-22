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

        [TestMethod]
        public void MonthlyRentForMediumPeriods()
        {
            Assert.AreEqual(160, CalculateMonthlyRateDelays(100, 12));

        }

        decimal CalculateMonthlyRateDelays(decimal monthlyRent, int delayedDays)
        {
            decimal shortPeriodPenalities = delayedDays > 11 ? (monthlyRent * delayedDays * 0.05m) : (monthlyRent * delayedDays * 0.02m);
            return monthlyRent + shortPeriodPenalities;
        }
    }
}
