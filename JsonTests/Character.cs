using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Character : Pattern
    {
        char givenChar;

        public Character(char givenChar)
        {
            this.givenChar = givenChar;
        }

        public (Match, string) Match(string input)
        {
            if (input.Equals(""))
            {
                return (new NoText(), input);
            }
            if (input[0] == givenChar)
            {
                return (new SuccessMatch("x"), input.Substring(1));
            }
            return (new NoMatch ("x"),  input);
        }

    }
}
