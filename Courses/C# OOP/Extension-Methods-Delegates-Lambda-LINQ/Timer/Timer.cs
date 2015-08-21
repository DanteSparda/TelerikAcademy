namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    class Timer
    {
        public delegate void TimerDlg();

        public TimerDlg SomeMethods { get; set; }

        private int timeInterval;

        public int TimeInterval
        {
            get { return this.timeInterval; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                }
                this.timeInterval = value;
            }
        }

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 80);
                Console.WriteLine();
            }
        }
    }
}