namespace Singleton;

public sealed class FileWriter //sealed = Klasse kann nicht geerbt werden
{
    private static readonly Lazy<FileWriter> instance = new(() => new FileWriter()); 
    //Lazy = Instanz wird erst erstellt, wenn sie gebraucht wird

    public static FileWriter Instance => instance.Value; //Globale Instanz von FileWriter

    private FileWriter() //Der Konstruktor ist privat, um die Instanziierung von außen zu verhindern
    {
    }

    public string Write(string name, string content) //Schreiben der Date, name ist leicht zu ändern
    {
        string fileName = name;
        string filePath = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory, "..", "..", "..", fileName));

        File.AppendAllText(filePath, content);
        return filePath;
    }

    public string Read(string filePath)
    {
        return File.ReadAllText(filePath);
    }

    public string ClearContent(string filePath)
    {
        File.WriteAllText(filePath, string.Empty);
        return filePath;
    }
}
