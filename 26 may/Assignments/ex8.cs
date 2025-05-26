using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class ImageProcessor
{
    private static volatile int _processedImagesCount = 0; 
    private static int _totalImages = 0;

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting batch image processing simulation with Parallel.ForEachAsync...");

        
        const int numberOfImages = 20;
        _totalImages = numberOfImages;
        List<string> imageFiles = Enumerable.Range(1, numberOfImages)
                                             .Select(i => $"image_{i:00}.jpg")
                                             .ToList();

        Console.WriteLine($"Total images to process: {_totalImages}");

        
        var parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount 
            
        };

        
        try
        {
            await Parallel.ForEachAsync(imageFiles, parallelOptions, async (imagePath, cancellationToken) =>
            {
                
                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}] Processing: {imagePath}");
                await Task.Delay(200, cancellationToken); // Simulate 200ms processing time per image

                
                int currentCount = Interlocked.Increment(ref _processedImagesCount);
                double percentage = (double)currentCount / _totalImages * 100;

                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}] Finished: {imagePath} | Progress: {percentage:F1}% ({currentCount}/{_totalImages})");

                
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