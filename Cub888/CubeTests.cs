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

        double CalculateSpecificCubes (int indexNumber)
        {
            string sufix = "888";
            double[] arrayNumbers = new double [2000000];
            int index = 1;
            string concatenateNumber = "";
            for (int i = 1; i < double.MaxValue ; i++)
            {
                concatenateNumber = Convert.ToString(i) + sufix;
                double radical = 1d / 3;
                if (Math.Abs(Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical)) - Math.Pow(Convert.ToDouble(concatenateNumber), radical)) < 0.000000000001d)
                {
                    arrayNumbers[index] = Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical));
                    index += 1;
                }
                
                //if (( Math.Pow(Convert.ToDouble(concatenateNumber), radical) == Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical))))
                
            }
            return arrayNumbers[indexNumber];
        }
    }
}
