namespace Playground;

class VectorSum
{
    static public void vectorSum()
    {
        int[] vector1 = { 10, 20, 30 };
        int[] vector2 = { 10, 20, 30 };
        int[] result = new int[vector1.Length];

        Random rand = new();

        for (int i = 0; i < vector1.Length; i++)
        {
            Console.WriteLine($"Vector1 [{i}]: " + vector1[i]);
            Console.WriteLine($"Vector2 [{i}]: " + vector2[i]);
        }

        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
            Console.WriteLine($"Sum of position [{i}]: " + result[i]);
        }

        Console.WriteLine();

    }
}