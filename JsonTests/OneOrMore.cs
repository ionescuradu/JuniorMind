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
            throw new NotImplementedException();
        }
    }
}
