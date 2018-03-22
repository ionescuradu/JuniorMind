using Xunit;

namespace TcpHtmlVerify
{
    public class UriParsingTests
    {
        [Fact]
        public void UriParsingTestCorrectUri()
        {
            var uriText = "en-us/library/syem.uri(v=vs.110).aspx";
            var pattern = new UriParsing();
            var (match, remaining) = pattern.Match(uriText);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void UriParsingTestIncorrectUri()
        {
            var uriText = "/en-us/library//system.uri(v=vs.110).aspx HTTP/1.1";
            var pattern = new UriParsing();
            var (match, remaining) = pattern.Match(uriText);
            Assert.True(match.Success);
            Assert.Equal(" HTTP/1.1", remaining);

        }
    }
}
