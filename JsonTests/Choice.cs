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
                    return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), input.Substring(input.Length - remaining.Length));
                }
            }
            return (new NoMatch("",input[0]), input);
        }
    }
}
