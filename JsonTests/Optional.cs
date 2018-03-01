using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Optional : Pattern
    {
        readonly private Pattern pattern;

        public Optional(Pattern pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
            }
            return (new SuccessMatch(""), input);
        }
    }
}
