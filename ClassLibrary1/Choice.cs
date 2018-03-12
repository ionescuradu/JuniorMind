using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Choice : Pattern
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
            var noMatch = new NoMatch("");
            var maxNoMatch = new NoMatch("");
            var max = 0;
            foreach (var item in choices)
            { 
                var (match, remaining) = item.Match(input);
                if (match.Success)
                {
                    return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), input.Substring(input.Length - remaining.Length));
                }
                if (max < noMatch.Merge((NoMatch)match))
                {
                    max = noMatch.Merge((NoMatch)match);
                    maxNoMatch = match as NoMatch;
                }
                noMatch = (NoMatch)match;
            }
            return (new NoMatch(input, max, maxNoMatch), input);
        }

        public void Add(Pattern newChoice)
        {
            choices.Add(newChoice);
        }
    }
}
