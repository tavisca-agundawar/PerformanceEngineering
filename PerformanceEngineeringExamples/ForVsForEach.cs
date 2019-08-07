using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace PerformanceEngineeringExamples
{
    [MemoryDiagnoser]
    public class ForVsForEach
    {
        static List<int> testList = new List<int> { };
        public void InitializeTestList()
        {
            for (int i = 0; i < 10000; i++)
            {
                testList.Add(i);
            }
        }

        [Benchmark]
        public void Benchmark_Of_For()
        {
            List<int> listForFor = new List<int> { };
            for (int index = 0; index < testList.Count; index++)
            {
                listForFor.Add(testList[index]);
            }
        }

        [Benchmark]
        public void Benchmark_Of_Foreach()
        {
            List<int> listForForEach = new List<int> { };

            foreach (var number in testList)
            {
                listForForEach.Add(testList[number]);
            }
        }
    }
}
