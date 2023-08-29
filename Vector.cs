namespace Playground;
class Vector
{
    static public void vector()
    {
        Random rand = new();

        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 1000);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine();
    }
}
