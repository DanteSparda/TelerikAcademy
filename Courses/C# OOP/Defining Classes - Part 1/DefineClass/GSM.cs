namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private static string theIPhone4S = "I Phone 4S is overpriced and not worth it! ";
        private Battery battery;
        private Display display;
        private Call resentCall;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public static string IPhone4S
        {
            get { return theIPhone4S; }
            set { theIPhone4S = value; }
        }

        public Call ResentCall
        {
            get
            {
                return this.resentCall;
            }

            set
            {
                this.resentCall = value;
            }
        }

        public List<Call> CallHistory { get; set; }

        public string Model { get; private set; }

        public string Manufacturer { get; private set; }

        public int Price { get; set; }

        public string Owner { get; set; }

        public string PrintMobileInfo(Battery battery, Display display)
        {
            string manufacturer = this.Manufacturer;
            string model = this.Model;
            string price = this.Price.ToString();
            string owner = this.Owner;
            this.CallHistory = new List<Call>();
            string mobileInfo = string.Format("Mobile Info:\nManufacturer:{0}\nModel: {1}\nPrice: {2}\nOwner: {3}", manufacturer, model, price, owner);
            string result = string.Format("{0} \nBattery info: {1}\nDisplay info: {2}", mobileInfo, battery.PrintInfoForBattery(), display.PrintInfoForDisplay());
            return result;
        }

        /// <summary>
        /// Adding and removing calls
        /// </summary>
        /// <param name="decision">add/remove</param>
        public void AddAndRemove(string decision, GSM currentGSM)
        {
            if (decision.ToLower() == "add")
            {
                Console.WriteLine("Enter number: ");
                string number = Console.ReadLine();
                currentGSM.resentCall = new Call(number);
                this.CallHistory.Add(currentGSM.resentCall);
            }
            else if (decision.ToLower() == "remove")
            {
                Console.WriteLine("Enter the position of the number you want to remove [from 1 to {0}]", this.CallHistory.Count);
                int removeIndexer = int.Parse(Console.ReadLine()) - 1;
                if (removeIndexer < 0 || removeIndexer > this.CallHistory.Count - 1)
                {
                    throw new ArgumentException("Wrong index");
                }
                else
                {
                    Console.WriteLine("You removed the call with number {0}", this.CallHistory[removeIndexer].LastNumber);
                    this.CallHistory.RemoveAt(removeIndexer);
                }
            }
        }

        public double TotalPriceOfCalls(GSM currentGSM)
        {
            double totalPrice = 0;
            foreach (Call talk in currentGSM.CallHistory)
            {
                double totalMinutes = double.Parse(talk.Duration.Minutes.ToString());
                totalPrice += totalMinutes * 0.37;
            }

            return totalPrice;
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        private static void Main()
        {
            // Inserting data:
            GSM myPhone = new GSM("Nokia", "Nokia OOD");
            myPhone.Price = 500;
            myPhone.Owner = "Ivancho";
            myPhone.battery = new Battery(BatteryType.NiMH);
            myPhone.battery.HourIdle = 12;
            myPhone.battery.HoursTalk = 520;
            myPhone.display = new Display(12);
            myPhone.display.NumberOfColors = 326;

            // Transfering data and printing
            Console.WriteLine(myPhone.PrintMobileInfo(myPhone.battery, myPhone.display));

            // Iphone4S data:
            string theIPhoneInfo = GSM.IPhone4S;
            Console.WriteLine(theIPhoneInfo);

            // and ETC 
            GSM phone = new GSM("Alcatel", "Alacatelov");
            GSMTest.CreateAFewGSMs(5);

            // Adding calls
            myPhone.resentCall = new Call("0898123231");
            Console.WriteLine(myPhone.resentCall.LastNumber);
            myPhone.CallHistory.Add(myPhone.resentCall);

            // Adding a second call
            myPhone.resentCall = new Call("08788765426");

            // Adding the call to the list
            myPhone.CallHistory.Add(myPhone.resentCall);
            foreach (Call talk in myPhone.CallHistory)
            {
                Console.WriteLine(talk.LastNumber);
            }

            // From here on, the adding to the callHistory is automatic
            myPhone.AddAndRemove("add", myPhone);
            myPhone.AddAndRemove("remove", myPhone);
            double totalPrice = myPhone.TotalPriceOfCalls(myPhone);

            // Not working because I don't have thread.sleep or something to make timespan
            Console.WriteLine("Total price: {0}", totalPrice);

            // Clearing the history
            myPhone.ClearHistory();
            GSMCallHistoryTest.GSMTest();
        }
    }
}
