using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bicycle
{
    [TestClass]
    public class bicycleTests
    {
        [TestMethod]
        public void OneCyclist()
        {
            var data = new Data[2] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75) };
            Assert.AreEqual(5887.5m, Distance(data));
        }

        public struct Data
        {
            public string name;
            public int secondCount;
            public int rotationCount;
            public int wheelDiam;

            public Data(string name, int secondCount, int rotationCount, int wheelDiam)
            {
                this.name = name;
                this.secondCount = secondCount;
                this.rotationCount = rotationCount;
                this.wheelDiam = wheelDiam;
            }
        }

        decimal Distance(Data[] data)
        {
            var rotations = 0;
            decimal distance = 0;
            for (int i = 0; i < data.Length; i++)
            {
                rotations += data[i].rotationCount;   
            }
            distance = rotations * data[0].wheelDiam * 3.14m;
            return distance;
        }
    }
}
