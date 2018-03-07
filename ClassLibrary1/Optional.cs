using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Optional : Pattern
    {
        readonly private Pattern pattern;

        public Optional(Pattern pattern)
        {
            this.pattern = new Many(pattern, 0, 1);
        }

        public (Match, string) Match(string input)
        {
            return pattern.Match(input);
        }
    }
}
