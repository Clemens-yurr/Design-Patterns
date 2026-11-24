namespace ServerPrototype
{
    internal class WebServer : Server
    {
        public string Name { get; set; }
        public string IpAdresse { get; set; }

        private int _ramGb;
        private int _cpuKerne;
        private string _os;
        private int _port;
        private bool _httpsAktiv;
        private int _maxVerbindungen;

        public WebServer(string name, string ip, int ramGb, int cpuKerne, string os,
                         int port, bool httpsAktiv, int maxVerbindungen)
        {
            Name = name;
            IpAdresse = ip;
            _ramGb = ramGb;
            _cpuKerne = cpuKerne;
            _os = os;
            _port = port;
            _httpsAktiv = httpsAktiv;
            _maxVerbindungen = maxVerbindungen;
        }

        public Server Clone()
        {
            return new WebServer(Name, IpAdresse, _ramGb, _cpuKerne, _os,
                                 _port, _httpsAktiv, _maxVerbindungen);
        }

        public void Show()
        {
            Console.WriteLine("WebServer      " + Name + " | " + IpAdresse + " | " + _ramGb + " GB RAM, " + _cpuKerne +
                              " Kerne, " + _os + " | Port " + _port + ", HTTPS: " + (_httpsAktiv ? "ja" : "nein") +
                              ", max. " + _maxVerbindungen + " Verbindungen");
        }
    }
}
