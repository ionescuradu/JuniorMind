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
            var timeSchedule = new Schedule[7] { new Schedule(8, "Luni"), new Schedule(8, "Marti"), new Schedule(8, "Miercuri"), new Schedule(9, "Joi"), new Schedule(10, "Vineri"), new Schedule(11, "Sambata"), new Schedule(11, "Duminica") };
            Assert.AreEqual(true, AlarmVerifier(8, "Luni", timeSchedule));
        }

        [TestMethod]
        public void SecondAlarmTest()
        {
            var timeSchedule = new Schedule[7] { new Schedule(8, "Luni"), new Schedule(8, "Marti"), new Schedule(8, "Miercuri"), new Schedule(9, "Joi"), new Schedule(10, "Vineri"), new Schedule(11, "Sambata"), new Schedule(11, "Duminica") };
            Assert.AreEqual(false, AlarmVerifier(9, "Luni", timeSchedule));
        }

        public struct Schedule
        {
            public int hour;
            public string dayOfWeek;

            public Schedule(int hour, string dayOfWeek)
            {
                this.dayOfWeek = dayOfWeek;
                this.hour = hour;
            }
        }

        bool AlarmVerifier(int givenHour, string givenDay, Schedule[] program)
        {
            bool setOnAlarm = false;
            for (int i = 0; i < program.Length; i++)
            {
                if (givenDay == program[i].dayOfWeek && givenHour == program[i].hour)
                {
                    setOnAlarm = true;
                }
            }
            return setOnAlarm;
        }
    }
}
