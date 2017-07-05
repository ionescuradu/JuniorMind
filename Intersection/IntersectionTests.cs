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
            Assert.AreEqual("000", Intersection(new Ways[4] { Ways.left, Ways.down, Ways.right, Ways.down }));
        }

        [TestMethod]
        public void IntersectionSecondTest()
        {
            Assert.AreEqual("125", Intersection(new Ways[6] { Ways.left, Ways.down, Ways.right, Ways.down, Ways.left, Ways.up }));
        }

        enum Ways
        {
            down,
            up,
            right,
            left
        }

        string Intersection(Ways[] directions)
        {
            int[] firstIntersection = new int[3];
            string intersectionPoint = "";
            for (int i = 0; i < directions.Length - 3; i++)
            {
                if (directions[i] != directions[i + 1] && directions[i] != directions[i + 2] && directions[i] != directions[i + 3] && directions[i + 1] != directions[i + 2] && directions[i + 1] != directions[i + 3] && directions[i + 2] != directions[i + 3])
                {
                    firstIntersection[0] = i - 1;
                    firstIntersection[1] = i;
                    firstIntersection[2] = i + 3;
                }
            }
            for (int i = 0; i < firstIntersection.Length; i++)
            {
                intersectionPoint += firstIntersection[i];
            }
            return intersectionPoint;
        }
    }
}
