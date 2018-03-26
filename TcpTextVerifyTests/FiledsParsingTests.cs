using System.Collections.Generic;
using Xunit;
namespace TcpHtmlVerify
{
    public class FieldsParsingTests
    {
        [Fact]
        public void FieldsParsing2Line()
        {
            // GIVEN
            var fieldText = "Server: nginx\n" +
                "Content-Length: 112";
            var pattern = new FieldsParsing();
            // WHEN
            var (match, remaining) = pattern.Match(fieldText);
            // THEN
            var fields = ((FieldsMatch)match).Dictionary;
            Assert.Equal("nginx", fields["Server"]);
            Assert.Equal("112", fields["Content-Length"]);
        }

        [Fact]
        public void FieldsParsing1Line()
        {
            var fieldText = "Server: nginx/1.13.9";
            var pattern = new FieldsParsing();
            var (match, remaining) = pattern.Match(fieldText);
            Dictionary<string, string> dictionaryToCompare = new Dictionary<string, string>();
            dictionaryToCompare.Add("Server", "nginx/1.13.9");
            Assert.Equal(dictionaryToCompare, ((FieldsMatch)match).Dictionary);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void FieldsParsingManyLines()
        {
            var fieldText = "Server: nginx/1.13.9\n" +
                "Content-Length: 3643\n" +
                "Connection: keep-alive\n" +
                "ETag: W/\"3643-1521708631000\"";
            var pattern = new FieldsParsing();
            var (match, remaining) = pattern.Match(fieldText);
            var fields = ((FieldsMatch)match).Dictionary;
            Assert.Equal("nginx/1.13.9", fields["Server"]);
            Assert.Equal("3643", fields["Content-Length"]);
            Assert.Equal("keep-alive", fields["Connection"]);
            Assert.Equal("W/\"3643-1521708631000\"", fields["ETag"]);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void FieldsParsingRemainingText()
        {
            var fieldText = "Server: nginx/1.13.9\n" +
                "Content-Length: 3643\r\n\r\n";
            var pattern = new FieldsParsing();
            var (match, remaining) = pattern.Match(fieldText);
            Assert.True(match.Success);
            Assert.Equal("\r\n\r\n", remaining);
        }
    }
}
