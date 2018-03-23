using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class Many : Pattern
    {
        readonly private Pattern pattern;
        private int minimum;
        private int maxim;


        public Many(Pattern pattern, int minimum = 0, int maxim = 0)
        {
            this.pattern = pattern;
            this.minimum = minimum;
            this.maxim = maxim;
        }

        public (Match, string) Match(string input)
        {
            var index = 0;
            var (match, remaining) = pattern.Match(input);
            while (match.Success)
            {
                index++;
                (match, remaining) = pattern.Match(remaining);
            }
            if (minimum <= index && (maxim == 0 || index <= maxim))
            {
                string foundText = input.Substring(0, input.Length - remaining.Length);
                return (new SuccessMatch(foundText), remaining);
            }
            return (new NoMatch(input, input.Length - remaining.Length, match as NoMatch), input);
        }
    }
}
