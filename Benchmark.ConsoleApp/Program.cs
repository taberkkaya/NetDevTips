using BenchmarkDotNet.Running;

namespace Benchmark.ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BenchmarkRunner.Run<BenchmarkService>();
    }
}
