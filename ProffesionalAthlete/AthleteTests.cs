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
            return ( numberOfRounds * (numberOfRounds + 1) + (numberOfRounds - 1) * numberOfRounds ) / 2 ;
        }
    }
}
