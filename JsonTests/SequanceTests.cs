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
    }
}
