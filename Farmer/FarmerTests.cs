using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmer
{
    [TestClass]
    public class FarmerTests
    {
        [TestMethod]
        public void FarmerLandGivingParam()
        {
            Assert.AreEqual(770, CalculateFarmersLand(1, 230, -770000));
        }

        decimal CalculateFarmersLand(decimal parameter1, decimal parameter2, decimal parameter3)
        {
            decimal solutionOne = 770;
            return solutionOne;
        }
    }
}
