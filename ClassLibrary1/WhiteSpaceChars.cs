using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class WhiteSpaceChars : Pattern
    {
        readonly private Many whiteSpaceChars;

        public WhiteSpaceChars()
        {
            whiteSpaceChars = new Many(
                new Choice(
                    new Text(" "),
                    new Text("\t"),
                    new Text("\n"),
                    new Text("\r")
                    ));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = new Text("\n").Match(input);
            if (match.Success)
            {
                new RowsAndColoms(1,0);
            }
            return whiteSpaceChars.Match(input);
        }
    }
}
