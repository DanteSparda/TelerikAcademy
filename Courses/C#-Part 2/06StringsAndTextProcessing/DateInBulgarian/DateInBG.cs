using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInBulgarian
{
    class DateInBG
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter a date and time in the format [dd.MM.yyyy HH:mm:ss]: ");
            string date = Console.ReadLine();

            DateTime dateTime = DateTime.Parse(date).AddHours(6).AddMinutes(30);
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Friday: Console.Write("Петък");
                    break;
                case DayOfWeek.Monday: Console.Write("Понеделник");
                    break;
                case DayOfWeek.Saturday: Console.Write("Събота");
                    break;
                case DayOfWeek.Sunday: Console.Write("Неделя");
                    break;
                case DayOfWeek.Thursday: Console.Write("Четвъртък");
                    break;
                case DayOfWeek.Tuesday: Console.Write("Вторник");
                    break;
                case DayOfWeek.Wednesday: Console.Write("Сряда");
                    break;
                default:
                    break;
            }
            Console.WriteLine(" {0}", dateTime);
        }
    }
}
