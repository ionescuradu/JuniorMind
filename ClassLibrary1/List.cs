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
            list = new Many(new Sequance(separator, characters));
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = characters.Match(input);
            if (match.Success)
            {
                (match, remaining) = list.Match(remaining);
                return (match, remaining);
            }
            return (new SuccessMatch(input), input);

        }
    }
}
