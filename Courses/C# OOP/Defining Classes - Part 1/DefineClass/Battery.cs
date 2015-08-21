namespace DefineClass
{
    using System;

    public class Battery
    {
        public Battery(BatteryType model)
        {
            this.Model = model;
        }

        public int HourIdle { get; set; }

        public int HoursTalk { get; set; }

        private BatteryType Model { get; set; }

        public string PrintInfoForBattery()
        {
            string inforFOrBattery = string.Format("\nModel: {0}\nHoursIdle: {1}\nHoursTalked: {2}", this.Model, this.HourIdle, this.HoursTalk);
            return inforFOrBattery;
        }
    }
}
