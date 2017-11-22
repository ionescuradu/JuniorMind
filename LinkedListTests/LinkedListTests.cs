using System;
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
            var array = list.ToArray();
            list.Add(4);
            array = list.ToArray();
            var compareList = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(compareList.ToArray(), list.ToArray());
        }
    }
}
