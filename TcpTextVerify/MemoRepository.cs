using System.IO;
using System.Text;

namespace TcpHtmlVerify
{
    public class MemoRepository : IRepository
    { 
        public Stream Repository(string input)
        {
            return new MemoryStream(Encoding.ASCII.GetBytes(input));
        }
    }
}
