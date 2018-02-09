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
            var set = new Set<int>(initialCapacity);
            Assert.AreEqual(true, set.Add(3));
        }

        [TestMethod]
        public void Set_Add2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(true, set.Add(13));
        }
    }
}
