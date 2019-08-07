using BenchmarkDotNet.Attributes;

namespace PerformanceEngineeringExamples
{
    [MemoryDiagnoser]
    public class StructVsClass
    {
        [Benchmark]
        public void Benchmark_For_Using_Struct()
        {
            MyStruct newDouble = new MyStruct();
            newDouble.MyDouble = 10;
            for (int index = 0; index < 100 ; index++)
            {
                newDouble.MyDouble += newDouble.MyDouble;
            }
        }

        [Benchmark]
        public void Benchmark_For_Using_Class()
        {
            MyClass newDouble = new MyClass();
            newDouble.MyDouble = 10;
            for (int index = 0; index < 100; index++)
            {
                newDouble.MyDouble += newDouble.MyDouble;
            }
        }

        struct MyStruct
        {
            public double MyDouble { get; set; }
        }

        class MyClass
        {
            public double MyDouble { get; set; }
        }
    }
}
