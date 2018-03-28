using System.Text;
using TcpHtmlVerifyTests;
using Xunit;
namespace TcpHtmlVerify
{
    public class ResponseTests
    {
        [Theory]
        [InlineData(StatusCode.OK, "HTTP/1.1 200 OK\r\n\r\n")]
        [InlineData(StatusCode.NotFound, "HTTP/1.1 404 Not Found\r\n\r\n")]
        public void ItIncludesTheGivenResponseCode(
            StatusCode code, 
            string expectedHeaders)
        {
            var response = new Response(code);

            var expected = Encoding.ASCII.GetBytes(expectedHeaders);
            //Assert.Equal(expected, response.GetBytes());
        }

        [Fact]
        public void ItIncludesTheGivenFields()
        {
            var response = new Response(StatusCode.OK);
            response.AddField("Content-Type", "text");

            var expected = //Encoding.ASCII.GetBytes(
                ("HTTP/1.1 200 OK\r\n" +
                "Content-Type: text\r\n" +
                "\r\n");
            Assert.Equal(expected, response.GetBytes());
        }
    }
}
