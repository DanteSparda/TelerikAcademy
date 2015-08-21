namespace DefineClass
{
    public class Display
    {
        public Display(int size)
        {
            this.Size = size;
        }

        public int Size { get; set; }

        public int NumberOfColors { get; set; }

        public string PrintInfoForDisplay()
        {
            string infoForDisplay = string.Format("Size: {0}\nNumberOfColors: {1}", this.Size, this.NumberOfColors);
            return infoForDisplay;
        }
    }
}