using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class SpecialChars : Pattern
    {
        readonly private Choice pattern;
        readonly private Choice hexazecimal;

        public SpecialChars()
        {
            hexazecimal = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'));
            pattern = new Choice(
                new Sequance(new Text("\\u"),
                             hexazecimal,
                             hexazecimal,
                             hexazecimal,
                             hexazecimal
                             ),
                new Text("\""),
                new Text("\\"),
                new Text("\\/"),
                new Text("\\b"),
                new Text("\\f"),
                new Text("\\n"),
                new Text("\\r"),
                new Text("\\t")
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
            }
            return (new NoMatch(input, input[0]), remaining);
        }
    }
}
