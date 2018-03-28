using System;
using System.Collections.Generic;

namespace TcpHtmlVerify
{
    public class Response
    {
        private StatusCode statusCode;
        private string response;
        private Dictionary<string, string> fields;
        private string payload;

        public Response(StatusCode statusCode)
        {
            this.statusCode = statusCode;
            fields = new Dictionary<string, string>();
        }

        public string GetBytes()
        {
            response = $"HTTP/1.1 {StatusCodeText()}\r\n";
            AddingFieldsText();
            response += payload;
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
            if (!fields.ContainsKey(name))
            {
                fields.Add(name, value);
            }
        }

        public void AddPayload(string textGiven)
        {
            fields.Add("Content-Length", textGiven.Length.ToString());
            payload = textGiven;
        }
    }
}
