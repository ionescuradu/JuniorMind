using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTests;

namespace TcpHtmlVerifyTests
{
    public class HtmlVerify : Pattern
    {
        private Sequance htmlOrder;
        public HtmlVerify()
        {
            var methods = new Choice(
                new Text("OPTIONS"),
                new Text("GET"),
                new Text("HEAD"),
                new Text("POST"),
                new Text("PUT"), 
                new Text("DELETE"),
                new Text("TRACE"),
                new Text("CONNECT"));
            var anyChar = new Many(
                new Choice(
                    new Range('!', '9'),
                    new Range(';', '~')));
            htmlOrder = new Sequance(
                methods,
                new Character(' '),
                anyChar,
                new Character(' '),
                new Text("HTTP/1.1"),
                new Many(
                    new Sequance(
                        new Text("\n"),
                        new Many(new Character(' ')),
                        anyChar,
                        new Many(new Character(' ')),
                        new Character(':'),
                        new Many(new Character(' ')),
                        anyChar
                        )
                    ),
                new Text("\r\n\r\n")
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = htmlOrder.Match(input);
            return (match, remaining);
        }
    }
}
