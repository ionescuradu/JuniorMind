using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Melon
{
    [TestClass]
    public class MelonSharingTests
    {
        [TestMethod]
        public void CalculateDaResponse()
        {
            Assert.AreEqual("DA", MelonDivision(2));
        }

        [TestMethod]
        public void CalculateNuResponse()
        {
            Assert.AreEqual("NU", MelonDivision(3));
        }

        string MelonDivision(decimal nrKg)
        {
            string response = MelonKgDividedByTwo(nrKg);
            return response;
        }

        private string MelonKgDividedByTwo(decimal nrKg)
        {
            string response = "";
            if (isMelonKgEvenOrOdd(nrKg))
                response = "DA";
            else response = "NU";
            return response;
        }

        private bool isMelonKgEvenOrOdd(decimal nrKg)
        {
            return (nrKg % 2 == 0);
        }
    }
}
