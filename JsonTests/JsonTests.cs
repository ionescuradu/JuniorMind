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
            var givenText = "-01";
            var myError = "01";
            Number(givenText, out var givenError);
            Assert.AreEqual(myError, givenError);
            Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest2()
        {
            var givenText = "-123";
            string myError = null;
            Number(givenText, out var givenError);
            Assert.AreEqual(myError, givenError);
            Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest3()
        {
            var givenText = "-123.1";
            string myError = null;
            Number(givenText, out var givenError);
            Assert.AreEqual(myError, givenError);
            Assert.AreEqual(true, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest4()
        {
            var givenText = "-123+";
            string myError = "3+";
            Number(givenText, out var givenError);
            Assert.AreEqual(myError, givenError);
            Assert.AreEqual(false, Number(givenText, out givenError));
        }

        [TestMethod]
        public void JsonNumberTest5()
        {
            var givenText = "12.-";
            string myError = ".-";
            Number(givenText, out var givenError);
            Assert.AreEqual(myError, givenError);
            Assert.AreEqual(false, Number(givenText, out givenError));
        }



        public bool Number(string text, out string error)
        {
            error = null;
            var index = 0;
            if (text[index] == '-')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                    if (text[index] == '0')
                    {
                        if (index + 1 < text.Length)
                        {
                            index++;
                            if ((text[index] == '.') || (text[index] == 'e') || (text[index] == 'E'))
                            {
                                if (text[index] == '.')
                                {
                                    if (index + 1 < text.Length)
                                    {
                                        index++;
                                        while (index < text.Length)
                                        {
                                            if (text[index] >= '0' && text[index] <= '9')
                                            {
                                                index++;
                                            }
                                            else
                                            {
                                                error = error + text[index - 1] + text[index];
                                                return false;
                                            }
                                        }
                                        if (index == text.Length)
                                        {
                                            return true;
                                        }
                                        if ((text[index] == 'e') || (text[index] == 'E'))
                                        {
                                            if (index + 1 < text.Length)
                                            {
                                                index++;
                                                if (text[index] == '+' || text[index] == '-')
                                                {
                                                    if (index + 1 < text.Length)
                                                    {
                                                        while (index < text.Length)
                                                        {
                                                            if (text[index] >= '0' && text[index] <= '9')
                                                            {
                                                                index++;
                                                            }
                                                            else
                                                            {
                                                                error = error + text[index - 1] + text[index];
                                                                return false;
                                                            }
                                                        }
                                                        if (index + 1 < text.Length)
                                                        {
                                                            error = error + text[index] + text[index + 1];
                                                            return false;
                                                        }
                                                        else return true;
                                                    }
                                                    error = error + text[index - 1] + text[index];
                                                    return false;
                                                }
                                                else
                                                {
                                                    error = error + text[index - 1] + text[index];
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                error = error + text[index - 1] + text[index];
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            error = error + text[index - 1] + text[index];
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        error = error + text[index - 1] + text[index];
                                        return false;
                                    }
                                }
                                else
                                { 
                                    if (index + 1 < text.Length)
                                    {
                                        index++;
                                        if (text[index] == '+' || text[index] == '-')
                                        {
                                            if (index + 1 < text.Length)
                                            {
                                                while (index < text.Length)
                                                {
                                                    if (text[index] >= '0' && text[index] <= '9')
                                                    {
                                                        index++;
                                                    }
                                                    else
                                                    {
                                                        error = error + text[index - 1] + text[index];
                                                        return false;
                                                    }
                                                }
                                                if (index + 1 < text.Length)
                                                {
                                                    error = error + text[index] + text[index + 1];
                                                    return false;
                                                }
                                                else return true;
                                            }
                                            error = error + text[index - 1] + text[index];
                                            return false;
                                        }
                                        else
                                        {
                                            error = error + text[index - 1] + text[index];
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        error = error + text[index - 1] + text[index];
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                error = error + text[index - 1] + text[index];
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        // este o cifra de la 1 la 9 chiar de la inceput
                    }
                }
                else
                {
                    error = error + text[index];
                    return false;
                }
            }
        }
    }
}
