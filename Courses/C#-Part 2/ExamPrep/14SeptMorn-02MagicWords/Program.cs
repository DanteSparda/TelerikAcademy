using System;
using System.Text;
using System.Collections.Generic;

class MagicWords
{
    private static bool done = false;
    static void BunnyFactory(List<int> inputList, long cycle)
    {
        long bunniesProduct = 1;
        long bunniesSum = 0;
        int nextCages = 0;
        string newOrder = "";
        long coutner = cycle;
        int index = 0;
        while (coutner != -1)
        {
            nextCages += inputList[index];
            index++;
            coutner--;
        }
        index = (int)cycle + 1;
        if (nextCages>inputList.Count)
        {
            done = true;
            return;
        }
        long mask = nextCages;
        while (mask != 0)
        {
            bunniesSum += inputList[index];
            bunniesProduct *= inputList[index];
            index++;
            mask--;
        }
        newOrder += bunniesSum;
        newOrder += bunniesProduct;
        int from = (int)(nextCages + cycle + 1);
        int to = inputList.Count;
        while (from != to)
        {
            //2548495634
            //391036804
            newOrder += inputList[from].ToString();
            from++;
        }


        inputList.Clear();
        for (int i = 0; i < newOrder.Length; i++)
        {
            inputList.Add(newOrder[i] - '0');
        }
        inputList.RemoveAll(item => item == 1);
        inputList.RemoveAll(item => item == 0);
    }
    static void Main()
    {
        List<int> inputList = new List<int>();
        string input = Console.ReadLine();
        while (input != "END")
        {
            inputList.Add(int.Parse(input));
            input = Console.ReadLine();
        }
        for (long i = 0; i < inputList.Count; i++)
        {
            BunnyFactory(inputList, i);
            if (done==true)
            {
                foreach (var digit in inputList)
	{
                    Console.Write("{0} ",digit);
	}
                break;
            }
        }
    }
}
