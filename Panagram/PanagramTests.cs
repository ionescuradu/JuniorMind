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

        bool CalculateIfWordPanagram(string inputSentence)
        {
            string allLetters = "abcdefghijklmnopqrstuvwxyz ";
            bool isPanagram = false;
            int numberOfFindings = 0;
            for (int i = 0; i < allLetters.Length; i++)
            {
                for (int j = 0; j < inputSentence.Length; j++)
                {
                    if (allLetters[i] == inputSentence[j])
                    {
                        isPanagram = true;
                    }
                    if (isPanagram == true)
                        numberOfFindings += 1;
                    isPanagram = false;
                }
            }
            if (numberOfFindings >= 26)
                isPanagram = true;
            else isPanagram = false;
            return isPanagram;
        }

    }
}
