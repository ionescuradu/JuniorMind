using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProffesionalAthlete
{
    [TestClass]
    public class AthleteTests
    {
        [TestMethod]
        public void TenRounds()
        {
            int result = numberOfRepetitions(10);
            Assert.AreEqual(100, result);
        }
        int numberOfRepetitions(int numberOfRounds)
        {
            int ascendingPart = numberOfRounds * (numberOfRounds + 1) / 2 ;
            int descendingPart = (numberOfRounds - 1) * numberOfRounds  / 2 ;
            return ascendingPart + descendingPart;
        }
    }
}
