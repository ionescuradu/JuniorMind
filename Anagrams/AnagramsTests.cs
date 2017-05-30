using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public void ThreeLettersWord()
        {
            Assert.AreEqual(6, CalculateNumberOfAnagrams(3));
        }

        [TestMethod]
        public void FourLetterWord()
        {
            Assert.AreEqual(24, CalculateNumberOfAnagrams(4));
        }

        decimal CalculateNumberOfAnagrams(int wordLenght)
        {
            decimal nrOfAnagrams = numberOfPermutation(wordLenght);
            return nrOfAnagrams;
        }

        private decimal numberOfPermutation(int wordLenght)
        {
            decimal result = 1;
            for (int i = 1; i <= wordLenght; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
