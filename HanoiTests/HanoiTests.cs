using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTests
{
    [TestClass]
    public class HanoiTests
    {
        [TestMethod]
        public void HanoiFirstTest()
        {
        //    Assert.AreEqual((Math.Pow(2, 4) - 1), HanoiTowers(4));
        }

        [TestMethod]
        public void HanoiSecondTest()
        {
        //    Assert.AreEqual((Math.Pow(2, 6) - 1), HanoiTowers(6));
        }

        [TestMethod]
        public void HanoiThirdTest()
        {
        //    Assert.AreEqual((Math.Pow(2, 10) - 1), HanoiTowers(10));
        }

        [TestMethod]
        public void HanoiFourthTest()
        {
        }

        int HanoiTowers(int numberOfDisks)
        {
            int counter = 0;
            int[] firstTower = new int[numberOfDisks];
            int[] secondTower = new int[numberOfDisks];
            int[] thirdTower = new int[numberOfDisks];
            int index = 0;
            int indexA = 0;
            int indexB = secondTower.Length - 1;
            int indexC = thirdTower.Length - 1;
            for (int i = 0; i < firstTower.Length; i++)
            {
                firstTower[i] = i + 1;
            }
            Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, numberOfDisks);
            return counter;
        }

        private decimal Hanoi(int[] firstTower, int[] secondTower, int[] thirdTower, int index, int indexA, int indexB, int indexC, ref int counter, int total) //recurection method
        {
            if (counter != Math.Pow(2,total) - 1)
            {
                switch (index)
                {
                    case 0: // A -> B
                        if (firstTower[indexA] < secondTower[indexB] || secondTower[indexB] == 0 && firstTower[indexA] != 0)
                        {
                            if (secondTower[indexB] == 0)
                            {
                                secondTower[indexB] = firstTower[indexA];
                                firstTower[indexA] = 0;
                                indexA += 1;
                                if (indexA == total)
                                    indexA = total - 1;
                                index = 1;
                                counter += 1;
                                return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                            }
                            else
                            {
                                if (firstTower[indexA] != 0)
                                {
                                    indexB -= 1;
                                    secondTower[indexB] = firstTower[indexA];
                                    firstTower[indexA] = 0;
                                    indexA += 1;
                                    if (indexA == total)
                                        indexA = total - 1;
                                    index = 1;
                                    counter += 1;
                                    return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                                }
                                else
                                {
                                    firstTower[indexA] = secondTower[indexB];
                                    secondTower[indexB] = 0;
                                    indexB += 1;
                                    counter += 1;
                                    if (indexB == total)
                                        indexB = total - 1;
                                    index = 1;
                                    return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                                }
                            }
                        }
                        else
                        {
                            indexA -= 1;
                            firstTower[indexA] = secondTower[indexB];
                            secondTower[indexB] = 0;
                            indexB += 1;
                            index = 1;
                            counter += 1;
                            return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                        }
                    case 1: // A -> C
                        if (firstTower[indexA] < thirdTower[indexC] || thirdTower[indexC] == 0)
                        {
                            if (thirdTower[indexC] == 0)
                            {
                                thirdTower[indexC] = firstTower[indexA];
                                firstTower[indexA] = 0;
                                indexA += 1;
                                if (indexA == total)
                                    indexA = total - 1;
                                index = 2;
                                counter += 1;
                                return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                            }
                            else
                            {
                                indexC -= 1;
                                thirdTower[indexC] = firstTower[indexA];
                                firstTower[indexA] = 0;
                                indexA += 1;
                                if (indexA == total)
                                    indexA = total - 1;
                                index = 2;
                                counter += 1;
                                return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                            }
                        }
                        else
                        {
                            firstTower[indexA - 1] = thirdTower[indexC];
                            thirdTower[indexC] = 0;
                            indexC += 1;
                            indexA -= 1;
                            index = 2;
                            counter += 1;
                            return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                        }
                    default: // B -> C
                        if (secondTower[indexB] < thirdTower[indexC] || thirdTower[indexC] == 0)
                        {
                            thirdTower[indexC - 1] = secondTower[indexB];
                            indexC -= 1;
                            secondTower[indexB] = 0;
                            indexB += 1;
                            if (indexB == total)
                                indexB = total - 1;
                            index = 0;
                            counter += 1;
                            return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                        }
                        else
                        {
                            secondTower[indexB - 1] = thirdTower[indexC];
                            thirdTower[indexC] = 0;
                            indexB -= 1;
                            indexC += 1;
                            if (indexC == total)
                                indexC = total - 1;
                            index = 0;
                            counter += 1;
                            return Hanoi(firstTower, secondTower, thirdTower, index, indexA, indexB, indexC, ref counter, total);
                        }
                }
            }
            else return counter;
        }
    }
}

