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
            var givenText = "-0";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest2()
        {
            var givenText = "-1";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest3()
        {
            var givenText = "+3";
            string myError = "+";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest4()
        {
            var givenText = "-m23+";
            string myError = "-m";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest5()
        {
            var givenText = "12";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest6()
        {
            var givenText = "-012";
            string myError = "-01";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest7()
        {
            var givenText = "0+456";
            string myError = "0+";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest8()
        {
            var givenText = "123.1";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest9()
        {
            var givenText = "123.1+";
            string myError = "123.1+";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest10()
        {
            var givenText = "123.101.1";
            string myError = "123.101.";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest11()
        {
            var givenText = "-12.89e+9";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest12()
        {
            var givenText = "-12.89e+";
            string myError = "-12.89e+";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest13()
        {
            var givenText = "1289.e+2";
            string myError = "1289.e";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest14()
        {
            var givenText = "1289.8E+2";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest15()
        {
            var givenText = "-1289.8";
            string myError = null;
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest16()
        {
            var givenText = "-1289.8me+9";
            string myError = "-1289.8m";
            //Number(givenText, out var givenError);
            //Assert.AreEqual(myError, givenError);
            //Assert.AreEqual(false, Number(givenText, out givenError));
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
