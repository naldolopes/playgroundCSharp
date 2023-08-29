using System;
using System.IO;

class ReadFile
{
    static public void readFile()
    {
        string path = "text.txt";

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {path} não foi encontrado.");
        }
    }
}
