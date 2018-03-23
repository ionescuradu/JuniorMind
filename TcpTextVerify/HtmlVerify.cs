using System.Collections.Generic;
using JsonTests;
using TcpHtmlVerify;

namespace TcpHtmlVerifyTests
{
    public class HtmlVerify : Pattern
    {
        private Sequance htmlOrder;
        public HtmlVerify()
        {
            var methods = new MethodPattern();
            var uriPath = new UriParsing();
            var anyChar = new Many(
                new Choice(
                    new Range('!', '9'),
                    new Range(';', '~')));
            var elementList = new Sequance(
                    new Many(new Character(' ')),
                        anyChar,
                        new Many(new Character(' ')),
                        new Character(':'),
                        new Many(new Character(' ')),
                        anyChar);
            htmlOrder = new Sequance(
                methods,
                new Character(' '),
                uriPath,
                new Character(' '),
                new Text("HTTP/1.1"),
                new Optional(
                    new Sequance(
                        new Text("\n"),
                        new List(elementList, new Text("\n")))),
                new Choice(
                    new Text("\r\n\r\n"),
                    new Text("\n\n")));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = htmlOrder.Match(input);
            return (match, remaining);
        }
    }
}
