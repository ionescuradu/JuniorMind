﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class String : Pattern
    {   
        public (Match, string) Match(string input)
        {
            return (new SuccessMatch(input), "");
        }
    }
}
