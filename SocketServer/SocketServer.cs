using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    public class SocketServer
    {

        public static string data;

        public static void StartServer()
        {
            byte[] bytes = new Byte[1024];
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(iPAddress, 4500);

            Socket server = new Socket(
                iPAddress.AddressFamily, 
                SocketType.Stream, 
                ProtocolType.Tcp
                );
            try
            {
                server.Bind(endPoint);
                server.Listen(1);

                while (true)
                {
                    Console.WriteLine("Waiting for a connection");
                    Socket transmition = server.Accept();
                    data = null;

                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = transmition.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Text received : {0}", data);
                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    transmition.Send(msg);
                    transmition.Shutdown(SocketShutdown.Both);
                    transmition.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }


        }



        public static void Main(string[] args)
        {
            StartServer();
        }
    }
}
