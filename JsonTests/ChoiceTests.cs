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
        public void ChoiceTest2()
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

        [TestMethod]
        public void ChoiceTest3()
        {
            string input = "raduionescu";
            var x = new Range('a', 'z'); //aduionescu => r
            var y = new Any("abcd"); // duionescu => a
            var z = new Any("dpqr"); // uionescu => d
            var t = new Any("yzt"); // uionescu
            var q = new Any("abrai"); // uionescu
            var choiceFirst = new Choice(x, y);
            var choice = new Choice(choiceFirst, z, t, q);
            var (match, remaining) = choice.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "uionescu");
        }

    }
}
