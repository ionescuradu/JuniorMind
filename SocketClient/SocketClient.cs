using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    class SocketClient
    {
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress iPAddress = iPHostEntry.AddressList[0];
                IPEndPoint endPoint = new IPEndPoint(iPAddress, 4500);

                Socket client = new Socket(
                iPAddress.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp
                );

                try
                {
                    client.Connect(endPoint);

                    byte[] msg = Encoding.ASCII.GetBytes("This is my first test<EOF>");
                    int bytesSent = client.Send(msg);
                    int bytesReceived = client.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesReceived));
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();

                }
                catch (ArgumentNullException argNull)
                {
                    Console.WriteLine("ArgumentNullException : {0}", argNull.ToString());
                    Console.ReadKey();
                }
                catch (SocketException socktExcept)
                {
                    Console.WriteLine("SocketException : {0}", socktExcept.ToString());
                    Console.ReadKey();
                }
                catch (ObjectDisposedException objExcep)
                {
                    Console.WriteLine("SocketException : {0}", objExcep.ToString());
                    Console.ReadKey();
                }
                catch (InvalidOperationException invalidOp)
                {
                    Console.WriteLine("SocketException : {0}", invalidOp.ToString());
                    Console.ReadKey();
                }


            }
            catch (Exception another)
            {
                Console.WriteLine(another.ToString());
            }
        }

        public static void Main(string[] args)
        {
            StartClient();
        }
    }

}
