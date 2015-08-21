/*
Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console. */ 

using System;

    class Data
    {
        static void Main()
        {
            string  FirstName, LastName, Gender, PersonalID,UniqueNumber;
            int Age;
                Console.Write("Enter your first name: ");
                FirstName = Console.ReadLine();
                Console.Write("Enter your last name: ");
                LastName = Console.ReadLine();
                Console.Write("Enter your age: ");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Enter your gender: ");
                Gender = Console.ReadLine();
                Console.Write("Enter your Personal ID number: ");
                PersonalID = Console.ReadLine();
                Console.Write("Enter your Unique employee number: ");
                UniqueNumber = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID Number: {4}\nUnique employee number: {5}",FirstName,LastName,Age,Gender,PersonalID,UniqueNumber);

        }
    }

