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

        public SpecialChars()
        {
            pattern = new Optional(
                new Choice(
                    new Text("\""),
                    new Text("\\"),
                    new Text("\/"),
                    new Text("\b"),
                    new Text("\f"),
                    new Text("\n"),
                    new Text("\r"),
                    new Text("\t"),
                    new Text("\u0041"),
                    new Text("\u0042"),
                    new Text("\u0043"),
                    new Text("\u0044")
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
