using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCConteinerExercise
{
    public class PlaneFactory
    {
        public static IPlane CreatePlane()
        {
            return new Plane();
        }

        public static IPlane CreateF_16Raptor()
        {
            return new F_16Raptor();
        }
    }
}
