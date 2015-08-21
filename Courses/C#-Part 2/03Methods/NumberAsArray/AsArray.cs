using System;
class AsArray
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first array: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        string[] firstArr = new string[firstArrLength];
        for (int i = firstArrLength - 1, falseOrder = 0; i >= 0; i--, falseOrder++)
        {
            Console.WriteLine("Enter digit N{0}", falseOrder);
            firstArr[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the length of the first array: ");
        int secondArrLength = int.Parse(Console.ReadLine());
        string[] secondArr = new string[secondArrLength];
        for (int i = secondArrLength - 1, falseOrder = 0; i >= 0; i--, falseOrder++)
        {
            Console.WriteLine("Enter digit N{0}", falseOrder);
            secondArr[i] = Console.ReadLine();
        }
        Console.Clear();
        string firstArrayWhole = string.Join("", firstArr);
        string secondArrayWhole = string.Join("", secondArr);
        Console.WriteLine("Your numbers are: {0} and {1}",firstArrayWhole,secondArrayWhole);
        int result = SumOFTwoArrays(firstArr, secondArr);
        Console.WriteLine("The result is: {0}",result);
    }
    static int SumOFTwoArrays(string[] firstArray, string[] secondArray)
    {
        int firstSum = int.Parse(string.Join("", firstArray));
        int secondSum = int.Parse(string.Join("", secondArray));
        int sum = firstSum + secondSum;
        return sum;
    }
}

