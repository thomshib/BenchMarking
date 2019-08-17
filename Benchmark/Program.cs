using System;
using Benchmark.BadBenchMarks;
using Benchmark.GoodBenchMarks;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BadExamples.SortList();
            GoodExamples.SortList();

            Console.ReadLine();
        }
    }
}
