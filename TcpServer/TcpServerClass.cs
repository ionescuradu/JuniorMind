using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using TcpHtmlVerify;
using CreateHttpServer;

namespace TcpServerClass
{
    public class TcpServer
    {
        public static void Main()
        {
            FileRepository repository = new FileRepository(@"C:\Users\Radu\Documents\GitHub\JuniorMind\aaa");
            Int32 port = 5000;
            IPAddress localAddress = IPAddress.Parse("127.0.0.1");
            var httpServer = new HttpServer(localAddress, port, repository);
            httpServer.Start();
        }
    }
}
