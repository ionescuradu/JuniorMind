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
            Assert.AreEqual("s0", remaining);
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
            Assert.AreEqual(",null,false,1234.7,\"radu\"]", remaining);
        }

        [TestMethod]
        public void ValueTestArrayWhiteSpace()
        {
            var x = new Json();
            var (match, remaining) = x.Match("\t[true\n,\nnull    ,false,1234.7,\"radu\"]");
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
            var (match, remaining) = x.Match("{ \"radu\" : true \n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }
        [TestMethod]
        public void ValueTestObjectWrong()
        {
            var x = new Json();
            var text = "{ \"radu\" :: true \n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }";
            var (match, remaining) = x.Match(text);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(text, remaining);
        }

        [TestMethod]
        public void ValueTestObjectLong()
        {
            var x = new Json();
            var (match, remaining) = x.Match("{ \"radu\" : { \"radu\" : true \n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] } \n, " +
                "\"ionescu\" : [true,null,false,1234.7,\"radu\"] }");
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void Test()
        {
            var x = new Json();
            var text = "{\n\t\"glossary\": {\n\t\"title\": \"example glossary\",\n\t\t\t\"GlossDiv\": {\n\"title\": \"S\",\n\t\t\t\"GlossList\": {\n\"GlossEntry\": {\n\"ID\": \"SGML\",\n\t\"SortAs\": \"SGML\",\n\t\"GlossTerm\": \"Standard Generalized Markup Language\",\n\t\"Acronym\": \"SGML\",\n\t\"Abbrev\": \"ISO 8879:1986\",\n\t\"GlossDef\": {\n\"para\": \"A meta-markup language, used to create markup languages such as DocBook.\",\n\t\"GlossSeeAlso\": [\"GML\", \"XML\"]\n},\n\t\t\t\t\t\t\"GlossSee\": \"markup\"\n     }\n    }\n    }\n   }\n}";
            var (match, remaining) = x.Match(text);
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void Test2()
        {
            var x = new Json();
            var text = "{\n\r\"glossary\": {}}";
            var (match, remaining) = x.Match(text);
            Assert.IsTrue(match.Success);
            Assert.AreEqual("", remaining);
        }

        [TestMethod]
        public void ValueTestObjectWrong2()
        {
            var x = new Json();
            var text = "[2,]";
            var (match, remaining) = x.Match(text);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(text, remaining);
        }

        [TestMethod]
        public void ValueTestObjectWrong3()
        {
            var x = new Json();
            var text = "{\"2\": 2,}";
            var (match, remaining) = x.Match(text);
            Assert.IsFalse(match.Success);
            Assert.AreEqual(text, remaining);
        }

        [TestMethod]
        public void ValueTestObjectIndexRemaining1()
        {
            var x = new Json();
            var text = "truf";
            var (match, remaining) = x.Match(text);
            Assert.AreEqual(3, (match as NoMatch).NoMatchPosition(text));
        }

        [TestMethod]
        public void ValueTestObjectIndexRemaining2()
        {
            var x = new Json();
            var text = "{\"2\": 2,}";
            var (match, remaining) = x.Match(text);
            Assert.AreEqual(7, (match as NoMatch).NoMatchPosition(text));
        }

        [TestMethod]
        public void ValueTestObjectIndexRemaining3()
        {
            var x = new Json();
            var text = "[2,]";
            var (match, remaining) = x.Match(text);
            Assert.AreEqual(2, (match as NoMatch).NoMatchPosition(text));
        }

        [TestMethod]
        public void ValueTestObjectIndexRemaining4()
        {
            var x = new Json();
            var text = "{\"2\":2,,\"2\": 5}";
            var (match, remaining) = x.Match(text);
            Assert.AreEqual(6, (match as NoMatch).NoMatchPosition(text));
        }
    }
}
