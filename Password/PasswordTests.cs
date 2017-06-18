using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void FistPasswordTest()
        {
            Assert.AreEqual("Password is Correct", GeneratePassword(new Options { passwordLenght = 4, upperCases = 1, numbers = 1, simbols = 1, withoutAmbigous = false, withoutSimilar = false}));
        }

        [TestMethod]
        public void SecondPasswordTest()
        {
            Assert.AreEqual("Password is Correct", GeneratePassword(new Options { passwordLenght = 6, upperCases = 2, numbers = 1, simbols = 2, withoutAmbigous = false, withoutSimilar = false }));
        }

        struct Options
        {
            public int passwordLenght;
            public int upperCases;
            public int numbers;
            public int simbols;
            public bool withoutSimilar;
            public bool withoutAmbigous;

        }

        string GeneratePassword(Options options)
        {
            string finalPassword = "";
            string ambiguousCharacters = "{}[]()/\'`~,;:.<>";
            string similarCharacters = "il1Lo0O";
            string simbolsVector = "*?!_&#$+-@^=%";
            int randomAmbigous = 0;
            int randomSimilar = 0;
            int remainingCharacters = options.passwordLenght - options.upperCases - options.numbers - options.simbols;
            if (options.withoutAmbigous != false)
                randomAmbigous = GenerateRandomNumber(1, remainingCharacters);
            var rest = remainingCharacters - randomAmbigous;
            if (options.withoutSimilar != false)
                randomSimilar = GenerateRandomNumber(1, remainingCharacters);
            int remainingLowerCase = rest - randomSimilar;
            finalPassword = GenerateRandomString(options.upperCases, 'A', 'Z', similarCharacters) + GenerateRandomString(remainingLowerCase, 'a', 'z', similarCharacters) + GenerateRandomString(options.numbers, '0', '9', similarCharacters) + GenerateSimbols(options.passwordLenght, options.simbols, simbolsVector) + GenerateSimilar(options.passwordLenght, similarCharacters, randomSimilar) + GenerateAmbigous(options.passwordLenght, ambiguousCharacters, randomAmbigous);
            char[] randomize = RandomizePassword(finalPassword);
            finalPassword = new string(randomize);
            bool correctPassword = PasswordValidation(options, finalPassword, ambiguousCharacters, similarCharacters, simbolsVector);
            if (correctPassword == true)
                return "Password is Correct";
            else
                return "Password is Incorrect";
        }

        private static bool PasswordValidation(Options options, string finalPassword, string ambiguousCharacters, string similarCharacters, string simbolsVector)
        {
            var indexSmall = 0;
            var indexUpper = 0;
            var indexNumber = 0;
            var indexAmbigous = false;
            var indexSimilar = false;
            var indexSimbols = 0;
            var indexAmbigous2 = 0;
            var indexSimilar2 = 0;
            bool correctPassword = false;
            for (int i = 0; i < finalPassword.Length; i++)
            {
                if (finalPassword[i] >= 'a' && finalPassword[i] <= 'z')
                {
                    indexSmall += 1;
                }
                if (finalPassword[i] >= 'A' && finalPassword[i] <= 'Z')
                {
                    indexUpper += 1;
                }
                if (finalPassword[i] >= '0' && finalPassword[i] <= '9')
                {
                    indexNumber += 1;
                }
                for (int j = 0; j < ambiguousCharacters.Length; j++)
                {
                    if (finalPassword[i] == ambiguousCharacters[j])
                    {
                        indexAmbigous = true;
                        indexAmbigous2 += 1;
                    }
                }
                for (int k = 0; k < similarCharacters.Length; k++)
                {
                    if (finalPassword[i] == similarCharacters[k])
                    {
                        indexSimilar = true;
                        indexSimilar2 += 1;
                    }

                }
                for (int m = 0; m < simbolsVector.Length; m++)
                {
                    if (finalPassword[i] == simbolsVector[m])
                    {
                        indexSimbols += 1;
                    }
                }
            }
            for (int i = 0; i < finalPassword.Length; i++)
            {
                if (finalPassword[i] == 'o' || finalPassword[i] == 'i')
                {
                    indexSmall -= 1;
                }
                if (finalPassword[i] == 'O' || finalPassword[i] == 'L')
                {
                    indexUpper -= 1;
                }
                if (finalPassword[i] == '0' || finalPassword[i] == '1')
                {
                    indexNumber -= 1;
                }
            }
            if (indexSimbols == options.simbols && indexSimilar == options.withoutSimilar && indexNumber == options.numbers && indexAmbigous == options.withoutAmbigous && indexUpper == options.upperCases && options.passwordLenght == (indexAmbigous2 + indexSimilar2 + indexSmall + indexUpper + indexSimbols + indexNumber))
                correctPassword = true;
            return correctPassword;
        }

        private char[] RandomizePassword(string finalPassword)
        {
            char[] randomize = finalPassword.ToCharArray();
            int lenght = randomize.Length - 1;
            while (lenght >= 0)
            {
                var random = GenerateRandomNumber(0, lenght + 1);
                var value = randomize[random];
                randomize[random] = randomize[lenght];
                randomize[lenght] = value;
                lenght--;
            }

            return randomize;
        }

        private string GenerateSimbols(int passwordLenght, int simbols, string simbolsVector)
        {
            string random = "";
            for (int i = 1; i <= simbols; i++)
            {
                int randomSimbols = GenerateRandomNumber(0, simbolsVector.Length);
                random += simbolsVector[randomSimbols];
            }
            return random;
        }
        private string GenerateSimilar(int passwordLenght, string similarCharacters, int randomSimilar)
        {
            string random = "";
            for (int i = 1; i <= randomSimilar; i++)
            {
                var similar = GenerateRandomNumber(0, similarCharacters.Length);
                random += (char)similar;
            }
            return random;
        }
        private string GenerateAmbigous(int passwordLenght, string ambiguousCharacters, int randomAmbigous)
        {
            string random = "";
            for (int i = 1; i <= randomAmbigous; i++)
            {
                var ambigous = GenerateRandomNumber(0, ambiguousCharacters.Length);
                random += (char)ambigous;
            }
            return random;
        }
        private string GenerateRandomString(int count, char start, char end, string excluded)
        {
            string random = "";
            int character = 0;
            for (int i = 1; i <= count; i++)
            {
                var index = 2;
                while (index >= 1)
                {
                    index = 0;
                    character = GenerateRandomNumber(start, end);
                    for (int j = 0; j < excluded.Length; j++)
                    {
                        if (character == excluded[j])
                        {
                            index += 1;
                        }
                    }
                }
                random += (char)character;
            }
            return random;
        }
        Random random = new Random();
        private int GenerateRandomNumber(int start, int end)
        {
            return random.Next(start, end);
        }
    }
}
