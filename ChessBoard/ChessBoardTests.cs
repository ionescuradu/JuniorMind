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

        [TestMethod]
        public void TestForFiveSquareDimensionOfChessBoard()
        {
            Assert.AreEqual(55, CalculateNumberOfSquaresOnChessBoard(5));

        }

        int CalculateNumberOfSquaresOnChessBoard(int chessDimension)    
        {
            int numberOfSquares = 0;
            for (int i = 1; i <= chessDimension; i++)
            {
                numberOfSquares += Convert.ToInt32(Math.Pow(i, 2));
            }
            return numberOfSquares;
        }
    }
}
