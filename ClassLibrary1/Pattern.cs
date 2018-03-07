using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public interface Pattern
    {
        (Match, string) Match(string input);
    }
}
