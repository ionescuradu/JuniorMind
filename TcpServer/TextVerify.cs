using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTests;

namespace TcpServerClass
{
    public class TextVerify
    {
        private Sequance textOrder;

        public TextVerify()
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
            var anyChar = new Choice(
                new Range((char)ushort.MinValue, (char)46),
                new Range((char)47, (char)57),
                new Range((char)59, (char)ushort.MaxValue)
                );
            textOrder = new Sequance(
                methods,
                new Character('/'),
                new Many(anyChar),
                new Character('/'),
                new Many(anyChar),
                new Character('/'),
                new Text("1.1")
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = textOrder.Match(input);
            return (match, remaining);
        }
    }
}
