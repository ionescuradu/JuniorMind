using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(true, dictionary.Contains(entry3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DictionaryAddException1()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(1, 101);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
        }

        [TestMethod]
        public void DictionaryClear1()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var auxDictionary = dictionary;
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            dictionary.Clear();
            CollectionAssert.AreEqual(auxDictionary.ToList(), dictionary.ToList());
        }

        [TestMethod]
        public void DictionaryRemove1()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(true, dictionary.Remove(1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DictionaryRemove2()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(false, dictionary.Remove(3));
        }

        [TestMethod]
        public void DictionaryRemove3()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(true, dictionary.Remove(entry1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DictionaryRemove4()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            var entry4 = new KeyValuePair<int, int>(5, 104);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            Assert.AreEqual(false, dictionary.Remove(entry4));
        }

        [TestMethod]
        public void DictionaryTryGetvalue1()
        {
            var initialCapacity = 3;
            var dictionary = new Dictionary<int, int>(initialCapacity);
            var entry1 = new KeyValuePair<int, int>(1, 100);
            var entry2 = new KeyValuePair<int, int>(2, 102);
            var entry3 = new KeyValuePair<int, int>(4, 103);
            dictionary.Add(entry1);
            dictionary.Add(entry2);
            dictionary.Add(entry3);
            dictionary.TryGetValue(1, out int value);
            Assert.AreEqual(100, value);
        }
    }


}
