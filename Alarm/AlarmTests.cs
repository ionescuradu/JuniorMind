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
            var AlarmSchedule = new DaysOfWeek[] { DaysOfWeek.Monday};
            Assert.AreEqual(true,AlarmVerifier(6, "Monday", AlarmSchedule));
        }
        [Flags]
        enum DaysOfWeek
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        bool AlarmVerifier(int givenHour, string givenDay, DaysOfWeek[] AlarmSchedule)
        {
            bool setOnAlarm = false;
            for (int i = 0; i < AlarmSchedule.Length; i++)
            {
                if (AlarmSchedule[i].HasFlag == )
                {

                }
            }
            return setOnAlarm;
        }
    }
}
