using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            server.Stop();
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(localAddress, port);
                server.Start();
                AcceptClient();
            }
            catch (SocketException e)
            {
                OnScreen($"SocketException: {e}\r\n");
            }
        }

        private async void AcceptClient()
        {
            try
            {
                OnScreen("\r\nWaiting for a connection...\r\n");
                if (stopLoop)
                {
                    OnScreen("Stopping the server");
                    return;
                }
                var client = await server.AcceptTcpClientAsync();
                AcceptClient();
                await ServeClient(client);
            }
            catch (ObjectDisposedException)
            {
                OnScreen($"Server stopped");
            }
            //return;
            //    .ContinueWith(t =>
            //    {
            //        if (!stopLoop)
            //            AcceptClient();
            //        else
            //            OnScreen("Stopping the server");
            //        ServeClient(t.Result).Wait();
            //    }, TaskContinuationOptions.OnlyOnRanToCompletion);
            //acceptTask
            //    .ContinueWith(t =>
            //        OnScreen("Error on task completion"), TaskContinuationOptions.OnlyOnFaulted);
            //return acceptTask;
        }

        private Task ServeClient(TcpClient tcpClient)
        {
        return ReadGivenStream(tcpClient.GetStream())
            .ContinueWith(headersTask =>
            {
                var result = headersTask.Result;
                OnScreen($"Headers received {result.Item1}\r\n");
                WriteGivenStream(result.Item1, result.Item2).Wait();
                tcpClient.Close();
            });
        }

        private Task WriteGivenStream(string headers, Stream stream)
        {
            return ProcessRequest(stream, headers, repository);
        }

        private Task ProcessRequest(
            Stream stream,
            string headers,
            IRepository repository)
        {
            var x = new HtmlVerify();
            var (match, remaining) = x.Match(headers);
            var controller = new StaticController(repository);
            var request = match as Request;

            //OnScreen($"Path received: {request.Uri}\r\n");

            var response = controller.Response(request);
            response.AddField("Connection", "close");
            OnScreen($"Responce headers {response.Headers}\r\n");

            var message = response.GetBytes();
            return stream
                .WriteAsync(message, 0, message.Length)
                .ContinueWith(t => OnScreen($"Finished writing in stream\r\n"));
        }

        private Task<(string, Stream)> ReadGivenStream(Stream stream)
        {
            var bytes = new Byte[1024];
            try
            {
                OnScreen("Connected!\r\n");
                return stream.ReadAsync(bytes, 0, bytes.Length)
                  .ContinueWith(t =>
                  {
                      OnScreen($"Read {t.Result} bytes\r\n");
                      return t.Result;
                  })
                  .ContinueWith(t => (Encoding.UTF8.GetString(bytes, 0, t.Result), stream));
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        private string DataFromStream(byte[] bytes)
        {
            int i;
            var data = "";
            while ((i = bytes.Length) != 0)
            {
                data += Encoding.UTF8.GetString(bytes, 0, i);
                if (data.IndexOf("\r\n\r\n") != -1)
                {
                    OnScreen($"Request received:{data}\r\n");
                    break;
                }
            }
            return data;
        }

    }
}
