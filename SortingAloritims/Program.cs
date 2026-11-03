using SortingAloritims.Algorithms;
using SortingAloritims.Utilities;

class Program
{
    static void Main()
    {
        int[] arr = { 7, 13, 11, 5, 3, 6, 8, 10, 9, 2, 1, 4 };

        SortingAlgorithms.InsertionSort(arr);
        while (true)
        {
            Console.WriteLine("Sorted Array:");
            ArrayUtilities.PrintArray(arr);
            Console.Write("Enter a number to search, or type q to exit: ");
            string? input = Console.ReadLine();

            if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                break;

            if (!int.TryParse(input, out int numberToSearch))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            SearchUtilities.SearchBinary(arr, numberToSearch);
            Console.WriteLine();
        }
    }
}