using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class ImageProcessor
{
    private static volatile int _processedImagesCount = 0; // Use volatile for thread-safe access
    private static int _totalImages = 0;

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting batch image processing simulation with Parallel.ForEachAsync...");

        // 1. Prepare a list of dummy image files
        const int numberOfImages = 20;
        _totalImages = numberOfImages;
        List<string> imageFiles = Enumerable.Range(1, numberOfImages)
                                             .Select(i => $"image_{i:00}.jpg")
                                             .ToList();

        Console.WriteLine($"Total images to process: {_totalImages}");

        // 2. Define the maximum degree of parallelism (how many images to process concurrently)
        // You can adjust this based on your CPU cores or desired concurrency.
        // For I/O-bound tasks (like real image processing that reads/writes files),
        // a higher degree of parallelism might be beneficial.
        var parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount // Use number of logical processors
            // MaxDegreeOfParallelism = 4 // Or a fixed number
        };

        // 3. Process images using Parallel.ForEachAsync
        try
        {
            await Parallel.ForEachAsync(imageFiles, parallelOptions, async (imagePath, cancellationToken) =>
            {
                // Simulate image processing
                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}] Processing: {imagePath}");
                await Task.Delay(200, cancellationToken); // Simulate 200ms processing time per image

                // Safely increment the counter and update progress
                int currentCount = Interlocked.Increment(ref _processedImagesCount);
                double percentage = (double)currentCount / _totalImages * 100;

                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}] Finished: {imagePath} | Progress: {percentage:F1}% ({currentCount}/{_totalImages})");

                // You could add cancellation logic here if needed:
                // cancellationToken.ThrowIfCancellationRequested();
            });

            Console.WriteLine("\nAll images processed successfully!");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("\nImage processing was cancelled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred during processing: {ex.Message}");
        }

        Console.WriteLine("Batch image processing simulation finished.");
    }
}