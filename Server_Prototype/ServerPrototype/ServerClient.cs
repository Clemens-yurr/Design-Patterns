namespace ServerPrototype
{ 
    internal class ServerClient
    {
        private Server _serverPrototype;

        public ServerClient(Server serverPrototype)
        {
            _serverPrototype = serverPrototype;
        }

        //klont Vorlage so oft wie man braucht
        public List<Server> CreateServers(int anzahl, string namePrefix, string ipBasis, int ersteIp)
        {
            List<Server> servers = new List<Server>();
            for (int i = 0; i < anzahl; i++)
            {
                Server neu = _serverPrototype.Clone();
                neu.Name = namePrefix + (i + 1);
                neu.IpAdresse = ipBasis + (ersteIp + i);
                servers.Add(neu);
            }
            return servers;
        }
    }
}
