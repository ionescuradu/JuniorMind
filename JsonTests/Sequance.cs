using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Sequance :Pattern
    {
        Pattern[] pattern;

        public Sequance( params Pattern[] pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!pattern[i].Match(input).Item1.Equals(true))
                {
                    return (new NoMatch(input, input[i]), input);
                }
                input = pattern[i].Match(input).Item2;
            }
            return (new SuccessMatch(
        }
    }
}
