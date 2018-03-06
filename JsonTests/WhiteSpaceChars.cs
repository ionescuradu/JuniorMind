using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class WhiteSpaceChars : Pattern
    {
        readonly private Many whiteSpaceChars;

        public WhiteSpaceChars()
        {
            whiteSpaceChars = new Many(
                new Choice(
                    new Text(" "),
                    new Text("\\t"),
                    new Text("\\n"),
                    new Text("\\r")
                    ));
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = whiteSpaceChars.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining: remaining);
            }
            return (new NoMatch(input, input[0]), remaining);
        }
    }
}
