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
            Assert.AreEqual("", GeneratePassword(10, 3, 2, 1, true, true));
        }

        //struct Options
        //{
        //    public char[] lowerCases;ra
        //    public char[] upperCases;
        //    public char[] numbers;
        //    public char[] withoutSimilar;
        //    public char[] withoutAmbigous;
        //}

        string GeneratePassword(int passwordLenght, int upperCases, int numbers, int simbols, bool withoutSimilar, bool withoutAmbigous)
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
            for (int i = 1; i <= remainingLowerCase; i++)  //Lower letter
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
            for (int i = 1; i <= randomAmbigous; i++)  //Ambigous
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
            for (int i = 1; i <= randomSimilar; i++) //Similar
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
            for (int i = 1; i <= simbols; i++) //Symbols
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
            for (int i = 1; i <= upperCases; i++)  //Upper letter
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
            for (int i = 1; i <= numbers; i++) //Numbers
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
            for (int i = 0; i < password.Length; i++)
            {
                finalPassword += password[i];
            }
            return finalPassword;
        }
        private int GenerateRandomNumber(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }
    }
}
