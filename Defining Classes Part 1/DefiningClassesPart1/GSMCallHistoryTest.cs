using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSMCallHistoryTest
    {
        public void Test()
        {
            GSM phone = new GSM("blabla", "Apple", 1);

            phone.MakeCall("0899256789", 24.4f, DateTime.Now);
            phone.MakeCall("0897298351", 311.3f, DateTime.Now);
            phone.MakeCall("0898617302", 90.0f, DateTime.Now);

            phone.showCallHistory();
            phone.setCallRate = 0.37;
            phone.CalculateTotalPrice();
            phone.removeLongestCall();
            phone.CalculateTotalPrice();
            phone.deleteHistory();
            phone.showCallHistory();
        }
    }
}
