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
            int numberOfFindings = 0;
            for (char i = 'a'; i <= 'a'+25 ; i++)
            {
                for (int j = 0; j < inputSentence.Length; j++)
                {
                    if (i == inputSentence[j])
                    {
                        isPanagram = true;
                    }
                }
                if (isPanagram == true)
                    numberOfFindings += 1;
                isPanagram = false;
            }
            if (numberOfFindings >= 26)
                isPanagram = true;
            return isPanagram;
        }

    }
}
