using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using CreateHttpServer;
using TcpApp1.Properties;
using TcpHtmlVerify;

namespace TcpApp1
{
    public partial class Form1 : Form
    {
        private HttpServer httpServer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portNumber.Text = Settings.Default.port.ToString();
            localAddress.Text = Settings.Default.ipAddress.ToString();
            fileRepository.Text = Settings.Default.repositoryPath.ToString();
        }

        private void StartServer(object sender, EventArgs e)
        {
            httpServer = new HttpServer(
                IPAddress.Parse(localAddress.Text),
                Convert.ToInt32(portNumber.Text),
                new FileRepository(fileRepository.Text)
                );
            httpServer.Start();
        }

        private void StopServer(object sender, EventArgs e)
        {
            httpServer.Stop();
        }

    }
}
