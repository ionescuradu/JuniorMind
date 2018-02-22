using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ChoiceTests
    {
        [TestMethod]
        public void ChoiceTest1()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("bcd");
            var choices = new Choice(x, y);
            var (match, remaining) = choices.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "adu");
        }

        [TestMethod]
        public void SequanceTest2()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("mno");
            var z = new Any("abc");
            var choices = new Choice(x, y, z);
            var (match, remaining) = choices.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "du");
        }
    }
}
