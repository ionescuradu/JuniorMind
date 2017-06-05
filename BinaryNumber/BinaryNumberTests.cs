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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateBinaryNumberFromDecimal(ToBinary(10)));
        }

        [TestMethod]
        public void SecondtTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, CalculateBinaryNumberFromDecimal(ToBinary(49)));
        }

        [TestMethod]
        public void ThirdTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateBinaryNumberFromDecimal(ToBinary(8)));
        }

        [TestMethod]
        public void FirstTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1 }, CalculateTheNotOperation(ToBinary(10)));
        }

        [TestMethod]
        public void SecondTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, CalculateTheNotOperation(ToBinary(49)));
        }

        [TestMethod]
        public void FirstTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateTheAndOperation(ToBinary(10), ToBinary(8)));
        }

        [TestMethod]
        public void SecondTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 1 }, CalculateTheAndOperation(ToBinary(21), ToBinary(7)));
        }

        [TestMethod]
        public void FirstTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateTheOrOperation(ToBinary(10), ToBinary(8)));
        }

        [TestMethod]
        public void SecondTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1, 1 }, CalculateTheOrOperation(ToBinary(21), ToBinary(7)));
        }

        [TestMethod]
        public void FirstTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0 }, CalculateTheXorOperation(ToBinary(10), ToBinary(8)));
        }

        [TestMethod]
        public void SecondTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateTheXorOperation(ToBinary(21), ToBinary(7)));
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
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 0, 0 }, CalculateLessThenNumber(ToBinary(49), ToBinary(8)));
        }

        [TestMethod]
        public void LessThenSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0, 1 }, CalculateLessThenNumber(ToBinary(49), ToBinary(37)));
        }

        [TestMethod]
        public void SumOfTwoNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0}, CalculateSumOfTwoNumbers(ToBinary(10), ToBinary(4)));
        }

        [TestMethod]
        public void SumOfTwoNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateSumOfTwoNumbers(ToBinary(10), ToBinary(8)));
        }

        [TestMethod]
        public void SubtractionOfNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0}, CalculateSubstractionOfTwoNumbers(ToBinary(10), ToBinary(4)));
        }

        [TestMethod]
        public void SubtractionOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 1, 1, 0, 1 }, CalculateSubstractionOfTwoNumbers(ToBinary(142), ToBinary(113)));
        }

        [TestMethod]
        public void MultiplicationOfNumberFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 1, 1, 1, 0 }, CalculateTheMultiplicationOfTwoBinaryNumbers(ToBinary(27), ToBinary(10)));
        }

        [TestMethod]
        public void MultiplicationOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1, 0, 0, 0 }, CalculateTheMultiplicationOfTwoBinaryNumbers(ToBinary(49), ToBinary(8)));
        }

        byte[] CalculateBinaryNumberFromDecimal(byte[] givenNumber)
        {
            byte[] numberBinary = givenNumber;
            return numberBinary;
        }

        byte[] CalculateTheNotOperation(byte[] givenNumber)
        {
            byte[] numberBinaryNot = CalculateNotOfABinaryNumber(givenNumber);
            return numberBinaryNot;
        }

        byte[] CalculateTheAndOperation(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            byte[] numberBinaryAnd = CalculateOrAndOfABinaryNumber(givenNumberOne, givenNumberTwo, 1);
            return numberBinaryAnd;
        }

        byte[] CalculateTheOrOperation(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            byte[] numberBinaryOr = CalculateOrAndOfABinaryNumber(givenNumberOne, givenNumberTwo, 0);
            return numberBinaryOr;
        }

        byte[] CalculateTheXorOperation(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            byte[] numberBinaryXor = CalculateXorOfABinaryNumber(givenNumberOne, givenNumberTwo);
            return numberBinaryXor;
        }

        byte[] CalculateTheShiftingLeft(int givenNumberOne, int numberOfBit)
        {
            givenNumberOne = givenNumberOne * Convert.ToInt32(Math.Pow(2, numberOfBit));
            byte[] numberBinaryOne = ToBinary(givenNumberOne);
            return numberBinaryOne;
        }

        byte[] CalculateTheShiftingRight(int givenNumberOne, int numberOfBit)
        {
            byte[] numberBinaryOne = ToBinary(givenNumberOne);
            int lenghtOfBinaryNumber = numberBinaryOne.Length;
            givenNumberOne = givenNumberOne / Convert.ToInt32(Math.Pow(2, numberOfBit));
            numberBinaryOne = ToBinary(givenNumberOne);
            Array.Reverse(numberBinaryOne);
            Array.Resize(ref numberBinaryOne, lenghtOfBinaryNumber);
            Array.Reverse(numberBinaryOne);
            return numberBinaryOne;
        }

        byte[] CalculateLessThenNumber(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo);
            byte[] smallestNumber = givenNumberOne;
            if (CalculateLessThan(givenNumberOne, givenNumberOne))
                smallestNumber = givenNumberTwo;
            else smallestNumber = givenNumberOne;
            return smallestNumber;
        }

        byte[] CalculateSumOfTwoNumbers(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo);
            byte[] sumOfTwoNumbers = new byte[givenNumberOne.Length];
            sumOfTwoNumbers = AddingTwoBinaryNumbers(givenNumberOne, givenNumberTwo);
            return sumOfTwoNumbers;
        }

        byte[] CalculateSubstractionOfTwoNumbers(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo);
            byte[] substractionOfTwoNumbers = new byte[givenNumberOne.Length];
            substractionOfTwoNumbers = SubtractingTwoBinaryNumbers(givenNumberOne, givenNumberTwo);
            return substractionOfTwoNumbers;
        }

        byte[] CalculateTheMultiplicationOfTwoBinaryNumbers(byte[] givenNumberOne, byte[] givenNumberTwo)
        {
            byte[] resultOfMultiplication = MultiplicationOfBinaryNumbers(givenNumberOne, givenNumberTwo);
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
            if (resultOfMultiplication[0] == 0)
            {
                Array.Reverse(resultOfMultiplication);
                Array.Resize(ref resultOfMultiplication, resultOfMultiplication.Length - 1);
                Array.Reverse(resultOfMultiplication);
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

        private static bool CalculateLessThan(byte[] numberBinaryOne, byte[] numberBinaryTwo)
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
            return (smallestNumber == numberBinaryOne);
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

        private byte[] CalculateOrAndOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo, int operation)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == numberBinaryTwo[i] && numberBinaryOne[i] == operation)
                    numberBinaryCombined[i] = Convert.ToByte(operation);
                else numberBinaryCombined[i] = Convert.ToByte( (operation + 1) % 2);
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

        private byte[] ToBinary(int givenNumber)
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
