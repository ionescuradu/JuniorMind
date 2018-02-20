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
                for (int i = 1; i < input.Length; i++)
                {
                    auxString += input[i];
                }
                return (new Match { Success = true}, auxString);
            }
            if (input[0] != givenChar)
            {
                return (new Match { Success = false}, input);
            }
            else return (new Match { Success = false}, auxString);
        }

    }
}
