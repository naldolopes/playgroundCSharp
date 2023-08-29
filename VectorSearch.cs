namespace Playground;

class VectorSearch
{
    static public void vectorSearch()
    {
        string[] names = { "John", "Peter", "Mary", "George", "Paul" };

        Console.WriteLine("Enter a name to search for:");
        string name = Console.ReadLine() ?? string.Empty;

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == name)
            {
                Console.WriteLine("Found at index {0}", i);
                return;
            }
        }

        Console.WriteLine("Not found");
    }
}