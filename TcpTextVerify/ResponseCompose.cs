using System.Collections.Generic;

namespace TcpHtmlVerify
{
    public class Response
    {
        public Response()
        {

        }

        public string Protocol => "HTTP/1.1";

        public string ResponseCode => "200 OK";
    }
}
