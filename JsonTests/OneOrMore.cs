using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class OneOrMore : Pattern
    {
        readonly private Pattern pattern;
        readonly private Many aux;

        public OneOrMore(Pattern pattern)
        {
            this.pattern = pattern;
            aux = new Many(pattern);
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = aux.Match(input);
            if (remaining == input)
            {
                return (new NoMatch(input, input[0]), input);
            }
            return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
        }
    }
}
