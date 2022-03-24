using System;
using System.Diagnostics;
using System.Threading;

// ex 4.3. Stopwatch class
// ---------------
// namespace: System.Diagnostics
// property for elapsed time in milliseconds: ElapsedMilliseconds
// property for checking if timer is running: IsRunning
// method for starting timer: Start
// method for stopping timer: Stop

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and instantiate two stopwatches
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            // start cron1
            cron1.Start();

            // pause program for 1s
            Thread.Sleep(1000);

            // start cron2
            cron2.Start();

            // pause program for 1s
            Thread.Sleep(1000);

            // stop both timers
            cron1.Stop();
            cron2.Stop();
        }
    }
}
