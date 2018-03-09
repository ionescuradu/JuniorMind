using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class MaxIndexStringTests
    {
        [TestMethod]
        public void MaxIndexString1()
        {
            var text = "text";
            var max = new MaxIndexInString(text);
            Assert.AreEqual(4, max.Max);
        }

        [TestMethod]
        public void MaxIndexString2()
        {
            var text = "text";
            var max = new MaxIndexInString(text);
            var text2 = "textmare";
            max = new MaxIndexInString(text2);
            Assert.AreEqual(8, max.Max);
        }
    }
}
