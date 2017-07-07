using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciFirst()
        {
            Assert.AreEqual(0, Fibonacci(0));
        }

        [TestMethod]
        public void FibonacciSecond()
        {
            Assert.AreEqual(1, Fibonacci(2));
        }

        int Fibonacci(int givenNumber)
        {
            if (givenNumber < 2)
            {
                return givenNumber;
            }
            else return Fibonacci(givenNumber - 1) + Fibonacci(givenNumber - 2);
        }
    }
}
