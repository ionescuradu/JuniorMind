using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class String : Pattern
    {
        readonly private Sequance givenString;

        public String()
        {
            var jsonChar = new Choice(
                new SpecialChars(),
                new Range('0', (char)ushort.MaxValue)
            );

            givenString = new Sequance(
                new Character('\"'),
                new Many(jsonChar),
                new Character('\"')
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = givenString.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
