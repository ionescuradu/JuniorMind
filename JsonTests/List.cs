using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class List : Pattern
    {
        private Pattern Characters;
        private Pattern Separator;

        public List(Pattern Characters, Pattern Separator)
        {
            this.Characters = Characters;
            this.Separator = Separator;
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(""), "");
            }
            var (match, remaining) = Characters.Match(input);
            if (match.Success && remaining == "")
            {
                return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), "");
            }
            return (new NoMatch("", ' '), "");
        }
    }
}
