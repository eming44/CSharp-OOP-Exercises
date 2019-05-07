using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Battery
    {
        private string model;
        private float hoursIdle;
        private float hoursTalk;

        public Battery(
            string model,
            float hoursIdle,
            float hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public enum BatteryType
        {
            Lilon,
            NiMH,
            NiCd
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Battery model: {0}\n", model);
            sb.AppendFormat("Battery idle hours: {0}\n", hoursIdle);
            sb.AppendFormat("Battery talk hours: {0}\n", hoursTalk);
            return sb.ToString();
        }
    }
}
