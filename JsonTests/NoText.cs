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
        private string text = "no more text while looking for ";

        public NoText(string stringToFind)
        {
            stringToFind = text + stringToFind;
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
