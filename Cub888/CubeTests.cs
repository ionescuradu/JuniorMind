using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cub888
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void FirstNumber()
        {
            Assert.AreEqual(192, CalculateSpecificCubes(1));
        }

        [TestMethod]
        public void SecondNumber()
        {
            Assert.AreEqual(442, CalculateSpecificCubes(2));
        }

        [TestMethod]
        public void ThirdNumber()
        {
            Assert.AreEqual(692, CalculateSpecificCubes(3));
        }

        double CalculateSpecificCubes (int indexNumber)
        {
            string sufix = "888";
            double indicatedNumber = 0;
            int index = 0;
            string concatenateNumber = "";
            double radical = 1d / 3;
                for (int i = 1; i < int.MaxValue; i++)
                {
                    concatenateNumber = Convert.ToString(i) + sufix;
                    double numberAtRadical = Math.Pow(Convert.ToDouble(concatenateNumber), radical);
                if (Math.Abs(Convert.ToInt32(numberAtRadical) - numberAtRadical) < 0.000000000001d)
                    {
                        index += 1;
                        indicatedNumber = Convert.ToInt32(numberAtRadical);
                    }
                    if (index == indexNumber)
                        break;
                }
            return indicatedNumber;
        }
    }
}
