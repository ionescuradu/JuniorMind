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
            var path = Path.Combine(rootPath, filePath.Trim("/".ToCharArray()));
            return new FileStream(path, FileMode.Open, FileAccess.Read);
        }
    }
}
