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

    static bool IsPrime(int number){

        if (number <= 1) return false;
        for(int i =2; i*i <=number; i++)
        {
            if (number % 2 == 0) return false;
        }
        return true;
    }
    static void PrintPrimes(int[] arr)
    {
        Console.WriteLine("Prime numbers in the array:");
        foreach (int num in arr)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
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
    // 1. Print Even Numbers
    static void PrintEvenNumbers(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // 2. Find Maximum Number
    static void FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("Maximum = " + max);
    }

    // 3. Reverse an Array
    static void ReverseArray(int[] arr)
    {
        int[] copy = (int[])arr.Clone();
        Array.Reverse(copy);
        foreach (int num in copy)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    // 4. Check Palindrome
    static void CheckPalindrome(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
            reversed += str[i];

        if (str == reversed)
            Console.WriteLine(str + " is a Palindrome");
        else
            Console.WriteLine(str + " is NOT a Palindrome");
    }

    // 5. Count Vowels
    static void CountVowels(string str)
    {
        int count = 0;
        str = str.ToLower();
        foreach (char c in str)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }
        Console.WriteLine("Total Vowels = " + count);
    }

    // 6. Find Second Largest Number
    static void FindSecondLargest(int[] arr)
    {
        int first = int.MinValue, second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }
        Console.WriteLine("Second Largest = " + second);
    }

    // 7. Remove Duplicates
    static void RemoveDuplicates(int[] arr)
    {
        HashSet<int> unique = new HashSet<int>(arr);
        foreach (int num in unique)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    // 8. Sum of Array
    static void SumOfArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum += num;
        Console.WriteLine("Sum = " + sum);
    }

    // 9. Fibonacci Series
    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;
        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
        Console.WriteLine();
    }

    // 10. Factorial of a Number
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }
    static void Main()
    {
        int[] arr = { 7, 13, 11, 5, 3,6,8,10,9, 2, 1, 4 };

        // Uncomment the sorting method you want to test
        // BubbleSort(arr);
        // SelectionSort(arr);
        InsertionSort(arr);
        

        PrintArray(arr);
        PrintPrimes(arr);
        Console.WriteLine("1. Even Numbers:");
        PrintEvenNumbers(arr);

        Console.WriteLine("\n2. Maximum Number:");
        FindMax(arr);

        Console.WriteLine("\n3. Reverse Array:");
        ReverseArray(arr);

        //Console.WriteLine("\n4. Check Palindrome:");
        //CheckPalindrome(arr);

        Console.WriteLine("\n5. Count Vowels:");
        CountVowels("Hello World");

        Console.WriteLine("\n6. Second Largest Number:");
        FindSecondLargest(arr);

        Console.WriteLine("\n7. Remove Duplicates:");
        RemoveDuplicates(arr);

        Console.WriteLine("\n8. Sum of Array:");
        SumOfArray(arr);

        Console.WriteLine("\n9. Fibonacci Series:");
        PrintFibonacci(10);

        Console.WriteLine("\n10. Factorial:");
        Console.WriteLine("Factorial of 5 = " + Factorial(5));
    }
}