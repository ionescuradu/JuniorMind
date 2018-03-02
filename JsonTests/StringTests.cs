using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void StringTest1()
        {
            var x = new String();
            var (match, remaining) = x.Match("");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
