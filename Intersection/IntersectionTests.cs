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
            Assert.AreEqual(new Coordonates { x = 0, y = 0 }, IntersectionPoint(new Coordonates {x = 0, y =0 }, 1 ,new Ways[4] { Ways.left, Ways.down, Ways.right, Ways.down }));
        }

        [TestMethod]
        public void IntersectionSecondTest()
        {
            Assert.AreEqual(new Coordonates { x = -1, y = -1 }, IntersectionPoint(new Coordonates { x = 0, y = 0 }, 1 , new Ways[6] { Ways.left, Ways.down, Ways.right, Ways.down, Ways.left, Ways.up }));
        }

        [TestMethod]
        public void IntersectionThirdTest()
        {
            Assert.AreEqual(new Coordonates { x = 1, y = 2 }, IntersectionPoint(new Coordonates { x = 0, y = 0 }, 1 , new Ways[11] { Ways.right, Ways.up, Ways.up, Ways.up, Ways.up, Ways.up, Ways.left, Ways.down, Ways.down, Ways.down, Ways.right }));
        }
        public struct Coordonates
        {
            public int x;
            public int y;
            public Coordonates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        enum Ways
        {
            down,
            up,
            right,
            left
        }
        Coordonates IntersectionPoint(Coordonates startingPoint, int segmentLenght, Ways[] direction)
        {
            var points = new Coordonates[direction.Length + 1];
            points[0].x = startingPoint.x;
            points[0].y = startingPoint.y;
            var meetingPoint = new Coordonates(0, 0);
            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == Ways.up)
                {
                    points[i + 1].y = points[i].y + segmentLenght;
                    points[i + 1].x = points[i].x;
                }
                if (direction[i] == Ways.down)
                {
                    points[i + 1].y = points[i].y - segmentLenght;
                    points[i + 1].x = points[i].x;
                }
                if (direction[i] == Ways.left)
                {
                    points[i + 1].y = points[i].y;
                    points[i + 1].x = points[i].x - segmentLenght;
                }
                if (direction[i] == Ways.right)
                {
                    points[i + 1].y = points[i].y;
                    points[i + 1].x = points[i].x + segmentLenght;
                }
                for (int j = 0; j < i; j++)
                {
                    if (points[j].x == points[i + 1].x && points[j].y == points[i + 1].y)
                    {
                        meetingPoint.x = points[i + 1].x;
                        meetingPoint.y = points[i + 1].y;
                    }
                }
            }
            return meetingPoint;
        }
    }
}
