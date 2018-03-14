using System;
using System.Net.Sockets;

namespace Socket
{
    public class Socket
    {
        private readonly AddressFamily addressFamily;
        private readonly SocketType socketType;
        private readonly ProtocolType protocolType;

        public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
        {
            this.addressFamily = AddressFamily.InterNetwork;
            this.socketType = SocketType.Stream;
            this.protocolType = ProtocolType.IPv4;
        }

        public static void Main()
        {
            
        }
    }
}
