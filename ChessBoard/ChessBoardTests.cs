using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class ChessBoardTests
    {
        [TestMethod]
        public void TestForTwoSquareDimensionOfChessBoard()
        {
            Assert.AreEqual(5, CalculateNumberOfSquaresOnChessBoard(2));
        }

        [TestMethod]
        public void TestForThreeSquareDimensionOfChessBoard()
        {
            Assert.AreEqual(14, CalculateNumberOfSquaresOnChessBoard(3));
        }

        [TestMethod]
        public void TestForFourSquareDimensionOfChessBoard()
        {
            Assert.AreEqual(30, CalculateNumberOfSquaresOnChessBoard(4));

        }

        int CalculateNumberOfSquaresOnChessBoard(int chessDimension)
        {
            int numberOfTwoByTwoSquare = Convert.ToInt32( Math.Pow(chessDimension - 1, 2));
            int numberOfThreeByThreeSquare = Convert.ToInt32(Math.Pow(chessDimension - 2, 2));
            int numberOfFourByFourSquare = Convert.ToInt32(Math.Pow(chessDimension - 3, 2));
            int numberOfSquares = chessDimension * chessDimension + numberOfTwoByTwoSquare + numberOfThreeByThreeSquare + numberOfFourByFourSquare;
            return numberOfSquares;
        }
    }
}
