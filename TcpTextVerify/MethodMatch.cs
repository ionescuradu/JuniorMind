using JsonTests;
using TcpHtmlVerify;

namespace TcpTextVerifyTests
{
    public class MethodMatch: Match
    {
        private readonly Method method;

        public MethodMatch(Method method)
        {
            this.method = method;
        }

        public bool Success => true;

        public Method Method => method;
    }
}