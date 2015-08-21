using System;
/* Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.*/
class Hello
{
    static void Main(string[] args)
    {
        PrintHello();
    }
    static void PrintHello()
    {
        Console.Write("Name?: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}",name);
    }
}

