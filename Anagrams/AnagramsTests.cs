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

        [TestMethod]
        public void ThreeLetterWordWithRepeatingLetter()
        {
            Assert.AreEqual(3, CalculateNumberOfAnagrams("ANA"));
        }

        [TestMethod]
        public void FourLetterWordRepeatingLetter()
        {
            Assert.AreEqual(12, CalculateNumberOfAnagrams("MERE"));
        }

        [TestMethod]
        public void TenLettersMultipleRepeatingLetters()
        {
            Assert.AreEqual(12600, CalculateNumberOfAnagrams("AAAABBCDDD"));
        }

        decimal CalculateNumberOfAnagrams(string givenWord)
        {
            decimal nrOfAnagrams = CalculateNumberOfPermutation(givenWord) / CalculateNumberOfRepeatingLetters(givenWord);
            return nrOfAnagrams;
        }

        private decimal CalculateNumberOfRepeatingLetters(string givenWord)
        {
            decimal maxRepetition = 1;
            for (char i = 'A'; i < 'Z'; i++)
            {
                decimal numberOfRepetition = 0;
                for (int j = 0; j < givenWord.Length; j++)
                {
                    if (i == givenWord[j])
                        numberOfRepetition += 1;
                }
                maxRepetition = maxRepetition * CalculateNumberOfPermutationForAGivenNumber(numberOfRepetition);
            }
            return maxRepetition;
        }

        private decimal CalculateNumberOfPermutation(string givenWord)
        {
            decimal result = 1;
            for (int i = 1; i <= givenWord.Length; i++)
            {
                result = result * i;
            }
            return result;
        }

        private decimal CalculateNumberOfPermutationForAGivenNumber(decimal NumberOfRepetion)
        {
            decimal result = 1;
            for (int i = 1; i <= NumberOfRepetion; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
