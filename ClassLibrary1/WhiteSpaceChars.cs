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
            return whiteSpaceChars.Match(input);
        }
    }
}
