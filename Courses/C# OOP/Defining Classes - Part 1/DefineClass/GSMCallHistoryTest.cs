namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {
        public static void GSMTest()
        {
            GSM testGSM = new GSM("Alcatel", "Volvo");

            testGSM.AddAndRemove("add", testGSM);
            Console.WriteLine(testGSM.ResentCall.Duration.ToString());
            Console.WriteLine(testGSM.ResentCall.LastNumber);

            testGSM.AddAndRemove("add", testGSM);
            Console.WriteLine(testGSM.ResentCall.Duration.ToString());
            Console.WriteLine(testGSM.ResentCall.LastNumber);

            testGSM.AddAndRemove("add", testGSM);
            Console.WriteLine(testGSM.ResentCall.Duration.ToString());
            Console.WriteLine(testGSM.ResentCall.LastNumber);

            double totalPrice = testGSM.TotalPriceOfCalls(testGSM);
            Console.WriteLine(totalPrice);

            int longestTalkIndex = 0;
            for (int i = 1; i < testGSM.CallHistory.Count; i++)
            {
                if (testGSM.CallHistory[i - 1].Duration > testGSM.CallHistory[i].Duration)
                {
                    {
                        longestTalkIndex = i - 1;
                    }
                }

                if (i == testGSM.CallHistory.Count - 1 && testGSM.CallHistory[i - 1].Duration < testGSM.CallHistory[i].Duration)
                {
                    longestTalkIndex = i;
                }
            }

            testGSM.CallHistory.RemoveAt(longestTalkIndex);
            double newTotalPrice = testGSM.TotalPriceOfCalls(testGSM);
            Console.WriteLine(newTotalPrice);
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine(testGSM.CallHistory[i].LastNumber);
                testGSM.CallHistory.RemoveAt(i);
            }
        }
    }
}
