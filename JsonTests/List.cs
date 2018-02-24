using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class List : Pattern
    {
        private Pattern Letters;
        private Pattern Separator;
        private Pattern[] patterns;
        private Many aux;

        public List(Pattern Characters, Pattern Separator)
        {
            this.Letters = Characters;
            this.Separator = Separator;
            aux = new Many(new Sequance(new Pattern[2] { Letters, Separator }));
        }

        public (Match, string) Match(string input)
        { 
            var (match, remaining) = aux.Match(input);
            if (match.Success && remaining == "")
            {
                return (new SuccessMatch(input), "");
            }
            (match, remaining) = Letters.Match(remaining);
            if (match.Success && remaining == "")
            {
                return (new SuccessMatch(input), "");
            }
            return (new NoMatch(input, input[0]), input);

        }
    }
}
