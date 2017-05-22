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

        [TestMethod]
        public void MonthlyRateForLongPeriods()
        {
            Assert.AreEqual(410, CalculateMonthlyRateDelays(100, 31));
        }

        decimal CalculateMonthlyRateDelays(decimal monthlyRent, int delayedDays)
        {
            decimal PeriodPenalities = monthlyRent * delayedDays * 0.02m;
            if (IsLongPeriod(delayedDays))
                PeriodPenalities = monthlyRent * delayedDays * 0.1m;
            else if (IsMediumPeriod(delayedDays))
                PeriodPenalities = monthlyRent * delayedDays * 0.05m;
            return monthlyRent + PeriodPenalities;
        }

        private bool IsLongPeriod(int delayedDays)
        {
            return delayedDays > 30;
        }

        private static bool IsMediumPeriod(int delayedDays)
        {
            return delayedDays > 10;
        }

        
    }
}
