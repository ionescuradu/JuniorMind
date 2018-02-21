using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class SuccessMatch : Match
    {
        private string foundString;

        public SuccessMatch(string foundString)
        {
            this.foundString = foundString;
        }

        public bool Success
        {
            get
            {
                return true;
            }
        }
    }
}
