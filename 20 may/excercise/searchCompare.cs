using System;

class SearchingComparison
{
    static void Main()
    {
        Random rand = new Random();
        int[] sortedArray = new int[50];

        // Generate sorted list of 50 random integers between 1 and 200
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = rand.Next(1, 201);
        }

        Array.Sort(sortedArray);
        Console.WriteLine("Sorted Array:");
        PrintArray(sortedArray);

        // Pick a random element from the array or a random number from the range
        int key = sortedArray[rand.Next(0, sortedArray.Length)];
        Console.WriteLine($"\nSearching for element: {key}");

        // Linear Search
        int linearComparisons = 0;
        int linearPos = LinearSearch(sortedArray, key, out linearComparisons);
        Console.WriteLine($"\n🔍 Linear Search:\nPosition: {linearPos}, Comparisons: {linearComparisons}");

        // Binary Search
        int binaryComparisons = 0;
        int binaryPos = BinarySearch(sortedArray, key, out binaryComparisons);
        Console.WriteLine($"\n🔍 Binary Search:\nPosition: {binaryPos}, Comparisons: {binaryComparisons}");

        // Analysis
        Console.WriteLine("\n📊 Efficiency Analysis:");
        Console.WriteLine("- Linear Search: O(n) time complexity");
        Console.WriteLine("- Binary Search: O(log n) time complexity");
        Console.WriteLine("- Binary Search is more efficient for large sorted lists.");
        Console.WriteLine("- For very small lists or unsorted data, Linear Search may be sufficient.");
    }

    static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i; // Found at index i
        }
        return -1; // Not found
    }

    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            comparisons++;
            int mid = (left + right) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Not found
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}