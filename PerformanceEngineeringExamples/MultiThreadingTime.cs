using System;
using System.Threading.Tasks;

namespace PerformanceEngineeringExamples
{
    public class MultiThreadingTime
    {
        public void CheckTime()
        {
            
            Console.ReadKey(true);
        }


        public async static Task DoShortTimeConsumingWork()
        {
            await Task.Delay(2000);
            Console.WriteLine("Short work done!");
        }

        public async static Task DoLongTimeConsumingWork()
        {
            await Task.Delay(4000);
            Console.WriteLine("Long work done!");
        }
    }
}
