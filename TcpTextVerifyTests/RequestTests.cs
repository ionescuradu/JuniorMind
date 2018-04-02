using TcpHtmlVerifyTests;
using Xunit;

namespace TcpHtmlVerify
{
    public class RequestTests
    {

        [Fact]
        public void IsASuccessMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n" +
                "Host: origin.example.com\r\n" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True((match as Request).Success);
        }

        [Fact]
        public void IsMethodMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n" +
                "Host: origin.example.com\r\n" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.Equal(Method.PUT, (match as Request).Method);
        }

        [Fact]
        public void IsUriMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.Equal(new UriMatch("/somewhere/fun").Uri, (match as Request).Uri);
        }

        [Fact]
        public void IsFieldsMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1" +
                "\r\nHost: origin.example.com" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.Equal("origin.example.com", (match as Request).Fields["Host"]);
        }
    }
}
