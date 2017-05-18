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

        [TestMethod]
        public void NumberOfPavementForTwelveByNineMarket()
        {
            decimal numberOfStone = totalNumberOfCubicalStone(12, 9, 4);
            Assert.AreEqual(9, numberOfStone);
        }

        decimal totalNumberOfCubicalStone( decimal marketDimensionOne, decimal marketDimensionTwo, decimal pavementDimension)
        {
            decimal horizontalStones = Math.Ceiling(marketDimensionOne / pavementDimension);
            decimal verticalStones = Math.Ceiling(marketDimensionTwo / pavementDimension);
            return horizontalStones * verticalStones;
        }
    }
}
