using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IListTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void IListTests1()
        {
            List givenList = new List(8);
            Assert.AreEqual(0, givenList.Add(2));
        }

        [TestMethod]
        public void IListTest2()
        {
            List givenList = new List(8);
            givenList.Add(2);
            Assert.AreEqual(1, givenList.Add(2));
        }

        [TestMethod]
        public void IListTest3()
        {
            List givenList = new List(8);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            givenList.Add(2);
            Assert.AreEqual(8, givenList.Add(2));
        }

        [TestMethod]
        public void IListTest4()
        {
            List givenList = new List(8) { 1, 2, 3};
            givenList.Remove(2);
            CollectionAssert.AreEqual(new List(8) { 1, 3 }, givenList);
        }

        [TestMethod]
        public void IListTest5()
        {
            List givenList = new List(8) { 1, 2, 3, 4, 5 };
            givenList.Remove(2);
            givenList.Remove(4);
            CollectionAssert.AreEqual(new List(8) { 1, 3, 5 }, givenList);
        }

        [TestMethod]
        public void IListTest6()
        {
            List givenList = new List(8) { 1, 2, 3, 4, 5 };
            givenList.Insert(2, 6);
            CollectionAssert.AreEqual(new List(8) { 1, 2, 6, 3, 4, 5 }, givenList);
        }

    }

    
}
