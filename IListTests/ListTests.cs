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

        [TestMethod]
        public void IListTest7()
        {
            List givenList = new List(8) { 1, 2, 3, 4, 5, 6, 7, 8 };
            List compareList = new List(10) { 1, 2, 9, 10, 3, 4, 5, 6, 7, 8 };
            givenList.Insert(2, 9);
            givenList.Insert(3, 10);
            CollectionAssert.AreEqual(compareList, givenList);
        }

        [TestMethod]
        public void IListTest8()
        {
            List givenList = new List(8) { 1, 2, 3 };
            Assert.AreEqual(true, givenList.Contains(2));
        }

        [TestMethod]
        public void IListTest9()
        {
            List givenList = new List(8) { 1, 2, 3 };
            Assert.AreEqual(false, givenList.Contains(4));
        }

        [TestMethod]
        public void IListTest10()
        {
            List givenList = new List(8) { 1, 2, 3 };
            givenList.Clear();
            CollectionAssert.AreEqual(new List(8), givenList);
        }

        [TestMethod]
        public void IListTest11()
        {
            List givenList = new List(8) { 1, 2, 3 };
            var compareArray = new List(8) { 0, 1, 2, 3 };
            object[] givenArray = new object[4];
            for (int i = 0; i < givenArray.Length; i++)
            {
                givenArray[i] = 0;
            }
            givenList.CopyTo(givenArray, 1);
            CollectionAssert.AreEqual(compareArray, givenArray);
        }

    }

    
}
