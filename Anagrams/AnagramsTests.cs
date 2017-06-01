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

        decimal CalculateNumberOfAnagrams(string givenWord)
        {
            decimal nrOfAnagrams = NumberOfPermutation(givenWord) / NumberOfRepeatingLetters(givenWord);
            return nrOfAnagrams;
        }

        private decimal NumberOfRepeatingLetters(string givenWord)
        {
            decimal numberOfRepetition = 1;
            decimal maxRepetetion = 1; 
            for (int i = 0; i < givenWord.Length; i++)
            {
                
                numberOfRepetition = CalculateNumberOfRepeatingLetters(givenWord, numberOfRepetition, i);
                maxRepetetion = maxRepetetion * NumberOfPermutationForAGivenNumber(numberOfRepetition);
            }
            return maxRepetetion;
        }

        private static decimal CalculateNumberOfRepeatingLetters(string givenWord, decimal numberOfRepetition, int i)
        {
            decimal repetition = 1;
            numberOfRepetition = 1;
            for (int j = i + 1; j < givenWord.Length; j++)
            {
                if (givenWord[i] == givenWord[j])
                    repetition += 1;
            }
            if (numberOfRepetition < repetition)
                numberOfRepetition = repetition;
            return numberOfRepetition;
        }

        private decimal NumberOfPermutation(string givenWord)
        {
            decimal result = 1;
            for (int i = 1; i <= givenWord.Length; i++)
            {
                result = result * i;
            }
            return result;
        }

        private decimal NumberOfPermutationForAGivenNumber(decimal NumberOfRepetion)
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
