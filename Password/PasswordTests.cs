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
            Assert.AreEqual("a", GeneratePassword(1, Options.LowerCases));
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
        string GeneratePassword(int passwordLenght, Options style)
        {
            string password = "a";
            return password;
        }
    }
}
