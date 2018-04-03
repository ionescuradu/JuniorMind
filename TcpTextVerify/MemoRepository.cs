using System.IO;
using System.Text;

namespace TcpHtmlVerify
{
    public class MemoRepository : IRepository
    {
        private readonly string input;

        public MemoRepository(string input)
        {
            this.input = input;
        }

        public bool IsDirectory(string path)
        {
            return false;
        }

        public Stream LoadFile(string filePath)
        {
            return new MemoryStream(Encoding.ASCII.GetBytes(input));
        }
    }
}
