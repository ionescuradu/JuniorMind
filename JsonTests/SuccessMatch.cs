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
        private bool success;

        public SuccessMatch(string foundString)
        {
            success = true;
            this.foundString = foundString;
        }

        public bool Success
        {
            get
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
