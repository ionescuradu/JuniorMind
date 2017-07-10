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

        decimal PochetCalculator(string[] givenArray)
        {
            string[] buffer = new string[givenArray.Length];
            if (givenArray.Length != 1)
            {
                for (int i = givenArray.Length - 1; i >= 0; i--)
                {
                    if (givenArray[i] == "*" || givenArray[i] == "/" || givenArray[i] == "+" || givenArray[i] == "-")
                    {
                        string switchCase = givenArray[i];
                        switch (switchCase)
                        {
                            case "+":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) + Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                break;
                            case "-":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) - Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                break;
                            case "/":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) / Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                break;
                            case "*":
                                givenArray[i + 1] = Convert.ToString(Convert.ToDecimal(givenArray[i + 1]) * Convert.ToDecimal(givenArray[i + 2]));
                                givenArray[i + 2] = "";
                                givenArray[i] = "";
                                break;
                        }
                    }

                }
                var index = 0;
                for (int i = 0; i < givenArray.Length; i++)
                {
                    if (givenArray[i] == "")
                    {
                        index += 1;
                    }
                    else
                    {
                        buffer[i - index] = givenArray[i];
                    }
                }
                Array.Resize(ref buffer, buffer.Length - index);
                return PochetCalculator(buffer);
            }
            else return Convert.ToDecimal(givenArray[0]);
        }
    }
}
