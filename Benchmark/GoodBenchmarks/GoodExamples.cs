using System;
using System.Linq;
using System.Diagnostics;


namespace Benchmark.GoodBenchMarks{
public static class GoodExamples{

    public static void SortList(){
        var list = Enumerable.Range(0,10000).ToList();
        var watch = Stopwatch.StartNew();
        list.Sort();
        watch.Stop();
        TimeSpan elapsedTime = watch.Elapsed;
        Console.WriteLine(elapsedTime.TotalMilliseconds);
    }

}

}