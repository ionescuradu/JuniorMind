using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TcpHtmlVerify;
using TcpHtmlVerifyTests;

namespace CreateHttpServer
{
    public class HttpServer
    {
        private TcpListener server;
        private readonly IPAddress localAddress;
        private readonly Int32 port;
        private readonly FileRepository repository;
        private bool stopLoop;
        public delegate void ConsoleOutput(string output);
        public event ConsoleOutput OnScreen;
        
        public HttpServer(
            IPAddress localAddress,
            Int32 port,
            FileRepository repository
            )
        {
            stopLoop = false;
            server = new TcpListener(localAddress, port);
            this.localAddress = localAddress;
            this.port = port;
            this.repository = repository;
        }
        
        public void Start()
        {
            var th = new Thread(StartServer);
            th.Start();
        }

        public void Stop()
        {
            stopLoop = true;
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(localAddress, port);
                server.Start();
                while (!stopLoop)
                {
                    OnScreen("Waiting for a connection...");
                    var client = server.AcceptTcpClient();
                    OnScreen("Connected!\r\n");
                    var stream = client.GetStream();
                    var data = ReceiveHeaders(stream);
                    if (!string.IsNullOrEmpty(data))
                        ProcessRequest(stream, data, repository);
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                OnScreen($"SocketException: {e}\r\n");
            }
            finally
            {
                server.Stop();
                OnScreen("Server shut down\r\n");
            }
            OnScreen("\nHit enter to continue...\r\n");
        }

        private static string ReceiveHeaders(Stream stream)
        {
            var bytes = new Byte[1024];
            try
            {
                string data = "";
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
            catch (SocketException e)
            {
                Console.WriteLine(e);
                return null;
            }
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
    }
}
