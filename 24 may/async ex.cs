class Program
{
    static async Task DownloadFileAsync(string filename, int delayMs)
    {
        Console.WriteLine($"strating download : {filename}");

        await Task.Delay(delayMs);

        Console.WriteLine($"complete download :{filename} ({delayMs}ms)");

    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("starting downloading all :");

        Task file1 = DownloadFileAsync("file1.pdf", 3000);
        Task file2 = DownloadFileAsync("file2.jpg", 2000);
        Task file3 = DownloadFileAsync("file3.zip", 4000);

        await Task.WhenAll(file1, file2, file3);

        Console.WriteLine("all downloads completed");
    }
}