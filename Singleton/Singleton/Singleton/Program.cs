using Singleton;

Console.WriteLine("Singleton-Pattern");
string name = "Singleton";
string oaths =
    "In Brightest Day, In Blackest Night, No Evil Shall Escape My Sight. Let those Who Worship Evil's Might, Beware My Power, Green Lantern's Light!\n" +
    "In fearful day, in raging night. With strong hearts full, our souls ignite. When all seems lost in the War of Light, Look to the stars, for hope burns bright\n" +
    "In brightest day, there will be Light.To cleanse the soul and set wrongs right. When darkness falls, look to the sky, a new dawn comes, Let there be Light\n" +
    "In Brightest Day, In Blackest Night, I will Embrace My Fear, I will do what's Right. I choose this Ring, I choose this Fight. In Service to this Lanterns Light\n";
string text = "TBD";
string content;
string fileName = $"{name}.txt";
string filePath;
FileWriter fileWriter = FileWriter.Instance;

SeClass seClass = new SeClass();
FileWriter fw2 = seClass.GetWriter();



filePath = fileWriter.Write(fileName, oaths);

content = fileWriter.Read(filePath);

Console.WriteLine($"Content von {name}:\n{content}");

Console.WriteLine($"Erste Referenz:  {fileWriter.GetHashCode()}");
Console.WriteLine($"Zweite Referenz: {fw2.GetHashCode()}");

fileWriter.ClearContent(filePath);