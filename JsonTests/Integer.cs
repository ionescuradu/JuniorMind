using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Integer : Pattern
    {
        public (Match, string) Match(string input)
        {
            var integer = new Choice(
                new Sequance(new Optional(new Character('-')),
                             new Character('0')),
                new Sequance(new Optional(new Character('-')),
                             new Many(new Range('1', '9'))));
            var (match, remaining) = integer.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
