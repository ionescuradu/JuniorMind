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
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<int, int>>();   
            }
            var newEntry1 = new Entry<int, int>(1, 100);
            var key = 1;
            var insertBucket = key.GetHashCode() % dictionary.Length;
            dictionary[insertBucket].Add(newEntry1);
            Assert.AreEqual(true, dictionary[insertBucket].Contains(newEntry1));
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
    }


}
