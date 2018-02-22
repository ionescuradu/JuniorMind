using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class NoMatch : Match
    {
        private string message;
        private string text = " found instead of ";

        public NoMatch(string stringNotFound, char firstFound)
        {
            message = firstFound + text + stringNotFound; 
        }

        public bool Success
        { get
            {
                return false;
            }
        }
    }
}
