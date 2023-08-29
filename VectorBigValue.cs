namespace Playground;
class VectorBigValue
{
    static public void vectorBigValue()
    {
        int[] array = { 1, 290, 310, 240, 250 };
        int bigValue = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > bigValue)
            {
                bigValue = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Array position [{i}]: " + array[i]);
        }

        Console.WriteLine($"Biggest value in array is: " + bigValue);
        Console.WriteLine();

    }
}