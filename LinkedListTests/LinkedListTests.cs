﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedAdd1()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Add(4);
            var compareList = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedAdd2()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.Add(8);
            var compareList = new List<int> { 1, 2, 3, 4, 5, 8 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedAddFirst1()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.AddFirst(8);
            var compareList = new List<int> { 8, 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedAddFirst2()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.AddFirst(8);
            list.AddFirst(9);
            var compareList = new List<int> { 9, 8, 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedInsert1()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Insert(1, 4);
            var compareList = new List<int> { 1, 4, 2, 3 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedInsert2()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Insert(0, 4);
            var compareList = new List<int> { 4, 1, 2, 3 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedInsert3()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Insert(3, 4);
            var compareList = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedInsert4()
        {
            var list = new List<int>();
            list.Insert(0, 4);
            var compareList = new List<int> { 4 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }

        [TestMethod]
        public void LinkedRemove1()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(true, list.Remove(2));
        }

        [TestMethod]    
        public void LinkedRemove2()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Remove(2);
            Assert.AreEqual(true, list.Remove(1));
        }

        [TestMethod]
        public void LinkedRemove3()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(false, list.Remove(4));
        }

        [TestMethod]
        public void LinkedRemove4()
        {
            var list = new List<int>();
            Assert.AreEqual(false, list.Remove(1));
        }

        [TestMethod]
        public void LinkedContains1()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(true, list.Contains(1));
        }

        [TestMethod]
        public void LinkedContains2()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(true, list.Contains(3));
        }

        [TestMethod]
        public void LinkedContainsLast1()
        {
            var list = new List<int> { 1, 2, 3, 2, 3 };
            Assert.AreEqual(true, list.ContainsLast(3));
        }

        [TestMethod]
        public void LinkedContains3()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(false, list.Contains(4));
        }

        [TestMethod]
        public void LinkedClear()
        {
            var list = new List<int> { 1, 2, 3 };
            var compareList = new List<int>();
            list.Clear();
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }
    }
}
