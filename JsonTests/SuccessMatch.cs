using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class SuccessMatch : Match
    {
        private string v;

        public SuccessMatch(string v)
        {
            this.v = v;
        }
    }
}
