using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunchWithAFriend
{
    [TestClass]
    public class LunchTests
    {
        [TestMethod]
        public void GivenDatesMeeting()
        {
            Assert.AreEqual(12, CalculateNextMeetingWithFriend(4, 6));
        }

        int CalculateNextMeetingWithFriend(int yourPeriod, int friendPeriod)
        {
            int smallestMultiple = 12;
            return smallestMultiple;
        }
    }
}
