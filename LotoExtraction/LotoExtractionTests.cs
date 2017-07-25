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
            int index = 0;
            while (index != givenNumbers.Length)
            {
                var aux = 0;
                var pos = index;
                for (int i = index; i < givenNumbers.Length; i++)
                {
                    if ( givenNumbers[pos] < givenNumbers[i])
                    {
                        pos = i;
                    }
                }
                aux = givenNumbers[pos];
                givenNumbers[pos] = givenNumbers[index];
                givenNumbers[index] = aux;                
                index += 1;
            }
            return givenNumbers;
        }
    }
}
