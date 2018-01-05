using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IDictionaryT
{
    [TestClass]
    public class IDictionaryTests
    {
        [TestMethod]
        public void DictionaryAdd1()
        {
            var dictionary = new List<Entry<int, int>>[3];
            var newEntry = new Entry<int, int>(1, 100);
            var key = 1;
            var insertBucket = key.GetHashCode() % dictionary.Length;
            dictionary[insertBucket].Add(newEntry);
            Assert.AreEqual(true, dictionary[insertBucket].Contains))
        }
    }
}
