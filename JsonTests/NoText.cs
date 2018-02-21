using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class NoText : Match
    {
        private string message = "no more text while looking for ";

        public NoText(string stringToFind)
        {
            stringToFind = message + stringToFind;
        }
        public bool Success
        {
            get
            {
                return false;
            }
        }
    }
}
