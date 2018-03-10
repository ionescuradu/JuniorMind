using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ManyTests
    {
        [TestMethod]
        public void ManyTests1()
        {
            var x = new Many(new Character('r'));
            var (match, remainng) = x.Match("rrradu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "adu");
        }

        [TestMethod]
        public void ManyTests2()
        {
            var x = new Many(new Character('r'));
            var (match, remainng) = x.Match("ionescu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "ionescu");
        }

        [TestMethod]
        public void ManyTests3()
        {
            var x = new Many(new Sequance(new Character('r'), new Character(' ')));
            var (match, remainng) = x.Match("r r ionescu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remainng, "ionescu");
        }

        [TestMethod]
        public void MinimOccurancesForMany()
        {
            var x = new Many(new Character('r'), 2);
            var (match, remainng) = x.Match("radu");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "radu");
        }

        [TestMethod]
        public void MaximumOccurances()
        {
            var x = new Many(new Character('r'), 0, 1);
            var (match, remainng) = x.Match("rradu");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remainng, "rradu");
        }

        [TestMethod]
        public void MaximumOccurancesRemainingText()
        {
            var x = new Many(new Character('r'), 0, 1);
            var (match, remainng) = x.Match("rradu");
            Assert.AreEqual(2, ((NoMatch)match).ErrorPosition);
        }

        [TestMethod]
        public void MaximumOccurancesRemainingText2()
        {
            var x = new Many(new Character('r'), 4, 0);
            var (match, remainng) = x.Match("rrradu");
            Assert.AreEqual(3, ((NoMatch)match).ErrorPosition);
        }


    }
}
