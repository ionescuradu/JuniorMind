using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Any : Pattern
    {
        private string givenText;

        public Any(string givenText)
        {
            this.givenText = givenText;
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new NoText(givenText), input);
            }
            for (int i = 0; i < givenText.Length; i++)
            {
                if (input[0] == givenText[i])
                {
                    return (new SuccessMatch(input[0].ToString()), input.Substring(1));
                }
            }
            return (new NoMatch(input[0].ToString(), input[0]), input);
        }
    }
}
