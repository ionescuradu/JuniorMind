using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class ValueTests
    {
        [TestMethod]
        public void ValueTest1()
        {
            var x = new Value();
            var (match, remaining) = x.Match("");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
