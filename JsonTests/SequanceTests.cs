using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class SequanceTests
    {
        [TestMethod]
        public void SequanceTest1()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("abcd");
            var patterns = new Sequance( x, y );
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "du");
        }

        [TestMethod]
        public void SequanceTest2()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("mno");
            var patterns = new Sequance(x, y);
            var (match, remaining) = patterns.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void SequanceTest3()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("mno");
            var patterns = new Sequance(x, y);
            var (match, remaining) = patterns.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void SequanceTest4()
        {
            string input = "radu";
            var x = new Range('a', 'z');
            var y = new Any("abcd");
            var z = new Any("dpqr");
            var t = new Any("uzt");
            var q = new Any("abra");
            var patterns = new Sequance(x, y, z, t, q);
            var (match, remaining) = patterns.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "radu");
        }

        [TestMethod]
        public void SequanceTest5()
        {
            string input = "raduionescu";
            var x = new Range('a', 'z'); //aduionescu => r
            var y = new Any("abcd"); // duionescu => a
            var z = new Any("dpqr"); //uionescu =>d
            var t = new Any("uzt"); //ionescu =>u
            var q = new Any("abrai"); //onescu => i
            var patternFirst = new Sequance(x, y);
            var patterns = new Sequance(patternFirst, z, t, q);
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "onescu");
        }
    }
}
