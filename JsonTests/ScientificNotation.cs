using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class ScientificNotation : Pattern
    {
        public (Match, string) Match(string input)
        {
            var scientific = new Sequance(
                new Any("Ee"),
                new Optional(new Any("+-")),
                new Many(new Range('0', '9'))
                );
            var (match, remaining) = scientific.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
