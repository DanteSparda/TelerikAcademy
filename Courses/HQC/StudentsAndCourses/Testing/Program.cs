using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCourse = new Course("TestCourse");
            var testStudent = new Student("Goshko");
            testCourse.AddStudent(testStudent);

            if (testStudent.Courses.Contains(testCourse))
            {
                Console.WriteLine(123);
            }
            if (testCourse.StudentsList.Contains(testStudent))
            {
                Console.WriteLine(321);
            }
        }
    }
}
