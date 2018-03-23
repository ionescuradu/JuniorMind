using JsonTests;
using Xunit;
namespace TcpHtmlVerify
{
    public class FieldsParsingTests
    {
        [Fact]
        public void FieldsParsing2Line()
        {
            var fieldText = "Server: nginx/1.13.9\n" +
                "Content-Length: 3643";
            var pattern = new FieldsParsing();
            var (match, remaining) = pattern.Match(fieldText);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void FieldsParsing1Line()
        {
            var fieldText = "Server: nginx/1.13.9";
            var pattern = new FieldsParsing();
            var (match, remaining) = pattern.Match(fieldText);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }
    }
}
