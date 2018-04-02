using System.IO;

namespace TcpHtmlVerify
{
    public class IndexRepository : IRepository
    {
        private string rootPath;

        public IndexRepository(string rootPath)
        {
            this.rootPath = rootPath;
        }

        public Stream LoadFile(string filePath)
        {
            var indexHtml = "index.html";
            var path = Path.Combine(rootPath, indexHtml.Trim("/".ToCharArray()));
            return new FileStream(path, FileMode.Open, FileAccess.Read);
        }
    }
}
