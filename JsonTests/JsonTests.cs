using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTests
{
    [TestClass]
    public class JsonTests
    {
        [TestMethod]
        public void ValueTest1()
        {
            var x = new Json();
            var (match, remaining) = x.Match("");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest2()
        {
            var x = new Json();
            var (match, remaining) = x.Match("\"\"");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest3()
        {
            var x = new Json();
            var (match, remaining) = x.Match("-104.575e-10");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest4()
        {
            var x = new Json();
            var (match, remaining) = x.Match("true");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTest5()
        {
            var x = new Json();
            var (match, remaining) = x.Match("-104.575e-1s0");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("-104.575e-1s0", remaining);
        }

        [TestMethod]
        public void ValueTestArray()
        {
            var x = new Json();
            var (match, remaining) = x.Match("[true,null,false,1234.7,\"radu\"]");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestArrayNoRightParenthesis()
        {
            var x = new Json();
            var (match, remaining) = x.Match("true,null,false,1234.7,\"radu\"]");
            Assert.IsFalse(match.Success);
            Assert.AreEqual("true,null,false,1234.7,\"radu\"]", remaining);
        }

        [TestMethod]
        public void ValueTestArrayWhiteSpace()
        {
            var x = new Json();
            var (match, remaining) = x.Match("\\t[true\\n,\\nnull    ,false,1234.7,\"radu\"]");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestArrayEmpty()
        {
            var x = new Json();
            var (match, remaining) = x.Match("[]");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestObjectEmpty()
        {
            var x = new Json();
            var (match, remaining) = x.Match("{}");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestObject()
        {
            var x = new Json();
            var (match, remaining) = x.Match("{ \"radu\" : true \\n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestObjectWrong()
        {
            var x = new Json();
            var text = "{ \"radu\" :: true \\n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }";
            var (match, remaining) = x.Match(text);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(text, remaining);
        }

        [TestMethod]
        public void ValueTestObjectLong()
        {
            var x = new Json();
            var (match, remaining) = x.Match("{ \"radu\" : { \"radu\" : true \\n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] } \\n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void Test()
        {
            var x = new Json();
            var text = "{ \"radu\" : 24, \"ionescu\" : [true, false, \\n 245.4e-20], \"adu\" : [2] }";
            var (match, remaining) = x.Match(text);
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }
    }
}
