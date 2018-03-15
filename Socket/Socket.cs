using System;
using System.Net;
using System.Net.Sockets;

namespace Socket
{
    public class Socket12
    {
        private SocketServer server;

        public static void Main()
        {
            var server = new SocketServer(
                AddressFamily.InterNetwork, 
                SocketType.Stream,
                ProtocolType.IPv4
                );
            IPHostEntry iPHost = Dns.GetHostEntry("");
            IPAddress iPAddress = iPHost.AddressList[0];
            var ipEndPoint = new IPEndPoint(iPAddress, 4510);
        }
    }
}
