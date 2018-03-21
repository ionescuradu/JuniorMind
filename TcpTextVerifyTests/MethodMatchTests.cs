using TcpHtmlVerify;
using Xunit;

namespace TcpTextVerifyTests
{
    public class MethodMatchTests
    {
        [Fact]
        public void IsASuccessMatch()
        {
            var methodMatch = new MethodMatch(Method.GET);
            Assert.True(methodMatch.Success);
        }

        [Fact]
        public void HasHttpMethodProperty()
        {
            var methodMatch = new MethodMatch(Method.GET);
            Assert.Equal(Method.GET, methodMatch.Method);
        }
    }
}
