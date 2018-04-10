using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using CreateHttpServer;
using TcpHtmlVerify;

namespace TcpApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartServer(object sender, EventArgs e)
        {
            var httpServer = new HttpServer(
                IPAddress.Parse(localAddress.Text),
                Convert.ToInt32(portNumber.Text),
                new FileRepository(fileRepository.Text)
                );
            httpServer.Start();
        }

        private void StopServer(object sender, EventArgs e)
        {

        }

    }
}
