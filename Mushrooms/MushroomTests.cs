using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class MushroomTests
    {
        [TestMethod]
        public void FirstTest()
        {
            decimal whiteMushroomNumber = calculateMushroomsNumber(30, 5);
            Assert.AreEqual(25, whiteMushroomNumber);
        }

        decimal calculateMushroomsNumber (int totalMushroomsNumer, decimal differenceWhiteRedMushrooms)
        {
            return totalMushroomsNumer * differenceWhiteRedMushrooms /(differenceWhiteRedMushrooms + 1);
        }
            
    }
}
