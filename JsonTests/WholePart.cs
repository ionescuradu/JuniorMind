using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class WholePart
    {
        public string CheckWholePart(string givenString)
        {
            var wholePart1 = new Sequance(new Optional(new Character('-')),new Character('0'));
            var wholePart2 = new Sequance(new Optional(new Character('-')), new Many(new Range('1', '9')));
            var (match, remaining) = wholePart1.Match(givenString);
            if (match.Success)
            {
                return remaining;
            }
            (match, remaining) = wholePart2.Match(givenString);
            if (match.Success)
            {
                return remaining;
            }
            return givenString;
        }
    }
}
