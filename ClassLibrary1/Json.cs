using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Json : Pattern
    {
        readonly private Choice jsonValue;

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
                new WhiteSpaceChars(),
                new String(),
                new WhiteSpaceChars(),
                new Character(':'),
                new WhiteSpaceChars(),
                jsonValue,
                new WhiteSpaceChars()
                );

            var jsonArray = new Sequance(
                new WhiteSpaceChars(),
                new Character('['),
                new WhiteSpaceChars(),
                (new List(jsonValue, separatorWhiteSpace)),
                new WhiteSpaceChars(),
                new Character(']'),
                new WhiteSpaceChars()
            );
            
             var jsonObject = new Sequance(
                new WhiteSpaceChars(),
                new Character('{'),
                new WhiteSpaceChars(),
                new List(objectSequance, separatorWhiteSpace),
                new Character('}'),
                new WhiteSpaceChars()
                );

            jsonValue.Add(jsonArray);
            jsonValue.Add(jsonObject);
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = jsonValue.Match(input);
            return Output(input, match, remaining);
        }

        private static (Match, string) Output(string input, Match match, string remaining)
        {
            if (match.Success && remaining == "")
            {
                int foundString = input.Length - remaining.Length;
                return (new SuccessMatch(input.Substring(0, foundString)), remaining);
            }
            return (new NoMatch(input), remaining);
        }
    }
}
