namespace ServerPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server webVorlage = new WebServer("vorlage", "0.0.0.0", 16, 8, "Ubuntu 24.04", 443, true, 5000);
            Server dbVorlage = new DatenbankServer("vorlage", "0.0.0.0", 64, 16, "Debian 12", 3306, "MariaDB", true);
            Server mailVorlage = new MailServer("vorlage", "0.0.0.0", 8, 4, "Debian 12", 25, true, 2048);

            ServerClient webClient = new ServerClient(webVorlage);
            ServerClient dbClient = new ServerClient(dbVorlage);
            ServerClient mailClient = new ServerClient(mailVorlage);

            List<Server> alle = new List<Server>();
            alle.AddRange(webClient.CreateServers(3, "web", "192.168.1.", 10));
            alle.AddRange(dbClient.CreateServers(2, "db", "192.168.2.", 10));
            alle.AddRange(mailClient.CreateServers(2, "mail", "192.168.3.", 10));

            Console.WriteLine("=== Rechenzentrum (" + alle.Count + " Server, alle per Clone()       erzeugt) ===");
            foreach (Server s in alle)
            {
                s.Show();
            }
            
            Console.WriteLine("\n=== Vorlagen (unveraendert) ===");
            webVorlage.Show();
            dbVorlage.Show();
            mailVorlage.Show();
        }
    }
}
