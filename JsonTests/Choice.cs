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
            var found = false;
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
                    found = true;
                    stringMatched += aux[0];
                    aux = remaining;
                    break;
                }
            }
            if (found)
            {
                return (new SuccessMatch(stringMatched), aux);
            }
            return (new NoMatch("nothing",input[0]), aux);

        }
    }
}
