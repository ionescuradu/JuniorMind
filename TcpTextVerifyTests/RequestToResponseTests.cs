using System.Text;
using TcpHtmlVerifyTests;
using Xunit;

namespace TcpHtmlVerify
{
    public class RequestToResponseTests
    {
        [Fact]
        public void FirstResponseNoContent()
        {
            var input = "PUT /somewhere/fun HTTP/1.1" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var response = new RequestToResponse(match as Request, new MemoRepository().Repository(""));
            string result = "HTTP/1.1 200 OK\r\n" +
                "Content-Length: 0\r\n" + 
                "\r\n";
            Assert.Equal(Encoding.ASCII.GetBytes(result), response.ToByte());
        }

        [Fact]
        public void ResponseWithContent()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\nHost: origin.example.com" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var response = new RequestToResponse(match as Request, new MemoRepository().Repository("{radu}"));
            string result = "HTTP/1.1 200 OK\r\n" +
                "Host: origin.example.com\r\n" +
                "Content-Length: 6\r\n\r\n" +
                "{radu}";
            Assert.Equal(Encoding.ASCII.GetBytes(result), response.ToByte());
        }
    }
}
