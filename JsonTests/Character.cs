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
            var auxString = "";
            if (input[0] == givenChar)
            {
                auxString = input.Substring(1, input.Length - 1);
                return (new Match { Success = true}, auxString);
            }
            return (new Match { Success = false }, input);
        }

    }
}
