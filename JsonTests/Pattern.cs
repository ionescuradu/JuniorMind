﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    interface Pattern
    {
        (Match, string) Match(string input);
    }
}
