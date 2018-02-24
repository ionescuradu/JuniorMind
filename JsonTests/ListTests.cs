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
    }
}
