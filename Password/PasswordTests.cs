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

        [TestMethod]
        public void MultiLowerCase()
        {
            Assert.AreEqual(3, GeneratePassword(3, Options.LowerCases));
        }

        [TestMethod]
        {
            Assert.AreEqual(10, GeneratePassword(10, Options.UpperCaseesAndNumber));
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
            char[] password = GenerateRandom('a', 'z', passwordLenght);
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] <= 122 && password[i] >= 97)
                    counter += 1;
            }
            return counter;
        }

        private char[] GenerateRandom(int start, int end, int passwordLenght)
        {
            char[] generatedNumbers = new char[passwordLenght];
            Random random = new Random();
            for (int i = 0; i < passwordLenght; i++)
            {
            }
            return generatedNumbers;
        }
    }
}
