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
            Assert.AreEqual(6, CalculateNumberOfAnagrams("MAR"));
        }

        [TestMethod]
        public void FourLetterWord()
        {
            Assert.AreEqual(24, CalculateNumberOfAnagrams("OAIE"));
        }

        [TestMethod]
        public void FiveLetterWord()
        {
            Assert.AreEqual(120, CalculateNumberOfAnagrams("CAINE"));
        }

        decimal CalculateNumberOfAnagrams(string givenWord)
        {
            decimal nrOfAnagrams = numberOfPermutation(givenWord);
            return nrOfAnagrams;
        }

        private decimal numberOfPermutation(string givenWord)
        {
            decimal result = 1;
            for (int i = 1; i <= givenWord.Length; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
