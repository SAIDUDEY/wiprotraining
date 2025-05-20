using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        Random rand = new Random();
        int[] originalArray = new int[20];

        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = rand.Next(1, 101); // 1 to 100
        }

        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        // Bubble Sort
        int[] bubbleArray = (int[])originalArray.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw1.Stop();
        Console.WriteLine("\nBubble Sorted Array:");
        PrintArray(bubbleArray);
        Console.WriteLine($"Time Taken: {sw1.Elapsed.TotalMilliseconds} ms");

        // Selection Sort
        int[] selectionArray = (int[])originalArray.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionArray);
        sw2.Stop();
        Console.WriteLine("\nSelection Sorted Array:");
        PrintArray(selectionArray);
        Console.WriteLine($"Time Taken: {sw2.Elapsed.TotalMilliseconds} ms");

        // Insertion Sort
        int[] insertionArray = (int[])originalArray.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionArray);
        sw3.Stop();
        Console.WriteLine("\nInsertion Sorted Array:");
        PrintArray(insertionArray);
        Console.WriteLine($"Time Taken: {sw3.Elapsed.TotalMilliseconds} ms");

        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("- All three algorithms have a worst-case time complexity of O(n^2)");
        Console.WriteLine("- For small arrays, time difference is negligible.");
        Console.WriteLine("- Insertion Sort usually performs better on nearly sorted arrays.");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            }

            // Swap
            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}