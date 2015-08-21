namespace School
{
    using System.Collections.Generic;

    public class School
    {
        private List<ClassesOfStudents> allClasses;

        public School()
        {
            this.allClasses = new List<ClassesOfStudents>();
        }

        public void AddClass(ClassesOfStudents studentClass)
        {
            this.allClasses.Add(studentClass);
        }
    }
}
