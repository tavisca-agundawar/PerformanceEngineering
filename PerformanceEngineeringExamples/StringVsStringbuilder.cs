using System;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
namespace PerformanceEngineeringExamples
{
    [MemoryDiagnoser]
    public class StringVsStringbuilder
    {
        public void ShowTimeDifference()
        {
            var watch = new Stopwatch();
            string hello = "hello";
            string name = "arnaw";
            watch.Start();
            for (int i = 0; i < 100; i++)
                hello = string.Concat(hello, name);
            Console.WriteLine($"Time taken using String in ticks {watch.ElapsedTicks}");

            StringBuilder stringBuilder = new StringBuilder(hello);
            watch.Restart();
            for (int i = 0; i < 100; i++)
                stringBuilder.Append(name);
            Console.WriteLine($"Time taken using String builder in ticks {watch.ElapsedTicks}");

            Console.ReadKey(true);
        }

        [Benchmark]
        public void Benchmark_Of_String()
        {
            string testString = "Benchmark.";
            for (int index = 0; index < 1000; index++)
            {
                testString += "Benching.";
            }
        }

        [Benchmark]
        public void Benchmark_Of_StringBuilder()
        {
            StringBuilder testStringBuilder = new StringBuilder("Benchmark.");
            for (int index = 0; index < 1000; index++)
            {
                testStringBuilder.Append("Benching.");
            }
        }
    }
}
