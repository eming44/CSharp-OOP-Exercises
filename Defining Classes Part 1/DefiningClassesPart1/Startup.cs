using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Startup
    {
        static void Main(string[] args)
        {
            GSM phone1 = new GSM("galaxy s8", "samsung", 1500, "me", new Battery("NAiH", 45.5f, 11.2f), new Display(15.6f, 15000000));
            phone1.MakeCall("0899256781", 124.4f, DateTime.Now);
            phone1.MakeCall("0897019351", 271.9f, DateTime.Now);
            phone1.MakeCall("0898691735", 80.0f, DateTime.Now);
            Console.WriteLine(phone1.ToString());
            phone1.setCallRate = 0.37;

            Console.WriteLine("{0:F2}", phone1.CalculateTotalPrice());
            //-----------------------------------------------------------
            GSM phone2 = new GSM("desire eye", "HTC");
            phone2.MakeCall("0897571295", 166.7f, DateTime.Now);
            phone2.MakeCall("0898549127", 139.5f, DateTime.Now);
            Console.WriteLine(phone2.ToString());
            phone2.setCallRate = 0.37;

            Console.WriteLine("{0:F2}", phone2.CalculateTotalPrice());

        }
    }
}
