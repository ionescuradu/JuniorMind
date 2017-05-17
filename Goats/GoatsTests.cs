using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class GoatsTests
    {
        [TestMethod]
        public void TenGoatsTenDaysTenKgHay()
        {
            decimal secondKgHay = CalculateKilogramsOfHay(10, 10, 10, 20, 10);
            Assert.AreEqual(20, secondKgHay);
        }
        decimal CalculateKilogramsOfHay(int firstDay, int firstgoats, int firstKgHay, int secondDay,  int secondGoats )
        {
            return secondDay * firstKgHay / firstDay;
        }
    }
}
