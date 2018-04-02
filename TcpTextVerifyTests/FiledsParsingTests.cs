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
            var fieldText = "Server: nginx\r\n" +
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
            //GIVEN
            var fieldText = "Server: nginx/1.13.9";
            var pattern = new FieldsParsing();
            //WHEN
            var (match, remaining) = pattern.Match(fieldText);
            //THEN
            Dictionary<string, string> dictionaryToCompare = new Dictionary<string, string>();
            dictionaryToCompare.Add("Server", "nginx/1.13.9");
            Assert.Equal(dictionaryToCompare, ((FieldsMatch)match).Dictionary);
            Assert.True(match.Success);
            Assert.Equal("", remaining);
        }

        [Fact]
        public void FieldsParsingManyLines()
        {
            //GIVEN
            var fieldText = "Server: nginx/1.13.9\r\n" +
                "Content-Length: 3643\r\n" +
                "Connection: keep-alive\r\n" +
                "ETag: W/\"3643-1521708631000\"";
            var pattern = new FieldsParsing();

            //WHEN
            var (match, remaining) = pattern.Match(fieldText);

            //THEN
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
            //GIVEN
            var fieldText = "Server: nginx/1.13.9\r\n" +
                "Content-Length: 3643\r\n\r\n";
            var pattern = new FieldsParsing();

            //WHEN
            var (match, remaining) = pattern.Match(fieldText);

            //THEN
            Assert.True(match.Success);
            Assert.Equal("\r\n\r\n", remaining);
        }

        [Fact]
        public void FieldsParsingChromeTest()
        {
            //GIVEN
            var fieldText = "Host: localhost: 5000\r\n" +
                            "Connection: keep-alive\r\n" +
                            "Cache-Control: max-age = 0\r\n" +
                            "Upgrade-Insecure-Requests: 1\r\n" +
                            "User-Agent: Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 65.0.3325.181 Safari / 537.36\r\n" +
                            "Accept: text / html,application / xhtml + xml,application / xml; q = 0.9,image / webp,image / apng,*/*;q=0.8\r\n" +
                            "Accept-Encoding: gzip, deflate, br\r\n" +
                            "Accept-Language: ro-RO,ro;q=0.9,en-US;q=0.8,en;q=0.7\r\n" +
                            "\r\n\r\n";
            var pattern = new FieldsParsing();

            //WHEN
            var (match, remaining) = pattern.Match(fieldText);

            //THEN
            var fields = ((FieldsMatch)match).Dictionary;
            Assert.Equal("localhost: 5000", fields["Host"]);
            Assert.Equal("keep-alive", fields["Connection"]);
            Assert.Equal("max-age = 0", fields["Cache-Control"]);
            Assert.Equal("1", fields["Upgrade-Insecure-Requests"]);
            Assert.Equal("Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 65.0.3325.181 Safari / 537.36", fields["User-Agent"]);
            Assert.Equal("text / html,application / xhtml + xml,application / xml; q = 0.9,image / webp,image / apng,*/*;q=0.8", fields["Accept"]);
            Assert.Equal("gzip, deflate, br", fields["Accept-Encoding"]);
            Assert.Equal("ro-RO,ro;q=0.9,en-US;q=0.8,en;q=0.7", fields["Accept-Language"]);
            Assert.True(match.Success);
        }
    }
}
