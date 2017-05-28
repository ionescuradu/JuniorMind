using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class PanagramTests
    {
        [TestMethod]
        public void FirstSentence()
        {
            Assert.AreEqual(false, CalculateIfWordPanagram("The quick brown fox"));
        }

        [TestMethod]
        public void SecondSentence()
        {
            Assert.AreEqual(true, CalculateIfWordPanagram("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void ThirdSentence()
        {
            Assert.AreEqual (true, CalculateIfWordPanagram("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void FourthSentence()
        {
            Assert.AreEqual(false, CalculateIfWordPanagram("The quick brown fox jumps over the lazy do"));
        }

        bool CalculateIfWordPanagram(string inputSentence)
        {
            bool isPanagram = false;
            for (char i = 'a'; i <= 'z' ; i++)
            {
                isPanagram = false;
                isPanagram = Contains(inputSentence, isPanagram, i);
                if (isPanagram != true)
                    return isPanagram;
            }
            return isPanagram;
        }

        private static bool Contains(string inputSentence, bool isPanagram, char i)
        {
            for (int j = 0; j < inputSentence.Length; j++)
            {
                if (i == inputSentence[j])
                {
                    isPanagram = true;
                }
            }

            return isPanagram;
        }
    }
}
