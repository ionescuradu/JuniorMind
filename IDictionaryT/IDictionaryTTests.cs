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
            var bucket1 = new List<Entry<int, int>>{};
            bucket1.Add(new Entry<int, int>(100, 500));
            var bucket2 = new List<Entry<int, int>> { };
            bucket2.Add(new Entry<int, int>(101, 600));
            var bucket3 = new List<Entry<int, int>> { };
            bucket3.Add(new Entry<int, int>(102, 700));
            var dictionary = new List<Entry<int, int>>[3] { bucket1, bucket2, bucket3 };

        }
    }
}
