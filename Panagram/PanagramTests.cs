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

        bool CalculateIfWordPanagram(string inputSentence)
        {
            string allLetters = "abcdefghijklmnopqrstuvwxyz";
            bool isPanagram = false;
            return isPanagram;
        }

    }
}
