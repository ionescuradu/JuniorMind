using TcpHtmlVerify;
using Xunit;


namespace TcpHtmlVerifyTests
{
    public class HtmlTests
    {
        [Fact]
        public void HtmlVerify1()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void HtmlVerify2()
        {
            var input = "PUT /somewhere/fun HTTP/1.1\nHost: origin.example.com" +
                "\r\n\r\n";
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
                "\nExpect: 100-continue" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("1234567890987", (match as Request).Fields["Content-Length"] );
        }

        [Fact]
        public void HtmlVerify4()
        {
            var input = "GET / HTTP/1.1" +
                "\nHost: hotnews.ro" +
                "\nConnection: keep-alive" +
                "\nUpgrade-Insecure-Requests: 1" +
                "\nUser-Agent: Mozilla/5.0(WindowsNT10.0;Win64;x64)AppleWebKit/537.36(KHTML,likeGecko)Chrome/64.0.3282.186Safari/537.36" +
                "\nAccept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8" +
                "\nAccept-Encoding: gzip,deflate" +
                "\nAccept-Language: ro-RO,ro;q=0.9,en-US;q=0.8,en;q=0.7" +
                "\nCookie: hn_most=1;_ga=GA1.2.1636163787.1520927974;hn_weather=5;acceptedCookies=accepted;cX_G=cx%3A2jenrpp7rft3025pathw1bpevk%3A3gbaihqyd1nwr;_gid=GA1.2.241502951.1521456482;cX_S=jey3wn8pm11i7nxy;evid_0046=d3c62b5b-dd2a-4426-bac7-ed31b75f6085;JSESSIONID=9449D285F93F06FBFCD879054FEAC3A6;cX_P=jepd8w98rd6dqb2z" +
                "\r\n\r\n";
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(input);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }
    }
}
