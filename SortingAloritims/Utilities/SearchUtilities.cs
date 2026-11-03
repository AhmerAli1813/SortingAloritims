namespace SortingAloritims.Utilities;

public static class SearchUtilities
{
    public static void SearchBinary(int[] arr, int targetValue)
    {
        Console.WriteLine($"Searching for {targetValue} in the array...");
        ArrayUtilities.PrintArray(arr);

        int loc = -1;
        int b = 0;
        int e = arr.Length - 1;
        int step = 1;

        if (arr.Length == 0 || targetValue > arr[^1] || targetValue < arr[0])
        {
            Console.WriteLine($"Element {targetValue} not found in the array");
            return;
        }

        while (b <= e)
        {
            int mid = b + (e - b) / 2;
            Console.WriteLine($"Step {step}: b={b}, e={e}, mid={mid}, arr[mid]={arr[mid]}");

            if (arr[mid] == targetValue)
            {
                loc = mid;
                Console.WriteLine($"  → FOUND! arr[{mid}] == {targetValue}");
                break;
            }

            if (arr[mid] < targetValue)
                b = mid + 1;
            else
                e = mid - 1;

            step++;
        }

        if (loc != -1)
            Console.WriteLine($"Element {targetValue} found at index {loc}");
        else
            Console.WriteLine($"Element {targetValue} not found in the array");
    }
}
