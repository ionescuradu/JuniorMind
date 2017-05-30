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
            int containsFriendPeriod = Cmmdc(myPeriod, friendPeriod);
            int smallestMultiple = myPeriod * friendPeriod / containsFriendPeriod;
            return smallestMultiple;
        }

        private static int Cmmdc(int myPeriod, int friendPeriod)
        {
            int devide = myPeriod % friendPeriod;
            int containsMyPeriod = myPeriod;
            int containsFriendPeriod = friendPeriod;
            while (devide != 0)
            {
                containsMyPeriod = containsFriendPeriod;
                containsFriendPeriod = devide;
                devide = containsMyPeriod % containsFriendPeriod;
            }

            return containsFriendPeriod;
        }
    }
}
