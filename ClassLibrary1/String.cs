using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class String : Pattern
    {
        readonly private Sequance givenString;

        public String()
        {
            var jsonChar = new Choice(
                new SpecialChars(),
                new Range((char)32, (char)33),
                new Range((char)35, (char)91), 
                new Range((char)93, (char)ushort.MaxValue)
            );

            givenString = new Sequance(
                new Character('\"'),
                new Many(jsonChar),
                new Character('\"')
                );
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = givenString.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
