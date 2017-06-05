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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateBinaryNumberFromDecimal(ToBinary(10, 2), 2));
        }

        [TestMethod]
        public void SecondtTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, CalculateBinaryNumberFromDecimal(ToBinary(49, 2), 2));
        }

        [TestMethod]
        public void ThirdTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateBinaryNumberFromDecimal(ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void FirstTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1 }, CalculateTheNotOperation(ToBinary(10, 2), 2));
        }

        [TestMethod]
        public void SecondTestNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, CalculateTheNotOperation(ToBinary(49, 2), 2));
        }

        [TestMethod]
        public void FirstTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, CalculateTheAndOperation(ToBinary(10, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void SecondTestAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 1 }, CalculateTheAndOperation(ToBinary(21, 2), ToBinary(7, 2), 2));
        }

        [TestMethod]
        public void FirstTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, CalculateTheOrOperation(ToBinary(10, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void SecondTestOr()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1, 1 }, CalculateTheOrOperation(ToBinary(21, 2), ToBinary(7, 2), 2));
        }

        [TestMethod]
        public void FirstTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0 }, CalculateTheXorOperation(ToBinary(10, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void SecondTestXor()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateTheXorOperation(ToBinary(21, 2), ToBinary(7, 2), 2));
        }

        [TestMethod]
        public void ShiftingLeftFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0}, CalculateTheShiftingLeft(1, 3, 2));
        }

        [TestMethod]
        public void ShiftingLeftSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0, 0}, CalculateTheShiftingLeft(5, 2, 2));
        }

        [TestMethod]
        public void ShiftingRightFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, CalculateTheShiftingRight(8, 3, 2));
        }

        [TestMethod]
        public void ShiftingRightSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 0, 0}, CalculateTheShiftingRight(50, 2, 2));
        }

        [TestMethod]
        public void LessThenFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 0, 0 }, CalculateLessThenNumber(ToBinary(49, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void LessThenSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0, 1 }, CalculateLessThenNumber(ToBinary(49, 2), ToBinary(37, 2), 2));
        }

        [TestMethod]
        public void SumOfTwoNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0}, CalculateSumOfTwoNumbers(ToBinary(10, 2), ToBinary(4, 2), 2));
        }

        [TestMethod]
        public void SumOfTwoNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0 }, CalculateSumOfTwoNumbers(ToBinary(10, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void SubtractionOfNumbersFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0}, CalculateSubstractionOfTwoNumbers(ToBinary(10, 2), ToBinary(4, 2), 2));
        }

        [TestMethod]
        public void SubtractionOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 1, 1, 0, 1 }, CalculateSubstractionOfTwoNumbers(ToBinary(142, 2), ToBinary(113, 2), 2));
        }

        [TestMethod]
        public void MultiplicationOfNumberFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 1, 1, 1, 0 }, CalculateTheMultiplicationOfTwoBinaryNumbers(ToBinary(27, 2), ToBinary(10, 2), 2));
        }

        [TestMethod]
        public void MultiplicationOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1, 0, 0, 0 }, CalculateTheMultiplicationOfTwoBinaryNumbers(ToBinary(49, 2), ToBinary(8, 2), 2));
        }

        [TestMethod]
        public void DivisionOfNumberFirstTest()
        {
            CollectionAssert.AreEqual(new byte[] {1, 1, 1}, CalculateTheDivisionOfTwoBinaryNumbers(ToBinary(42, 2), ToBinary(6, 2), 2));
        }

        [TestMethod]
        public void DivisionOfNumbersSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1, 1 }, CalculateTheDivisionOfTwoBinaryNumbers(ToBinary(46, 2), ToBinary(2, 2), 2));
        }

        [TestMethod]
        public void DivisionOfNumbersThirdTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1, 1 }, CalculateTheDivisionOfTwoBinaryNumbers(ToBinary(2, 2), ToBinary(46, 2), 2));
        }

        byte[] CalculateBinaryNumberFromDecimal(byte[] givenNumber, int baseNumber)
        {
            byte[] numberBinary = givenNumber;
            return numberBinary;
        }

        byte[] CalculateTheNotOperation(byte[] givenNumber, int baseNumber)
        {
            byte[] numberBinaryNot = CalculateNotOfABinaryNumber(givenNumber, baseNumber);
            return numberBinaryNot;
        }

        byte[] CalculateTheAndOperation(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            byte[] numberBinaryAnd = CalculateOrAndOfABinaryNumber(givenNumberOne, givenNumberTwo, 1, baseNumber);
            return numberBinaryAnd;
        }

        byte[] CalculateTheOrOperation(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            byte[] numberBinaryOr = CalculateOrAndOfABinaryNumber(givenNumberOne, givenNumberTwo, 0, baseNumber);
            return numberBinaryOr;
        }

        byte[] CalculateTheXorOperation(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            byte[] numberBinaryXor = CalculateXorOfABinaryNumber(givenNumberOne, givenNumberTwo, baseNumber);
            return numberBinaryXor;
        }

        byte[] CalculateTheShiftingLeft(int givenNumberOne, int numberOfBit, int baseNumber)
        {
            givenNumberOne = givenNumberOne * Convert.ToInt32(Math.Pow(baseNumber, numberOfBit));
            byte[] numberBinaryOne = ToBinary(givenNumberOne, baseNumber);
            return numberBinaryOne;
        }

        byte[] CalculateTheShiftingRight(int givenNumberOne, int numberOfBit, int baseNumber)
        {
            byte[] numberBinaryOne = ToBinary(givenNumberOne, baseNumber);
            int lenghtOfBinaryNumber = numberBinaryOne.Length;
            givenNumberOne = givenNumberOne / Convert.ToInt32(Math.Pow(baseNumber, numberOfBit));
            numberBinaryOne = ToBinary(givenNumberOne, baseNumber);
            Array.Reverse(numberBinaryOne);
            Array.Resize(ref numberBinaryOne, lenghtOfBinaryNumber);
            Array.Reverse(numberBinaryOne);
            return numberBinaryOne;
        }

        byte[] CalculateLessThenNumber(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo, baseNumber);
            byte[] smallestNumber = givenNumberOne;
            if (CalculateLessThan(givenNumberOne, givenNumberTwo, baseNumber))
                smallestNumber = givenNumberOne;
            else smallestNumber = givenNumberTwo;
            return smallestNumber;
        }

        byte[] CalculateSumOfTwoNumbers(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo, baseNumber);
            byte[] sumOfTwoNumbers = new byte[givenNumberOne.Length];
            sumOfTwoNumbers = AddingTwoBinaryNumbers(givenNumberOne, givenNumberTwo, baseNumber);
            return sumOfTwoNumbers;
        }

        byte[] CalculateSubstractionOfTwoNumbers(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo, baseNumber);
            byte[] substractionOfTwoNumbers = new byte[givenNumberOne.Length];
            substractionOfTwoNumbers = SubtractingTwoBinaryNumbers(givenNumberOne, givenNumberTwo, baseNumber);
            return substractionOfTwoNumbers;
        }

        byte[] CalculateTheMultiplicationOfTwoBinaryNumbers(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            byte[] resultOfMultiplication = MultiplicationOfBinaryNumbers(givenNumberOne, givenNumberTwo, baseNumber);
            return resultOfMultiplication;
        }

        byte[] CalculateTheDivisionOfTwoBinaryNumbers(byte[] givenNumberOne, byte[] givenNumberTwo, int baseNumber)
        {
            int result = 0;
            MakingTheTwoBinaryNumbersTheSameLenght(ref givenNumberOne, ref givenNumberTwo, baseNumber);
            if (CalculateLessThan(givenNumberOne, givenNumberTwo, baseNumber) == true)
            {
                byte[] intermediate = givenNumberTwo;
                givenNumberTwo = givenNumberOne;
                givenNumberOne = intermediate;
            }
            byte[] reminder = new byte[givenNumberOne.Length];
            while (CalculateLessThan(givenNumberOne, reminder, baseNumber) == false && CalculateLessThan(givenNumberOne, reminder, baseNumber) == false)
            {
                givenNumberOne = SubtractingTwoBinaryNumbers(givenNumberOne, givenNumberTwo, baseNumber);
                result += 1;
            }
            byte[] outcome = ToBinary(result, baseNumber);
            return outcome;
        }
        
        private byte[] MultiplicationOfBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo, int baseNumber)
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
                    MakingTheTwoBinaryNumbersTheSameLenght(ref resultOfMultiplication, ref bufferNumber, baseNumber);
                    string rezultattrei = "";
                    for (int k = 0; k < bufferNumber.Length; k++)
                    {
                        rezultattrei += Convert.ToString(bufferNumber[k]);
                    }
                    resultOfMultiplication = AddingTwoBinaryNumbers(resultOfMultiplication, bufferNumber, baseNumber);
                    string rezultat = "";
                    for (int k = 0; k < resultOfMultiplication.Length; k++)
                    {
                        rezultat += Convert.ToString(resultOfMultiplication[k]);
                    }
                }
                else
                {
                    MakingTheTwoBinaryNumbersTheSameLenght(ref resultOfMultiplication, ref bufferNumber, baseNumber);
                    string rezultatdoi = "";
                    for (int k = 0; k < resultOfMultiplication.Length; k++)
                    {
                        rezultatdoi += Convert.ToString(bufferNumber[k]);
                    }
                    resultOfMultiplication = AddingTwoBinaryNumbers(resultOfMultiplication, bufferNumber, baseNumber);
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

        private byte[] SubtractingTwoBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo, int baseNumber)
        {
            byte[] subtractionOfNumbers = new byte[numberBinaryOne.Length];
            int difference = 0;
            for (int i = numberBinaryOne.Length - 1; i >= 0; i--)
            {
                int ajutor = (numberBinaryTwo[i] + numberBinaryOne[i] - difference) % baseNumber;
                if (ajutor < 0)
                    ajutor = Math.Abs(ajutor);
                subtractionOfNumbers[i] =Convert.ToByte(ajutor);
                if (numberBinaryTwo[i] > numberBinaryOne[i])
                    difference = 1;
                else if (numberBinaryOne[i] > numberBinaryTwo[i])
                    difference = 0;
            }
            return subtractionOfNumbers;
        }

        private byte[] AddingTwoBinaryNumbers(byte[] numberBinaryOne, byte[] numberBinaryTwo, int baseNumber)
        {
            byte[] sumOfNumbers = new byte[numberBinaryOne.Length];
            byte surplus = 0;
            string rezultat = "";
            for (int i = numberBinaryOne.Length -1; i >=0; i--)
            {
                sumOfNumbers[i] = Convert.ToByte((numberBinaryOne[i] + numberBinaryTwo[i] + surplus) % baseNumber);
                surplus = Convert.ToByte((numberBinaryOne[i] + numberBinaryTwo[i] + surplus) / baseNumber);
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

        private static bool CalculateLessThan(byte[] numberBinaryOne, byte[] numberBinaryTwo, int baseNumber)
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

        private byte[] CalculateXorOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo, int baseNumber)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo, baseNumber);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == 1 ^ numberBinaryTwo[i] == 1)
                    numberBinaryCombined[i] = 1;
                else numberBinaryCombined[i] = 0;
            }
            return numberBinaryCombined;
        }

        private byte[] CalculateOrAndOfABinaryNumber(byte[] numberBinaryOne, byte[] numberBinaryTwo, int operation, int baseNumber)
        {
            MakingTheTwoBinaryNumbersTheSameLenght(ref numberBinaryOne, ref numberBinaryTwo, baseNumber);
            byte[] numberBinaryCombined = new byte[numberBinaryOne.Length];
            for (int i = 0; i < numberBinaryOne.Length; i++)
            {
                if (numberBinaryOne[i] == numberBinaryTwo[i] && numberBinaryOne[i] == operation)
                    numberBinaryCombined[i] = Convert.ToByte(operation);
                else numberBinaryCombined[i] = Convert.ToByte( (operation + 1) % baseNumber);
            }
            return numberBinaryCombined;
        }

        private static void MakingTheTwoBinaryNumbersTheSameLenght(ref byte[] numberBinaryOne, ref byte[] numberBinaryTwo, int baseNumber)
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

        private static byte[] CalculateNotOfABinaryNumber(byte[] numberBinary, int baseNumber)
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

        private byte[] ToBinary(int givenNumber, int baseNumber)
        {
            byte[] numberInBinary = new byte [100] ;
            int i = 0;
            do
            {
                numberInBinary[i] = Convert.ToByte(givenNumber % baseNumber);
                givenNumber = givenNumber / baseNumber;
                i += 1;
            } while (givenNumber != 0);
            Array.Resize(ref numberInBinary, i);
            Array.Reverse(numberInBinary);
            return numberInBinary;
        }
    }
}
