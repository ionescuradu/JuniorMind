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
            double[] arrayNumbers = new double [200];
            int index = 0;
            string concatenateNumber = "";
                for (int i = 1; i < int.MaxValue; i++)
                {
                    concatenateNumber = Convert.ToString(i) + sufix;
                    double radical = 1d / 3;
                    if (Math.Abs(Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical)) - Math.Pow(Convert.ToDouble(concatenateNumber), radical)) < 0.000000000001d)
                    {
                        index += 1;
                        arrayNumbers[index] = Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical));
                    }
                    if (index == indexNumber)
                        break;



                }
            return arrayNumbers[indexNumber];
        }
    }
}
