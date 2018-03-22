using Xunit;

namespace TcpHtmlVerify
{
    public class UriParsingTests
    {
        [Fact]
        public void UriParsingTestCorrectUrl()
        {
            var uriText = "/en-us/library/system.uri(v=vs.110).aspx";
            var pattern = new UriParsing();
            var (match, remaining) = pattern.Match(uriText);
            Assert.True(match.Success);
        }
    }
}
