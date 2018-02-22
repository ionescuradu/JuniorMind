using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Choice : Pattern
    {
        string givenString;

        public Choice(string givenString)
        {
            this.givenString = givenString;
        }

        public (Match, string) Match(string input)
        {
            for (int i = 0; i < givenString.Length; i++)
            {
                if (input[0] == givenString[i])
                {
                    return (new SuccessMatch(input[0].ToString()), input.Substring(1));
                }
            }
            return (new SuccessMatch(""), input);

        }
    }
}
