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
            var initialCapacity = 3;
            var dictionary = new Dictionary<int,int>(initialCapacity);
            var entry = new KeyValuePair<int, int>(1, 100);
            dictionary.Add(entry);
            Assert.AreEqual(true, dictionary.Contains(entry));
        }

        [TestMethod]
        public void DictionaryAdd2()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            dictionary.Add(entry1);
            Assert.AreEqual(false, dictionary.Contains(entry2));
        }

        [TestMethod]
        public void DictionaryAdd3()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(1, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(true, dictionary.Contains(entry3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DictionaryAddException1()
        {

        }

    }


}
