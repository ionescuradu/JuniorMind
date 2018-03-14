using System;
using System.Net.Sockets;

namespace Socket
{
    class SocketServer
    {
        private readonly AddressFamily addressFamily;
        private readonly SocketType socketType;
        private readonly ProtocolType protocolType;

        public SocketServer(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
        {
            this.addressFamily = AddressFamily.InterNetwork;
            this.socketType = SocketType.Stream;
            this.protocolType = ProtocolType.Tcp;
        }
    }
}
