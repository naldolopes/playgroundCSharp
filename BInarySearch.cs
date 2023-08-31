namespace Playground;
class BinarySearch
{
    static public void binarySearch()
    {
        // create an array of 10 positions
        int[] numbers = new int[10];

        // ask to user give the numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Type the {i + 1}º number: ");
            numbers[i] = int.Parse(Console.ReadLine() ?? string.Empty);
        }

        // sort the array
        Array.Sort(numbers);

        // jump a line
        Console.WriteLine("\n");

        // jump a line
        Console.WriteLine("Ordered Array: ");

        // show the Ordered Array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"at idx {i} : {numbers[i]} ");
        }

        // jump a line
        Console.WriteLine("\n");

        // ask to user give the number to search
        Console.Write("Type the number to search: ");
        int valueToSearch = int.Parse(Console.ReadLine() ?? string.Empty);

        int start = 0;                // start of the array
        int end = numbers.Length - 1; // end of the array
        int interactions = 1;        // interactions counter

        // search the number using binary search
        // Start the binary search
        while (start <= end)
        {
            // calculate the middle
            int middle = (start + end) / 2;

            // check if the number in the middle is the value to search
            if (numbers[middle] == valueToSearch)
            {
                Console.WriteLine($"Interactions: {interactions}"); // show the interactions counter
                Console.WriteLine($"!!! The number {valueToSearch} was found at position {middle} !!!"); // show the message
                break; // break the loop
            }
            else if (numbers[middle] < valueToSearch) // check if the number in the middle is less than the value to search
            {
                start = middle + 1; // if the number in the middle is less than the value to search, the start will be the middle + 1
            }
            else
            {
                end = middle - 1; // if the number in the middle is greater than the value to search, the end will be the middle - 1
            }

            interactions++; // increment the interactions counter
        }
    }
}


// [ 10 20 30 40 50 60 70 80 90 100 ]
//   0  1  2  3  4  5  6  7  8  9     