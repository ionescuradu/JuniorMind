using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpClientClass
{
    class TcpClientClass
    {
        private string server;
        private int port;

        public TcpClientClass(string server, int port)
        {
            this.server = server;
            this.port = port;
        }

        public static void Connect(String server, String message)
        {
            try
            {
                int port = 5000;
                TcpClient client = new TcpClient(server, port);
                Byte[] data = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", message);
                data = new Byte[1024];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
        public static void Main(string[] args)
        {
            Connect("127.0.0.1", @"PUT/somewhere/fun HTTP/1.1");
        }
    }
}
