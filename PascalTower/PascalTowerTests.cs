using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTower
{
    [TestClass]
    public class PascalTowerTests
    {
        [TestMethod]
        public void PascalFirstTest()
        {
            CollectionAssert.AreEqual(new int[1] { 1 }, Triangle(1));
        }

        [TestMethod]
        public void PascalSecondTest()
        {
            CollectionAssert.AreEqual(new int[2] { 1 , 1 }, Triangle(2));
        }

        [TestMethod]
        public void PascalThirdTest()
        {
            CollectionAssert.AreEqual(new int[5] { 1, 4, 6, 4, 1}, Triangle(5));
        }

        [TestMethod]
        public void PascalFourthTest()
        {
            CollectionAssert.AreEqual(new int[7] { 1, 6, 15, 20, 15, 6, 1 }, Triangle(7));
        }

        int[] Triangle(int row)
        {
            int[] triangleLevel = new int[row];
            for (int i = 0; i < row; i++)
            {
                triangleLevel[i] = Pascal(row, i + 1);
            }
            return triangleLevel;
        }

        private int Pascal(int row, int element)
        {
            if (row <= 2 || element == 1 || row == element)
                return 1;
            return Pascal(row - 1, element - 1) + Pascal(row - 1, element);
        }
    }
}
