using System;
using System.ComponentModel;
using System.Net;
using System.Text;
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
        private string path = "C:\\Users\\Radu\\Documents\\GitHub\\JuniorMind\\aaa";
        private StringBuilder builder = new StringBuilder();
        private HttpServer httpServer;
        private bool stop = false;

        public HttpSettingsViewModel()
        {
            ExecuteCommand = new RelayCommand(Start, CanExecuteStartCommand);
            StopCommand = new RelayCommand(Stop, CanStop);
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

        public ICommand StopCommand
        {
            get;
            internal set;
        }

        private bool CanStop()
        {
            return stop;
        }

        private bool CanExecuteStartCommand()
        {
            //return !(string.IsNullOrEmpty(path) && string.IsNullOrEmpty(portNumber) && string.IsNullOrEmpty(ipAddress));
            return !stop;
        }

        public void Start()
        {
            httpServer = new HttpServer(IPAddress.Parse(ipAddress), Convert.ToInt32(portNumber), new FileRepository(path));
            httpServer.OnScreen += HttpServer_OnScreen;
            stop = true;
            httpServer.Start();
        }

        public void Stop()
        {
            stop = false;
            httpServer.Stop();
        }

        public string TxtConsole
        {
            get
            {
                return builder.ToString();
            }
        }

        private void HttpServer_OnScreen(string output)
        {
            builder.Append(DateTime.Now.ToLongTimeString() + " " + output);
            NotifyPropertyChanged("TxtConsole");
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
