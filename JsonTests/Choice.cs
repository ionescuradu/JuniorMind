using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Choice : Pattern
    {
        readonly private List<Pattern> choices;

        public Choice(params Pattern[] choices)
        {
            this.choices = choices.ToList();
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new NoText(input), input);
            }
            foreach (var item in choices)
            { 
                var (match, remaining) = item.Match(input);
                if (match.Success)
                {
                    return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), input.Substring(input.Length - remaining.Length));
                }
            }
            return (new NoMatch("",input[0]), input);
        }

        internal void Add(Pattern newChoice)
        {
            choices.Add(newChoice);
        }
    }
}
