using System;
using System.Linq;
using System.Diagnostics;
using System.IO;

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

    public static bool IsPrime(int n){

        for(int i = 2; i < n-1; i++){
            if( n % i == 0) return false;
        }
        return true;
    }
    public static void IOBenchMark(){
        int N= 1000;
        var measurements = new long[N];
        byte[] data = new byte[64 * 1024 * 1024]; // 64MB
        for(int i = 0; i < N ; i++){
            var watch = Stopwatch.StartNew();
            var fileName = Path.GetTempFileName();
            File.WriteAllBytes(fileName,data);
            File.Delete(fileName);
            watch.Stop();
            measurements[i] = watch.ElapsedMilliseconds;
            Console.WriteLine(measurements[i]);

        }
        Console.WriteLine($"File write took Minimum: {measurements.Min()}");
        Console.WriteLine($"File write took Maximum: {measurements.Max()}");
        Console.WriteLine($"File write took Average: {measurements.Average()}");
    }

}

}