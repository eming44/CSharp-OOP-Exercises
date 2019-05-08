using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCConteinerExercise
{
    public class CarFactory
    {
        public static ICar CreateBMW()
        {
            return new BMW();
        }

        public static ICar CreateAudi()
        {
            return new Audi();
        }
    }
}
