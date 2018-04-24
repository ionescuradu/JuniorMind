
namespace FirstWpfApp
{
    public class HttpSettingsViewModel
    {
        private string portNumber = "5000";
        private string ipAddress = "127.0.0.1";
        private bool enable = true;

        public string IpAddress
        {
            get { return ipAddress; }
            set
            {
                if (ipAddress != value)
                {
                    ipAddress = value;
                }
            }
        }

        public string PortNumber
        {
            get { return portNumber; }
            set
            {
                if (portNumber != value)
                {
                    portNumber = value;
                }
            }
        }

        public bool IsOn
        {
            get
            {
                return enable;
            }
        }

        public bool IsOff
        {
            get
            {
                return !enable;
            }
        }
    }
}
