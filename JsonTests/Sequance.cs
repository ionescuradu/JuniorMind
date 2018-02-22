using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Sequance :Pattern
    {
        Pattern[] pattern;

        public Sequance( params Pattern[] pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var aux = input;
            for (int i = 0; i < pattern.Length; i++)
            {
                var (match, remaining) = pattern[i].Match(aux);
                if (!match.Equals(true))
                {
                    return (new NoMatch(aux, aux[i]), aux);
                }
                aux = remaining;
            }
            return (new SuccessMatch(input.Substring(0, input.Length - aux.Length)), aux);
        }
    }
}
