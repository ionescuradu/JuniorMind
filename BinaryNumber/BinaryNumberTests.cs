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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateBinaryNumberFromDecimal(10));
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
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1 }, CalculateTheNotOperation(10));
        }

        [TestMethod]
        public void SecondTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, CalculateTheNotOperation(49));
        }

        [TestMethod]
        public void FirstTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateTheAndOperation(10, 8));
        }

        [TestMethod]
        public void SecondTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 1 }, CalculateTheAndOperation(21, 7));
        }

        [TestMethod]
        public void FirstTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateTheOrOperation(10, 8));
        }

        [TestMethod]
        public void SecondTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1, 1 }, CalculateTheOrOperation(21, 7));
        }

        [TestMethod]
        public void FirstTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0 }, CalculateTheXorOperation(10, 8));
        }

        [TestMethod]
        public void SecondTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateTheXorOperation(21, 7));
        }

        [TestMethod]
        public void ShiftingLeftFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0}, CalculateTheShiftingLeft(1, 3));
        }

        [TestMethod]
        public void ShiftingLeftSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0, 0}, CalculateTheShiftingLeft(5, 2));
        }

        [TestMethod]
        public void ShiftingRightFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, CalculateTheShiftingRight(8, 3));
        }

        [TestMethod]
        public void ShiftingRightSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 0, 0}, CalculateTheShiftingRight(50, 2));
        }

        [TestMethod]
        public void LessThenFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 0, 0 }, CalculateLessThenNumber(49, 8));
        }

        [TestMethod]
        public void LessThenSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0, 1 }, CalculateLessThenNumber(49, 37));
        }

        [TestMethod]
        public void SumOfTwoNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0}, CalculateSumOfTwoNumbers(10, 4));
        }

        [TestMethod]
        public void SumOfTwoNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateSumOfTwoNumbers(10, 8));
        }

        [TestMethod]
        public void SubtractionOfNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0}, CalculateSubstractionOfTwoNumbers(10, 4));
        }

        [TestMethod]
        public void SubtractionOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 1, 1, 0, 1 }, CalculateSubstractionOfTwoNumbers(142, 113));
        }

        [TestMethod]
        public void MultiplicationOfNumberFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 1, 1, 1, 0 }, CalculateTheMultiplicationOfTwoBinaryNumbers(27, 10));
        }


        byte[] CalculateBinaryNumberFromDecimal(int givenNumber)
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

        byte[] CalculateTheAndOperation(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            byte[] numberBinaryAnd = CalculateAndOfABinaryNumber(numberBinaryOne, numberBinaryTwo);
            return numberBinaryAnd;
        }

        byte[] CalculateTheOrOperation(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            byte[] numberBinaryOr = CalculateOrOfABinaryNumber(numberBinaryOne, numberBinaryTwo);
            return numberBinaryOr;
        }

        byte[] CalculateTheXorOperation(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            byte[] numberBinaryXor = CalculateXorOfABinaryNumber(numberBinaryOne, numberBinaryTwo);
            return numberBinaryXor;
        }

        byte[] CalculateTheShiftingLeft(int givenNumberOne, int numberOfBit)
        {
            givenNumberOne = givenNumberOne * Convert.ToInt32(Math.Pow(2, numberOfBit));
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            return numberBinaryOne;
        }

        byte[] CalculateTheShiftingRight(int givenNumberOne, int numberOfBit)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            int lenghtOfBinaryNumber = numberBinaryOne.Length;
            givenNumberOne = givenNumberOne / Convert.ToInt32(Math.Pow(2, numberOfBit));
            numberBinaryOne = ConvertToBinary(givenNumberOne);
            Array.Reverse(numberBinaryOne);
            Array.Resize(ref numberBinaryOne, lenghtOfBinaryNumber);
            Array.Reverse(numberBinaryOne);
            return numberBinaryOne;
        }

        byte[] CalculateLessThenNumber(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] smallestNumber = CalculateLessThan(numberBinaryOne, numberBinaryTwo);
            return smallestNumber;
        }

        byte[] CalculateSumOfTwoNumbers(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] sumOfTwoNumbers = new byte[numberBinaryOne.Length];
            sumOfTwoNumbers = AddingTwoBinaryNumbers(numberBinaryOne, numberBinaryTwo);
            return sumOfTwoNumbers;
        }

        byte[] CalculateSubstractionOfTwoNumbers(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] substractionOfTwoNumbers = new byte[numberBinaryOne.Length];
            substractionOfTwoNumbers = SubtractingTwoBinaryNumbers(numberBinaryOne, numberBinaryTwo);
            return substractionOfTwoNumbers;
        }

        byte[] CalculateTheMultiplicationOfTwoBinaryNumbers(int givenNumberOne, int givenNumberTwo)
        {
            byte[] numberBinaryOne = ConvertToBinary(givenNumberOne);
            byte[] numberBinaryTwo = ConvertToBinary(givenNumberTwo);
            byte[] resultOfMultiplication = MultiplicationOfBinaryNumbers(numberBinaryOne, numberBinaryTwo);
            return resultOfMultiplication;
        }

        private byte[] MultiplicationOfBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            byte[] resultOfMultiplication = new byte[numberBinaryOne.Length + numberBinaryTwo.Length];
            for (int i = numberBinaryTwo.Length - 1; i >= 0; i--)
            {
                byte[] bufferNumber = new byte[numberBinaryOne.Length];
                for (int j = 0; j < numberBinaryOne.Length; j++)
                {
                    bufferNumber[j] = Convert.ToByte(numberBinaryOne[j] * numberBinaryTwo[i]);
                }
                if (i != numberBinaryTwo.Length - 1)
                {
                    Array.Resize(ref bufferNumber, bufferNumber.Length + numberBinaryTwo.Length - i - 1);
                    MakingTheTwoBinaryNumbersTheSameLenght(ref resultOfMultiplication, ref bufferNumber);
                    string rezultattrei = "";
                    for (int k = 0; k < bufferNumber.Length; k++)
                    {
                        rezultattrei += Convert.ToString(bufferNumber[k]);
                    }
                    resultOfMultiplication = AddingTwoBinaryNumbers(resultOfMultiplication, bufferNumber);
                    string rezultat = "";
                    for (int k = 0; k < resultOfMultiplication.Length; k++)
                    {
                        rezultat += Convert.ToString(resultOfMultiplication[k]);
                    }
                }
                else
                {
                    MakingTheTwoBinaryNumbersTheSameLenght(ref resultOfMultiplication, ref bufferNumber);
                    string rezultatdoi = "";
                    for (int k = 0; k < resultOfMultiplication.Length; k++)
                    {
                        rezultatdoi += Convert.ToString(bufferNumber[k]);
                    }
                    resultOfMultiplication = AddingTwoBinaryNumbers(resultOfMultiplication, bufferNumber);
                    string rezultatpatru = "";
                    for (int k = 0; k < resultOfMultiplication.Length; k++)
                    {
                        rezultatpatru += Convert.ToString(resultOfMultiplication[k]);
                    }
                }
            }

            return resultOfMultiplication;
        }

        private byte[] SubtractingTwoBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            byte[] subtractionOfNumbers = new byte[numberBinaryOne.Length];
            byte difference = 0;
            for (int i = numberBinaryOne.Length - 1; i >= 0; i--)
            {
                subtractionOfNumbers[i] = Convert.ToByte((numberBinaryTwo[i] + numberBinaryOne[i] - difference) % 2);
                if (numberBinaryTwo[i] > numberBinaryOne[i])
                    difference = 1;
                else difference = 0;
            }
            return subtractionOfNumbers;
        }

        private byte[] AddingTwoBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            byte[] sumOfNumbers = new byte[numberBinaryOne.Length];
            byte surplus = 0;
            string rezultat = "";
            for (int i = numberBinaryOne.Length -1; i >=0; i--)
            {
                sumOfNumbers[i] = Convert.ToByte((numberBinaryOne[i] + numberBinaryTwo[i] + surplus) % 2);
                surplus = Convert.ToByte((numberBinaryOne[i] + numberBinaryTwo[i] + surplus) / 2);
                rezultat = Convert.ToString(sumOfNumbers[i]) + rezultat;
            }
            if (surplus != 0)
            {
                Array.Reverse(sumOfNumbers);
                Array.Resize(ref sumOfNumbers, numberBinaryOne.Length + 1);
                Array.Reverse(sumOfNumbers);
                sumOfNumbers[0] = 1;
            }
            return sumOfNumbers;
        }

        private static byte[] CalculateLessThan(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            byte[] smallestNumber = numberBinaryOne;
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] > numberBinaryTwo[i])
                {
                    smallestNumber = numberBinaryTwo;
                    break;
                }
                else smallestNumber = numberBinaryOne;
            }

            return smallestNumber;
        }

        private byte[] CalculateXorOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == 1 ^ numberBinaryTwo[i] == 1)
                    numberBinaryCombined[i] = 1;
                else numberBinaryCombined[i] = 0;
            }
            return numberBinaryCombined;
        }

        private byte[] CalculateOrOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == numberBinaryTwo[i] && numberBinaryOne[i] == 0)
                    numberBinaryCombined[i] = 0;
                else numberBinaryCombined[i] = 1;
            }
            return numberBinaryCombined;
        }

        private byte[] CalculateAndOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (byte i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == numberBinaryTwo[i] && numberBinaryOne[i] == 1)
                    numberBinaryCombined[i] = 1;
                else numberBinaryCombined[i] = 0;
            }
            return numberBinaryCombined;
        }

        private static void MakingTheTwoBinaryNumbersTheSameLenght(ref byte[] numberBinaryOne, ref byte[] numberBinaryTwo)
        {
            if (numberBinaryOne.Length > numberBinaryTwo.Length)
            {
                Array.Reverse(numberBinaryTwo);
                Array.Resize(ref numberBinaryTwo, numberBinaryOne.Length);
                Array.Reverse(numberBinaryTwo);
            }
            else
            {
                Array.Reverse(numberBinaryOne);
                Array.Resize(ref numberBinaryOne, numberBinaryTwo.Length);
                for (int i = numberBinaryOne.Length; i < numberBinaryTwo.Length; i++)
                    numberBinaryOne[i] = 0;
                Array.Reverse(numberBinaryOne);
            }
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
