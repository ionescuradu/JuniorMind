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
            decimal buildingArea = buildingpoints(1.000001m, 2.000002m, 3.000003m, 4.000004m, 6.000006m, 1.000001m);
            Assert.AreEqual(6.000012m, buildingArea);
        }
        decimal buildingpoints(decimal Xa, decimal Ya, decimal Xb, decimal Yb, decimal Xc, decimal Yc)
        {
            decimal area = Math.Abs((Xa * (Yb - Yc) + Xb * (Yc - Ya) + Xc * (Ya - Yb)) / 2);
            return area;
        }

    }
}
