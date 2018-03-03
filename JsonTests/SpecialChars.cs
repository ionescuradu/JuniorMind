using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class SpecialChars : Pattern
    {
        readonly private Optional pattern;
        readonly private Any hexazecimal;

        public SpecialChars()
        {
            hexazecimal = new Any("0123456789ABCDEFabcdef");
            pattern = new Optional(
                new Choice(
                    new Sequance(new Character((char)92),
                                 new Character('u'),
                                 hexazecimal,
                                 hexazecimal,
                                 hexazecimal,
                                 hexazecimal
                                 ),
                    new Text("\""),
                    new Text("\\"),
                    new Text("\\/"),
                    new Text("\b"),
                    new Text("\f"),
                    new Text("\n"),
                    new Text("\r"),
                    new Text("\t")
                    )
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
        }
    }
}
