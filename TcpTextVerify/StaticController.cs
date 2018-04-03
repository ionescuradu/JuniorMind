using System;
using System.IO;

namespace TcpHtmlVerify
{
    public class StaticController
    {
        private const string indexHtml = "index.html";
        private readonly IRepository repository;

        public StaticController(IRepository repository)
        {
            this.repository = repository;
        }

        public Response Response(Request request)
        {
            var path = request.Uri.ToString();
            if (repository.IsDirectory(path))
            {
                path += indexHtml;
            }
            try
            {
                using (var stream = repository.LoadFile(path))
                {
                    var payload = LoadStreamInMemory(stream);
                    var response = new Response(StatusCode.OK);
                    response.AddPayload(payload);
                    return response;
                }
            }
            catch(FileNotFoundException)
            {
                return new Response(StatusCode.NotFound);
            }
        }

        private Byte[] LoadStreamInMemory(Stream stream)
        {
            var auxStream = new MemoryStream();
            stream.CopyTo(auxStream);
            return auxStream.ToArray();
        }
    }
}
