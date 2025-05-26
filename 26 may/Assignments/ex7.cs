using System;

namespace StrategyPatternDemo

{

  

    abstract class CompressionStrategy

    {

        public abstract void Compress(string inputPath, string outputPath);

    }

   

    class ZipCompression : CompressionStrategy

    {

        public override void Compress(string inputPath, string outputPath)

        {

            Console.WriteLine($"Compressing '{inputPath}' into ZIP format at '{outputPath}'");

           

        }

    }

   

    class RarCompression : CompressionStrategy

    {

        public override void Compress(string inputPath, string outputPath)

        {

            Console.WriteLine($"Compressing '{inputPath}' into RAR format at '{outputPath}'");

          

        }

    }

   

    class Compressor

    {

        private CompressionStrategy _strategy;

        public Compressor(CompressionStrategy strategy)

        {

            _strategy = strategy;

        }

        public void SetStrategy(CompressionStrategy strategy)

        {

            _strategy = strategy;

        }

        public void CompressFile(string inputPath, string outputPath)

        {

            _strategy.Compress(inputPath, outputPath);

        }

    }

    

    class Program

    {

        static void Main()

        {

            Compressor compressor = new Compressor(new ZipCompression());

            compressor.CompressFile("file.txt", "file.zip");

            

            compressor.SetStrategy(new RarCompression());

            compressor.CompressFile("file.txt", "file.rar");

            Console.ReadKey();

        }

    }

}