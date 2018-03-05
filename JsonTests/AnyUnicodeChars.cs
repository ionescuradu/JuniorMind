using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class AnyUnicodeChars : Pattern
    {
        readonly private Choice anyUnicodeChar;

        public AnyUnicodeChars()
        {
            anyUnicodeChar = new Choice(
                new SpecialChars(),
                new Range((char)ushort.MinValue, (char)ushort.MaxValue));
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), input);
            }
            var (match, remaining) = anyUnicodeChar.Match(input);
            if (match.Success)
            {
                string foundString = input.Substring(0, input.Length - remaining.Length);
                return (new SuccessMatch(foundString), remaining);
            }
            return (new NoMatch(input, input[0]), input);
        }
    }
}
