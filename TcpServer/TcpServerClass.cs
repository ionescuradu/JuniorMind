using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using JsonTests;

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
                    int i;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.UTF8.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);
                        string html;
                        var text = new TextVerify();
                        var (match, remaining) = text.Match(data);
                        if (match.Success && remaining == "")
                        {
                            html = "<h1>Header is OK</h1>";
                        }
                        else
                        {
                        html = "<h1>Header is not OK</h1>";
                        }
                        byte[] msg = Encoding.UTF8.GetBytes(html);
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", html);
                    }
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
    