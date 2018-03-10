using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class List : Pattern
    {
        readonly private Pattern characters;
        readonly private Pattern separator;
        readonly private Many list;

        public List(Pattern characters, Pattern separator)
        {
            this.characters = characters;
            this.separator = separator;
            list = new Many(new Sequance(new Pattern[] { characters, separator }));
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = list.Match(input);
            var aux = remaining;
            (match, remaining) = characters.Match(remaining);
            if (aux != input)
            {
                if (!match.Success)
                {
                    return (new NoMatch(input, input.Length - remaining.Length), input);
                }
                return (new SuccessMatch(input.Substring(input.Length - remaining.Length)), remaining);
            }
            return (new SuccessMatch(input), remaining);
        }
    }
}
