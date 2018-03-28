using Xunit;
namespace TcpHtmlVerify
{
    public class ResponseTests
    {
        [Fact]
        public void HttpFormat()
        {
            var x = new Response();
            Assert.Equal("HTTP/1.1", x.Protocol);
        }

        [Fact]
        public void ResponseCode()
        {
            var x = new Response();
            Assert.Equal("200 OK", x.ResponseCode);
        }
    }
}
