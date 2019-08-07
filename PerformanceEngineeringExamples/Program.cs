using BenchmarkDotNet.Running;

namespace PerformanceEngineeringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var StringVsStringBuilderSummary = BenchmarkRunner.Run<StringVsStringbuilder>();
            var ForVsForEachSummary = BenchmarkRunner.Run<ForVsForEach>();
            var ArrayVsListSummary = BenchmarkRunner.Run<ArrayVsList>();
            var TaskVsThreadSummary = BenchmarkRunner.Run<TaskVsThread>();
            var StructVsClassSummary = BenchmarkRunner.Run<StructVsClass>();
        }
    }
}
