namespace School
{
    public class Teachers : People, IComment
    {
        private Disciplines teachersObject;

        public Teachers(string name, Disciplines discipline)
            : base(name)
        {
            this.teachersObject = discipline;
        }

        public Disciplines TeacherDiscipline
        {
            get
            {
                return this.teachersObject;
            }
        }

        public string Comment(string input)
        {
            return string.Format("I am a teacher and I think that: {0}", input);
        }
    }
}
