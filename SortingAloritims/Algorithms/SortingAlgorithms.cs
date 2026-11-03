namespace SortingAloritims.Algorithms;

public static class SortingAlgorithms
{
    public static void BubbleSort(int[] arr)
    {
        Console.WriteLine("Bubble Sort Start");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool isSwap = false;

            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                    isSwap = true;
                }
            }

            if (!isSwap)
                return;
        }
    }

    public static void SelectionSort(int[] arr)
    {
        Console.WriteLine("Selection Sort Start");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            Swap(arr, i, minIndex);
        }
    }

    public static void InsertionSort(int[] arr)
    {
        Console.WriteLine("Insertion Sort Start");

        for (int i = 0; i < arr.Length; i++)
        {
            int current = arr[i];
            int prevIndex = i - 1;

            while (prevIndex >= 0 && arr[prevIndex] > current)
            {
                arr[prevIndex + 1] = arr[prevIndex];
                prevIndex--;
            }

            arr[prevIndex + 1] = current;
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}
