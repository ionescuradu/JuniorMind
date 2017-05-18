using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavementForMarket
{
    [TestClass]
    public class PavementForMarketTests
    {
        [TestMethod]
        public void NumberOfPavementForSixBySixMarket()
        {
            decimal numberOfStone = totalNumberOfCubicalStone(6, 6, 4);
            Assert.AreEqual(4, numberOfStone);
        }

        decimal totalNumberOfCubicalStone( decimal marketDimensionOne, decimal marketDimensionTwo, decimal pavementDimension)
        {
            return Math.Ceiling( marketDimensionOne / pavementDimension ) * Math.Ceiling( marketDimensionTwo / pavementDimension);
        }
    }
}
