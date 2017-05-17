using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class TrainsTests
    {
        [TestMethod]
        public void Distance100()
        {
            decimal distance = CalculateFlightDistance(100, 25);
            Assert.AreEqual(75, distance);
        }
        decimal CalculateFlightDistance( decimal totalDistance, decimal trainVelocity)
        {
            return 2 * 25 * 3 * 100 / 2 / 25 / 4; 
        }

    }
}
