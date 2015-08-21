using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Numbers
{

    static int MIN = 1;
    static int MAX = 100;
    const int COUNT = 10;
    static void Main(string[] args)
    {
        try
        {
            for (int i = 0; i < COUNT; i++)
            {
                MIN = ReadInteger();
            }
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }

    private static int ReadInteger()
    {
        Console.Write("Enter number in range [{0}...{1}]: ", MIN + 1, MAX - 1);
        int number = int.Parse(Console.ReadLine());

        if (number <= MIN || number >= MAX)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}