using System;
using System.Diagnostics;
using System.Threading;

class Timer
{
    static void Main()
    {
        //хронометър
        Stopwatch timer = new Stopwatch();
        timer.Start();
        do
        {
            Console.WriteLine("{0}:{1}:{2}",timer.Elapsed.Minutes, timer.Elapsed.Seconds, timer.Elapsed.Milliseconds);
            Thread.Sleep(60);
            Console.Clear();
        } while (true);

        int timerMin = 2;
        int timerSec = 60;
        do
        {
            if (timerSec == 0)
            {
                Console.WriteLine("{0}:{1}", timerMin, timerSec);
                --timerMin;
                timerSec = 60;
            }
            else
            {
                Console.WriteLine("{0}:{1}", timerMin, timerSec);
            }
            --timerSec;
            if (timerSec == 0 && timerMin == 0)
            {
                Console.Clear();
                Console.WriteLine("Time is over.");
                break;
            }
            Thread.Sleep(1000);
            Console.Clear();
        } while (true);
    }
}