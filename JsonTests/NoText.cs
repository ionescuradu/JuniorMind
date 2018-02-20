using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class NoText : Match
    {
        private bool success;

        public NoText()
        {
            success = false;
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
