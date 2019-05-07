using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Display
    {
        private float size;
        private int numberOfColors;

        public Display(
            float size,
            int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Display size: {0}\n", size);
            sb.AppendFormat("Dsiplay number of colors: {0}\n", numberOfColors);
            return sb.ToString();
        }
    }
}
