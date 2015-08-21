namespace School
{
    public class Students : People, IComment
    {
        public Students(string iD, string name)
            : base(name)
        {
            this.UniqueNumber = iD;
        }

        public string UniqueNumber { get; private set; }

        public string Comment(string input)
        {
            return string.Format("I am a student and I think that: {0}", input);
        }
    }
}
