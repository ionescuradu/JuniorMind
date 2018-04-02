using System;
using System.IO;

namespace TcpHtmlVerify
{
    public class StaticController
    { 
        private readonly IRepository repository;

        public StaticController(IRepository repository)
        {
            this.repository = repository;
        }

        public Response Response(Request request)
        {
            var path = request.Uri.ToString();
            var stream = repository.LoadFile(path);
            var payload = LoadStreamInMemory(stream);
            var response = new Response(StatusCode.OK);
            response.AddPayload(payload);
            return response;
        }

        private Byte[] LoadStreamInMemory(Stream stream)
        {
            var auxStream = new MemoryStream();
            stream.CopyTo(auxStream);
            return auxStream.ToArray();
        }
    }
}
