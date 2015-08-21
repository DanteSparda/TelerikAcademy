namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FirstNameBeforeLastName
    {
        static void Main()
        {
            var listOfStudents = new List<Students>
            { 
                new Students("Ivan","Ivanov",19),
                new Students("Gosho","Ivanov",33),
                new Students("Pesho","Goshov",23),
                new Students("Avatar","Aang",50)
            };
            List<Students> sortedByNameStudents = listOfStudents.Where(student => student.FirstName.CompareTo(student.LastName) < 0).ToList();
            Console.WriteLine("Alphabetical names: ");
            foreach (var st in sortedByNameStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
            List<Students> sortedByAgeStudents = listOfStudents.Where(st => st.Age > 17 && st.Age < 25).ToList();
            Console.WriteLine("Age between 18 and 24");
            foreach (var st in sortedByAgeStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
            var sortedDescending = listOfStudents
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
            Console.WriteLine("Ordered by descending");
            foreach (var st in sortedDescending)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

        }
    }

}
