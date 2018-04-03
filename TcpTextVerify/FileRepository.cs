using System;
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

        public bool IsDirectory(string path)
        {
            return Directory.Exists(GetFullPath(path));
        }

        public Stream LoadFile(string filePath)
        {
            return new FileStream(GetFullPath(filePath), FileMode.Open, FileAccess.Read);
        }

        private string GetFullPath(string filePath)
        {
            return Path.Combine(rootPath, filePath.Trim("/".ToCharArray()));
        }
    }
}
