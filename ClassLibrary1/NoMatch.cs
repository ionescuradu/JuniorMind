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
        
        public NoMatch(string givenString, int errorPosition = 0)
        {
            this.givenString = givenString;
            this.errorPosition = errorPosition;
        }

        public int Merge(NoMatch error)
        {
            if (ErrorPosition < error.ErrorPosition)
            {
                return error.ErrorPosition;
            }
            return ErrorPosition;
        }

        public bool Success => false;

        public int ErrorPosition => errorPosition;
    }
}
