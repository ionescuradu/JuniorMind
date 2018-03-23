using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class List : Pattern
    {
        readonly private Pattern pattern;

        public List(Pattern characters, Pattern separator)
        {
            pattern = new Sequance(
                characters, 
                new Many(new Sequance(separator, characters))
                );
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
            var (match, remaining) = pattern.Match(input);
            if (match.Success)
            {
                return (match, remaining);
            }
            return (new SuccessMatch(input), input);

        }
    }
}
