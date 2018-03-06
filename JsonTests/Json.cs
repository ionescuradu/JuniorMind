using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Json : Pattern
    {
        readonly private Choice jsonValue;
        readonly private Sequance jsonArray;
        readonly private Sequance jsonObject;

        public Json()
        {
            jsonValue = new Choice(
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

            Sequance objectSequance = new Sequance(
                new String(),
                new Character(':'),
                jsonValue);

            jsonArray = new Sequance(
                new WhiteSpaceChars(),
                new Character('['),
                new WhiteSpaceChars(),
                new List(jsonValue, separatorWhiteSpace),
                new WhiteSpaceChars(),
                new Character(']'),
                new WhiteSpaceChars()
            );
            
            jsonObject = new Sequance(
                new WhiteSpaceChars(),
                new Character('{'),
                new WhiteSpaceChars(),
                new List(objectSequance, separatorWhiteSpace),
                new WhiteSpaceChars(),
                new Character('{'),
                new WhiteSpaceChars()
                );

            jsonValue.Add(jsonArray);
            jsonValue.Add(jsonObject);
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = jsonArray.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }

        public (Match, string) MatchValue(string input)
        {
            var (match, remaining) = jsonValue.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }

        public (Match, string) MatchArray(string input)
        {
            var (match, remaining) = jsonArray.Match(input);
            if (match.Success)
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input, ' '), remaining);
        }
    }
}
