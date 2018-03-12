using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class NoMatchTests
    {
        [TestMethod]
        public void NoMatchIndexCompare()
        {
            var noMatch1 = new NoMatch("raduionescu", 4);
            var noMatch2 = new NoMatch("raduionescu", 3);
            Assert.AreEqual(4, noMatch1.Merge(noMatch2));
        }

        [TestMethod]
        public void NoMatchComplexIndexCompare()
        {
            var x = new Sequance(
                new Character('a'),
                new Character('b'),
                new Character('c'),
                new Character('d')
            );
            var (noMatch1, remaining1) = x.Match("abm");
            var (noMatch2, remaining2) = x.Match("abcm");
            var first = (NoMatch)noMatch1;
            var second = (NoMatch)noMatch2;
            Assert.AreEqual(3, ((NoMatch)noMatch1).Merge((NoMatch)noMatch2));
        }

        [TestMethod]
        public void NoMatchIncludingNoMatch1()
        {
            var x = new Sequance(
                new Character('a'),
                new Character('b'),
                new Character('c'),
                new Character('d')
            );
            var (noMatch1, remaining1) = x.Match("abm");
            var (noMatch2, remaining2) = x.Match("abcm");
            Assert.IsFalse(noMatch1.Success);
        }

        [TestMethod]
        public void NoMatchIncludingNoMatch2()
        {
            var x = new Sequance(
                new Text("ra"),
                new Text("dm")
            );
            var (noMatch1, remaining1) = x.Match("radu");
            Assert.IsFalse(noMatch1.Success);
        }
    }
}
