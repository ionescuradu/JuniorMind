using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Scientific : Pattern
    {
        readonly Sequance scientific;

        public Scientific()
        {
            scientific = new Sequance(
                new Any("Ee"),
                new Optional(new Any("+-")),
                new OneOrMore(new Range('0', '9'))
                );
        }
        public (Match, string) Match(string input)
        {
            var (match, remaining) = scientific.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
