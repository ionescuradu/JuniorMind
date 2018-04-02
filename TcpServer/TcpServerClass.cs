using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using JsonTests;
using TcpHtmlVerify;
using TcpHtmlVerifyTests;


namespace TcpServerClass
{
    class TcpServerClass
    {
        public static void Main()
        {
            TcpListener server = null;
            try
            {
                Int32 port = 5000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);
                server.Start();
                Byte[] bytes = new Byte[1024];
                string data = null;
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    data = null;
                    NetworkStream stream = client.GetStream();
                    data = StringGivenByClient(bytes, data, stream);
                    var x = new HtmlVerify();
                    var (match, remaining) = x.Match(data);
                    var controller = new StaticController(new FileRepository(@"C:\Users\Radu\Documents\GitHub\JuniorMind\aaa"));
                    var response = controller.Response(match as Request);
                    var message = response.GetBytes();
                    stream.Write(message, 0, message.Length);
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        private static string StringGivenByClient(byte[] bytes, string data, NetworkStream stream)
        {
            int i = 0;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data += Encoding.UTF8.GetString(bytes, 0, i);
                if (data.IndexOf("\r\n\r\n") != -1)
                {
                    break;
                }
            }

            return data;
        }
    }
}
    