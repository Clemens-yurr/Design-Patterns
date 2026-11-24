namespace Singleton;

public class SeClass
{
    public FileWriter GetWriter()
    {
        return FileWriter.Instance;
    }
}