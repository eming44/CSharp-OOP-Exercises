using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    static class Distance
    {
        public static double calDistance (Point3D first, Point3D second)
        {
            double distance = 0f;
            distance = Math.Sqrt(Math.Pow(second.xGet - first.xGet, 2) + Math.Pow(second.yGet - first.yGet, 2) + Math.Pow(second.zGet - first.zGet, 2));
            return distance;
        }

    }
}
