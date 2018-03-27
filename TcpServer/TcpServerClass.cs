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
            Match aux = null;
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
                    string html = "";
                    NetworkStream stream = client.GetStream();
                    int i = 0;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data += Encoding.UTF8.GetString(bytes, 0, i);
                        if (data.IndexOf("\r\n\r\n") != 0)
                        {
                            break;
                        }
                    }
                    var x = new HtmlVerify();
                    var (match, remaining) = x.Match(data);
                    aux = match;
                    if (match.Success)
                    {
                        html = "<h1>The header is correct</h1>";
                    }
                    else
                    {
                        html = "<h1>The header is incorrect</h1>";
                    }
                    Console.WriteLine("Sent: {0}\nRequested path was: {1}", html, (aux as Request).Uri);
                    var message = html + "\n" + "\nRequested path was: " + (aux as Request).Uri;
                    var msg = Encoding.UTF8.GetBytes(message);
                    stream.Write(msg, 0, msg.Length);
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
    }
}
    