namespace DefineClass
{
    using System;

    public class Call
    {
        private DateTime date;
        private TimeSpan time;
        private string lastNumber;
        private TimeSpan duration;

        public Call(string phoneNumber)
        {
            this.lastNumber = phoneNumber;
            this.date = DateTime.Now;
            this.time = DateTime.Now.TimeOfDay;
            this.duration = DateTime.Now.Subtract(DateTime.Now);
        }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string LastNumber
        {
            get
            {
                return this.lastNumber;
            }

            private set
            {
                this.lastNumber = value;
            }
        }

        public TimeSpan Duration { get; set; }
    }
}
