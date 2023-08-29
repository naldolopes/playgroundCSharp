namespace Playground;

class VectorAvg
{
    static public void vectorAvg()
    {
        int avg = 0;
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < array.Length; i++)
        {
            avg += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Array position [{i}]: " + array[i]);
        }

        Console.WriteLine($"Array Average is: " + avg / array.Length);

        Console.WriteLine();

    }

}