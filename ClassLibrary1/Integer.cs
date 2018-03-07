using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Integer : Pattern
    {
        readonly private Choice integer;
        
        public Integer()
        {
            integer = new Choice(
                new Sequance(new Optional(new Character('-')),
                             new Character('0')),
                new Sequance(new Optional(new Character('-')),
                             new Range('1', '9'),
                             new Many(new Range('0', '9'))));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = integer.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
