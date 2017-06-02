using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryNumber
{
    [TestClass]
    public class BinaryNumberTests
    {
        [TestMethod]
        public void FirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0}, CalculateBinaryNumberFromDecimal(10));
        }

        [TestMethod]
        public void SecondtTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, CalculateBinaryNumberFromDecimal(49));
        }

        [TestMethod]
        public void ThirdTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateBinaryNumberFromDecimal(8));
        }

        byte[] CalculateBinaryNumberFromDecimal (int givenNumber)
        {
            byte[] numberBinary = ConvertToBinary(givenNumber);
            return numberBinary;
        }

        private byte[] ConvertToBinary(int givenNumber)
        {
            string binary = "";
            byte[] numberInBinary = new byte [20];
            do
            {
                binary = givenNumber % 2 + binary;
                givenNumber = givenNumber / 2;
            } while (givenNumber != 0);
            for (int i = 0; i < binary.Length; i++)
            {
                numberInBinary[i] = Convert.ToByte(binary[i]);
            }
            return numberInBinary;
        }
    }
}
