using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Fractional : Pattern
    {
        public (Match, string) Match(string input)
        {
            var fractional = new Sequance(
                new Character('.'), 
                new OneOrMore(new Range('0', '9'))
                );
            var (match, remaining) = fractional.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
