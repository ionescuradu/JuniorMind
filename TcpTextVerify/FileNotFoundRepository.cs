using System.IO;

namespace TcpHtmlVerify
{
    public class FileNotFoundRepository : IRepository
    {
        public bool IsDirectory(string path)
        {
            return false;
        }

        public Stream LoadFile(string filePath)
        {
            throw new FileNotFoundException();
        }

    }
}
