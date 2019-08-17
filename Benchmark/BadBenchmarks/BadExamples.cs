using System;
using System.Linq;


namespace Benchmark.BadBenchMarks{
public static class BadExamples{

    public static void SortList(){
        var list = Enumerable.Range(0,10000).ToList();
        DateTime start = DateTime.Now;
        list.Sort();
        DateTime end = DateTime.Now;
        TimeSpan elapsedTime = end - start;
        Console.WriteLine(elapsedTime.TotalMilliseconds);
    }

}

}