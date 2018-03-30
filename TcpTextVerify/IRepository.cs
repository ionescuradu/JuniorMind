
using System.IO;

namespace TcpHtmlVerify
{
    public interface IRepository
    {
        Stream Repository(string input);
            
    }
}
