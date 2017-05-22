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
            Assert.AreEqual(460, CalculateMonthlyRateDelays(100, 36));
        }

        decimal CalculateMonthlyRateDelays(decimal monthlyRent, int delayedDays)
        {
            decimal[] penalities = { 0.02m, 0.05m, 0.1m };
            decimal PeriodPenalities = GetPeriodPenalities(monthlyRent, delayedDays,penalities);
            return monthlyRent + PeriodPenalities;
        }

        private decimal GetPeriodPenalities(decimal monthlyRent, int delayedDays, decimal[] penalities)
        {
            decimal PeriodPenalities = monthlyRent * delayedDays * penalities[0];
            if (IsLongPeriod(delayedDays))
                PeriodPenalities = monthlyRent * delayedDays * penalities[2];
            else if (IsMediumPeriod(delayedDays))
                PeriodPenalities = monthlyRent * delayedDays * penalities[1];
            return PeriodPenalities;
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
