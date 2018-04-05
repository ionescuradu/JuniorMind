using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TcpHtmlVerify;
using TcpHtmlVerifyTests;


namespace TcpServerClass
{
    class TcpServerClass
    {
        public static void Main()
        {
            TcpListener server = null;
            FileRepository repository = new FileRepository(@"C:\Users\Radu\Documents\GitHub\JuniorMind\aaa");

            try
            {
                Int32 port = 5000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);
                server.Start();
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    var client = server.AcceptTcpClient();

                    Console.WriteLine("Connected!");
                    var stream = client.GetStream();
                    var data = ReceiveHeaders(stream);
                    if (!string.IsNullOrEmpty(data))
                        ProcessRequest(stream, data, repository);
                    client.Close();
                    Console.WriteLine("Connected!");
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

        private static void ProcessRequest(
            NetworkStream stream,
            string headers,
            IRepository repository)
        {
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(headers);
            var controller = new StaticController(repository);
            var request = match as Request;

            Console.WriteLine($"Request received {request.Uri}");

            var response = controller.Response(request);
            var message = response.GetBytes();
            stream.Write(message, 0, message.Length);
        }

        private static string ReceiveHeaders(Stream stream)
        {
            var bytes = new Byte[1024];
            try
            {
                string data = "";
                int i = 0;
                //var reader = new StreamReader(stream);
                //while (reader.Read() != -1)
                //{
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data += Encoding.UTF8.GetString(bytes, 0, i);
                    if (data.IndexOf("\r\n\r\n") != -1)
                    {
                        break;
                    }
                }
                //}
                return data;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
