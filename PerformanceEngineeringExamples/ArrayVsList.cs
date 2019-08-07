using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace PerformanceEngineeringExamples
{
    [MemoryDiagnoser]
    public class ArrayVsList
    {
        
        [Benchmark]
        public void Benchmark_Of_Adding_Number_In_Int_Array()
        {
            int[] intArray;
            int countNumber = 10000;
            intArray = new int[countNumber];
            int i = 0;
            while (i < countNumber)
            {
                intArray[i] = i;
                i++;
            }
        }
        [Benchmark]
        public void Benchmark_Of_Adding_Number_In_List()
        {
            List<int> intList = new List<int>();
            int countNumber = 10000;
            for (int i = 0; i < countNumber; i++)
            {
                intList.Add(i);
            }
        }
    }
}
