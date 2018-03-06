using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Json : Pattern
    {
        readonly private Choice value;
        readonly private Sequance array;

        public Json()
        {
            value = new Choice(
                new String(),
                new Number(),
                new Text("true"),
                new Text("false"), 
                new Text("null")
            );

            Sequance separatorWhiteSpace = new Sequance(
                new WhiteSpaceChars(),
                new Character(','), 
                new WhiteSpaceChars()
            );
            array = new Sequance(
                new WhiteSpaceChars(),
                new Character('['),
                new WhiteSpaceChars(),
                new List(value, separatorWhiteSpace),
                new WhiteSpaceChars(),
                new Character(']'),
                new WhiteSpaceChars()
            );
            value.Add(array);
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = array.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }

        public (Match, string) MatchValue(string input)
        {
            var (match, remaining) = value.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
