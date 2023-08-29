class FileWorldCounter
{
    static public void fileWorldCounter()
    {
        Console.Write("Type the file path: ");
        string path = Console.ReadLine() ?? string.Empty;

        if (!File.Exists(path))
        {
            Console.WriteLine($"The file {path} does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(path);

        int counter = 0;

        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            counter += words.Length;
        }

        Console.WriteLine($"The file {path} has {counter} words.");
    }
}