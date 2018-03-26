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
            var patterns = new Sequance(x, y);
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
            var x = new Range('a', 'z');
            var y = new Any("abcd");
            var z = new Any("dpqr");
            var t = new Any("uzt");
            var q = new Any("abrai");
            var patternFirst = new Sequance(x, y);
            var patterns = new Sequance(patternFirst, z, t, q);
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "onescu");
        }

        [TestMethod]
        public void SequanceTest6()
        {
            string input = "radu";
            var patterns = new Sequance(
                new Range('a', 'z'),
                new Optional(new Character('a'))
                );
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "du");
        }

        [TestMethod]
        public void SequanceTest7()
        {
            string input = "radu";
            var patterns = new Sequance(
                new Range('a', 'z'),
                new Optional(new Character('a')),
                new Optional(new Character('d'))
                );
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "u");
        }

        [TestMethod]
        public void SequanceTest8()
        {
            string input = "1.12";
            var patterns = new Sequance(
                new Integer(),
                new Optional(new Fractional()),
                new Optional(new Scientific())
                );
            var (match, remaining) = patterns.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }


        [TestMethod]
        public void SequanceBasicErrorReporting()
        {
            var x = new Sequance(
                new Character('a'),
                new Character('b')
            );
            var (match, remainng) = x.Match("ax");
            var noMatch = (NoMatch)match;
            Assert.AreEqual(1, noMatch.ErrorPosition);
        }

        [TestMethod]
        public void SequanceTextErrorReporting()
        {
            var x = new Sequance(
                new Character('a'),
                new Character('b'),
                new Character('c'),
                new Character('d')
            );
            var (match, remainng) = x.Match("abcx");
            var noMatch = (NoMatch)match;
            Assert.AreEqual(3, noMatch.ErrorPosition);
        }

        [TestMethod]
        public void SequanceMatchArray()
        {
            string input = "raduionescu";
            var patterns = new Sequance(
                new Sequance(
                    new Character('r'),
                    new Character('a')),
                new Sequance(
                    new Character('d'),
                    new Character('u')));
            var (match, remaining) = patterns.Match(input);
            Assert.AreEqual("radu", match.ToString());
        }
    }
}
