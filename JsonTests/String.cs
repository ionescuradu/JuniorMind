using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class String : Pattern
    {
        readonly private OneOrMore givenString;

        public String()
        {
            givenString = new OneOrMore(
                new Choice(
                    new AnyUnicodeChars(),
                    new SpecialChars()
                )
            );
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = givenString.Match(input);
            if (remaining == input)
            {
                return (new NoMatch(input, input[0]), input);
            }
            if (remaining != "")
            {
                return (new NoMatch(input, input[0]), remaining);
            }
            return (new SuccessMatch(input), remaining);
        }
    }
}
