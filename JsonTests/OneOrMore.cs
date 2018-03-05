using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class OneOrMore : Pattern
    {
        readonly private Many aux;

        public OneOrMore(Pattern pattern)
        {
            aux = new Many(pattern, 1);
        }

        public (Match, string) Match(string input)
        {
            return aux.Match(input);
        }
    }
}
