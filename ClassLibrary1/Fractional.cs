﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Fractional : Pattern
    {
        readonly private Sequance fractional;

        public Fractional()
        {
            fractional = new Sequance(
                new Character('.'),
                new OneOrMore(new Range('0', '9'))
                );
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = fractional.Match(input);
            if (match.Success)
            {
                return (new SuccessMatch(input), remaining);
            }
            return (new NoMatch(input, input.Length - remaining.Length), remaining);
        }
    }
}
