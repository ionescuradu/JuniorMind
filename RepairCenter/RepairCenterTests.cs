using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenterTests
    {
        [TestMethod]
        public void RepairCenterFirst()
        {
            CollectionAssert.AreEqual(new priority[3] { priority.High, priority.Medium, priority.Low }, sortingArray(new priority[3] { priority.Low, priority.High, priority.Medium }));
        }

        [TestMethod]
        public void RepairCenterSecond()
        {
            CollectionAssert.AreEqual(new priority[4] { priority.High, priority.High, priority.Medium, priority.Low }, sortingArray(new priority[4] { priority.Low, priority.High, priority.Medium, priority.High }));
        }

        [TestMethod]
        public void RepairCenterThird()
        {
            CollectionAssert.AreEqual(new priority[5] { priority.High, priority.High, priority.Medium, priority.Medium, priority.Low }, sortingArray(new priority[5] { priority.Low, priority.High, priority.Medium, priority.High, priority.Medium }));
        }

        enum priority
        {
            High,
            Medium,
            Low
        }

        priority[] sortingArray(priority[] givenArray)
        {
            var index = 0; //se poate extrage functia de sortare pe low, medium, high !!!!!!!!!!!
            Sorting(givenArray, ref index, priority.High);
            Sorting(givenArray, ref index, priority.Medium);
            Sorting(givenArray, ref index, priority.Low);
            return givenArray;
        }

        private static void Sorting(priority[] givenArray, ref int index, priority auxiliar)
        {
            var max = auxiliar;
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == auxiliar)
                {
                    max = givenArray[index];
                    givenArray[index] = auxiliar;
                    givenArray[i] = max;
                    index += 1;
                }
            }
        }
    }
}
