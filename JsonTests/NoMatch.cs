using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class NoMatch : Match
    {
        private string stringNotFound;
        private new bool Success { get; set; }

        public NoMatch(string stringNotFound)
        {
            Success = false;
            this.stringNotFound = stringNotFound;
        }
    }
}
