using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archaeological_site
{
    [TestClass]
    public class ArchaeologicalTests
    {
        [TestMethod]
        public void FirstTry()
        {
            float buildingArea = buildingpoints(1.000001f, 2.000002f, 3.000003f, 4.000004f, 6.000006f, 1.000001f);
            Assert.AreEqual(6.000012f, buildingArea);
        }
        float buildingpoints(float Xa, float Ya, float Xb, float Yb, float Xc, float Yc)
        {
            float area = Math.Abs((Xa * (Yb - Yc) + Xb * (Yc - Ya) + Xc * (Ya - Yb)) / 2);
            return area;
        }

    }
}
