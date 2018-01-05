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
            var insertBucket = entry.Key.GetHashCode() % initialCapacity;
            dictionary.Add(entry);
            Assert.AreEqual(true, dictionary.Contains(entry));
        }

        [TestMethod]
        public void DictionaryAdd2()
        {
            var dictionary = new List<Entry<int, int>>[3];
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<int, int>>();
            }
            var newEntry1 = new Entry<int, int>(1, 100);
            var newEntry2 = new Entry<int, int>(2, 102);
            var key = 1;
            var insertBucket = key.GetHashCode() % dictionary.Length;
            dictionary[insertBucket].Add(newEntry1);
            Assert.AreEqual(false, dictionary[insertBucket].Contains(newEntry2));
        }

        [TestMethod]
        public void DictionaryAdd3()
        {
            var dictionary = new List<Entry<int, int>>[3];
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<int, int>>();
            }
            var newEntry1 = new Entry<int, int>(1, 100);
            var newEntry2 = new Entry<int, int>(2, 102);
            var key = 1;
            var key2 = 2;
            var insertBucket = key.GetHashCode() % dictionary.Length;
            var insertBucket2 = key2.GetHashCode() % dictionary.Length;
            dictionary[insertBucket].Add(newEntry1);
            dictionary[insertBucket2].Add(newEntry2);
            Assert.AreEqual(false, dictionary[insertBucket].Contains(newEntry2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DictionaryAddException1()
        {
            var dictionary = new List<Entry<int, int>>[3];
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<int, int>>();
            }
            var newEntry1 = new Entry<int, int>(1, 100);
            var newEntry2 = new Entry<int, int>(1, 102);
            var key = 1;
            var insertBucket = key.GetHashCode() % dictionary.Length;
            dictionary[insertBucket].Add(newEntry1);
            dictionary[insertBucket].Add(newEntry2);
        }

    }


}
