using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Start stopwatch to track total download time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Simulate downloading 3 files in parallel
        Task download1 = DownloadFileAsync("file1.txt", 2000); // 2 seconds
        Task download2 = DownloadFileAsync("file2.txt", 3000); // 3 seconds
        Task download3 = DownloadFileAsync("file3.txt", 1000); // 1 second

        await Task.WhenAll(download1, download2, download3);

        stopwatch.Stop();
        Console.WriteLine($" All files downloaded in {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download of {fileName}...");
        await Task.Delay(delay); // Simulates download time
        Console.WriteLine($"Finished downloading {fileName} in {delay} ms");
    }
}