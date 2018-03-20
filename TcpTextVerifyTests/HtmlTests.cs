using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace TcpHtmlVerifyTests
{
    public class HtmlTests
    {
        [Fact]
        public void HtmlVerify1()
        {
            var input = "PUT /somewhere/fun HTTP/1.1";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void HtmlVerify2()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\nHost: origin.example.com";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void HtmlVerify3()
        {
            var input = "PUT /somewhere/fun HTTP/1.1" +
                "\nHost: origin.example.com" +
                "\nContent-Type: video/h264" +
                "\nContent-Length: 1234567890987" +
                "\nExpect: 100-continue";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }
    }
}
