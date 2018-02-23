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
            Assert.AreEqual(remaining, "adu");
        }

        [TestMethod]
        public void ChoiceTest3()
        {
            string input = "raduionescu";
            var x = new Range('0', '9'); 
            var y = new Any("abcd"); 
            var z = new Any("dpqr"); 
            var t = new Any("yzt"); 
            var q = new Any("abrai"); 
            var choiceFirst = new Choice(x, y);
            var choice = new Choice(choiceFirst, z, t, q);
            var (match, remaining) = choice.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "aduionescu");
        }

        [TestMethod]
        public void ChoiceTest4()
        {
            string input = "radu";
            var x = new Range('0', '9');
            var y = new Any("mno");
            var z = new Any("abc");
            var choices = new Choice(x, y, z);
            var (match, remaining) = choices.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void ChoiceTest5()
        {
            string input = "raduionescu";
            var x = new Range('a', 'z');
            var y = new Any("abcd");
            var sequanceFirst = new Sequance(x, y);
            var choice = new Choice(sequanceFirst, new Character('d'));
            var (match, remaining) = choice.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "duionescu");
        }

        [TestMethod]
        public void ChoiceTest6()
        {
            string input = "raduionescu";
            var x = new Range('a', 'z');
            var y = new Any("bcd");
            var z = new Character('d');
            var sequanceFirst = new Sequance(x, y);
            var choice = new Choice(sequanceFirst, z);
            var (match, remaining) = choice.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "raduionescu");
        }
    }
}
