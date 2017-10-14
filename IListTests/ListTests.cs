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
        public void TestMethod1()
        {
            List givenList = new List(8);
            givenList.Add(2);
            Assert.AreEqual(1, givenList.Add(2));
        }
    }
}
