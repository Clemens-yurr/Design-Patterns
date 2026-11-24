namespace ServerPrototype
{
    internal interface Server
    {
        string Name { get; set; }
        string IpAdresse { get; set; }
        Server Clone();     //clont den fertig eingerichteten Server
        void Show();        //ausgabe
    }
}
