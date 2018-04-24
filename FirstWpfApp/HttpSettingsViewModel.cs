using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Input;
using CreateHttpServer;
using FirstWpfApp.View.ViewModel;
using TcpHtmlVerify;

namespace FirstWpfApp
{
    public class HttpSettingsViewModel : INotifyPropertyChanged
    {
        private string portNumber = "5000";
        private string ipAddress = "127.0.0.1";
        private string path = "";
        private HttpServer httpServer;

        public HttpSettingsViewModel()
        {
            ExecuteCommand = new RelayCommand(Start, CanExecuteStartCommand);
        }

        public string IpAddress
        {
            get
            {
                return ipAddress;
            }
            set
            {
                if (ipAddress != value)
                {
                    ipAddress = value;
                    NotifyPropertyChanged("IpAddress");
                }
            }
        }

        public string PortNumber
        {
            get
            {
                return portNumber;
            }
            set
            {
                if (portNumber != value)
                {
                    portNumber = value;
                    NotifyPropertyChanged("PortNumber");
                }
            }
        }

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                if (path != value)
                {
                    path = value;
                    NotifyPropertyChanged("Path");
                }
            }
        }

        public bool IsOn
        {
            get
            {
                return true;
            }
        }

        protected void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ExecuteCommand
        {
            get;
            internal set;
        }

        private bool CanExecuteStartCommand()
        {
            return !(string.IsNullOrEmpty(path) && string.IsNullOrEmpty(portNumber) && string.IsNullOrEmpty(ipAddress));
        }

        public void Start()
        {
            httpServer = new HttpServer(IPAddress.Parse(ipAddress), Convert.ToInt32(portNumber), new FileRepository(path));
            httpServer.Start();
        }
        
    }
}
