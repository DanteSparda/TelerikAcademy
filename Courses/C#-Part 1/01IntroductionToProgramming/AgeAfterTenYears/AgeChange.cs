/* Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years. */

using System;
class AgeChange
{
    static void Main()
    {

        Console.Write("Please enter your birthday in DD/MM/YYYY : ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int ageNow, ageAfter;
        if (birthday.Month - today.Month < 0)
        {
            if (birthday.Day - today.Day < 0)
                ageNow = today.Year - birthday.Year;
            else
                ageNow = today.Year - birthday.Year - 1;
        }
        else
            ageNow = today.Year - birthday.Year - 1;
        ageAfter = ageNow + 10;
        Console.WriteLine("You are {0} years old now.\nYou will be {1} years old after 10 years.", ageNow, ageAfter);
    }
}
