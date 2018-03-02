using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class String : Pattern
    {
        readonly private Choice specialChars;

        public String()
        {           
        }

        public (Match, string) Match(string input)
        {
            if (input == "")
            {
                return (new SuccessMatch(input), "");
            }
        }
    }
}
