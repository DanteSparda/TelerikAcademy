using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private int uniqueNumber;
        private ICollection<Course> courses;
        public Student(string name)
        {
            this.Name = name;
            this.uniqueNumber = School.UniqueNumber++;
            this.courses = new List<Course>();
        }

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
        }
        public ICollection<Course> Courses
        {
            get { return this.courses; }
        }
        public string Name
        {
            get
            {
                return this.name;

            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Student name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public void SignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null!");
            }
            if (course.StudentsList.Contains(this) && !this.Courses.Contains(course))
            {
                this.courses.Add(course);
            }
            else if (!course.StudentsList.Contains(this) && this.Courses.Contains(course))
            {
                course.StudentsList.Add(this);
            }
            else if (course.StudentsList.Contains(this) && this.Courses.Contains(course))
            {
                throw new ArgumentException("You are already signed for this course!");
            }
        }
        public void UnsignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't be null!");
            }
            if (course.StudentsList.Contains(this))
            {
                course.RemoveStudent(this);
                this.courses.Remove(course);
            }
            else
            {
                throw new ArgumentException("You are not signed for this course!");
            }
        }
    }
}
