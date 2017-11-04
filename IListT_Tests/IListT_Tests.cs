using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IListT_Tests
{
    [TestClass]
    public class IListT_Tests
    {
        [TestMethod]
        public void ListAdd1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            var compareList = new List<int>(8) { 2 };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListAdd2()
        {
            List<string> givenList = new List<string>(8);
            givenList.Add("Ana");
            givenList.Add("are");
            var compareList = new List<string>(8) { "Ana", "are" };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListRemove1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            Assert.AreEqual(true, givenList.Remove(3));
        }

        [TestMethod]
        public void ListRemove2()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            Assert.AreEqual(false, givenList.Remove(4));
        }

        [TestMethod]
        public void ListInsert1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            givenList.Insert(1, 4);
            var compareList = new List<int>(8) { 2, 4, 3 };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListInsert2()
        {
            List<string> givenList = new List<string>(8);
            givenList.Add("Ana");
            givenList.Add("mere");
            givenList.Insert(1, "are");
            var compareList = new List<string>(8) { "Ana", "are", "mere" };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }
    }
}
