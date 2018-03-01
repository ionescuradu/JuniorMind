using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Numbers : Pattern
    {
        public (Match, string) Match(string input)
        {
            var number = new Choice(
                new Sequance(new Integer(), new Fractional(), new ScientificNotation()),
                new Sequance(new Integer(), new Fractional()),
                new Sequance(new Integer())
                );
            var (match, remaining) = number.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
