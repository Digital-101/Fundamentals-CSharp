// AccumulationExperiment.cs
using System;
using System.Diagnostics;

class AccumulationExperiment {
    static void Main() {
        const int ITER = 50_000_000;
        const float fVal = 0.000001f;
        const double dVal = 0.000001;
        const decimal mVal = 0.000001m;

        var sw = Stopwatch.StartNew();
        float f = 0f;
        for (int i=0;i<ITER;i++) f += fVal;
        sw.Stop();
        Console.WriteLine($"float result = {f} (time {sw.ElapsedMilliseconds} ms)");

        sw.Restart();
        double d = 0.0;
        for (int i=0;i<ITER;i++) d += dVal;
        sw.Stop();
        Console.WriteLine($"double result = {d} (time {sw.ElapsedMilliseconds} ms)");

        sw.Restart();
        decimal m = 0m;
        for (int i=0;i<ITER;i++) m += mVal;
        sw.Stop();
        Console.WriteLine($"decimal result = {m} (time {sw.ElapsedMilliseconds} ms)");
    }
}
