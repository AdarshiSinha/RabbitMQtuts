using System;
using System.Diagnostics;
using System.Threading;
namespace stopwatch_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch= new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }
    }
}
