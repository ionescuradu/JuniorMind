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
        public void UpperCaseAndNumber()
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
        int GeneratePassword(int passwordLenght, Options passwordType)
        {
            switch (passwordType)
            {
                case Options.LowerCases:
                    return PasswordVerifierLower(passwordLenght);
                case Options.UpperCaseesAndNumber:
                    return PasswordVerifierUpper(passwordLenght);
                default:
                    return 0;

            }
        }

        private int PasswordVerifierUpper(int passwordLenght)
        {
            int number = 1;
            char[] password = GenerateRandom('A', 'Z', number, passwordLenght);
            int counter = 0;
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] <= 'Z' && password[i] >= 'A')
                    counter += 1;
            }
            if (password[password.Length - 1] == password.Length - 1)
                counter += 1;
            return counter;
        }

            private int PasswordVerifierLower(int passwordLenght)
        {
            int number = 0;
            char[] password = GenerateRandom('a', 'z', number, passwordLenght);
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] <= 'z' && password[i] >= 'a')
                    counter += 1;
            }
            return counter;
        }

        private char[] GenerateRandom(int start, int end, int number, int passwordLenght)
        {
            char[] generatedNumbers = new char[passwordLenght];
            Random random = new Random();
            if (number == 0)
            {
                for (int i = 0; i < passwordLenght; i++)
                {
                    generatedNumbers[i] = (char)random.Next(start, end);
                }
            }
            else
            { 
                for (int i = 0; i < passwordLenght - 1; i++)
                {
                    generatedNumbers[i] = (char)random.Next(start, end);
                }
                generatedNumbers[passwordLenght - 1] = (char)(passwordLenght - 1);
            }
            return generatedNumbers;
        }
    }
}
