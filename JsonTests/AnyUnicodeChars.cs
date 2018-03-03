using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class AnyUnicodeChars : Pattern
    {
        readonly private Choice anyUnicodeChar;
        readonly private Choice exceptionUnicode;
        readonly private Any hexazecimal;

        public AnyUnicodeChars()
        {
            hexazecimal = new Any("0123456789ABCDEFabcdef");

            exceptionUnicode = new Choice(
                new Sequance(new Character((char)92),
                             new Character('u'),
                             new Character('0'),
                             new Character('0'),
                             new Any("01"),
                             hexazecimal
                             ),
                new Sequance(new Character((char)92),
                             new Character('u'),
                             new Character('0'),
                             new Character('0'),
                             new Character('2'),
                             new Character('2')
                             ),
                new Sequance(new Character((char)92),
                             new Character('u'),
                             new Character('0'),
                             new Character('0'),
                             new Character('5'),
                             new Any("Cc")
                             )
                );

            anyUnicodeChar = new Choice(
                new SpecialChars(),
                new Range((char)32, (char)33),
                new Range((char)35, (char)91),
                new Range((char)93, (char)255)
                );
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), input);
            }
            var (match, remaining) = exceptionUnicode.Match(input);
            if (match.Success)
            {
                return (new NoMatch(input, input[0]), input);
            }
            (match, remaining) = anyUnicodeChar.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
            }
            return (new NoMatch(input, input[0]), input);
        }
    }
}
