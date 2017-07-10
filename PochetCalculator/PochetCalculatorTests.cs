using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PochetCalculator
{
    [TestClass]
    public class PochetCalculatorTests
    {
        [TestMethod]
        public void CalculatorFirstTest()
        {
            Assert.AreEqual(12, PochetCalculator(new string[3] { "*", "3", "4" }));
        }

        [TestMethod]
        public void CalculatorSecondTest()
        {
            Assert.AreEqual(4, PochetCalculator(new string[5] { "*", "+", "1", "1", "2" }));
        }

        [TestMethod] 
        public void CalculatorThirdTest()
        {
            Assert.AreEqual(1564.75m, PochetCalculator(new string[11] { "+", "/", "*", "+", "56", "46", "46", "3", "-", "1", "0.25" }));
        }

        decimal PochetCalculator(string[] givenArray)
        {
            if (givenArray.Length != 1)
            {
                for (int i = givenArray.Length - 1; i >= 0; i--)
                {
                    if (givenArray[i] == "*" || givenArray[i] == "/" || givenArray[i] == "+" || givenArray[i] == "-")
                    {
                        switch (givenArray[i])
                        {
                            case "+":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) + Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                givenArray = ResizingArray(givenArray);
                                return PochetCalculator(givenArray);
                            case "-":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) - Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                givenArray = ResizingArray(givenArray);
                                return PochetCalculator(givenArray);
                            case "/":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) / Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                givenArray = ResizingArray(givenArray);
                                return PochetCalculator(givenArray);
                            case "*":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) * Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                givenArray = ResizingArray(givenArray);
                                return PochetCalculator(givenArray);
                        }

                    }
                }
                return PochetCalculator(givenArray);
            }
            else return Convert.ToDecimal(givenArray[0]);
        }

        private static string[] ResizingArray(string[] givenArray)
        {
            var index = 0;
            for (int j = 0; j < givenArray.Length; j++)
            {
                if (givenArray[j] == "")
                {
                    index += 1;
                }
                else
                {
                    givenArray[j - index] = givenArray[j];
                }
            }
            Array.Resize(ref givenArray, givenArray.Length - index);
            return givenArray;
        }
    }
}
