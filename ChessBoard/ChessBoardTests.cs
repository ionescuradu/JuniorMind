using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class ChessBoardTests
    {
        [TestMethod]
        public void TestForFourSquareDimensionOfChessBoard()
        {
            Assert.AreEqual(5, CalculateNumberOfSquaresOnChessBoard(2));
        }

        int CalculateNumberOfSquaresOnChessBoard(int chessDimension)
        {
            int numberOfSquares = chessDimension * chessDimension + 1;
            return numberOfSquares;
        }
    }
}
