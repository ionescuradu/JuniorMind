﻿using System;
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

        [TestMethod]
        public void FirstTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1}, CalculateTheNotOperation(10));
        }

        [TestMethod]
        public void SecondTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0}, CalculateTheNotOperation(49));
        }

        byte[] CalculateBinaryNumberFromDecimal (int givenNumber)
        {
            byte[] numberBinary = ConvertToBinary(givenNumber);
            return numberBinary;
        }

        byte[] CalculateTheNotOperation(int givenNumber)
        {
            byte[] numberBinary = ConvertToBinary(givenNumber);
            byte[] numberBinaryNot = CalculateNotOfABinaryNumber(numberBinary);
            return numberBinaryNot;
        }



        private static byte[] CalculateNotOfABinaryNumber(byte[] numberBinary)
        {
            byte[] numberBinaryNot = new byte[numberBinary.Length];
            for (byte i = 0; i < numberBinary.Length; i++)
            {
                if (numberBinary[i] == 0)
                    numberBinaryNot[i] = 1;
                else numberBinaryNot[i] = 0;
            }

            return numberBinaryNot;
        }

        private byte[] ConvertToBinary(int givenNumber)
        {
            byte[] numberInBinary = new byte [100] ;
            int i = 0;
            do
            {
                numberInBinary[i] = Convert.ToByte(givenNumber % 2);
                givenNumber = givenNumber / 2;
                i += 1;
            } while (givenNumber != 0);
            Array.Resize(ref numberInBinary, i);
            Array.Reverse(numberInBinary);
            return numberInBinary;
        }
    }
}
