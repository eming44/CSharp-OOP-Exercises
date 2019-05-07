using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSM
    {
        //Encapsulate date of GSM in fields----------------------------------------------------
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;
        public static GSM IPhone4S = new GSM("4S", "iPhone");

        public GSM(
            string model,
            string manufacturer,
            int price = 0,
            string owner = null,
            Battery battery = null,
            Display display = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
        //Display GSM------------------------------------------------------------------------------
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Model: {0}\n", model);
            sb.AppendFormat("Manufacturer: {0}\n", manufacturer);

            if (owner != null)
            {
                sb.AppendFormat("Owner: {0}\n", owner);
            }
            if (price != null)
            {
                sb.AppendFormat("Price: {0}\n", price);
            }
            if (battery != null)
            {
                sb.AppendFormat(battery.ToString());
            }
            if (display != null)
            {
                sb.AppendFormat(display.ToString());
            }
            return sb.ToString();
        }
        //----Call History, Add, Delete calls-------------------------------------------------------
        //Data base---------------------------------------------------------------------------------
        private List<Call> callHistory = new List<Call>();

        public void MakeCall(string dialedNumber, float duration, DateTime dateTime)
        {
            callHistory.Add(new Call(dialedNumber, duration, dateTime));
        }
        public void showCallHistory()
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, callHistory[i].ToString());
            }
        }
        //Add calls----------------------------------------------------------------------------------
        public void addCall(Call newCall)
        {
            callHistory.Add(newCall);
            Console.WriteLine("Call saved in phone history!");
        }
        //Remove calls-------------------------------------------------------------------------------
        public void removeCall(int number)
        {
            callHistory.Remove(callHistory[number]);
            Console.WriteLine("Call deleted!");
        }
        //Delete whole call histrory-----------------------------------------------------------------
        public void deleteHistory()
        {
            callHistory.Clear();
            Console.WriteLine("Call history is deleted!");
        }
        //Calculate price of calls--------------------------------------------------------------------
        public double setCallRate;
        public double CalculateTotalPrice()
        {
            double totalLength = 0;
            foreach (var item in callHistory)
            {
                totalLength += item.Duration;
            }

            return totalLength * setCallRate;
        }
        //Find longest call duration and remove it---------------------------------------------------
        public void removeLongestCall()
        {
            float longestDuration = 0.0f;
            int position = 0;

            for (int i = 1; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration > callHistory[i - 1].Duration)
                {
                    longestDuration = callHistory[i].Duration;
                    position = i;
                }
            }
            callHistory.Remove(callHistory[position]);
        }
    }
}
