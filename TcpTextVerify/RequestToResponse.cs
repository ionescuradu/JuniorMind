using System.Collections.Generic;

namespace TcpHtmlVerify
{
    public class RequestToResponse
    {
        private readonly Request request;
        private readonly Response response;

        public RequestToResponse(Request request)
        {
            this.request = request;
            response = new Response(StatusCode.OK);
        }

        public byte[] ToByte() => response.GetBytes();
    }
}
