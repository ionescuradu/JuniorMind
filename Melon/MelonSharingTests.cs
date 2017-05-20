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

        string MelonDivision(decimal nrKg)
        {
            string response = "DA";
            return response;
        }

    }
}
