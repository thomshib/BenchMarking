using System;
using Benchmark.BadBenchMarks;
using Benchmark.GoodBenchMarks;

using System.Diagnostics;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //BadExamples.SortList();
            //GoodExamples.SortList();
            //InvokeIsPrime();
            //InvokeIsPrimeBetter();

            BadExamples.IOBenchMark();
            GoodExamples.IOBenchMark();

            Console.ReadLine();
        }

        private static void InvokeIsPrime()
        {
            Stopwatch watch1 = Stopwatch.StartNew();
            GoodExamples.IsPrime(2147483647);
            watch1.Stop();


            Stopwatch watch2 = Stopwatch.StartNew();
            GoodExamples.IsPrime(2147483647);
            watch2.Stop();

            Console.WriteLine($"IsPrime took {watch1.ElapsedMilliseconds} vs. {watch2.ElapsedMilliseconds}");

        }

        private static void InvokeIsPrimeBetter()
        {
            Stopwatch watch1 = Stopwatch.StartNew();
            GoodExamples.IsPrime(2147483647);
            watch1.Stop();


            Stopwatch watch2 = Stopwatch.StartNew();
            GoodExamples.IsPrime(2147483647);
            watch2.Stop();

            //add max accepatable error of 20%
            var error = ((watch1.ElapsedMilliseconds + watch2.ElapsedMilliseconds) / 2) * 0.20;
            Console.WriteLine($"IsPrime took {watch1.ElapsedMilliseconds} vs. {watch2.ElapsedMilliseconds}");
            if(Math.Abs(watch1.ElapsedMilliseconds - watch2.ElapsedMilliseconds) < error){
                Console.WriteLine("There is no significant difference");
            }else if( watch1.ElapsedMilliseconds < watch2.ElapsedMilliseconds){
                Console.WriteLine("watch1 is faster");
            }else{
                Console.WriteLine("watch2 is faster");
            }

        }
    }
}
