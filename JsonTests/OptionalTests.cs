using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class OptionalTests
    {
        [TestMethod]
        public void OptionalTest1()
        {

            var x = new Optional(new Character('-'));
            var (match, remaining) = x.Match("-radu");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "rau");
        }
    }
}
