using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Value : Pattern
    {
        readonly private Choice givenValue;

        public Value()
        {
            givenValue = new Choice(
                new String(),
                new Number(),
                new Text("True"),
                new Text("False"),
                new Text("null"));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = givenValue.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
