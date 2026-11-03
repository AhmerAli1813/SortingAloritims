namespace SortingAloritims.Utilities;

public static class ArrayUtilities
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static void PrintPrimes(int[] arr)
    {
        Console.WriteLine("Prime numbers in the array:");
        foreach (int num in arr)
        {
            if (IsPrime(num))
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    public static void PrintEvenNumbers(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("Maximum = " + max);
    }

    public static void ReverseArray(int[] arr)
    {
        int[] copy = (int[])arr.Clone();
        Array.Reverse(copy);
        PrintArray(copy);
    }

    public static void CheckPalindrome(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
            reversed += str[i];

        Console.WriteLine(str == reversed
            ? str + " is a Palindrome"
            : str + " is NOT a Palindrome");
    }

    public static void CountVowels(string str)
    {
        int count = 0;
        str = str.ToLower();
        foreach (char c in str)
        {
            if (c is 'a' or 'e' or 'i' or 'o' or 'u')
                count++;
        }
        Console.WriteLine("Total Vowels = " + count);
    }

    public static void FindSecondLargest(int[] arr)
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

    public static void RemoveDuplicates(int[] arr)
    {
        HashSet<int> unique = new(arr);
        foreach (int num in unique)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    public static void SumOfArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum += num;
        Console.WriteLine("Sum = " + sum);
    }

    public static void PrintFibonacci(int n)
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

    public static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    public static string ReverseWord(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
                chars[i] = char.ToLower(chars[i]);
            else if (char.IsLower(chars[i]))
                chars[i] = char.ToUpper(chars[i]);
        }

        return new string(chars);
    }
}
