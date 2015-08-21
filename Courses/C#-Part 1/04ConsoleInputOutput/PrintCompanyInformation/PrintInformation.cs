/* Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;
    class PrintInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter company address: ");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter fax number: ");
            string faxNumber = Console.ReadLine();
            if (faxNumber.Length<5)
            {
                faxNumber = "(no fax)";
            }
            Console.WriteLine("Enter web site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter manager first name:: ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter manager last name:: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Enter manager age:: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAdress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            Console.WriteLine("Fax: {0}",faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel.  {3})", managerFirstName, managerLastName, managerAge, managerPhone);



        }
    }
