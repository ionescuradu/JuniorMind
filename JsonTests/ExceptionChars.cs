﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class ExceptionChars : Pattern
    {
        readonly private Choice exceptionChars;
        readonly private Any hexazecimal;

        public ExceptionChars()
        {
            hexazecimal = new Any("0123456789ABCDEFabcdef");
            exceptionChars = new Choice(
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
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new NoText(input), input);
            }
            var (match, remaining) = exceptionChars.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input.Substring(0, input.Length - remaining.Length)), remaining);
            }
            return (new NoMatch(input, input[0]), input);
        }
    }
}
