using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class String : Pattern
    {
        readonly private Optional givenString;

        public String()
        {          
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = givenString.Match(input);
            return (new SuccessMatch(input), "");
        }
    }
}
