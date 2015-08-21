namespace School
{
    using System.Collections.Generic;
    using System.Text;

    public class ClassesOfStudents : IComment
    {
        private string uniqueTextIdentifier;
        private List<Students> attendingStudents;
        private List<Teachers> workingTeachers;

        public ClassesOfStudents(string uniqueText)
        {
            this.uniqueTextIdentifier = uniqueText;
            this.attendingStudents = new List<Students>();
            this.workingTeachers = new List<Teachers>();
        }

        public string Comment(string input)
        {
            return string.Format("We are a class and we think that: {0}", input);
        }

        public void AddTeacher(Teachers teacher)
        {
            this.workingTeachers.Add(teacher);
        }

        public void AddStudent(Students student)
        {
            this.attendingStudents.Add(student);
        }

        public string GetClassInfo()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("This class {0}, has:\n", this.uniqueTextIdentifier));
            foreach (var teacher in this.workingTeachers)
            {
                result.Append(string.Format("Teacher: {0} teaches: {1}\n", teacher.Name, teacher.TeacherDiscipline.Name));
            }

            foreach (var student in this.attendingStudents)
            {
                result.Append(string.Format("Student: {0} has ID: {1}\n", student.Name, student.UniqueNumber));
            }

            return result.ToString();
        }
    }
}
