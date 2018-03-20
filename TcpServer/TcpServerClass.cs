using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
                    string html = "";
                    NetworkStream stream = client.GetStream();
                    int i = 0;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data += Encoding.UTF8.GetString(bytes, 0, i);
                        //byte[] msg = Encoding.UTF8.GetBytes(data);
                        //stream.Write(msg, 0, msg.Length);
                        //Console.WriteLine("Sent: {0}", data);
                        if (data.Length > 4)
                        {
                            if ((data.Substring(data.Length - 4) == "\r\n\r\n"))
                            {
                                Console.WriteLine("Received: {0}", data);
                                var (match, remaining) = new HtmlVerify().Match(data);
                                if (match.Success)
                                {
                                    html = "<h1>The header is correct</h1>";
                                }
                                else
                                {
                                    html = "<h1>The header is incorrect</h1>";
                                }
                                break;
                            }
                        }
                    }
                    var msg = Encoding.UTF8.GetBytes(html);
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Sent: {0}", html);
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
    