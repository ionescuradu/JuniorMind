using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Sequance :Pattern
    {
        readonly private Pattern[] pattern;

        public Sequance( params Pattern[] pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var aux = input;
            if (input == "")
            {
                return (new NoText(input), input);
            }   
            for (int i = 0; i < pattern.Length; i++)
            {
                var (match, remaining) = pattern[i].Match(aux);
                if (!match.Success)
                {
                    return (new NoMatch(aux, input.Length - remaining.Length), input);
                }
                aux = remaining;
            }
            return (new SuccessMatch(input.Substring(0, input.Length - aux.Length)), aux);
        }
    }
}
