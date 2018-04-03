using System;
using System.Text;
using TcpHtmlVerifyTests;
using Xunit;

namespace TcpHtmlVerify
{
    public class RequestToResponseTests
    {
        [Fact]
        public void GenerateResponseForValidPath()
        {
            // Given
            var payload = "payloadBody";
            var repository = new MemoRepository(payload);
            var controller = new StaticController(repository);
            var request = new Request(
                Method.GET, 
                new Uri("/index.html", UriKind.Relative), 
                new System.Collections.Generic.Dictionary<string, string>());

            // When
            var response = controller.Response(request);

            // Then
            string result = "HTTP/1.1 200 OK\r\n" +
                    $"Content-Length: {payload.Length}\r\n\r\n" +
                    payload;
            Assert.Equal(Encoding.ASCII.GetBytes(result), response.GetBytes());
        }

        [Fact]
        public void GenerateResponseForFileNotFound()
        {
            // Given
            var repository = new FileNotFoundRepository();
            var controller = new StaticController(repository);
            var request = new Request(
                Method.GET,
                new Uri("/NoPath.txt", UriKind.Relative),
                new System.Collections.Generic.Dictionary<string, string>());

            // When
            var response = controller.Response(request);

            // Then
            string result = "HTTP/1.1 404 Not Found\r\n" +
                    $"Content-Length: 0\r\n\r\n";
            Assert.Equal(Encoding.ASCII.GetBytes(result), response.GetBytes());
        }
    }
}
