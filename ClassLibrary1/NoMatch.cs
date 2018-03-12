using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class NoMatch : Match
    {
        private readonly string givenString;
        private readonly int errorPosition;
        private readonly NoMatch noMatch;
        
        public NoMatch(string givenString, int errorPosition = 0,NoMatch noMatch = null)
        {
            this.givenString = givenString;
            this.errorPosition = errorPosition;
            this.noMatch = noMatch;
        }

        public int Merge(NoMatch error)
        {
            if (ErrorPosition < error.ErrorPosition)
            {
                return error.ErrorPosition;
            }
            return ErrorPosition;
        }

        public int NoMatchPosition(string input)
        {
            var aux = noMatch;
            while (aux.noMatch != null)
            {
                aux = aux.noMatch;
            }
            return input.Length - aux.givenString.Length;
        }

        public bool Success => false;

        public int ErrorPosition => errorPosition;
    }
}
