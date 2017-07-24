using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoExtraction
{
    [TestClass]
    public class LotoExtractionTests
    {
        [TestMethod]
        public void LotoSortingFirstTest()
        {
            CollectionAssert.AreEqual(new int[3] { 6, 5, 4}, LotoSorting(new int[3] { 4, 5, 6} ) );
        }

        [TestMethod]
        public void LotoSortingSecondTest()
        {
            CollectionAssert.AreEqual(new int[5] { 46, 45, 24, 17, 7 }, LotoSorting(new int[5] { 7, 46, 24, 17, 45 }));
        }

        int[] LotoSorting(int[] givenNumbers)
        {
            int[] sortedNumbers = new int[givenNumbers.Length];
            int index = 0;
            while (index != givenNumbers.Length)
            {
                int max = givenNumbers[0];
                var pos = 0;
                for (int i = 0; i < givenNumbers.Length; i++)
                {
                    if (max < givenNumbers[i])
                    {
                        max = givenNumbers[i];
                        pos = i;
                    }
                }
                givenNumbers[pos] = 0;
                sortedNumbers[index] = max;
                index += 1;
            }
            return sortedNumbers;
        }
    }
}
