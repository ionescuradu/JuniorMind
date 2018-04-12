using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using CreateHttpServer;
using TcpApp1.Properties;
using TcpHtmlVerify;

namespace TcpApp1
{
    public partial class Form1 : Form
    {
        private HttpServer httpServer;
        private StringBuilder builder = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portNumber.Text = Settings.Default.port.ToString();
            localAddress.Text = Settings.Default.ipAddress.ToString();
            fileRepository.Text = Settings.Default.repositoryPath.ToString();
            stop.Enabled = false;
        }

        private void StartServer(object sender, EventArgs e)
        {
            stop.Enabled = true;
            httpServer = new HttpServer(
                IPAddress.Parse(localAddress.Text),
                Convert.ToInt32(portNumber.Text),
                new FileRepository(fileRepository.Text)
                );
            httpServer.OnScreen += HttpServer_OnScreen;
            httpServer.Start();
        }

        private void HttpServer_OnScreen(string output)
        {
            txtConsole.Text += output;
        }

        private void StopServer(object sender, EventArgs e)
        {
            httpServer.Stop();
        }

        void OnScreen(string output)
        {
            builder.AppendLine(output);
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
