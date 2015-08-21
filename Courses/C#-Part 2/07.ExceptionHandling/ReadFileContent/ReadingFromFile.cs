using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileContent
{
    class ReadingFromFile
    {
        static void ReadFile(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("Printing the content: ");
                Console.WriteLine(fileContent);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main()
        {
           //The path is: ../../../NewFile.txt
            Console.Write("Enter full path to the file: ");
            string filePath = Console.ReadLine();
            ReadFile(filePath);
        }
    }
}