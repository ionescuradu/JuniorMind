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
            Assert.AreEqual("", GeneratePassword(10, 3, 2, 1, false, false));
        }

        struct Options
        {
            public int passwordlenght;
            public int upperCases;
            public int numbers;
            public int simbols;
            public bool withoutSimilar;
            public bool withoutAmbigous;

        }

        string GeneratePassword(int passwordLenght, int upperCases, int numbers, int simbols, bool withoutSimilar, bool withoutAmbigous)
        {
            Options options = new Options();
            return PasswordGenration(passwordLenght, upperCases, numbers, simbols, withoutSimilar, withoutAmbigous); ;
        }

        private string PasswordGenration(int passwordLenght, int upperCases, int numbers, int simbols, bool withoutSimilar, bool withoutAmbigous)
        {
            char[] password = new char[passwordLenght];
            string finalPassword = "";
            string ambiguousCharacters = "{}[]()/\'`~,;:.<>";
            string similarCharacters = "il1Lo0O";
            string simbolsVector = "*?!_&#$+-@^=%";
            int randomAmbigous = 0;
            int randomSimilar = 0;
            int remainingCharacters = passwordLenght - upperCases - numbers - simbols;
            if (withoutAmbigous != false)
                randomAmbigous = GenerateRandomNumber(1, remainingCharacters);
            var rest = remainingCharacters - randomAmbigous;
            if (withoutSimilar != false)
                randomSimilar = GenerateRandomNumber(1, remainingCharacters);
            int remainingLowerCase = rest - randomSimilar;
            GenerateLowerCase(passwordLenght, password, remainingLowerCase);
            GenerateAmbigous(passwordLenght, password, ambiguousCharacters, randomAmbigous);
            GenerateSimilar(passwordLenght, password, similarCharacters, randomSimilar);
            GenerateSimbols(passwordLenght, simbols, password, simbolsVector);
            GenerateUpperCase(passwordLenght, upperCases, password);
            GenerateNumbers(passwordLenght, numbers, password);
            for (int i = 0; i < password.Length; i++)
            {
                finalPassword += password[i];
            }

            return finalPassword;
        }

        private void GenerateNumbers(int passwordLenght, int numbers, char[] password)
        {
            for (int i = 1; i <= numbers; i++)
            {
                var index = 1;
                var randomNumber = GenerateRandomNumber(Convert.ToInt32('2'), Convert.ToInt32('9'));
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)randomNumber;
                        index = 0;
                    }
                }
            }
        }
        private void GenerateUpperCase(int passwordLenght, int upperCases, char[] password)
        {
            for (int i = 1; i <= upperCases; i++) 
            {
                var index = 1;
                var randomLetter = GenerateRandomNumber(Convert.ToInt32('A'), Convert.ToInt32('Z'));
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)randomLetter;
                        index = 0;
                    }
                }
            }
        }
        private void GenerateSimbols(int passwordLenght, int simbols, char[] password, string simbolsVector)
        {
            for (int i = 1; i <= simbols; i++)
            {
                var index = 1;
                var randomSimbols = GenerateRandomNumber(0, simbolsVector.Length);
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)simbolsVector[randomSimbols];
                        index = 0;
                    }
                }
            }
        }
        private void GenerateSimilar(int passwordLenght, char[] password, string similarCharacters, int randomSimilar)
        {
            for (int i = 1; i <= randomSimilar; i++)
            {
                var index = 1;
                var similar = GenerateRandomNumber(0, similarCharacters.Length);
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)similarCharacters[similar];
                        index = 0;
                    }
                }
            }
        }
        private void GenerateAmbigous(int passwordLenght, char[] password, string ambiguousCharacters, int randomAmbigous)
        {
            for (int i = 1; i <= randomAmbigous; i++)
            {
                var index = 1;
                var ambigous = GenerateRandomNumber(0, ambiguousCharacters.Length);
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)ambiguousCharacters[ambigous];
                        index = 0;
                    }
                }
            }
        }
        private void GenerateLowerCase(int passwordLenght, char[] password, int remainingLowerCase)
        {
            for (int i = 1; i <= remainingLowerCase; i++)
            {
                var index = 1;
                var randomLetter = GenerateRandomNumber(Convert.ToInt32('a'), Convert.ToInt32('z'));
                while (index != 0)
                {
                    int indexForPassword = GenerateRandomNumber(0, passwordLenght);
                    if (password[indexForPassword] == 0)
                    {
                        password[indexForPassword] = (char)randomLetter;
                        index = 0;
                    }
                }
            }
        }
        private int GenerateRandomNumber(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }
    }
}
