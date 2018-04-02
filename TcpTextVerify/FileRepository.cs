using System.IO;

namespace TcpHtmlVerify
{
    public class FileRepository : IRepository
    {
        private string rootPath;

        public FileRepository(string rootPath)
        {
            this.rootPath = rootPath;
        }

        public Stream LoadFile(string filePath)
        {
            var indexHtml = "index.html";
            var path = Path.Combine(rootPath, filePath.Trim("/".ToCharArray()));
            if (File.Exists(path))
            {
                return new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            path = Path.Combine(path, indexHtml.Trim("/".ToCharArray()));
            if (File.Exists(path))
            {
                return new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            return null;
        }
    }
}
