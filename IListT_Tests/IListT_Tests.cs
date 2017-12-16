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
            CollectionAssert.AreEqual(compareList.ToList(), givenList.ToList());
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
        public void ListAdd3()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(1);
            givenList.Add(2);
            givenList.Add(3);
            givenList.Add(4);
            givenList.Add(5);
            givenList.Add(6);
            givenList.Add(7);
            givenList.Add(8);
            givenList.Add(9);
            var compareList = new List<int>(16) { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListRemove1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            Assert.AreEqual(true, givenList.Remove(3));
        }

        [TestMethod]
        public void ListRemove2()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            Assert.AreEqual(false, givenList.Remove(4));
        }

        [TestMethod]
        public void ListInsert1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            givenList.Insert(1, 4);
            var compareList = new List<int>(8) { 2, 4, 3 };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListInsert2()
        {
            List<string> givenList = new List<string>(8);
            givenList.Add("Ana");
            givenList.Add("mere");
            givenList.Insert(1, "are");
            var compareList = new List<string>(8) { "Ana", "are", "mere" };
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListContains1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            Assert.AreEqual(true, givenList.Contains(2));
        }

        [TestMethod]
        public void ListContains2()
        {
            List<string> givenList = new List<string>(8);
            givenList.Add("Ana");
            givenList.Add("are");
            givenList.Add("mere");
            Assert.AreEqual(false, givenList.Contains("Mere"));
        }

        [TestMethod]
        public void ListClear1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            givenList.Clear();
            var compareList = new List<int>(8);
            CollectionAssert.AreEqual(compareList.ToArray(), givenList.ToArray());
        }

        [TestMethod]
        public void ListToArray1()
        {
            List<int> givenList = new List<int>(8) { 2, 3, 4 };
            var compareArray = new List<int>(8) { 0, 2, 3, 4 };
            var givenArray = new int[4] { 0, 0, 0, 0 };
            givenList.CopyTo(givenArray, 1);
            CollectionAssert.AreEqual(compareArray.ToArray(), givenArray);
        }

        [TestMethod]
        public void ListToArray2()
        {
            List<string> givenList = new List<string>(8) { "are", "mere", "multe" };
            var compareArray = new List<string>(8) { "Ana", "are", "mere", "multe" };
            var givenArray = new string[4] { "Ana", "", "", "" };
            givenList.CopyTo(givenArray, 1);
            CollectionAssert.AreEqual(compareArray.ToArray(), givenArray);
        }

        [TestMethod]
        public void YieldTest1()
        {
            List<int> givenList = new List<int>(8) { 2, 1};
            var enumerator = givenList.GetEnumerator();
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(2, enumerator.Current);
        }

        [TestMethod]
        public void YieldTest2()
        {
            List<int> givenList = new List<int>(8) { 3, 2, 1 };
            var enumerator = givenList.GetEnumerator();
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(3, enumerator.Current);
        }

        [TestMethod]
        public void YieldTest3()
        {
            List<int> givenList = new List<int>(8) { 10, 15, 100, 2, 1 };
            var enumerator = givenList.GetEnumerator();
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual(10, enumerator.Current);
        }

        [TestMethod]
        public void YieldTest4()
        {
            List<int> givenList = new List<int>(8);
            var enumerator = givenList.GetEnumerator();
            Assert.IsFalse(enumerator.MoveNext());
            Assert.AreEqual(0 , enumerator.Current);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CopyToException1()
        {
            List<int> givenList = new List<int>(8) { 2, 3, 4 };
            int[] givenArray = null;
            givenList.CopyTo(givenArray, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToException2()
        {
            List<int> givenList = new List<int>(8) { 2, 3, 4 };
            int[] givenArray = new int[4] { 0, 0, 0, 0 };
            givenList.CopyTo(givenArray, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CopyToException3()
        {
            List<int> givenList = new List<int>(8) { 2, 3, 4, 5 };
            int[] givenArray = new int[4] { 0, 0, 0, 0 };
            givenList.CopyTo(givenArray, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertException1()
        {
            List<int> givenList = new List<int>(8);
            givenList.Add(2);
            givenList.Add(3);
            givenList.Insert(-1, 4);
            //{ 2, 4, 3 };
        }
    }
}
