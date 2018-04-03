
using System.IO;

namespace TcpHtmlVerify
{
    public interface IRepository
    {
        Stream LoadFile(string filePath);
        bool IsDirectory(string path);    
    }
}
