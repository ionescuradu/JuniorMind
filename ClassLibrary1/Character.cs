using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Character : Pattern
    {
        readonly char givenChar;

        public Character(char givenChar)
        {
            this.givenChar = givenChar;
        }

        public (Match, string) Match(string input)
        {
            if (input.Equals(""))
            {
                return (new NoText(givenChar.ToString()), input);
            }
            if (input[0] == givenChar)
            {
                return (new SuccessMatch(givenChar.ToString()), input.Substring(1));
            }
            return (new NoMatch (givenChar.ToString(), input[0]),  input);
        }

    }
}
