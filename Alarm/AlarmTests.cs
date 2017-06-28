using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void FirstAlarmTest()
        {
            Assert.AreEqual(true, AlarmVerifier(new Alarm(4, DaysOfWeek.Tuesday | DaysOfWeek.Thursday), DaysOfWeek.Tuesday, 4));
        }

        [TestMethod]
        public void SecondAlarmTest()
        {
            Assert.AreEqual(false, AlarmVerifier(new Alarm(4, DaysOfWeek.Tuesday | DaysOfWeek.Thursday | DaysOfWeek.Friday), DaysOfWeek.Monday, 4));
        }

        [TestMethod]
        public void ThirdAlarmTest()
        {
            Assert.AreEqual(false, AlarmVerifier(new Alarm(4, DaysOfWeek.Tuesday | DaysOfWeek.Thursday), DaysOfWeek.Tuesday, 3));
        }

        [Flags]
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
        struct Alarm
        {
            public DaysOfWeek days;
            public int hour;

            public Alarm(int hour, DaysOfWeek days)
            {
                this.days = days;
                this.hour = hour;
            }
        }

        bool AlarmVerifier(Alarm alarm, DaysOfWeek currentDay, int currentHour)
        {
            return isSet(alarm.days, currentDay) && currentHour == alarm.hour;
        }

        private bool isSet(DaysOfWeek daySet, DaysOfWeek currentDay)
        {
            return (daySet & currentDay) != 0;
        }
    }
}
