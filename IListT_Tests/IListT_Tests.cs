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
            var compareList = new List<int>(8) { 2 };
            Assert.AreEqual(true, givenList.Remove(3));
        }
    }
}
