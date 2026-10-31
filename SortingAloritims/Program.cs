using System;

class Program
{
   
    // Correct way to swap two elements inside an array
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // ===================== BUBBLE SORT =====================
    // Repeatedly compare adjacent elements and swap if they are out of order.
    // After each pass, the largest element "bubbles" to the end.
    static void BubbleSort(int[] arr)
    {
        Console.WriteLine("Bubble Sort Start");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool IsSwap = false;               // Optimization flag

            // Last i elements are already in place
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap adjacent elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    IsSwap = true;
                }
            }

            // If no swap happened → array is already sorted
            if (!IsSwap)
            {
                return;
            }
        }
    }

    // ===================== SELECTION SORT =====================
    // Find the minimum element from the unsorted part and put it at the beginning.
    // Sorted region grows from left to right.
    static void SelectionSort(int[] arr)
    {
        Console.WriteLine("Selection Sort Start");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;                  // Assume current index has the minimum

            // Find the actual minimum in the remaining array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum with the element at position i
            Swap(arr, i, minIndex);
        }
    }

    // ===================== INSERTION SORT =====================
    // Take one element at a time and insert it into its correct position
    // among the already sorted elements on the left.
    static void InsertionSort(int[] arr)
    {
        Console.WriteLine("Insertion Sort Start");

        for (int i = 0; i < arr.Length; i++)
        {
            int current = arr[i];              // Element to be inserted
            int prevIndex = i - 1;

            // Shift larger elements to the right to make space
            while (prevIndex >= 0 && arr[prevIndex] > current)
            {
                arr[prevIndex + 1] = arr[prevIndex];
                prevIndex--;
            }

            // Place the current element in its correct position
            arr[prevIndex + 1] = current;
        }
    }

    // Helper method to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 5, 3, 2, 1, 4 };

        // Uncomment the sorting method you want to test
        // BubbleSort(arr);
        // SelectionSort(arr);
        InsertionSort(arr);

        PrintArray(arr);
    }
}