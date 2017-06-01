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
            double[] arrayNumbers = new double [200];
            int index = 1;
            string concatenateNumber = "";
            for (int i = 1; i < double.MaxValue ; i++)
            {
                concatenateNumber = Convert.ToString(i) + sufix;
                double radical = 1d / 3;
                //double convertedtodouble = Convert.ToDouble(concatenateNumber);
                //double convertedtodoublecuputere = Math.Pow(Convert.ToDouble(concatenateNumber), radical);
                //double numarConvertit = Convert.ToInt16(Math.Pow(Convert.ToDouble(concatenateNumber), radical));
                if (( Math.Pow(Convert.ToDouble(concatenateNumber), radical) == Convert.ToInt32(Math.Pow(Convert.ToDouble(concatenateNumber), radical))))
                {
                    arrayNumbers[index] = i;
                    index += 1;
                }
            }
            return arrayNumbers[indexNumber];
        }
    }
}
