using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTests
{
    public class MaxIndexInString
    {
        public MaxIndexInString(string remaining)
        {
            if (Max < remaining.Length )
            {
                Max = remaining.Length;
            }
        }

        public int Max { get; internal set; }
    }
}
