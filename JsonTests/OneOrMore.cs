using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class OneOrMore : Pattern
    {
        private Pattern pattern;

        public OneOrMore(Pattern pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            while (match.Success)
            {
                (match, remaining) = pattern.Match(remaining);
            }
            if (remaining == input)
            {
                return (new NoMatch(input,input[0]), input);
            }
            return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
        }
    }
}
