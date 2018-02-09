using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISetT_Tests
{
    [TestClass]
    public class ISetT_Tests
    {
        [TestMethod]
        public void Set_Add1()
        {
            var initialCapacity = 10;
            var entry = new Entry<int>(3);
            var set = new Set<int>(initialCapacity);
            Assert.AreEqual(true, set.Add(3));
        }
    }
}
