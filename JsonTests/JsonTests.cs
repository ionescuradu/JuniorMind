using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class JsonTests
    {
        [TestMethod]
        public void JsonNumberTest1()
        {
            var integer = new Integer();
            var (match, remaining) = integer.Match("0");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest2()
        {
            var integer = new Integer();
            var (match, remaining) = integer.Match("123456");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest3()
        {
            var integer = new Integer();
            var (match, remaining) = integer.Match("-1234");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest4()
        {
            var integer = new Integer();
            var (match, remaining) = integer.Match("-0");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest5()
        {
            var integer = new Integer();
            var (match, remaining) = integer.Match("1.");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, ".");
        }

        [TestMethod]
        public void JsonNumberTest6()
        {
            var fractional = new Fractional();
            var (match, remaining) = fractional.Match(".12");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest7()
        {
            var fractional = new Fractional();
            var (match, remaining) = fractional.Match("1.12");
            Assert.IsFalse(match.Success);
            Assert.AreEqual(remaining, "1.12");
        }

        [TestMethod]
        public void JsonNumberTest8()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("1.12");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest9()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("-1.475");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest10()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("-104.575");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest11()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("-104.575e-10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest12()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("-104.575e10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest13()
        {
            var number = new Numbers();
            var (match, remaining) = number.Match("-104.575ef10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "f10");
        }

        public bool Number(string text, out string error)
        {
            error = null;
            var index = 0;
            if (IsNegative(ref index, text))
            {
                if (index + 1 < text.Length)
                {
                    index++;
                    if (!(text[index] >= '0' && text[index] <= '9'))
                    {
                        error = GenerateError(text, error, index);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            if (!(text[index] >= '0' && text[index] <= '9'))
            {
                error += text[index];
                return false;
            }
            if (text[index] == '0')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                    if (text[index] != '.')
                    {
                        error = GenerateError(text, error, index);
                        return false;
                    }
                    if (index + 1 < text.Length)
                    {
                        index++;
                    }
                }
                else return true;
            }
            while (text[index] >= '0' && text[index] <= '9')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                }
                else return true;
            }
            if (text[index] == '.')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                }
                while (text[index] >= '0' && text[index] <= '9')
                {
                    if (index + 1 < text.Length)
                    {
                        index++;
                    }
                    else return true;
                }
                if (text[index - 1] == '.')
                {
                    error = GenerateError(text, error, index);
                    return false;
                }
            }
            if (text[index] == 'e' || text[index] == 'E')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                }
                if (text[index] == '+' || text[index] == '-')
                {
                    if (index + 1 < text.Length)
                    {
                        index++;
                    }
                    while (text[index] >= '0' && text[index] <= '9')
                    {
                        if (index + 1 < text.Length)
                        {
                            index++;
                        }
                        else return true;
                    }
                    if (index != text.Length - 1)
                    {
                        error = GenerateError(text, error, index);
                        return false;
                    }
                }
            }
            error = GenerateError(text, error, index);
            return false;
        }

        private static string GenerateError(string text, string error, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                error = error + text[i];
            }

            return error;
        }

        public bool IsNegative(ref int index, string text)
        {
            return (text[index] == '-');            
        }
    }
}
