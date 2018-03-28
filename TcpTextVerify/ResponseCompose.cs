using System.Collections.Generic;

namespace TcpHtmlVerify
{
    public class Response
    {
        private StatusCode statusCode;
        private string response;
        private Dictionary<string, string> fields;

        public Response(StatusCode statusCode)
        {
            this.statusCode = statusCode;
            fields = new Dictionary<string, string>();
        }

        public string GetBytes()
        {
            response = $"HTTP/1.1 {StatusCodeText()}\r\n";
            AddingFieldsText();
            return response;//Encoding.ASCII.GetBytes(response);
        }

        private void AddingFieldsText()
        {
            foreach (var item in fields)
            {
                response += item.Key + ": " + item.Value + "\r\n";
            }
            response += "\r\n";
        }

        private string StatusCodeText()
        {
            if (statusCode == StatusCode.NotFound)
            {
                return "404 Not Found";
            }
            return "200 OK";
        }

        public void AddField(string name, string value)
        {
            fields.Add(name, value);
        }
    }
}
