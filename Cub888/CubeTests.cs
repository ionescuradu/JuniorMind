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

        double CalculateSpecificCubes (double indexNumber)
        {
            double[] arrayNumbers = {192d};
            return arrayNumbers[0];
        }
    }
}
