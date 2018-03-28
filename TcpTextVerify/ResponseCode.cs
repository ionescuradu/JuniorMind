using System.Collections.Generic;

namespace TcpHtmlVerify
{
    class ResponseCode
    {
        public ResponseCode()
        {
            var dictionary = new Dictionary<int, string>
            {
                { 100, "Continue" },
                { 101, "Switching Protocols" },
                { 200, "OK" },
                { 201, "Created" },
                { 202, "Accepted" },
                { 203, "Non-Authoritative Information" },
                { 204, "No Content" },
                { 205, "Reset Content" },
                { 206, "Partial Content" },
                { 300, "Multiple Choices" },
                { 301, "Moved Permanently" },
                { 302, "Found" },
                { 303, "See Other" },
                { 304, "Not Modified" },
                { 400, "Bad Request" },
                { 401, "Unauthorized" },
                { 404, "Not Found" },
                { 500, "Internal Server Error" },
                { 502, "Bad Gateway" },
                { 505, "HTTP Version Not Supported" }
            };
        }
    }
}
