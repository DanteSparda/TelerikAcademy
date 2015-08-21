namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void CreateAFewGSMs(int num)
        {
            List<GSM> mobileArr = new List<GSM>();
            for (int i = 1; i <= num; i++)
            {
                mobileArr.Add(new GSM("modern " + i + " GSM", "apple" + i));
            }

            foreach (var gsm in mobileArr)
            {
                Console.WriteLine(gsm.Model);
                Console.WriteLine(gsm.Manufacturer);
            }
        }
    }
}
