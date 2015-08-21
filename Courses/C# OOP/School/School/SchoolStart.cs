namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolStart
    {
        private static void Main()
        {
            School mySchool = new School();
            var firstGrade = new ClassesOfStudents("UniqueA");
            firstGrade.AddStudent(new Students("123512", "Gosho"));
            firstGrade.AddStudent(new Students("183522", "Ivan"));
            firstGrade.AddStudent(new Students("749812", "Artur"));
            firstGrade.AddStudent(new Students("923519", "Delaila"));
            firstGrade.AddStudent(new Students("563781", "Yeylz"));
            firstGrade.AddTeacher(new Teachers("Ivanova", new Disciplines("Biology", 12, 3)));
            firstGrade.AddTeacher(new Teachers("Georgieva", new Disciplines("History", 13, 2)));
            var gosheto = new Teachers("Gosho", new Disciplines("Math", 10, 5));
            firstGrade.AddTeacher(gosheto);

            string classInfo = firstGrade.GetClassInfo();
            Console.WriteLine(classInfo);
            string goshetoSays = gosheto.Comment("I love cookies!");
            Console.WriteLine(goshetoSays);
        }
    }
}
