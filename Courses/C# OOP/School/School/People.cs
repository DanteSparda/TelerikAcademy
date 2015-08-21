namespace School
{
    public class People
    {
        public People(string nameOfTeacher)
        {
            this.Name = nameOfTeacher;
        }

        public string Name { get; private set; }
    }
}
