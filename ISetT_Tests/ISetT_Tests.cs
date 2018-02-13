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

        [TestMethod]
        public void Set_Contains2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            var auxSet = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(true, set.Contains(3));
        }

        [TestMethod]
        public void Set_Remove1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(true, set.Remove(3));
        }

        [TestMethod]
        public void Set_Remove2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            Assert.AreEqual(false, set.Remove(5));
        }

        [TestMethod]
        public void Set_Add4Revised()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            set.Remove(14);
            Assert.AreEqual(true, set.Add(34));
        }

        [TestMethod]
        public void Set_ExceptWith1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(4);
            var result = new Set<int>(initialCapacity);
            result.Add(3);
            set.ExceptWith(other);
            CollectionAssert.AreEqual(result.ToList(), set.ToList());
        }

        [TestMethod]
        public void Set_IntersectWith1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(14);
            set.Add(24);
            set.Add(43);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(43);
            var result = new Set<int>(initialCapacity);
            result.Add(4);
            result.Add(24);
            result.Add(43);
            set.IntersectWith(other);
            CollectionAssert.AreEqual(result.ToList(), set.ToList());
        }

        [TestMethod]
        public void Set_IsProperSubsetOf1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(43);
            other.Add(3);
            Assert.AreEqual(true, set.IsProperSubsetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSubsetOf2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            set.Add(5);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(43);
            other.Add(3);
            Assert.AreEqual(false, set.IsProperSubsetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSubsetOf3()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(false, set.IsProperSubsetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSupersetOf1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            set.Add(5);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(true, set.IsProperSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSupersetOf2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(false, set.IsProperSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSupersetOf3()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(false, set.IsProperSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSupersetOf4()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            var other = new List<int>();
            Assert.AreEqual(false, set.IsProperSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsProperSupersetOf5()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            var other = new List<int>();
            Assert.AreEqual(true, set.IsProperSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsSubsetOf1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(true, set.IsSubsetOf(other));
        }

        [TestMethod]
        public void Set_IsSubsetOf2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            set.Add(5);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(false, set.IsSubsetOf(other));
        }

        [TestMethod]
        public void Set_IsSupersetOf1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            set.Add(5);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(true, set.IsSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsSupersetOf2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(24);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(true, set.IsSupersetOf(other));
        }

        [TestMethod]
        public void Set_IsSupersetOf3()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(4);
            other.Add(24);
            other.Add(3);
            Assert.AreEqual(false, set.IsSupersetOf(other));
        }

        [TestMethod]
        public void Set_Overlaps1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(4);
            other.Add(34);
            other.Add(14);
            Assert.AreEqual(true, set.Overlaps(other));
        }

        [TestMethod]
        public void Set_Overlaps2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(5);
            other.Add(34);
            other.Add(14);
            Assert.AreEqual(false, set.Overlaps(other));
        }

        [TestMethod]
        public void Set_SetEquals1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(3);
            other.Add(4);
            Assert.AreEqual(true, set.SetEquals(other));
        }

        [TestMethod]
        public void Set_SetEquals2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            var other = new List<int>();
            other.Add(3);
            other.Add(4);
            Assert.AreEqual(false, set.SetEquals(other));
        }

        [TestMethod]
        public void Set_SymmetricExceptWith1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            var other = new List<int>();
            other.Add(4);
            var result = new Set<int>(initialCapacity);
            result.Add(3);
            set.SymmetricExceptWith(other);
            CollectionAssert.AreEqual(result.ToList(), set.ToList());
        }

        [TestMethod]
        public void Set_SymmetricExceptWith2()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            var other = new List<int>();
            other.Add(4);
            other.Add(4);
            other.Add(5);
            var result = new Set<int>(initialCapacity);
            result.Add(3);
            set.SymmetricExceptWith(other);
            CollectionAssert.AreEqual(result.ToList(), set.ToList());
        }

        [TestMethod]
        public void Set_UnionWith1()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            var other = new List<int>();
            other.Add(8);
            other.Add(8);
            var result = new Set<int>(initialCapacity);
            result.Add(3);
            result.Add(4);
            result.Add(5);
            result.Add(8);
            set.UnionWith(other);
            CollectionAssert.AreEqual(result.ToList(), set.ToList());
        }

        [TestMethod]
        public void Set_CopyTo()
        {
            var initialCapacity = 10;
            var set = new Set<int>(initialCapacity);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            var array = new int[10];
            var result = new int[10] { 0, 0, 3, 4, 5, 0, 0, 0, 0, 0};
            set.CopyTo(array, 2);
            CollectionAssert.AreEqual(result, array);
        }
    }
}
