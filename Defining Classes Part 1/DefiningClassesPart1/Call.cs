using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Call
    {
        private DateTime dateTime;
        private string phoneNumber;
        private float duration;

        public Call(
            string phoneNumber,
            float duration,
            DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Dialed number: {0}\n", phoneNumber);
            sb.AppendFormat("Duration(in seconds): {0}\n", duration);
            sb.AppendFormat("Date & Time: {0}\n", dateTime);
            return sb.ToString();
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
        }

        public float Duration
        {
            get
            {
                return this.duration;
            }
        }
    }
}
