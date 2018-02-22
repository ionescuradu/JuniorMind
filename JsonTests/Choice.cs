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
            var aux = input;
            var stringMatched= "";
            if (input == "")
            {
                return (new NoText(input), input);
            }
            for (int i = 0; i < choices.Length; i++)
            {
                var (match, remaining) = choices[i].Match(aux);
                if (match.Success)
                {
                    stringMatched += aux[0];
                    aux = remaining;
                }
            }
            return (new SuccessMatch(stringMatched), aux);

        }
    }
}
