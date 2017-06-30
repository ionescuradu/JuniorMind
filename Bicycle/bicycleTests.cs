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

        [TestMethod]
        public void TwoCyclists()
        {
            var data = new Data[5] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75), new Data("Dan", 1, 12, 75), new Data("Dan", 1, 8, 75), new Data("Dan", 3, 5, 75)};
            Assert.AreEqual(5887.5m, Distance(data));
        }

        [TestMethod]
        public void TwoCyclistsSpeed()
        {
            var data = new Data[5] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75), new Data("Dan", 1, 12, 75), new Data("Dan", 1, 8, 75), new Data("Dan", 3, 5, 75) };
            Assert.AreEqual("Radu", CyclistSpeedster(data));
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
            var cyclistName = data[0].name;
            var i = 0;
            decimal distance = 0;
            while (i < data.Length && cyclistName == data[i].name)
                {
                    rotations += data[i].rotationCount;
                    i += 1;
                }
            distance = rotations * data[0].wheelDiam * 3.14m;
            return distance;
        }

        string CyclistSpeedster(Data[] data)
        {
            var speed = data[0].rotationCount * data[0].wheelDiam;
            var index = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (speed < data[i].rotationCount * data[i].wheelDiam)
                {
                    index = i;
                    speed = data[i].rotationCount * data[i].wheelDiam;
                }
            }
            return data[index].name;
        }
    }
}
