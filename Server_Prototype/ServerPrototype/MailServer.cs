namespace ServerPrototype
{
    internal class MailServer : Server
    {
        public string Name { get; set; }
        public string IpAdresse { get; set; }

        private int _ramGb;
        private int _cpuKerne;
        private string _os;
        private int _port;
        private bool _spamFilter;
        private int _postfachMb;

        public MailServer(string name, string ip, int ramGb, int cpuKerne, string os,
                          int port, bool spamFilter, int postfachMb)
        {
            Name = name;
            IpAdresse = ip;
            _ramGb = ramGb;
            _cpuKerne = cpuKerne;
            _os = os;
            _port = port;
            _spamFilter = spamFilter;
            _postfachMb = postfachMb;
        }

        public Server Clone()
        {
            return new MailServer(Name, IpAdresse, _ramGb, _cpuKerne, _os,
                                  _port, _spamFilter, _postfachMb);
        }

        public void Show()
        {
            Console.WriteLine("MailServer     " + Name + " | " + IpAdresse + " | " + _ramGb + " GB RAM, " + _cpuKerne +
                              " Kerne, " + _os + " | Port " + _port + ", Spamfilter: " + (_spamFilter ? "ja" : "nein") +
                              ", Postfach " + _postfachMb + " MB");
        }
    }
}
