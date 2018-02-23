using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Optional : Pattern
    {
        private Pattern pattern;

        public Optional(Pattern pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            return (new SuccessMatch(input[input[input.Length - remaining.Length]].ToString()), remaining);
        }
    }
}
