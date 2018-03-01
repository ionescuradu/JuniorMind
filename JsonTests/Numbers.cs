using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Numbers : Pattern
    {
        readonly private Choice number;

        public Numbers()
        {
            number = new Choice(
                new Sequance(new Integer(), new Fractional(), new Scientific()),
                new Sequance(new Integer(), new Fractional()),
                new Sequance(new Integer())
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
