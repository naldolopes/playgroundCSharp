namespace Playground;
class LinearSearch
{
    static public void linearSearch()
    {
        // create an array of 10 positions
        int[] numbers = new int[10];

        // ask to user give the numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Type the {i + 1}º number: ");
            numbers[i] = int.Parse(Console.ReadLine() ?? string.Empty);
        }

        // jump a line
        Console.Write("\n");

        // ask to user give the number to search
        Console.Write("Type the number to search: ");
        int valueToSearch = int.Parse(Console.ReadLine() ?? string.Empty);

        // search the number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == valueToSearch)
            {
                // jump a line
                Console.Write("\n");
                Console.WriteLine($"The number {valueToSearch} is at the position {i + 1}");
                break;
            }
        }

    }
}