using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IListT_Tests
{
    [TestClass]
    public class IListT_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            var compareList = new List<int>(8) { 2 };
            CollectionAssert.AreEqual(compareList, givenList);
        }
    }
}
