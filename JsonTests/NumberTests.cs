using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class NumberTests
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
            var number = new Number();
            var (match, remaining) = number.Match("1.12");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest9()
        {
            var number = new Number();
            var (match, remaining) = number.Match("-1.475");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest10()
        {
            var number = new Number();
            var (match, remaining) = number.Match("-104.575");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest11()
        {
            var number = new Number();
            var (match, remaining) = number.Match("-104.575e-10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest12()
        {
            var number = new Number();
            var (match, remaining) = number.Match("-104.575e10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "");
        }

        [TestMethod]
        public void JsonNumberTest13()
        {
            var number = new Number();
            var (match, remaining) = number.Match("-104.575ef10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual(remaining, "ef10");
        }

        [TestMethod]
        public void JsonNumberTest14()
        {
            var number = new Number();
            var (match, remaining) = number.Match("12.1m");
            var aux = ((NoMatch)match).ErrorPosition;
            Assert.AreEqual(4, ((NoMatch)match).ErrorPosition);
        }
    }
}
