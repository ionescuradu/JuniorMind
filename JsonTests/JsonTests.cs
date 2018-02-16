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



        public bool Number(string text, out string error)
        {
            error = null;
            var index = 0;
            while (text[index] == ' ')
            {
                index++;
            }
            if (text[index] == '-' || text[index] == '0')
            {
                if (text[index] == '0')
                {
                    if (text[index + 1] != '.')
                    {
                        error += text[index] + text[index + 1];
                        return false;
                    }
                }
                if (text[index + 1] == '0')
                {
                    if (text[index + 2] != '.')
                    {
                        error = error + text[index + 1] + text[index + 2];
                        return false;
                    }
                }
                index++;
            }
            while (text[index] >= '0' && text[index] <= '9')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                }
                else
                {
                    return error == null;
                }
            }
            if (text[index] == '.')
            {
                if (index + 1 < text.Length)
                {
                    index++;
                }
                else
                {
                    return error == null;
                }
                if (index + 1 >= text.Length)
                {
                    return true;
                }
                if (!(text[index + 1] >= '0' && text[index + 1] <= '9'))
                {
                    error = error + text[index] + text[index + 1];
                    return false;
                }
            }
            if (text[index] == 'e' || text[index] == 'E')
            {
                if (index + 1 >= text.Length)
                {
                    error = error + text[index - 1] + text[index];
                    return false;
                }
                if (!(text[index + 1] == '+' || text[index + 1] == '-'))
                {
                    error = error + text[index] + text[index + 1];
                    return false;
                }
                while (text[index] >= '0' && text[index] <= '9')
                {
                    if (index + 1 < text.Length)
                    {
                        index++;
                    }
                    else
                    {
                        return error == null;
                    }
                }
            }
            error = error + text[index - 1] + text[index];
            return false;
        }
    }
}
