using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Number : Pattern
    {
        readonly private Sequance number;

        public Number()
        {
            number = new Sequance(
                new Integer(), 
                new Optional(new Fractional()),
                new Optional(new Scientific())
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = number.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
