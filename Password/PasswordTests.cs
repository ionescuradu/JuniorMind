using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void OneLowerLetter()
        {
            Assert.AreEqual(1, GeneratePassword(1, Options.LowerCases));
        }

        enum Options
        {
            LowerCases,
            UpperCaseesAndNumber,
            NumbersAndHowMany,
            SimbolsAndNumber,
            WithoutSpeacialChars,
            WithoutAmbiguuChars
        }
        int GeneratePassword(int passwordLenght, Options style)
        {
            string password = "a";
            int counter = 0;
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] <= 26 && password[i] >= 1)
                    counter += 1;
            }
            return counter;
        }
    }
}
