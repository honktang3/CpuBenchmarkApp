// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using CpuBenchmarkApp.Function;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

#region Computation
int numberOfItemToItertate = 10000;

Parallel.For(0, numberOfItemToItertate, i =>
{
    CpuStressor.stressProcessor(i);
});
#endregion Computation

stopWatch.Stop();
// Get the elapsed time as a TimeSpan value.
TimeSpan ts = stopWatch.Elapsed;

// Format and display the TimeSpan value.
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("Total Runnign Time: " + elapsedTime);
Console.ReadKey();
