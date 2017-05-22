using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmer
{
    [TestClass]
    public class FarmerTests
    {
        [TestMethod]
        public void FarmerLandGivingParam()
        {
            Assert.AreEqual(770, CalculateFarmersLand(1, 230, -770000));
        }

        double CalculateFarmersLand(double parameter1, double parameter2, double parameter3)
        {
            return GradeTwoEcuationSolutions(parameter1, parameter2, parameter3);
        }

        private static double GradeTwoEcuationSolutions(double parameter1, double parameter2, double parameter3)
        {
            double determiner = parameter2 * parameter2 - 4 * parameter1 * parameter3;
            if (determiner < 0)
            {
                return 0;// Here it should say that the problem doesnt have any real solutions
            }
            else
            {
            }
                double solutionOne = (-parameter2 + Math.Sqrt(determiner)) / 2;
                double solutionTwo = (-parameter2 - Math.Sqrt(determiner)) / 2;
                if (solutionOne > 0)
                {
                    return solutionOne;
                }
                else if (solutionTwo > 0)
                    {
                        return solutionTwo;
                    }
                    return 0; // Here it should say that the problem doesnt have any real solutions
        }
    }
}
