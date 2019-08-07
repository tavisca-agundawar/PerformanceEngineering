using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;

namespace PerformanceEngineeringExamples
{
    [MemoryDiagnoser]
    public class TaskVsThread
    {
        
        [Benchmark]
        public void Benchmark_For_Execution_With_Threads()
        {
            int timeInMS = 2000;
            Thread thread1 = new Thread(() => DoSmallTimeConsumingWork(timeInMS));
            Thread thread2 = new Thread(() => DoLargeTimeConsumingWork(timeInMS));

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }



        [Benchmark]
        public void Benchmark_For_Execution_With_Tasks()
        {

            Task.Run(async () =>
            {
                var task1 = DoSmallTimeConsumingWork();
                var task2 = DoLargeTimeConsumingWork();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();


        }

        public static void DoSmallTimeConsumingWork(int timeInMS)
        {
            Thread.Sleep(timeInMS + 1000);
        }

        public static void DoLargeTimeConsumingWork(int timeInMS)
        {
            Thread.Sleep(timeInMS + 2000);
        }

        public async static Task DoSmallTimeConsumingWork()
        {
            await Task.Delay(3000);
        }

        public async static Task DoLargeTimeConsumingWork()
        {
            await Task.Delay(4000);
        }
    }
}
