namespace ServerPrototype
{
    internal class DatenbankServer : Server
    {
        public string Name { get; set; }
        public string IpAdresse { get; set; }

        private int _ramGb;
        private int _cpuKerne;
        private string _os;
        private int _port;
        private string _datenbankTyp;
        private bool _backupAktiv;

        public DatenbankServer(string name, string ip, int ramGb, int cpuKerne, string os,
                               int port, string datenbankTyp, bool backupAktiv)
        {
            Name = name;
            IpAdresse = ip;
            _ramGb = ramGb;
            _cpuKerne = cpuKerne;
            _os = os;
            _port = port;
            _datenbankTyp = datenbankTyp;
            _backupAktiv = backupAktiv;
        }

        public Server Clone()
        {
            return new DatenbankServer(Name, IpAdresse, _ramGb, _cpuKerne, _os,
                                       _port, _datenbankTyp, _backupAktiv);
        }

        public void Show()
        {
            Console.WriteLine("DatenbankServer " + Name + " | " + IpAdresse + " | " + _ramGb + " GB RAM, " + _cpuKerne +
                              " Kerne, " + _os + " | Port " + _port + ", " + _datenbankTyp +
                              ", Backup: " + (_backupAktiv ? "ja" : "nein"));
        }
    }
}
