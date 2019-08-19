using System;
using System.Diagnostics;
using System.Linq;
using System.IO;


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

    public static void IOBenchMark(){
        byte[] data = new byte[64 * 1024 * 1024]; // 64MB
        var watch = Stopwatch.StartNew();
        var fileName = Path.GetTempFileName();
        File.WriteAllBytes(fileName,data);
        File.Delete(fileName);
        watch.Stop();
        Console.WriteLine($"File write took {watch.ElapsedMilliseconds}");
    }


}

}