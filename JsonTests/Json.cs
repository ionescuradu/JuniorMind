using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Json : Pattern
    {
        readonly private Choice givenValue;
        readonly private Sequance array;

        public Json()
        {
            givenValue = new Choice(
                new String(),
                new Number(),
                new Text("true"),
                new Text("false"), 
                new Text("null"));
            Sequance separatorWhiteSpace = new Sequance(
                new WhiteSpaceChars(),
                new Character(','), 
                new WhiteSpaceChars()
            );
            array = new Sequance(
                new WhiteSpaceChars(),
                new Character('['),
                new WhiteSpaceChars(),
                new List(givenValue, separatorWhiteSpace),
                new WhiteSpaceChars(),
                new Character(']'),
                new WhiteSpaceChars());
            givenValue.Add(array);
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
            var (match, remaining) = givenValue.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
