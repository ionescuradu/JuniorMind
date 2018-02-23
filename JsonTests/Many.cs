using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Many : Pattern
    {
        private Pattern pattern;

        public Many(Pattern pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var aux = input;
            var (match, remaining) = pattern.Match(input);
            while (match.Success)
            {
                aux = remaining;
                (match, remaining) = pattern.Match(aux);
            }
            if (aux == input)
            {
                return (new SuccessMatch("Nothing Found"), aux);
            }
            return (new SuccessMatch(input.Substring(0, input.Length - aux.Length)), aux);
        }
    }
}
