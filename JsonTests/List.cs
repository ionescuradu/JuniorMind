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
            return (new NoMatch("", ' '), input);
        }
    }
}
