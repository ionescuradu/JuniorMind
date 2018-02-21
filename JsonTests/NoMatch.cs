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
        private string text = " found instead of ";

        public NoMatch(string stringNotFound, char firstFound)
        {
            success = false;
            stringNotFound = firstFound + text + stringNotFound; 
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
