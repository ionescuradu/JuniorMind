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

        [TestMethod]
        public void OneCyclistAverageSpeed()
        {
            var data = new Data[2] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75) };
            Assert.AreEqual("Radu", CyclistAverageSpeed(data));
        }

        [TestMethod]
        public void TwoCyclistsAverageSpeed()
        {
            var data = new Data[5] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75), new Data("Dan", 1, 12, 75), new Data("Dan", 2, 8, 75), new Data("Dan", 3, 5, 75) };
            Assert.AreEqual("Radu", CyclistAverageSpeed(data));
        }

        [TestMethod]
        public void TwoCyclistsAverageSpeedSecond()
        {
            var data = new Data[7] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75), new Data("Radu", 3, 12, 75), new Data("Radu", 4, 18, 75), new Data("Dan", 1, 20, 75), new Data("Dan", 2, 20, 75), new Data("Dan", 3, 15, 75) };
            Assert.AreEqual("Dan", CyclistAverageSpeed(data));
        }

        [TestMethod]
        public void TwoCyclistsAverageSpeedThird()
        {
            var data = new Data[12] { new Data("Radu", 1, 10, 75), new Data("Radu", 2, 15, 75), new Data("Radu", 3, 12, 75), new Data("Radu", 4, 18, 75), new Data("Dan", 1, 20, 75), new Data("Dan", 2, 20, 75), new Data("Dan", 3, 15, 75), new Data("Alin", 1, 10, 55), new Data("Alin", 2, 20, 55), new Data("Alin", 3, 20, 55), new Data("Alin", 4, 10, 55), new Data("Alin", 5, 10, 55) };
            Assert.AreEqual("Dan", CyclistAverageSpeed(data));
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

        string CyclistAverageSpeed(Data[] data)
        {
            decimal averageSpeed = 0;
            string cyclist = data[0].name;
            decimal speed = 0;
            var name = data[0].name;
            decimal distance = data[0].rotationCount * data[0].wheelDiam;
            var index = 1;
            for (int i = 1; i < data.Length; i++)
            {
                if (name == data[i].name)
                {
                    distance += data[i].rotationCount * data[i].wheelDiam;
                    index += 1;
                }
                else 
                {
                    speed = distance / index;
                    if (averageSpeed < speed)
                    {
                        cyclist = data[i - 1].name;
                        name = data[i].name;
                        i -= 1;
                        distance = 0;
                        index = 0;
                        averageSpeed = speed;
                    }
                }
            }
            var velocity = distance / index;
            if (averageSpeed < velocity)
            {
                cyclist = data[data.Length - 1].name;
            }
            return cyclist;
        }
    }
}
