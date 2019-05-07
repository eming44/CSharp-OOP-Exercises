using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSMTest
    {
        public void ValidationTest()
        {
            GSM[] phones = new GSM[3];
            phones[0] = new GSM("galaxy s7", "Samsung", 1200, "Gosho", new Battery("bla", 52, 12), new Display(3.6f, 1200000));
            phones[1] = new GSM("desire eye", "HTC");
            phones[2] = new GSM("e9", "Nokia");

            foreach (var item in phones)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
