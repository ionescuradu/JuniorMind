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

        enum priority
        {
            High,
            Medium,
            Low
        }

        priority[] sortingArray(priority[] givenArray)
        {
            var index = 0; //se poate extrage functia de sortare pe low, medium, high !!!!!!!!!!!
            var auxiliar = priority.High;
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == priority.High)
                {
                    auxiliar = givenArray[index];
                    givenArray[index] = priority.High;
                    givenArray[i] = auxiliar;
                    index += 1;
                }
            }
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == priority.Medium)
                {
                    auxiliar = givenArray[index];
                    givenArray[index] = priority.Medium;
                    givenArray[i] = auxiliar;
                    index += 1;
                }
            }
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == priority.Low)
                {
                    auxiliar = givenArray[index];
                    givenArray[index] = priority.Low;
                    givenArray[i] = auxiliar;
                    index += 1;
                }
            }
            return givenArray;
        }
    }
}
