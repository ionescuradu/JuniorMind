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
        private bool success;

        public NoMatch(string stringNotFound)
        {
            success = false;
            this.stringNotFound = stringNotFound;
        }

        public bool Success
        { get
            {
                return success;
            }
            set
            {
                success = value;
            }
        }
    }
}
