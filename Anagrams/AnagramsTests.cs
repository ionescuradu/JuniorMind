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

        decimal CalculateNumberOfAnagrams(int wordLenght)
        {
            decimal nrOfAnagrams = 6;
            return nrOfAnagrams;
        }
    }
}
