using System.Collections.Generic;
using JsonTests;

namespace TcpHtmlVerify
{
    public class Request : Match
    {
        private readonly List<Match> list;

        public Request(List<Match> list)
        {
            this.list = list;
        }

        public bool Success => true;
    }
}
