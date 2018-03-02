using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class List : Pattern
    {
        readonly private Pattern Letters;
        readonly private Pattern Separator;
        readonly private Many list;

        public List(Pattern Characters, Pattern Separator)
        {
            this.Letters = Characters;
            this.Separator = Separator;
            list = new Many(new Sequance(new Pattern[] { Letters, Separator }));
        }

        public (Match, string) Match(string input)
        { 
            var (match, remaining) = list.Match(input);
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
