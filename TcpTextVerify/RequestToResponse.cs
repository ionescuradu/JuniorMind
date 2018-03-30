using System.IO;

namespace TcpHtmlVerify
{
    public class RequestToResponse
    {
        private readonly Request request;
        private readonly Response response;

        public RequestToResponse(Request request, Stream stream)
        {
            this.request = request;
            response = new Response(StatusCode.OK);
            foreach (var item in request.Fields)
            {
                response.AddField(item.Key, item.Value);
            }
            response.AddPayload(((MemoryStream)stream).ToArray());
        }

        public byte[] ToByte() => response.GetBytes();
    }
}
