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
            Assert.AreEqual(false, Intersection(new Ways[4] { Ways.left, Ways.down, Ways.right, Ways.down }));
        }

        [TestMethod]
        public void IntersectionSecondTest()
        {
            Assert.AreEqual(true, Intersection(new Ways[6] { Ways.left, Ways.down, Ways.right, Ways.down, Ways.left, Ways.up }));
        }

        enum Ways
        {
            down,
            up,
            right,
            left
        }

        bool Intersection(Ways[] directions)
        {
            bool verdict = true;
            for (int i = 0; i < directions.Length - 3; i++)
            {
                if (directions[i] == directions[i + 1] || directions[i] == directions[i + 2] || directions[i] == directions[i + 3] || directions[i + 1] == directions[i + 2] || directions[i + 1] == directions[i + 3] || directions[i + 2] == directions[i + 3])
                {
                    verdict = false;
                }
                else verdict = true;
            }
            return verdict;
        }
    }
}
