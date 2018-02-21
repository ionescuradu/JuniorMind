using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Range : Pattern
    {
        private char startChar;
        private char endChar;

        public Range(char startChar, char endChar)
        {
            this.startChar = startChar;
            this.endChar = endChar;
        }

        public (Match, string) Match(string input)
        {
            if (input.Equals(""))
            {
                return (new NoText(input[0].ToString()), input);
            }
            if (input[0] >= startChar && input[0] <=endChar)
            {
                return (new SuccessMatch(input[0].ToString()), input.Substring(1));
            }
            return (new NoMatch(input[0].ToString(), input[0]), input);
        }
    }
}
