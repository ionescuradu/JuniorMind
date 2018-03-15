using System;
using System.Net;
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
            this.addressFamily = addressFamily;
            this.socketType = socketType;
            this.protocolType = protocolType;
        }

        public void Bind(IPEndPoint ipEndPoint)
        {
            throw new NotImplementedException();
        }
    }
}
