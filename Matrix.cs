namespace Playground;
class Matrix
{
    static public void matrix()
    {
        Random rand = new();
        int[,] matrix = new int[3, 3];

        // generate random numbers
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[col, row] = rand.Next(0, 2);
            }
        }

        // print numbers
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write(matrix[col, row] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}