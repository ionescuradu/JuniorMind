using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void ListTest1()
        {
            string input = "";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ListTest2()
        {
            string input = "r";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ListTest3()
        {
            string input = "r ";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ListTest4()
        {
            string input = "r r r ";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ListTest5()
        {
            string input = "r r r";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void ListTest6()
        {
            string input = "r r r 4";
            var x = new List(new Character('r'), new Character(' '));
            var (match, remaining) = x.Match(input);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "r r r 4");
        }

    }
}
