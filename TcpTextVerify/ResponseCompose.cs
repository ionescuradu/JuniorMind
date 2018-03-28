using System;
using System.Collections.Generic;
using System.Text;

namespace TcpHtmlVerify
{
    public class Response
    {
        private StatusCode statusCode;
        private string response;
        private Dictionary<string, string> dictionary;

        public Response(StatusCode statusCode)
        {
            this.statusCode = statusCode;
            dictionary = new Dictionary<string, string>();
        }

        public string GetBytes()
        {
            response = $"HTTP/1.1 {StatusCodeText()}\r\n";
            foreach (var item in dictionary)
            {
                response += item.Key + ": " + item.Value + "\r\n";
            }
            response += "\r\n";
            return response;//Encoding.ASCII.GetBytes(response);
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
            dictionary.Add(name, value);
        }
    }
}
