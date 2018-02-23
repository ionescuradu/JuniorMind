using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Choice : Pattern
    {
        Pattern[] choices;

        public Choice(params Pattern[] choices)
        {
            this.choices = choices;
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new NoText(input), input);
            }
            for (int i = 0; i < choices.Length; i++)
            {
                var (match, remaining) = choices[i].Match(input);
                if (match.Success)
                {
                    return (new SuccessMatch(input[0].ToString()), input.Substring(1));
                }
            }
            return (new NoMatch("nothing",input[0]), input);
        }
    }
}
