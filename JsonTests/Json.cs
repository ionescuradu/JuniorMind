﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Json : Pattern
    {
        readonly private Choice givenValue;
        readonly private Sequance givenArray;

        public Json()
        {
            givenValue = new Choice(
                new String(),
                new Number(),
                new Text("true"),
                new Text("false"),
                new Text("null"));
            givenArray = new Sequance(
                new Character('['),
                new List(givenValue, new Character(',')),
                new Character(']'));
        }

        public (Match, string) Match(string input)
        {
            givenValue.add(givenArray);
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
