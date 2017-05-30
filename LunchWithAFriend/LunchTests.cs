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

        [TestMethod]
        public void Cmmc8And6()
        {
            Assert.AreEqual(24, CalculateNextMeetingWithFriend(8, 6));
        }

        int CalculateNextMeetingWithFriend(int myPeriod, int friendPeriod)
        {
            int smallestMultiple = 12;
            return smallestMultiple;
        }
    }
}
