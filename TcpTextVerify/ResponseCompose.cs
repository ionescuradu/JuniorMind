﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TcpHtmlVerify
{
    public class Response
    {
        private StatusCode statusCode;
        private Dictionary<string, string> fields;
        private byte[] payload;

        public Response(StatusCode statusCode)
        {
            this.statusCode = statusCode;
            fields = new Dictionary<string, string>();
        }

        public byte[] GetBytes()
        {
            var headers = $"HTTP/1.1 {StatusCodeText()}\r\n";
            headers += AddingFieldsText();
            var responce = Encoding.ASCII.GetBytes(headers);
            if (payload != null)
            {
                return responce.Concat(payload).ToArray();
            }
            return responce;
        }

        private string AddingFieldsText()
        {
            var response = "";
            foreach (var item in fields)
            {
                response += item.Key + ": " + item.Value + "\r\n";
            }
            response += "\r\n";
            return response;
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
            fields[name] = value;
        }

        public void AddPayload(byte[] body)
        {
            AddField("Content-Length", body.Length.ToString());
            payload = body;
        }
    }
}
