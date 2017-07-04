using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class IntersectionTests
    {
        [TestMethod]
        public void IntersectionFirstTest()
        {
            Assert.AreEqual(false, Intersection(new string[4] { "stanga", "jos", "dreapta", "jos" }));
        }

        bool Intersection(string[] directions)
        {
            bool verdict = true;
            for (int i = 0; i < directions.Length - 3; i++)
            {
                if (directions[i] == directions[i + 1] || directions[i] == directions[i + 2] || directions[i] == directions[i + 3] || directions[i + 1] == directions[i + 2] || directions[i + 1] == directions[i + 3] || directions[i + 2] == directions[i + 3])
                {
                    verdict = false;
                }
            }
            return verdict;
        }
    }
}
