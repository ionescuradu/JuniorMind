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
            Assert.AreEqual("", GeneratePassword(new Options { passwordLenght = 4, upperCases = 1, numbers = 1, simbols = 1, withoutAmbigous = false, withoutSimilar = false}));
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
            char[] randomize = finalPassword.ToCharArray();
            int lenght = randomize.Length - 1;
            while (lenght >= 0 )
            {
                var random = GenerateRandomNumber(0, lenght + 1);
                var value = randomize[random];
                randomize[random] = randomize[lenght];
                randomize[lenght] = value;
                lenght--; 
            }
            finalPassword = new string(randomize);
            return finalPassword;
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

        private int GenerateRandomNumber(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }
    }
}
