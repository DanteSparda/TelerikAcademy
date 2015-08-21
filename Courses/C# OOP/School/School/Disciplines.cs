namespace School
{
    public class Disciplines : IComment
    {
        private string name;
        private int numOfLectures;
        private int numOfExercies;

        public Disciplines(string nameOfDiscipline, int lecturesNumber, int exerciesNumber)
        {
            this.name = nameOfDiscipline;
            this.numOfExercies = exerciesNumber;
            this.numOfLectures = lecturesNumber;
        }

        public string Name 
        {
            get
            { 
                return this.name; 
            }
        }

        public int NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
        }

        public int NumOfExercises
        {
            get
            {
                return this.numOfExercies;
            }
        }

        public string Comment(string input)
        {
            return string.Format("Here's this discipline comment: {0}", input);
        }
    }
}
