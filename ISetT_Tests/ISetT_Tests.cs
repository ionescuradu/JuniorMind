using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void Set_Add3()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(false, set.Add(3));
        }

        [TestMethod]
        public void Set_Clear1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            var auxSet = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            set.Clear();
            CollectionAssert.AreEqual(auxSet.ToArray(), set.ToArray());
        }

        [TestMethod]
        public void Set_Contains1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            var auxSet = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(false, set.Contains(5));
        }
    }
}
