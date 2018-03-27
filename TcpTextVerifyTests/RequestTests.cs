using System.Collections.Generic;
using JsonTests;
using TcpHtmlVerifyTests;
using Xunit;

namespace TcpHtmlVerify
{
    public class RequestTests
    {

        [Fact]
        public void IsASuccessMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var request = new Request(match);
            Assert.True(request.Success);
        }

        [Fact]
        public void IsMethodMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var request = new Request(match);
            Assert.Equal(Method.PUT, request.Method);
        }

        [Fact]
        public void IsUriMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var request = new Request(match);
            Assert.Equal(new UriMatch("/somewhere/fun").Uri, request.Uri);
        }

        [Fact]
        public void IsFieldsMatch()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\nHost: origin.example.com" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            var request = new Request(match);
            Assert.Equal("origin.example.com", request.Fields["Host"]);
        }
    }
}
