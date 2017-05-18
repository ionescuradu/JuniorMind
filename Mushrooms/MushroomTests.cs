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
            decimal whiteMushroomNumber = calculateRedMushroomsNumber(30, 5);
            Assert.AreEqual(25, whiteMushroomNumber);
        }

        [TestMethod]
        public void SecondTest()
        {
            decimal whiteMushroomNumber = calculateRedMushroomsNumber(20, 3);
            Assert.AreEqual(15, whiteMushroomNumber);
        }

        decimal calculateRedMushroomsNumber (int totalMushroomsNumer, decimal differenceWhiteRedMushrooms)
        {
            return totalMushroomsNumer * differenceWhiteRedMushrooms /(differenceWhiteRedMushrooms + 1);
        }
            
    }
}
