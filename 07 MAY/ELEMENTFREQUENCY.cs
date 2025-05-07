using System;
class Frequencycounter
{
    public static void PrintFrequency(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("the array is empty");
            return;
        }
        Dictionary<int, int> frequencymap = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (frequencymap.ContainsKey(num))
            {
                frequencymap[num]++; ;

            }
            else
            {
                frequencymap[num] = 1;
            }
        }
        foreach (KeyValuePair<int, int> pair in frequencymap)
        {
            Console.WriteLine($"{pair.Key} appears {pair.Value} {(pair.Value == 1 ? "time" : "times")}");

        }

    }
    public static void Main(string[] args)
    {
        int[] sampleInput = { 1, 2, 2, 3, 4, 4, 4 };
        Console.WriteLine("SampleInput :{ " + string.Join(",",sampleInput) + "} " );
            Console.WriteLine("Output: ");
        PrintFrequency(sampleInput);
    }
}